using System;
using System.Collections.Generic;
using System.Windows.Forms;
using vibrance.GUI.Properties;

namespace vibrance.GUI.common
{
    public partial class VibranceSettings : Form
    {
        private IVibranceProxy _v;
        private ListViewItem _sender;
        private readonly Func<int, string> _resolveLabelLevel;

        public VibranceSettings(IVibranceProxy v, int minValue, int maxValue, int defaultValue, ListViewItem sender, ApplicationSetting setting, List<ResolutionModeWrapper> supportedResolutionList, Func<int, string> resolveLabelLevel)
        {
            InitializeComponent();
            this.Icon = Resources.vibranceguiplus_logo;
            this.trackBarIngameLevel.Minimum = minValue;
            this.trackBarIngameLevel.Maximum = maxValue;
            this.trackBarIngameLevel.Value = defaultValue;
            this._sender = sender;
            _resolveLabelLevel = resolveLabelLevel;
            this._v = v;
            labelIngameLevel.Text = _resolveLabelLevel(trackBarIngameLevel.Value);
            this.labelTitle.Text += $@"""{sender.Text}""";
            if (_sender != null && 
                _sender.ListView != null && 
                _sender.ListView.LargeImageList != null && 
                _sender.ImageIndex >= 0 && 
                _sender.ImageIndex < _sender.ListView.LargeImageList.Images.Count)
            {
                this.pictureBox.Image = _sender.ListView.LargeImageList.Images[_sender.ImageIndex];
            }
            this.cBoxResolution.DataSource = supportedResolutionList;
            
            this.trackBarShadowLevel.Minimum = 0;
            this.trackBarShadowLevel.Maximum = 100;
            this.trackBarShadowLevel.Value = 0;
            this.labelShadowLevel.Text = "0%";
            
            this.trackBarGammaLevel.Minimum = 50;
            this.trackBarGammaLevel.Maximum = 280;
            this.trackBarGammaLevel.Value = 100;
            this.labelGammaLevel.Text = "1.00";
            
            // If the setting is new, we don't need to set the progress bar value
            if (setting != null)
            {
                // Sets the progress bar value to the Ingame Vibrance setting
                this.trackBarIngameLevel.Value = setting.IngameLevel;
                this.cBoxResolution.SelectedItem = setting.ResolutionSettings;
                this.checkBoxResolution.Checked = setting.IsResolutionChangeNeeded;
                this.trackBarShadowLevel.Value = setting.ShadowBoostLevel;
                this.labelShadowLevel.Text = $"{this.trackBarShadowLevel.Value}%";
                this.trackBarGammaLevel.Value = (int)(setting.GammaLevel * 100f);
                this.labelGammaLevel.Text = $"{setting.GammaLevel:F2}";
                // Necessary to reload the label which tells the percentage
                trackBarIngameLevel_Scroll(null, null); 
            }

            // Check mutual exclusivity after loading settings
            CheckMutualExclusivity();
        }

        private void trackBarIngameLevel_Scroll(object sender, EventArgs e)
        {
            _v.SetVibranceIngameLevel(trackBarIngameLevel.Value);
            labelIngameLevel.Text = _resolveLabelLevel(trackBarIngameLevel.Value);
        }

        private void trackBarShadowLevel_Scroll(object sender, EventArgs e)
        {
            labelShadowLevel.Text = $"{trackBarShadowLevel.Value}%";
            CheckMutualExclusivity();
        }

        private void trackBarGammaLevel_Scroll(object sender, EventArgs e)
        {
            float gamma = trackBarGammaLevel.Value / 100f;
            labelGammaLevel.Text = $"{gamma:F2}";
            CheckMutualExclusivity();
        }

        private void CheckMutualExclusivity()
        {
            bool gammaActive = trackBarGammaLevel.Value != 100;  // 1.0 = default
            bool shadowActive = trackBarShadowLevel.Value != 0;   // 0 = default

            if (gammaActive && shadowActive)
            {
                // Both are active - disable one and show warning
                // We'll disable Shadow Boost and suggest resetting Gamma
                trackBarShadowLevel.Enabled = false;
                labelShadowLevel.Enabled = false;
                labelWarningExclusivity.Text = "Reset Gamma to use Shadow Boost";
                labelWarningExclusivity.Visible = true;
            }
            else if (gammaActive)
            {
                // Only Gamma is active - disable Shadow Boost
                trackBarShadowLevel.Enabled = false;
                labelShadowLevel.Enabled = false;
                labelWarningExclusivity.Text = "Reset Gamma to use Shadow Boost";
                labelWarningExclusivity.Visible = true;
            }
            else if (shadowActive)
            {
                // Only Shadow Boost is active - disable Gamma
                trackBarGammaLevel.Enabled = false;
                labelGammaLevel.Enabled = false;
                labelWarningExclusivity.Text = "Reset Shadow Boost to use Gamma";
                labelWarningExclusivity.Visible = true;
            }
            else
            {
                // Both are at defaults - enable both and hide warning
                trackBarGammaLevel.Enabled = true;
                labelGammaLevel.Enabled = true;
                trackBarShadowLevel.Enabled = true;
                labelShadowLevel.Enabled = true;
                labelWarningExclusivity.Visible = false;
            }
        }

        private void buttonGammaReset_Click(object sender, EventArgs e)
        {
            trackBarGammaLevel.Value = 100;  // 1.0 = neutral
            labelGammaLevel.Text = "1.00";
            CheckMutualExclusivity();
        }

        private void buttonShadowBoostReset_Click(object sender, EventArgs e)
        {
            trackBarShadowLevel.Value = 0;   // 0 = disabled
            labelShadowLevel.Text = "0%";
            CheckMutualExclusivity();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public ApplicationSetting GetApplicationSetting()
        {
            ResolutionModeWrapper resolution = this.cBoxResolution.SelectedItem as ResolutionModeWrapper;
            string resolutionString = resolution != null ? resolution.ToString() : "";
            
            return new ApplicationSetting(_sender.Text, _sender.Tag.ToString(), this.trackBarIngameLevel.Value, 
                resolution, this.checkBoxResolution.Checked, this.trackBarShadowLevel.Value, this.trackBarGammaLevel.Value / 100f);
        }

        private void checkBoxResolution_CheckedChanged(object sender, EventArgs e)
        {
            this.cBoxResolution.Enabled = this.checkBoxResolution.Checked;
        }
    }
}
