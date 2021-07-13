
namespace OpenSetup.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpPlayer = new System.Windows.Forms.TabPage();
            this.lblDescPlayer = new System.Windows.Forms.Label();
            this.flowPlayer = new System.Windows.Forms.FlowLayoutPanel();
            this.tpGlobal = new System.Windows.Forms.TabPage();
            this.lblDescGlobal = new System.Windows.Forms.Label();
            this.flowGlobal = new System.Windows.Forms.FlowLayoutPanel();
            this.tpCreator = new System.Windows.Forms.TabPage();
            this.lblDescCreator = new System.Windows.Forms.Label();
            this.flowCreator = new System.Windows.Forms.FlowLayoutPanel();
            this.tpBypass = new System.Windows.Forms.TabPage();
            this.lblDescBypass = new System.Windows.Forms.Label();
            this.flowBypass = new System.Windows.Forms.FlowLayoutPanel();
            this.tpBruteforce = new System.Windows.Forms.TabPage();
            this.pbSetup = new System.Windows.Forms.PictureBox();
            this.gbProxyImport = new System.Windows.Forms.GroupBox();
            this.tbProxyListPath = new System.Windows.Forms.TextBox();
            this.btnImportProxyList = new System.Windows.Forms.Button();
            this.btnHelpProxyList = new System.Windows.Forms.Button();
            this.btnBrowseProxyList = new System.Windows.Forms.Button();
            this.lblDescProxyPath = new System.Windows.Forms.Label();
            this.gbProxyManagement = new System.Windows.Forms.GroupBox();
            this.btnAddProxyManually = new System.Windows.Forms.Button();
            this.tbProxyUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearProxyList = new System.Windows.Forms.Button();
            this.lbProxyView = new System.Windows.Forms.ListBox();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.btnGeneratorAttack = new System.Windows.Forms.Button();
            this.btnAttackDictionary = new System.Windows.Forms.Button();
            this.gbTarget = new System.Windows.Forms.GroupBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblDescUsername = new System.Windows.Forms.Label();
            this.gbWordlist = new System.Windows.Forms.GroupBox();
            this.tbWordlist = new System.Windows.Forms.TextBox();
            this.btnHelpWordlist = new System.Windows.Forms.Button();
            this.btnBrowseWordlist = new System.Windows.Forms.Button();
            this.lblDescWordlist = new System.Windows.Forms.Label();
            this.gbGenerator = new System.Windows.Forms.GroupBox();
            this.nudLimit = new System.Windows.Forms.NumericUpDown();
            this.tbCharset = new System.Windows.Forms.TextBox();
            this.btnHelpGenerator = new System.Windows.Forms.Button();
            this.lblDescCharset = new System.Windows.Forms.Label();
            this.lblDescLimitLength = new System.Windows.Forms.Label();
            this.nudStart = new System.Windows.Forms.NumericUpDown();
            this.lblDescStartLength = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnProxyShuffle = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpPlayer.SuspendLayout();
            this.tpGlobal.SuspendLayout();
            this.tpCreator.SuspendLayout();
            this.tpBypass.SuspendLayout();
            this.tpBruteforce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetup)).BeginInit();
            this.gbProxyImport.SuspendLayout();
            this.gbProxyManagement.SuspendLayout();
            this.gbActions.SuspendLayout();
            this.gbTarget.SuspendLayout();
            this.gbWordlist.SuspendLayout();
            this.gbGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpPlayer);
            this.tcMain.Controls.Add(this.tpGlobal);
            this.tcMain.Controls.Add(this.tpCreator);
            this.tcMain.Controls.Add(this.tpBypass);
            this.tcMain.Controls.Add(this.tpBruteforce);
            this.tcMain.Location = new System.Drawing.Point(12, 30);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(776, 418);
            this.tcMain.TabIndex = 0;
            // 
            // tpPlayer
            // 
            this.tpPlayer.Controls.Add(this.lblDescPlayer);
            this.tpPlayer.Controls.Add(this.flowPlayer);
            this.tpPlayer.Location = new System.Drawing.Point(4, 22);
            this.tpPlayer.Name = "tpPlayer";
            this.tpPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlayer.Size = new System.Drawing.Size(768, 392);
            this.tpPlayer.TabIndex = 0;
            this.tpPlayer.Text = "Player";
            this.tpPlayer.UseVisualStyleBackColor = true;
            // 
            // lblDescPlayer
            // 
            this.lblDescPlayer.AutoSize = true;
            this.lblDescPlayer.Location = new System.Drawing.Point(6, 5);
            this.lblDescPlayer.Name = "lblDescPlayer";
            this.lblDescPlayer.Size = new System.Drawing.Size(216, 13);
            this.lblDescPlayer.TabIndex = 1;
            this.lblDescPlayer.Text = "This is where all the player-related hacks are";
            // 
            // flowPlayer
            // 
            this.flowPlayer.AutoScroll = true;
            this.flowPlayer.Location = new System.Drawing.Point(6, 21);
            this.flowPlayer.Name = "flowPlayer";
            this.flowPlayer.Size = new System.Drawing.Size(756, 365);
            this.flowPlayer.TabIndex = 0;
            // 
            // tpGlobal
            // 
            this.tpGlobal.Controls.Add(this.lblDescGlobal);
            this.tpGlobal.Controls.Add(this.flowGlobal);
            this.tpGlobal.Location = new System.Drawing.Point(4, 22);
            this.tpGlobal.Name = "tpGlobal";
            this.tpGlobal.Padding = new System.Windows.Forms.Padding(3);
            this.tpGlobal.Size = new System.Drawing.Size(768, 392);
            this.tpGlobal.TabIndex = 1;
            this.tpGlobal.Text = "Global";
            this.tpGlobal.UseVisualStyleBackColor = true;
            // 
            // lblDescGlobal
            // 
            this.lblDescGlobal.AutoSize = true;
            this.lblDescGlobal.Location = new System.Drawing.Point(6, 5);
            this.lblDescGlobal.Name = "lblDescGlobal";
            this.lblDescGlobal.Size = new System.Drawing.Size(216, 13);
            this.lblDescGlobal.TabIndex = 3;
            this.lblDescGlobal.Text = "This is where all the global-related hacks are";
            // 
            // flowGlobal
            // 
            this.flowGlobal.AutoScroll = true;
            this.flowGlobal.Location = new System.Drawing.Point(6, 21);
            this.flowGlobal.Name = "flowGlobal";
            this.flowGlobal.Size = new System.Drawing.Size(756, 365);
            this.flowGlobal.TabIndex = 2;
            // 
            // tpCreator
            // 
            this.tpCreator.Controls.Add(this.lblDescCreator);
            this.tpCreator.Controls.Add(this.flowCreator);
            this.tpCreator.Location = new System.Drawing.Point(4, 22);
            this.tpCreator.Name = "tpCreator";
            this.tpCreator.Size = new System.Drawing.Size(768, 392);
            this.tpCreator.TabIndex = 2;
            this.tpCreator.Text = "Creator";
            this.tpCreator.UseVisualStyleBackColor = true;
            // 
            // lblDescCreator
            // 
            this.lblDescCreator.AutoSize = true;
            this.lblDescCreator.Location = new System.Drawing.Point(6, 5);
            this.lblDescCreator.Name = "lblDescCreator";
            this.lblDescCreator.Size = new System.Drawing.Size(221, 13);
            this.lblDescCreator.TabIndex = 3;
            this.lblDescCreator.Text = "This is where all the creator-related hacks are";
            // 
            // flowCreator
            // 
            this.flowCreator.AutoScroll = true;
            this.flowCreator.Location = new System.Drawing.Point(6, 21);
            this.flowCreator.Name = "flowCreator";
            this.flowCreator.Size = new System.Drawing.Size(756, 365);
            this.flowCreator.TabIndex = 2;
            // 
            // tpBypass
            // 
            this.tpBypass.Controls.Add(this.lblDescBypass);
            this.tpBypass.Controls.Add(this.flowBypass);
            this.tpBypass.Location = new System.Drawing.Point(4, 22);
            this.tpBypass.Name = "tpBypass";
            this.tpBypass.Size = new System.Drawing.Size(768, 392);
            this.tpBypass.TabIndex = 3;
            this.tpBypass.Text = "Bypass";
            this.tpBypass.UseVisualStyleBackColor = true;
            // 
            // lblDescBypass
            // 
            this.lblDescBypass.AutoSize = true;
            this.lblDescBypass.Location = new System.Drawing.Point(6, 5);
            this.lblDescBypass.Name = "lblDescBypass";
            this.lblDescBypass.Size = new System.Drawing.Size(221, 13);
            this.lblDescBypass.TabIndex = 3;
            this.lblDescBypass.Text = "This is where all the bypass-related hacks are";
            // 
            // flowBypass
            // 
            this.flowBypass.AutoScroll = true;
            this.flowBypass.Location = new System.Drawing.Point(6, 21);
            this.flowBypass.Name = "flowBypass";
            this.flowBypass.Size = new System.Drawing.Size(756, 364);
            this.flowBypass.TabIndex = 2;
            // 
            // tpBruteforce
            // 
            this.tpBruteforce.Controls.Add(this.pbSetup);
            this.tpBruteforce.Controls.Add(this.gbProxyImport);
            this.tpBruteforce.Controls.Add(this.gbProxyManagement);
            this.tpBruteforce.Controls.Add(this.gbActions);
            this.tpBruteforce.Controls.Add(this.gbTarget);
            this.tpBruteforce.Controls.Add(this.gbWordlist);
            this.tpBruteforce.Controls.Add(this.gbGenerator);
            this.tpBruteforce.Location = new System.Drawing.Point(4, 22);
            this.tpBruteforce.Name = "tpBruteforce";
            this.tpBruteforce.Padding = new System.Windows.Forms.Padding(3);
            this.tpBruteforce.Size = new System.Drawing.Size(768, 392);
            this.tpBruteforce.TabIndex = 4;
            this.tpBruteforce.Text = "Bruteforce";
            this.tpBruteforce.UseVisualStyleBackColor = true;
            // 
            // pbSetup
            // 
            this.pbSetup.Image = global::OpenSetup.Properties.Resources.bruteforce_setup;
            this.pbSetup.Location = new System.Drawing.Point(9, 6);
            this.pbSetup.Name = "pbSetup";
            this.pbSetup.Size = new System.Drawing.Size(747, 58);
            this.pbSetup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSetup.TabIndex = 19;
            this.pbSetup.TabStop = false;
            // 
            // gbProxyImport
            // 
            this.gbProxyImport.Controls.Add(this.tbProxyListPath);
            this.gbProxyImport.Controls.Add(this.btnImportProxyList);
            this.gbProxyImport.Controls.Add(this.btnHelpProxyList);
            this.gbProxyImport.Controls.Add(this.btnBrowseProxyList);
            this.gbProxyImport.Controls.Add(this.lblDescProxyPath);
            this.gbProxyImport.Location = new System.Drawing.Point(280, 327);
            this.gbProxyImport.Name = "gbProxyImport";
            this.gbProxyImport.Size = new System.Drawing.Size(482, 59);
            this.gbProxyImport.TabIndex = 18;
            this.gbProxyImport.TabStop = false;
            this.gbProxyImport.Text = "Proxy import";
            // 
            // tbProxyListPath
            // 
            this.tbProxyListPath.Enabled = false;
            this.tbProxyListPath.Location = new System.Drawing.Point(6, 32);
            this.tbProxyListPath.Name = "tbProxyListPath";
            this.tbProxyListPath.Size = new System.Drawing.Size(253, 20);
            this.tbProxyListPath.TabIndex = 17;
            // 
            // btnImportProxyList
            // 
            this.btnImportProxyList.Location = new System.Drawing.Point(351, 30);
            this.btnImportProxyList.Name = "btnImportProxyList";
            this.btnImportProxyList.Size = new System.Drawing.Size(125, 23);
            this.btnImportProxyList.TabIndex = 20;
            this.btnImportProxyList.Text = "Load";
            this.btnImportProxyList.UseVisualStyleBackColor = true;
            this.btnImportProxyList.Click += new System.EventHandler(this.btnImportProxyList_Click);
            // 
            // btnHelpProxyList
            // 
            this.btnHelpProxyList.Location = new System.Drawing.Point(322, 30);
            this.btnHelpProxyList.Name = "btnHelpProxyList";
            this.btnHelpProxyList.Size = new System.Drawing.Size(23, 23);
            this.btnHelpProxyList.TabIndex = 19;
            this.btnHelpProxyList.Text = "?";
            this.btnHelpProxyList.UseVisualStyleBackColor = true;
            this.btnHelpProxyList.Click += new System.EventHandler(this.btnHelpProxyList_Click);
            // 
            // btnBrowseProxyList
            // 
            this.btnBrowseProxyList.Location = new System.Drawing.Point(265, 30);
            this.btnBrowseProxyList.Name = "btnBrowseProxyList";
            this.btnBrowseProxyList.Size = new System.Drawing.Size(51, 23);
            this.btnBrowseProxyList.TabIndex = 17;
            this.btnBrowseProxyList.Text = "Browse";
            this.btnBrowseProxyList.UseVisualStyleBackColor = true;
            this.btnBrowseProxyList.Click += new System.EventHandler(this.btnBrowseProxyList_Click);
            // 
            // lblDescProxyPath
            // 
            this.lblDescProxyPath.AutoSize = true;
            this.lblDescProxyPath.Location = new System.Drawing.Point(6, 16);
            this.lblDescProxyPath.Name = "lblDescProxyPath";
            this.lblDescProxyPath.Size = new System.Drawing.Size(75, 13);
            this.lblDescProxyPath.TabIndex = 18;
            this.lblDescProxyPath.Text = "Proxy list path:";
            // 
            // gbProxyManagement
            // 
            this.gbProxyManagement.Controls.Add(this.btnProxyShuffle);
            this.gbProxyManagement.Controls.Add(this.btnAddProxyManually);
            this.gbProxyManagement.Controls.Add(this.tbProxyUrl);
            this.gbProxyManagement.Controls.Add(this.label1);
            this.gbProxyManagement.Controls.Add(this.btnClearProxyList);
            this.gbProxyManagement.Controls.Add(this.lbProxyView);
            this.gbProxyManagement.Location = new System.Drawing.Point(280, 70);
            this.gbProxyManagement.Name = "gbProxyManagement";
            this.gbProxyManagement.Size = new System.Drawing.Size(482, 251);
            this.gbProxyManagement.TabIndex = 17;
            this.gbProxyManagement.TabStop = false;
            this.gbProxyManagement.Text = "Proxy management";
            // 
            // btnAddProxyManually
            // 
            this.btnAddProxyManually.Location = new System.Drawing.Point(332, 15);
            this.btnAddProxyManually.Name = "btnAddProxyManually";
            this.btnAddProxyManually.Size = new System.Drawing.Size(51, 23);
            this.btnAddProxyManually.TabIndex = 24;
            this.btnAddProxyManually.Text = "Add";
            this.btnAddProxyManually.UseVisualStyleBackColor = true;
            this.btnAddProxyManually.Click += new System.EventHandler(this.btnAddProxyManually_Click);
            // 
            // tbProxyUrl
            // 
            this.tbProxyUrl.Location = new System.Drawing.Point(73, 17);
            this.tbProxyUrl.Name = "tbProxyUrl";
            this.tbProxyUrl.Size = new System.Drawing.Size(253, 20);
            this.tbProxyUrl.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Proxy URL:";
            // 
            // btnClearProxyList
            // 
            this.btnClearProxyList.Location = new System.Drawing.Point(395, 222);
            this.btnClearProxyList.Name = "btnClearProxyList";
            this.btnClearProxyList.Size = new System.Drawing.Size(81, 23);
            this.btnClearProxyList.TabIndex = 21;
            this.btnClearProxyList.Text = "Clear";
            this.btnClearProxyList.UseVisualStyleBackColor = true;
            this.btnClearProxyList.Click += new System.EventHandler(this.btnClearProxyList_Click);
            // 
            // lbProxyView
            // 
            this.lbProxyView.FormattingEnabled = true;
            this.lbProxyView.Location = new System.Drawing.Point(6, 43);
            this.lbProxyView.Name = "lbProxyView";
            this.lbProxyView.Size = new System.Drawing.Size(470, 173);
            this.lbProxyView.TabIndex = 0;
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.btnGeneratorAttack);
            this.gbActions.Controls.Add(this.btnAttackDictionary);
            this.gbActions.Location = new System.Drawing.Point(6, 337);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(265, 49);
            this.gbActions.TabIndex = 16;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // btnGeneratorAttack
            // 
            this.btnGeneratorAttack.Location = new System.Drawing.Point(134, 19);
            this.btnGeneratorAttack.Name = "btnGeneratorAttack";
            this.btnGeneratorAttack.Size = new System.Drawing.Size(125, 24);
            this.btnGeneratorAttack.TabIndex = 1;
            this.btnGeneratorAttack.Text = "Generator Attack";
            this.btnGeneratorAttack.UseVisualStyleBackColor = true;
            this.btnGeneratorAttack.Click += new System.EventHandler(this.btnGeneratorAttack_Click);
            // 
            // btnAttackDictionary
            // 
            this.btnAttackDictionary.Location = new System.Drawing.Point(6, 19);
            this.btnAttackDictionary.Name = "btnAttackDictionary";
            this.btnAttackDictionary.Size = new System.Drawing.Size(125, 23);
            this.btnAttackDictionary.TabIndex = 0;
            this.btnAttackDictionary.Text = "Dictionary Attack";
            this.btnAttackDictionary.UseVisualStyleBackColor = true;
            this.btnAttackDictionary.Click += new System.EventHandler(this.btnAttackDictionary_Click);
            // 
            // gbTarget
            // 
            this.gbTarget.Controls.Add(this.tbUsername);
            this.gbTarget.Controls.Add(this.lblDescUsername);
            this.gbTarget.Location = new System.Drawing.Point(6, 272);
            this.gbTarget.Name = "gbTarget";
            this.gbTarget.Size = new System.Drawing.Size(265, 59);
            this.gbTarget.TabIndex = 15;
            this.gbTarget.TabStop = false;
            this.gbTarget.Text = "Target";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(6, 32);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(253, 20);
            this.tbUsername.TabIndex = 5;
            // 
            // lblDescUsername
            // 
            this.lblDescUsername.AutoSize = true;
            this.lblDescUsername.Location = new System.Drawing.Point(6, 16);
            this.lblDescUsername.Name = "lblDescUsername";
            this.lblDescUsername.Size = new System.Drawing.Size(90, 13);
            this.lblDescUsername.TabIndex = 6;
            this.lblDescUsername.Text = "Target username:";
            // 
            // gbWordlist
            // 
            this.gbWordlist.Controls.Add(this.tbWordlist);
            this.gbWordlist.Controls.Add(this.btnHelpWordlist);
            this.gbWordlist.Controls.Add(this.btnBrowseWordlist);
            this.gbWordlist.Controls.Add(this.lblDescWordlist);
            this.gbWordlist.Location = new System.Drawing.Point(6, 176);
            this.gbWordlist.Name = "gbWordlist";
            this.gbWordlist.Size = new System.Drawing.Size(265, 90);
            this.gbWordlist.TabIndex = 14;
            this.gbWordlist.TabStop = false;
            this.gbWordlist.Text = "Wordlist";
            // 
            // tbWordlist
            // 
            this.tbWordlist.Enabled = false;
            this.tbWordlist.Location = new System.Drawing.Point(6, 34);
            this.tbWordlist.Name = "tbWordlist";
            this.tbWordlist.Size = new System.Drawing.Size(253, 20);
            this.tbWordlist.TabIndex = 9;
            // 
            // btnHelpWordlist
            // 
            this.btnHelpWordlist.Location = new System.Drawing.Point(236, 61);
            this.btnHelpWordlist.Name = "btnHelpWordlist";
            this.btnHelpWordlist.Size = new System.Drawing.Size(23, 23);
            this.btnHelpWordlist.TabIndex = 16;
            this.btnHelpWordlist.Text = "?";
            this.btnHelpWordlist.UseVisualStyleBackColor = true;
            this.btnHelpWordlist.Click += new System.EventHandler(this.btnHelpWordlist_Click);
            // 
            // btnBrowseWordlist
            // 
            this.btnBrowseWordlist.Location = new System.Drawing.Point(155, 61);
            this.btnBrowseWordlist.Name = "btnBrowseWordlist";
            this.btnBrowseWordlist.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseWordlist.TabIndex = 15;
            this.btnBrowseWordlist.Text = "Browse";
            this.btnBrowseWordlist.UseVisualStyleBackColor = true;
            this.btnBrowseWordlist.Click += new System.EventHandler(this.btnBrowseWordlist_Click);
            // 
            // lblDescWordlist
            // 
            this.lblDescWordlist.AutoSize = true;
            this.lblDescWordlist.Location = new System.Drawing.Point(6, 18);
            this.lblDescWordlist.Name = "lblDescWordlist";
            this.lblDescWordlist.Size = new System.Drawing.Size(72, 13);
            this.lblDescWordlist.TabIndex = 10;
            this.lblDescWordlist.Text = "Wordlist path:";
            // 
            // gbGenerator
            // 
            this.gbGenerator.Controls.Add(this.nudLimit);
            this.gbGenerator.Controls.Add(this.tbCharset);
            this.gbGenerator.Controls.Add(this.btnHelpGenerator);
            this.gbGenerator.Controls.Add(this.lblDescCharset);
            this.gbGenerator.Controls.Add(this.lblDescLimitLength);
            this.gbGenerator.Controls.Add(this.nudStart);
            this.gbGenerator.Controls.Add(this.lblDescStartLength);
            this.gbGenerator.Location = new System.Drawing.Point(6, 70);
            this.gbGenerator.Name = "gbGenerator";
            this.gbGenerator.Size = new System.Drawing.Size(265, 100);
            this.gbGenerator.TabIndex = 13;
            this.gbGenerator.TabStop = false;
            this.gbGenerator.Text = "Generator";
            // 
            // nudLimit
            // 
            this.nudLimit.Location = new System.Drawing.Point(109, 71);
            this.nudLimit.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudLimit.Name = "nudLimit";
            this.nudLimit.Size = new System.Drawing.Size(97, 20);
            this.nudLimit.TabIndex = 11;
            this.nudLimit.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // tbCharset
            // 
            this.tbCharset.Location = new System.Drawing.Point(6, 32);
            this.tbCharset.Name = "tbCharset";
            this.tbCharset.Size = new System.Drawing.Size(253, 20);
            this.tbCharset.TabIndex = 7;
            // 
            // btnHelpGenerator
            // 
            this.btnHelpGenerator.Location = new System.Drawing.Point(236, 68);
            this.btnHelpGenerator.Name = "btnHelpGenerator";
            this.btnHelpGenerator.Size = new System.Drawing.Size(23, 23);
            this.btnHelpGenerator.TabIndex = 16;
            this.btnHelpGenerator.Text = "?";
            this.btnHelpGenerator.UseVisualStyleBackColor = true;
            this.btnHelpGenerator.Click += new System.EventHandler(this.btnHelpGenerator_Click);
            // 
            // lblDescCharset
            // 
            this.lblDescCharset.AutoSize = true;
            this.lblDescCharset.Location = new System.Drawing.Point(6, 16);
            this.lblDescCharset.Name = "lblDescCharset";
            this.lblDescCharset.Size = new System.Drawing.Size(73, 13);
            this.lblDescCharset.TabIndex = 8;
            this.lblDescCharset.Text = "Character set:";
            // 
            // lblDescLimitLength
            // 
            this.lblDescLimitLength.AutoSize = true;
            this.lblDescLimitLength.Location = new System.Drawing.Point(106, 55);
            this.lblDescLimitLength.Name = "lblDescLimitLength";
            this.lblDescLimitLength.Size = new System.Drawing.Size(63, 13);
            this.lblDescLimitLength.TabIndex = 12;
            this.lblDescLimitLength.Text = "Limit length:";
            // 
            // nudStart
            // 
            this.nudStart.Location = new System.Drawing.Point(6, 71);
            this.nudStart.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudStart.Name = "nudStart";
            this.nudStart.Size = new System.Drawing.Size(97, 20);
            this.nudStart.TabIndex = 9;
            this.nudStart.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // lblDescStartLength
            // 
            this.lblDescStartLength.AutoSize = true;
            this.lblDescStartLength.Location = new System.Drawing.Point(3, 55);
            this.lblDescStartLength.Name = "lblDescStartLength";
            this.lblDescStartLength.Size = new System.Drawing.Size(64, 13);
            this.lblDescStartLength.TabIndex = 10;
            this.lblDescStartLength.Text = "Start length:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.lblCaption);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 24);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.ForeColor = System.Drawing.Color.White;
            this.lblCaption.Location = new System.Drawing.Point(6, 6);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(61, 13);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "OpenSetup";
            this.lblCaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
            // 
            // btnProxyShuffle
            // 
            this.btnProxyShuffle.Location = new System.Drawing.Point(308, 222);
            this.btnProxyShuffle.Name = "btnProxyShuffle";
            this.btnProxyShuffle.Size = new System.Drawing.Size(81, 23);
            this.btnProxyShuffle.TabIndex = 25;
            this.btnProxyShuffle.Text = "Shuffle";
            this.btnProxyShuffle.UseVisualStyleBackColor = true;
            this.btnProxyShuffle.Click += new System.EventHandler(this.btnProxyShuffle_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "OpenSetup";
            this.tcMain.ResumeLayout(false);
            this.tpPlayer.ResumeLayout(false);
            this.tpPlayer.PerformLayout();
            this.tpGlobal.ResumeLayout(false);
            this.tpGlobal.PerformLayout();
            this.tpCreator.ResumeLayout(false);
            this.tpCreator.PerformLayout();
            this.tpBypass.ResumeLayout(false);
            this.tpBypass.PerformLayout();
            this.tpBruteforce.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSetup)).EndInit();
            this.gbProxyImport.ResumeLayout(false);
            this.gbProxyImport.PerformLayout();
            this.gbProxyManagement.ResumeLayout(false);
            this.gbProxyManagement.PerformLayout();
            this.gbActions.ResumeLayout(false);
            this.gbTarget.ResumeLayout(false);
            this.gbTarget.PerformLayout();
            this.gbWordlist.ResumeLayout(false);
            this.gbWordlist.PerformLayout();
            this.gbGenerator.ResumeLayout(false);
            this.gbGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpPlayer;
        private System.Windows.Forms.TabPage tpGlobal;
        private System.Windows.Forms.Label lblDescPlayer;
        private System.Windows.Forms.FlowLayoutPanel flowPlayer;
        private System.Windows.Forms.TabPage tpCreator;
        private System.Windows.Forms.TabPage tpBypass;
        private System.Windows.Forms.Label lblDescGlobal;
        private System.Windows.Forms.FlowLayoutPanel flowGlobal;
        private System.Windows.Forms.Label lblDescCreator;
        private System.Windows.Forms.FlowLayoutPanel flowCreator;
        private System.Windows.Forms.Label lblDescBypass;
        private System.Windows.Forms.FlowLayoutPanel flowBypass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.TabPage tpBruteforce;
        private System.Windows.Forms.Label lblDescLimitLength;
        private System.Windows.Forms.NumericUpDown nudLimit;
        private System.Windows.Forms.Label lblDescStartLength;
        private System.Windows.Forms.NumericUpDown nudStart;
        private System.Windows.Forms.Label lblDescCharset;
        private System.Windows.Forms.TextBox tbCharset;
        private System.Windows.Forms.Label lblDescUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.GroupBox gbWordlist;
        private System.Windows.Forms.Label lblDescWordlist;
        private System.Windows.Forms.TextBox tbWordlist;
        private System.Windows.Forms.GroupBox gbGenerator;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Button btnGeneratorAttack;
        private System.Windows.Forms.Button btnAttackDictionary;
        private System.Windows.Forms.GroupBox gbTarget;
        private System.Windows.Forms.Button btnHelpWordlist;
        private System.Windows.Forms.Button btnBrowseWordlist;
        private System.Windows.Forms.Button btnHelpGenerator;
        private System.Windows.Forms.GroupBox gbProxyImport;
        private System.Windows.Forms.Button btnImportProxyList;
        private System.Windows.Forms.Button btnHelpProxyList;
        private System.Windows.Forms.Button btnBrowseProxyList;
        private System.Windows.Forms.Label lblDescProxyPath;
        private System.Windows.Forms.TextBox tbProxyListPath;
        private System.Windows.Forms.GroupBox gbProxyManagement;
        private System.Windows.Forms.Button btnAddProxyManually;
        private System.Windows.Forms.TextBox tbProxyUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearProxyList;
        private System.Windows.Forms.ListBox lbProxyView;
        private System.Windows.Forms.PictureBox pbSetup;
        private System.Windows.Forms.Button btnProxyShuffle;
    }
}