
namespace WinFormsRiotAPI
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.summonerTabPage = new System.Windows.Forms.TabPage();
            this.matchTabPage = new System.Windows.Forms.TabPage();
            this.championTabPage = new System.Windows.Forms.TabPage();
            this.summonerGroupBox = new System.Windows.Forms.GroupBox();
            this.summerNameLabel = new System.Windows.Forms.Label();
            this.summerNameControlBox = new WinFormsRiotAPI.UserControls.inputControlBox();
            this.puuidLabel = new System.Windows.Forms.Label();
            this.puuidControlbox = new WinFormsRiotAPI.UserControls.inputControlBox();
            this.accountIDLabel = new System.Windows.Forms.Label();
            this.accountIDControlBox = new WinFormsRiotAPI.UserControls.inputControlBox();
            this.summonerInfroGroupBox = new System.Windows.Forms.GroupBox();
            this.summonerInformationIDLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.summonerInformationAccountIDLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.summonerInformationPUUIDLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.summonerInformationNameLabel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.summonerInformationProfileIDLabel = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.summonerInformationRevisionLabel = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.summonerInformationLevelLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPIKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riotDeveloperPortalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchGroupBox = new System.Windows.Forms.GroupBox();
            this.summonerPUUID = new System.Windows.Forms.Label();
            this.summonerPUUIDMatchControlBox = new WinFormsRiotAPI.UserControls.inputControlBox();
            this.matchIDLabel = new System.Windows.Forms.Label();
            this.matchIDControlBox = new WinFormsRiotAPI.UserControls.inputControlBox();
            this.tabControl.SuspendLayout();
            this.summonerTabPage.SuspendLayout();
            this.matchTabPage.SuspendLayout();
            this.summonerGroupBox.SuspendLayout();
            this.summonerInfroGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.matchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.CausesValidation = false;
            this.tabControl.Controls.Add(this.summonerTabPage);
            this.tabControl.Controls.Add(this.matchTabPage);
            this.tabControl.Controls.Add(this.championTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(686, 537);
            this.tabControl.TabIndex = 0;
            // 
            // summonerTabPage
            // 
            this.summonerTabPage.Controls.Add(this.summonerInfroGroupBox);
            this.summonerTabPage.Controls.Add(this.summonerGroupBox);
            this.summonerTabPage.Location = new System.Drawing.Point(4, 22);
            this.summonerTabPage.Name = "summonerTabPage";
            this.summonerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.summonerTabPage.Size = new System.Drawing.Size(678, 511);
            this.summonerTabPage.TabIndex = 0;
            this.summonerTabPage.Text = "Summoner V4";
            this.summonerTabPage.UseVisualStyleBackColor = true;
            // 
            // matchTabPage
            // 
            this.matchTabPage.Controls.Add(this.matchGroupBox);
            this.matchTabPage.Location = new System.Drawing.Point(4, 22);
            this.matchTabPage.Name = "matchTabPage";
            this.matchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.matchTabPage.Size = new System.Drawing.Size(678, 511);
            this.matchTabPage.TabIndex = 1;
            this.matchTabPage.Text = "Match V5";
            this.matchTabPage.UseVisualStyleBackColor = true;
            // 
            // championTabPage
            // 
            this.championTabPage.Location = new System.Drawing.Point(4, 22);
            this.championTabPage.Name = "championTabPage";
            this.championTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.championTabPage.Size = new System.Drawing.Size(678, 526);
            this.championTabPage.TabIndex = 2;
            this.championTabPage.Text = "Champion V3";
            this.championTabPage.UseVisualStyleBackColor = true;
            // 
            // summonerGroupBox
            // 
            this.summonerGroupBox.Controls.Add(this.accountIDLabel);
            this.summonerGroupBox.Controls.Add(this.accountIDControlBox);
            this.summonerGroupBox.Controls.Add(this.puuidLabel);
            this.summonerGroupBox.Controls.Add(this.puuidControlbox);
            this.summonerGroupBox.Controls.Add(this.summerNameLabel);
            this.summonerGroupBox.Controls.Add(this.summerNameControlBox);
            this.summonerGroupBox.Location = new System.Drawing.Point(30, 18);
            this.summonerGroupBox.Name = "summonerGroupBox";
            this.summonerGroupBox.Size = new System.Drawing.Size(618, 145);
            this.summonerGroupBox.TabIndex = 1;
            this.summonerGroupBox.TabStop = false;
            this.summonerGroupBox.Text = "&Get A Summoner By...";
            // 
            // summerNameLabel
            // 
            this.summerNameLabel.AutoSize = true;
            this.summerNameLabel.Location = new System.Drawing.Point(46, 29);
            this.summerNameLabel.Name = "summerNameLabel";
            this.summerNameLabel.Size = new System.Drawing.Size(88, 13);
            this.summerNameLabel.TabIndex = 1;
            this.summerNameLabel.Text = "Summoner Name";
            // 
            // summerNameControlBox
            // 
            this.summerNameControlBox.Location = new System.Drawing.Point(16, 45);
            this.summerNameControlBox.Name = "summerNameControlBox";
            this.summerNameControlBox.Size = new System.Drawing.Size(149, 66);
            this.summerNameControlBox.TabIndex = 0;
            // 
            // puuidLabel
            // 
            this.puuidLabel.AutoSize = true;
            this.puuidLabel.Location = new System.Drawing.Point(290, 29);
            this.puuidLabel.Name = "puuidLabel";
            this.puuidLabel.Size = new System.Drawing.Size(41, 13);
            this.puuidLabel.TabIndex = 3;
            this.puuidLabel.Text = "PUUID";
            // 
            // puuidControlbox
            // 
            this.puuidControlbox.Location = new System.Drawing.Point(236, 45);
            this.puuidControlbox.Name = "puuidControlbox";
            this.puuidControlbox.Size = new System.Drawing.Size(149, 66);
            this.puuidControlbox.TabIndex = 2;
            // 
            // accountIDLabel
            // 
            this.accountIDLabel.AutoSize = true;
            this.accountIDLabel.Location = new System.Drawing.Point(491, 29);
            this.accountIDLabel.Name = "accountIDLabel";
            this.accountIDLabel.Size = new System.Drawing.Size(61, 13);
            this.accountIDLabel.TabIndex = 5;
            this.accountIDLabel.Text = "Account ID";
            // 
            // accountIDControlBox
            // 
            this.accountIDControlBox.Location = new System.Drawing.Point(448, 45);
            this.accountIDControlBox.Name = "accountIDControlBox";
            this.accountIDControlBox.Size = new System.Drawing.Size(149, 66);
            this.accountIDControlBox.TabIndex = 4;
            // 
            // summonerInfroGroupBox
            // 
            this.summonerInfroGroupBox.Controls.Add(this.textBox7);
            this.summonerInfroGroupBox.Controls.Add(this.summonerInformationLevelLabel);
            this.summonerInfroGroupBox.Controls.Add(this.textBox6);
            this.summonerInfroGroupBox.Controls.Add(this.summonerInformationRevisionLabel);
            this.summonerInfroGroupBox.Controls.Add(this.textBox5);
            this.summonerInfroGroupBox.Controls.Add(this.summonerInformationProfileIDLabel);
            this.summonerInfroGroupBox.Controls.Add(this.textBox4);
            this.summonerInfroGroupBox.Controls.Add(this.summonerInformationNameLabel);
            this.summonerInfroGroupBox.Controls.Add(this.textBox3);
            this.summonerInfroGroupBox.Controls.Add(this.summonerInformationPUUIDLabel);
            this.summonerInfroGroupBox.Controls.Add(this.textBox2);
            this.summonerInfroGroupBox.Controls.Add(this.summonerInformationAccountIDLabel);
            this.summonerInfroGroupBox.Controls.Add(this.textBox1);
            this.summonerInfroGroupBox.Controls.Add(this.summonerInformationIDLabel);
            this.summonerInfroGroupBox.Location = new System.Drawing.Point(30, 189);
            this.summonerInfroGroupBox.Name = "summonerInfroGroupBox";
            this.summonerInfroGroupBox.Size = new System.Drawing.Size(618, 299);
            this.summonerInfroGroupBox.TabIndex = 2;
            this.summonerInfroGroupBox.TabStop = false;
            this.summonerInfroGroupBox.Text = "&Retrieved Summoner Information";
            // 
            // summonerInformationIDLabel
            // 
            this.summonerInformationIDLabel.AutoSize = true;
            this.summonerInformationIDLabel.Location = new System.Drawing.Point(13, 48);
            this.summonerInformationIDLabel.Name = "summonerInformationIDLabel";
            this.summonerInformationIDLabel.Size = new System.Drawing.Size(74, 13);
            this.summonerInformationIDLabel.TabIndex = 0;
            this.summonerInformationIDLabel.Text = "Summoner ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 3;
            // 
            // summonerInformationAccountIDLabel
            // 
            this.summonerInformationAccountIDLabel.AutoSize = true;
            this.summonerInformationAccountIDLabel.Location = new System.Drawing.Point(13, 74);
            this.summonerInformationAccountIDLabel.Name = "summonerInformationAccountIDLabel";
            this.summonerInformationAccountIDLabel.Size = new System.Drawing.Size(64, 13);
            this.summonerInformationAccountIDLabel.TabIndex = 2;
            this.summonerInformationAccountIDLabel.Text = "Account ID:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 20);
            this.textBox3.TabIndex = 5;
            // 
            // summonerInformationPUUIDLabel
            // 
            this.summonerInformationPUUIDLabel.AutoSize = true;
            this.summonerInformationPUUIDLabel.Location = new System.Drawing.Point(13, 100);
            this.summonerInformationPUUIDLabel.Name = "summonerInformationPUUIDLabel";
            this.summonerInformationPUUIDLabel.Size = new System.Drawing.Size(44, 13);
            this.summonerInformationPUUIDLabel.TabIndex = 4;
            this.summonerInformationPUUIDLabel.Text = "PUUID:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(110, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(146, 20);
            this.textBox4.TabIndex = 7;
            // 
            // summonerInformationNameLabel
            // 
            this.summonerInformationNameLabel.AutoSize = true;
            this.summonerInformationNameLabel.Location = new System.Drawing.Point(13, 126);
            this.summonerInformationNameLabel.Name = "summonerInformationNameLabel";
            this.summonerInformationNameLabel.Size = new System.Drawing.Size(91, 13);
            this.summonerInformationNameLabel.TabIndex = 6;
            this.summonerInformationNameLabel.Text = "Summoner Name:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(381, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(146, 20);
            this.textBox5.TabIndex = 9;
            // 
            // summonerInformationProfileIDLabel
            // 
            this.summonerInformationProfileIDLabel.AutoSize = true;
            this.summonerInformationProfileIDLabel.Location = new System.Drawing.Point(284, 48);
            this.summonerInformationProfileIDLabel.Name = "summonerInformationProfileIDLabel";
            this.summonerInformationProfileIDLabel.Size = new System.Drawing.Size(77, 13);
            this.summonerInformationProfileIDLabel.TabIndex = 8;
            this.summonerInformationProfileIDLabel.Text = "Profile Icon ID:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(381, 71);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(146, 20);
            this.textBox6.TabIndex = 11;
            // 
            // summonerInformationRevisionLabel
            // 
            this.summonerInformationRevisionLabel.AutoSize = true;
            this.summonerInformationRevisionLabel.Location = new System.Drawing.Point(284, 74);
            this.summonerInformationRevisionLabel.Name = "summonerInformationRevisionLabel";
            this.summonerInformationRevisionLabel.Size = new System.Drawing.Size(77, 13);
            this.summonerInformationRevisionLabel.TabIndex = 10;
            this.summonerInformationRevisionLabel.Text = "Revision Date:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(381, 97);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(146, 20);
            this.textBox7.TabIndex = 13;
            // 
            // summonerInformationLevelLabel
            // 
            this.summonerInformationLevelLabel.AutoSize = true;
            this.summonerInformationLevelLabel.Location = new System.Drawing.Point(284, 100);
            this.summonerInformationLevelLabel.Name = "summonerInformationLevelLabel";
            this.summonerInformationLevelLabel.Size = new System.Drawing.Size(89, 13);
            this.summonerInformationLevelLabel.TabIndex = 12;
            this.summonerInformationLevelLabel.Text = "Summoner Level:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aPIKeyToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // aPIKeyToolStripMenuItem
            // 
            this.aPIKeyToolStripMenuItem.Name = "aPIKeyToolStripMenuItem";
            this.aPIKeyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aPIKeyToolStripMenuItem.Text = "&API Key...";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.riotDeveloperPortalToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // riotDeveloperPortalToolStripMenuItem
            // 
            this.riotDeveloperPortalToolStripMenuItem.Name = "riotDeveloperPortalToolStripMenuItem";
            this.riotDeveloperPortalToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.riotDeveloperPortalToolStripMenuItem.Text = "&Riot Developer Portal...";
            // 
            // matchGroupBox
            // 
            this.matchGroupBox.Controls.Add(this.summonerPUUID);
            this.matchGroupBox.Controls.Add(this.summonerPUUIDMatchControlBox);
            this.matchGroupBox.Controls.Add(this.matchIDLabel);
            this.matchGroupBox.Controls.Add(this.matchIDControlBox);
            this.matchGroupBox.Location = new System.Drawing.Point(30, 18);
            this.matchGroupBox.Name = "matchGroupBox";
            this.matchGroupBox.Size = new System.Drawing.Size(618, 145);
            this.matchGroupBox.TabIndex = 2;
            this.matchGroupBox.TabStop = false;
            this.matchGroupBox.Text = "&Get A Match By...";
            // 
            // summonerPUUID
            // 
            this.summonerPUUID.AutoSize = true;
            this.summonerPUUID.Location = new System.Drawing.Point(380, 30);
            this.summonerPUUID.Name = "summonerPUUID";
            this.summonerPUUID.Size = new System.Drawing.Size(94, 13);
            this.summonerPUUID.TabIndex = 3;
            this.summonerPUUID.Text = "Summoner PUUID";
            // 
            // summonerPUUIDMatchControlBox
            // 
            this.summonerPUUIDMatchControlBox.Location = new System.Drawing.Point(354, 46);
            this.summonerPUUIDMatchControlBox.Name = "summonerPUUIDMatchControlBox";
            this.summonerPUUIDMatchControlBox.Size = new System.Drawing.Size(149, 66);
            this.summonerPUUIDMatchControlBox.TabIndex = 2;
            // 
            // matchIDLabel
            // 
            this.matchIDLabel.AutoSize = true;
            this.matchIDLabel.Location = new System.Drawing.Point(184, 30);
            this.matchIDLabel.Name = "matchIDLabel";
            this.matchIDLabel.Size = new System.Drawing.Size(51, 13);
            this.matchIDLabel.TabIndex = 1;
            this.matchIDLabel.Text = "Match ID";
            // 
            // matchIDControlBox
            // 
            this.matchIDControlBox.Location = new System.Drawing.Point(134, 46);
            this.matchIDControlBox.Name = "matchIDControlBox";
            this.matchIDControlBox.Size = new System.Drawing.Size(149, 66);
            this.matchIDControlBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 576);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.tabControl.ResumeLayout(false);
            this.summonerTabPage.ResumeLayout(false);
            this.matchTabPage.ResumeLayout(false);
            this.summonerGroupBox.ResumeLayout(false);
            this.summonerGroupBox.PerformLayout();
            this.summonerInfroGroupBox.ResumeLayout(false);
            this.summonerInfroGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.matchGroupBox.ResumeLayout(false);
            this.matchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage summonerTabPage;
        private System.Windows.Forms.TabPage matchTabPage;
        private System.Windows.Forms.TabPage championTabPage;
        private UserControls.inputControlBox summerNameControlBox;
        private System.Windows.Forms.GroupBox summonerGroupBox;
        private System.Windows.Forms.Label summerNameLabel;
        private System.Windows.Forms.Label accountIDLabel;
        private UserControls.inputControlBox accountIDControlBox;
        private System.Windows.Forms.Label puuidLabel;
        private UserControls.inputControlBox puuidControlbox;
        private System.Windows.Forms.GroupBox summonerInfroGroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label summonerInformationIDLabel;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label summonerInformationLevelLabel;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label summonerInformationRevisionLabel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label summonerInformationProfileIDLabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label summonerInformationNameLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label summonerInformationPUUIDLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label summonerInformationAccountIDLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPIKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riotDeveloperPortalToolStripMenuItem;
        private System.Windows.Forms.GroupBox matchGroupBox;
        private System.Windows.Forms.Label summonerPUUID;
        private UserControls.inputControlBox summonerPUUIDMatchControlBox;
        private System.Windows.Forms.Label matchIDLabel;
        private UserControls.inputControlBox matchIDControlBox;
    }
}

