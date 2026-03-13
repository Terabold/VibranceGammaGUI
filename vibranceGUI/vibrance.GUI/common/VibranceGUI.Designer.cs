namespace vibrance.GUI.common
{
    partial class VibranceGUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelGlobalInfo = new System.Windows.Forms.Label();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VibranceGUI));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.checkBoxAutostart = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxNeverChangeResolutions = new System.Windows.Forms.CheckBox();
            this.checkBoxPrimaryMonitorOnly = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelWindowsLevel = new System.Windows.Forms.Label();
            this.trackBarWindowsLevel = new System.Windows.Forms.TrackBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.observerStatusLabel = new System.Windows.Forms.Label();
            this.settingsBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonProcessExplorer = new System.Windows.Forms.Button();
            this.buttonRemoveProgram = new System.Windows.Forms.Button();
            this.listApplications = new System.Windows.Forms.ListView();
            this.buttonAddProgram = new System.Windows.Forms.Button();
            this.buttonDonate = new System.Windows.Forms.Button();
            this.contextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWindowsLevel)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Running minimized... Like the program? Consider donating!";
            this.notifyIcon.BalloonTipTitle = "VibranceGammaGUI";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = vibrance.GUI.Properties.Resources.vibranceguiplus_logo;
            this.notifyIcon.Text = "VibranceGammaGUI";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donateToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(217, 48);
            this.contextMenuStrip.Text = "Vibrance Control";
            // 

            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.donateToolStripMenuItem.Text = "Support Developer (Donate)";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // checkBoxAutostart
            // 
            this.checkBoxAutostart.AutoSize = true;
            this.checkBoxAutostart.Location = new System.Drawing.Point(6, 19);
            this.checkBoxAutostart.Name = "checkBoxAutostart";
            this.checkBoxAutostart.Size = new System.Drawing.Size(131, 17);
            this.checkBoxAutostart.TabIndex = 8;
            this.checkBoxAutostart.Text = "Autostart VibranceGammaGUI";
            this.checkBoxAutostart.UseVisualStyleBackColor = true;
            this.checkBoxAutostart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAutostart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.checkBoxAutostart.CheckedChanged += new System.EventHandler(this.checkBoxAutostart_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxNeverChangeResolutions);
            this.groupBox1.Controls.Add(this.checkBoxPrimaryMonitorOnly);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.checkBoxAutostart);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 143);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // checkBoxNeverChangeResolutions
            // 
            this.checkBoxNeverChangeResolutions.AutoSize = true;
            this.checkBoxNeverChangeResolutions.Location = new System.Drawing.Point(163, 42);
            this.checkBoxNeverChangeResolutions.Name = "checkBoxNeverChangeResolutions";
            this.checkBoxNeverChangeResolutions.Size = new System.Drawing.Size(147, 17);
            this.checkBoxNeverChangeResolutions.TabIndex = 16;
            this.checkBoxNeverChangeResolutions.Text = "Never change resolutions";
            this.toolTip.SetToolTip(this.checkBoxNeverChangeResolutions, "When checking this, VibranceGammaGUI will never change the resolution on any of your monitors.");
            this.checkBoxNeverChangeResolutions.UseVisualStyleBackColor = true;
            this.checkBoxNeverChangeResolutions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxNeverChangeResolutions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.checkBoxNeverChangeResolutions.CheckedChanged += new System.EventHandler(this.checkBoxNeverChangeResolutions_CheckedChanged);
            // 
            // checkBoxPrimaryMonitorOnly
            // 
            this.checkBoxPrimaryMonitorOnly.AutoSize = true;
            this.checkBoxPrimaryMonitorOnly.Location = new System.Drawing.Point(6, 42);
            this.checkBoxPrimaryMonitorOnly.Name = "checkBoxPrimaryMonitorOnly";
            this.checkBoxPrimaryMonitorOnly.Size = new System.Drawing.Size(151, 17);
            this.checkBoxPrimaryMonitorOnly.TabIndex = 15;
            this.checkBoxPrimaryMonitorOnly.Text = "Affect Primary Monitor only";
            this.toolTip.SetToolTip(this.checkBoxPrimaryMonitorOnly, "When checking this, VibranceGammaGUI will only change vibrance values on your primary monitor.");
            this.checkBoxPrimaryMonitorOnly.UseVisualStyleBackColor = true;
            this.checkBoxPrimaryMonitorOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxPrimaryMonitorOnly.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.checkBoxPrimaryMonitorOnly.CheckedChanged += new System.EventHandler(this.checkBoxPrimaryMonitorOnly_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelWindowsLevel);
            this.groupBox3.Controls.Add(this.trackBarWindowsLevel);
            this.groupBox3.Location = new System.Drawing.Point(7, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 72);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Windows Vibrance Level";
            // 
            // labelWindowsLevel
            // 
            this.labelWindowsLevel.AutoSize = true;
            this.labelWindowsLevel.Location = new System.Drawing.Point(148, 22);
            this.labelWindowsLevel.Name = "labelWindowsLevel";
            this.labelWindowsLevel.Size = new System.Drawing.Size(0, 13);
            this.labelWindowsLevel.TabIndex = 1;
            // 
            // trackBarWindowsLevel
            // 
            this.trackBarWindowsLevel.Location = new System.Drawing.Point(15, 22);
            this.trackBarWindowsLevel.Maximum = 63;
            this.trackBarWindowsLevel.Name = "trackBarWindowsLevel";
            this.trackBarWindowsLevel.Size = new System.Drawing.Size(131, 45);
            this.trackBarWindowsLevel.TabIndex = 0;
            this.trackBarWindowsLevel.Scroll += new System.EventHandler(this.trackBarWindowsLevel_Scroll);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(106, 420);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(61, 13);
            this.statusLabel.TabIndex = 14;
            this.statusLabel.Text = "Initializing...";
            // 
            // observerStatusLabel
            // 
            this.observerStatusLabel.AutoSize = true;
            this.observerStatusLabel.Location = new System.Drawing.Point(12, 420);
            this.observerStatusLabel.Name = "observerStatusLabel";
            this.observerStatusLabel.Size = new System.Drawing.Size(87, 13);
            this.observerStatusLabel.TabIndex = 13;
            this.observerStatusLabel.Text = "Observer status: ";
            // settingsBackgroundWorker
            // 
            this.settingsBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.settingsBackgroundWorker_DoWork);
            this.settingsBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.settingsBackgroundWorker_RunWorkerCompleted);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 100;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonProcessExplorer);
            this.groupBox5.Controls.Add(this.buttonRemoveProgram);
            this.groupBox5.Controls.Add(this.listApplications);
            this.groupBox5.Controls.Add(this.buttonAddProgram);
            this.groupBox5.Location = new System.Drawing.Point(13, 161);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(397, 227);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Program Settings";
            // 
            // buttonProcessExplorer
            // 
            this.buttonProcessExplorer.Location = new System.Drawing.Point(7, 20);
            this.buttonProcessExplorer.Name = "buttonProcessExplorer";
            this.buttonProcessExplorer.Size = new System.Drawing.Size(75, 23);
            this.buttonProcessExplorer.TabIndex = 3;
            this.buttonProcessExplorer.Text = "Add";
            this.buttonProcessExplorer.UseVisualStyleBackColor = true;
            this.buttonProcessExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProcessExplorer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonProcessExplorer.Click += new System.EventHandler(this.buttonProcessExplorer_Click);
            // 
            // buttonRemoveProgram
            // 
            this.buttonRemoveProgram.Location = new System.Drawing.Point(186, 20);
            this.buttonRemoveProgram.Name = "buttonRemoveProgram";
            this.buttonRemoveProgram.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveProgram.TabIndex = 2;
            this.buttonRemoveProgram.Text = "Remove";
            this.buttonRemoveProgram.UseVisualStyleBackColor = true;
            this.buttonRemoveProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveProgram.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonRemoveProgram.Click += new System.EventHandler(this.buttonRemoveProgram_Click);
            // 
            // listApplications
            // 
            this.listApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.listApplications.ForeColor = System.Drawing.Color.White;
            this.listApplications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listApplications.Location = new System.Drawing.Point(7, 49);
            this.listApplications.Name = "listApplications";
            this.listApplications.Size = new System.Drawing.Size(384, 172);
            this.listApplications.TabIndex = 1;
            this.listApplications.UseCompatibleStateImageBehavior = false;
            this.listApplications.DoubleClick += new System.EventHandler(this.listApplications_DoubleClick);
            // 
            // buttonAddProgram
            // 
            this.buttonAddProgram.Location = new System.Drawing.Point(88, 20);
            this.buttonAddProgram.Name = "buttonAddProgram";
            this.buttonAddProgram.Size = new System.Drawing.Size(92, 23);
            this.buttonAddProgram.TabIndex = 0;
            this.buttonAddProgram.Text = "Add manually";
            this.buttonAddProgram.UseVisualStyleBackColor = true;
            this.buttonAddProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProgram.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonAddProgram.Click += new System.EventHandler(this.buttonAddProgram_Click);
            // 
                        // 
            // labelGlobalInfo
            // 
            this.labelGlobalInfo.AutoSize = true;
            this.labelGlobalInfo.Location = new System.Drawing.Point(13, 395);
            this.labelGlobalInfo.Name = "labelGlobalInfo";
            this.labelGlobalInfo.Size = new System.Drawing.Size(350, 13);
            this.labelGlobalInfo.TabIndex = 20;
            this.labelGlobalInfo.Text = "Note: Vibrance is applied to the entire monitor while app is in focus.";
            this.labelGlobalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            // 
            // buttonDonate
            // 
            this.buttonDonate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(130)))), ((int)(((byte)(50)))));
            this.buttonDonate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            this.buttonDonate.FlatAppearance.BorderSize = 2;
            this.buttonDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDonate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonDonate.ForeColor = System.Drawing.Color.White;
            this.buttonDonate.Location = new System.Drawing.Point(13, 505);
            this.buttonDonate.Name = "buttonDonate";
            this.buttonDonate.Size = new System.Drawing.Size(397, 32);
            this.buttonDonate.TabIndex = 21;
            this.buttonDonate.Text = "⭐ Support Developer - Donate via PayPal ⭐";
            this.buttonDonate.UseVisualStyleBackColor = false;
            this.buttonDonate.Click += new System.EventHandler(this.buttonDonate_Click);
            // VibranceGUI
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ForeColor = System.Drawing.Color.White;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 550);
            this.Controls.Add(this.buttonDonate);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.observerStatusLabel);
            this.Controls.Add(this.labelGlobalInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = vibrance.GUI.Properties.Resources.vibranceguiplus_logo; // This might need adjustment if Resources isn't updated yet
            this.MaximizeBox = false;
            this.Name = "VibranceGUI";
            this.Text = "VibranceGammaGUI v2.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWindowsLevel)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.CheckBox checkBoxAutostart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelWindowsLevel;
        private System.Windows.Forms.TrackBar trackBarWindowsLevel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label observerStatusLabel;
        private System.ComponentModel.BackgroundWorker settingsBackgroundWorker;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox checkBoxPrimaryMonitorOnly;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonRemoveProgram;
        private System.Windows.Forms.ListView listApplications;
        private System.Windows.Forms.Button buttonAddProgram;
        private System.Windows.Forms.Button buttonProcessExplorer;
        private System.Windows.Forms.CheckBox checkBoxNeverChangeResolutions;
        private System.Windows.Forms.Label labelGlobalInfo;
        private System.Windows.Forms.Button buttonDonate;
    }
}

