namespace vibrance.GUI.common
{
    partial class VibranceSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VibranceSettings));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trackBarIngameLevel = new System.Windows.Forms.TrackBar();
            this.labelIngameLevel = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cBoxResolution = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonShadowBoostReset = new System.Windows.Forms.Button();
            this.trackBarShadowLevel = new System.Windows.Forms.TrackBar();
            this.labelShadowLevel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonGammaReset = new System.Windows.Forms.Button();
            this.trackBarGammaLevel = new System.Windows.Forms.TrackBar();
            this.labelGammaLevel = new System.Windows.Forms.Label();
            this.labelWarningExclusivity = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelResolution = new System.Windows.Forms.Label();
            this.checkBoxResolution = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIngameLevel)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShadowLevel)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGammaLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trackBarIngameLevel);
            this.groupBox2.Controls.Add(this.labelIngameLevel);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 72);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingame Vibrance Level";
            // 
            // trackBarIngameLevel
            // 
            this.trackBarIngameLevel.Location = new System.Drawing.Point(16, 23);
            this.trackBarIngameLevel.Maximum = 63;
            this.trackBarIngameLevel.Name = "trackBarIngameLevel";
            this.trackBarIngameLevel.Size = new System.Drawing.Size(131, 45);
            this.trackBarIngameLevel.TabIndex = 9;
            this.trackBarIngameLevel.Scroll += new System.EventHandler(this.trackBarIngameLevel_Scroll);
            // 
            // labelIngameLevel
            // 
            this.labelIngameLevel.AutoSize = true;
            this.labelIngameLevel.Location = new System.Drawing.Point(149, 26);
            this.labelIngameLevel.Name = "labelIngameLevel";
            this.labelIngameLevel.Size = new System.Drawing.Size(27, 13);
            this.labelIngameLevel.TabIndex = 10;
            this.labelIngameLevel.Text = "50%";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(100, 407);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(66, 9);
            this.labelTitle.MaximumSize = new System.Drawing.Size(150, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(63, 13);
            this.labelTitle.TabIndex = 15;
            this.labelTitle.Text = "Settings for ";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 9);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(48, 48);
            this.pictureBox.TabIndex = 16;
            this.pictureBox.TabStop = false;
            // 
            // cBoxResolution
            // 
            this.cBoxResolution.Enabled = false;
            this.cBoxResolution.FormattingEnabled = true;
            this.cBoxResolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.cBoxResolution.ForeColor = System.Drawing.Color.White;
            this.cBoxResolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxResolution.Location = new System.Drawing.Point(6, 57);
            this.cBoxResolution.Name = "cBoxResolution";
            this.cBoxResolution.Size = new System.Drawing.Size(234, 21);
            this.cBoxResolution.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonShadowBoostReset);
            this.groupBox3.Controls.Add(this.trackBarShadowLevel);
            this.groupBox3.Controls.Add(this.labelShadowLevel);
            this.groupBox3.Location = new System.Drawing.Point(12, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 72);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shadow Boost Level";
            // 
            // trackBarShadowLevel
            // 
            this.buttonShadowBoostReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonShadowBoostReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShadowBoostReset.Location = new System.Drawing.Point(189, 26);
            this.buttonShadowBoostReset.Name = "buttonShadowBoostReset";
            this.buttonShadowBoostReset.Size = new System.Drawing.Size(50, 23);
            this.buttonShadowBoostReset.TabIndex = 11;
            this.buttonShadowBoostReset.Text = "Reset";
            this.buttonShadowBoostReset.UseVisualStyleBackColor = true;
            this.buttonShadowBoostReset.Click += new System.EventHandler(this.buttonShadowBoostReset_Click);
            // 
            // trackBarShadowLevel
            // 
            this.trackBarShadowLevel.Location = new System.Drawing.Point(16, 23);
            this.trackBarShadowLevel.Maximum = 100;
            this.trackBarShadowLevel.Name = "trackBarShadowLevel";
            this.trackBarShadowLevel.Size = new System.Drawing.Size(131, 45);
            this.trackBarShadowLevel.TabIndex = 9;
            this.trackBarShadowLevel.Scroll += new System.EventHandler(this.trackBarShadowLevel_Scroll);
            // 
            // labelShadowLevel
            // 
            this.labelShadowLevel.AutoSize = true;
            this.labelShadowLevel.Location = new System.Drawing.Point(149, 26);
            this.labelShadowLevel.Name = "labelShadowLevel";
            this.labelShadowLevel.Size = new System.Drawing.Size(27, 13);
            this.labelShadowLevel.TabIndex = 10;
            this.labelShadowLevel.Text = "0%";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonGammaReset);
            this.groupBox4.Controls.Add(this.trackBarGammaLevel);
            this.groupBox4.Controls.Add(this.labelGammaLevel);
            this.groupBox4.Location = new System.Drawing.Point(12, 219);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 72);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gamma Level";
            // 
            // trackBarGammaLevel
            // 
            this.buttonGammaReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonGammaReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGammaReset.Location = new System.Drawing.Point(189, 26);
            this.buttonGammaReset.Name = "buttonGammaReset";
            this.buttonGammaReset.Size = new System.Drawing.Size(50, 23);
            this.buttonGammaReset.TabIndex = 11;
            this.buttonGammaReset.Text = "Reset";
            this.buttonGammaReset.UseVisualStyleBackColor = true;
            this.buttonGammaReset.Click += new System.EventHandler(this.buttonGammaReset_Click);
            // 
            // trackBarGammaLevel
            // 
            this.trackBarGammaLevel.Location = new System.Drawing.Point(16, 23);
            this.trackBarGammaLevel.Name = "trackBarGammaLevel";
            this.trackBarGammaLevel.Size = new System.Drawing.Size(131, 45);
            this.trackBarGammaLevel.TabIndex = 9;
            this.trackBarGammaLevel.Scroll += new System.EventHandler(this.trackBarGammaLevel_Scroll);
            // 
            // labelGammaLevel
            // 
            this.labelGammaLevel.AutoSize = true;
            this.labelGammaLevel.Location = new System.Drawing.Point(149, 26);
            this.labelGammaLevel.Name = "labelGammaLevel";
            this.labelGammaLevel.Size = new System.Drawing.Size(27, 13);
            this.labelGammaLevel.TabIndex = 10;
            // 
            // labelWarningExclusivity
            // 
            this.labelWarningExclusivity.AutoSize = true;
            this.labelWarningExclusivity.ForeColor = System.Drawing.Color.Red;
            this.labelWarningExclusivity.Location = new System.Drawing.Point(12, 297);
            this.labelWarningExclusivity.Name = "labelWarningExclusivity";
            this.labelWarningExclusivity.Size = new System.Drawing.Size(246, 13);
            this.labelWarningExclusivity.TabIndex = 22;
            this.labelWarningExclusivity.Text = "Reset Gamma to use Shadow Boost";
            this.labelWarningExclusivity.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelResolution);
            this.groupBox1.Controls.Add(this.checkBoxResolution);
            this.groupBox1.Controls.Add(this.cBoxResolution);
            this.groupBox1.Location = new System.Drawing.Point(12, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 84);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingame Resolution";
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResolution.Location = new System.Drawing.Point(4, 18);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(225, 13);
            this.labelResolution.TabIndex = 19;
            this.labelResolution.Text = "For (Borderless) Windowed Mode players only!";
            // 
            // checkBoxResolution
            // 
            this.checkBoxResolution.AutoSize = true;
            this.checkBoxResolution.Location = new System.Drawing.Point(6, 34);
            this.checkBoxResolution.Name = "checkBoxResolution";
            this.checkBoxResolution.Size = new System.Drawing.Size(183, 17);
            this.checkBoxResolution.TabIndex = 18;
            this.checkBoxResolution.Text = "Change Resolution when Ingame";
            this.checkBoxResolution.UseVisualStyleBackColor = true;
            this.checkBoxResolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxResolution.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.checkBoxResolution.CheckedChanged += new System.EventHandler(this.checkBoxResolution_CheckedChanged);
            // 
            // VibranceSettings
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ForeColor = System.Drawing.Color.White;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 442);
            this.Controls.Add(this.labelWarningExclusivity);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = vibrance.GUI.Properties.Resources.vibranceguiplus_logo;
            this.MaximizeBox = false;
            this.Name = "VibranceSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VibranceGammaGUI Settings";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIngameLevel)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShadowLevel)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGammaLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBarIngameLevel;
        private System.Windows.Forms.Label labelIngameLevel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cBoxResolution;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxResolution;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar trackBarShadowLevel;
        private System.Windows.Forms.Label labelShadowLevel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trackBarGammaLevel;
        private System.Windows.Forms.Label labelGammaLevel;
        private System.Windows.Forms.Button buttonGammaReset;
        private System.Windows.Forms.Button buttonShadowBoostReset;
        private System.Windows.Forms.Label labelWarningExclusivity;
    }
}