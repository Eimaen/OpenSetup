
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.tcMain.SuspendLayout();
            this.tpPlayer.SuspendLayout();
            this.tpGlobal.SuspendLayout();
            this.tpCreator.SuspendLayout();
            this.tpBypass.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpPlayer);
            this.tcMain.Controls.Add(this.tpGlobal);
            this.tcMain.Controls.Add(this.tpCreator);
            this.tcMain.Controls.Add(this.tpBypass);
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
            this.flowPlayer.Size = new System.Drawing.Size(756, 375);
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
            this.flowGlobal.Size = new System.Drawing.Size(756, 375);
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
            this.flowCreator.Size = new System.Drawing.Size(756, 375);
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
            this.flowBypass.Size = new System.Drawing.Size(756, 375);
            this.flowBypass.TabIndex = 2;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.tcMain.ResumeLayout(false);
            this.tpPlayer.ResumeLayout(false);
            this.tpPlayer.PerformLayout();
            this.tpGlobal.ResumeLayout(false);
            this.tpGlobal.PerformLayout();
            this.tpCreator.ResumeLayout(false);
            this.tpCreator.PerformLayout();
            this.tpBypass.ResumeLayout(false);
            this.tpBypass.PerformLayout();
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
    }
}