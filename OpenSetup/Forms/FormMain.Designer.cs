
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPlayer = new System.Windows.Forms.TabPage();
            this.tpGlobal = new System.Windows.Forms.TabPage();
            this.tpCreator = new System.Windows.Forms.TabPage();
            this.tpBypass = new System.Windows.Forms.TabPage();
            this.flowPlayer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDescPlayer = new System.Windows.Forms.Label();
            this.lblDescGlobal = new System.Windows.Forms.Label();
            this.flowGlobal = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDescCreator = new System.Windows.Forms.Label();
            this.flowCreator = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDescBypass = new System.Windows.Forms.Label();
            this.flowBypass = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tpPlayer.SuspendLayout();
            this.tpGlobal.SuspendLayout();
            this.tpCreator.SuspendLayout();
            this.tpBypass.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPlayer);
            this.tabControl1.Controls.Add(this.tpGlobal);
            this.tabControl1.Controls.Add(this.tpCreator);
            this.tabControl1.Controls.Add(this.tpBypass);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tpPlayer
            // 
            this.tpPlayer.Controls.Add(this.lblDescPlayer);
            this.tpPlayer.Controls.Add(this.flowPlayer);
            this.tpPlayer.Location = new System.Drawing.Point(4, 22);
            this.tpPlayer.Name = "tpPlayer";
            this.tpPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlayer.Size = new System.Drawing.Size(768, 400);
            this.tpPlayer.TabIndex = 0;
            this.tpPlayer.Text = "Player";
            this.tpPlayer.UseVisualStyleBackColor = true;
            // 
            // tpGlobal
            // 
            this.tpGlobal.Controls.Add(this.lblDescGlobal);
            this.tpGlobal.Controls.Add(this.flowGlobal);
            this.tpGlobal.Location = new System.Drawing.Point(4, 22);
            this.tpGlobal.Name = "tpGlobal";
            this.tpGlobal.Padding = new System.Windows.Forms.Padding(3);
            this.tpGlobal.Size = new System.Drawing.Size(768, 400);
            this.tpGlobal.TabIndex = 1;
            this.tpGlobal.Text = "Global";
            this.tpGlobal.UseVisualStyleBackColor = true;
            // 
            // tpCreator
            // 
            this.tpCreator.Controls.Add(this.lblDescCreator);
            this.tpCreator.Controls.Add(this.flowCreator);
            this.tpCreator.Location = new System.Drawing.Point(4, 22);
            this.tpCreator.Name = "tpCreator";
            this.tpCreator.Size = new System.Drawing.Size(768, 400);
            this.tpCreator.TabIndex = 2;
            this.tpCreator.Text = "Creator";
            this.tpCreator.UseVisualStyleBackColor = true;
            // 
            // tpBypass
            // 
            this.tpBypass.Controls.Add(this.lblDescBypass);
            this.tpBypass.Controls.Add(this.flowBypass);
            this.tpBypass.Location = new System.Drawing.Point(4, 22);
            this.tpBypass.Name = "tpBypass";
            this.tpBypass.Size = new System.Drawing.Size(768, 400);
            this.tpBypass.TabIndex = 3;
            this.tpBypass.Text = "Bypass";
            this.tpBypass.UseVisualStyleBackColor = true;
            // 
            // flowPlayer
            // 
            this.flowPlayer.Location = new System.Drawing.Point(6, 21);
            this.flowPlayer.Name = "flowPlayer";
            this.flowPlayer.Size = new System.Drawing.Size(756, 375);
            this.flowPlayer.TabIndex = 0;
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
            // lblDescGlobal
            // 
            this.lblDescGlobal.AutoSize = true;
            this.lblDescGlobal.Location = new System.Drawing.Point(6, 5);
            this.lblDescGlobal.Name = "lblDescGlobal";
            this.lblDescGlobal.Size = new System.Drawing.Size(216, 13);
            this.lblDescGlobal.TabIndex = 3;
            this.lblDescGlobal.Text = "This is where all the player-related hacks are";
            // 
            // flowGlobal
            // 
            this.flowGlobal.Location = new System.Drawing.Point(6, 21);
            this.flowGlobal.Name = "flowGlobal";
            this.flowGlobal.Size = new System.Drawing.Size(756, 375);
            this.flowGlobal.TabIndex = 2;
            // 
            // lblDescCreator
            // 
            this.lblDescCreator.AutoSize = true;
            this.lblDescCreator.Location = new System.Drawing.Point(6, 5);
            this.lblDescCreator.Name = "lblDescCreator";
            this.lblDescCreator.Size = new System.Drawing.Size(216, 13);
            this.lblDescCreator.TabIndex = 3;
            this.lblDescCreator.Text = "This is where all the player-related hacks are";
            // 
            // flowCreator
            // 
            this.flowCreator.Location = new System.Drawing.Point(6, 21);
            this.flowCreator.Name = "flowCreator";
            this.flowCreator.Size = new System.Drawing.Size(756, 375);
            this.flowCreator.TabIndex = 2;
            // 
            // lblDescBypass
            // 
            this.lblDescBypass.AutoSize = true;
            this.lblDescBypass.Location = new System.Drawing.Point(6, 5);
            this.lblDescBypass.Name = "lblDescBypass";
            this.lblDescBypass.Size = new System.Drawing.Size(216, 13);
            this.lblDescBypass.TabIndex = 3;
            this.lblDescBypass.Text = "This is where all the player-related hacks are";
            // 
            // flowBypass
            // 
            this.flowBypass.Location = new System.Drawing.Point(6, 21);
            this.flowBypass.Name = "flowBypass";
            this.flowBypass.Size = new System.Drawing.Size(756, 375);
            this.flowBypass.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.tabControl1.ResumeLayout(false);
            this.tpPlayer.ResumeLayout(false);
            this.tpPlayer.PerformLayout();
            this.tpGlobal.ResumeLayout(false);
            this.tpGlobal.PerformLayout();
            this.tpCreator.ResumeLayout(false);
            this.tpCreator.PerformLayout();
            this.tpBypass.ResumeLayout(false);
            this.tpBypass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
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
    }
}