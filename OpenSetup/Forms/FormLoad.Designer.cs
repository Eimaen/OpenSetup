
namespace OpenSetup.Forms
{
    partial class OpenSetup
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
            this.lblCaption = new System.Windows.Forms.Label();
            this.pDrag = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbProcess = new System.Windows.Forms.TextBox();
            this.lblProcNameDesc = new System.Windows.Forms.Label();
            this.btnNoMemoryMode = new System.Windows.Forms.Button();
            this.pDrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.ForeColor = System.Drawing.Color.White;
            this.lblCaption.Location = new System.Drawing.Point(6, 6);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(128, 13);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "OpenSetup Loading Form";
            this.lblCaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
            // 
            // pDrag
            // 
            this.pDrag.BackColor = System.Drawing.Color.Purple;
            this.pDrag.Controls.Add(this.lblCaption);
            this.pDrag.Location = new System.Drawing.Point(0, 0);
            this.pDrag.Name = "pDrag";
            this.pDrag.Size = new System.Drawing.Size(377, 24);
            this.pDrag.TabIndex = 2;
            this.pDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
            // 
            // btnLoad
            // 
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.Gray;
            this.btnLoad.Location = new System.Drawing.Point(214, 30);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbProcess
            // 
            this.tbProcess.Location = new System.Drawing.Point(89, 32);
            this.tbProcess.Name = "tbProcess";
            this.tbProcess.Size = new System.Drawing.Size(117, 20);
            this.tbProcess.TabIndex = 4;
            this.tbProcess.Text = "GeometryDash";
            // 
            // lblProcNameDesc
            // 
            this.lblProcNameDesc.AutoSize = true;
            this.lblProcNameDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblProcNameDesc.Location = new System.Drawing.Point(6, 35);
            this.lblProcNameDesc.Name = "lblProcNameDesc";
            this.lblProcNameDesc.Size = new System.Drawing.Size(77, 13);
            this.lblProcNameDesc.TabIndex = 5;
            this.lblProcNameDesc.Text = "Process name:";
            // 
            // btnNoMemoryMode
            // 
            this.btnNoMemoryMode.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNoMemoryMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoMemoryMode.ForeColor = System.Drawing.Color.Gray;
            this.btnNoMemoryMode.Location = new System.Drawing.Point(295, 30);
            this.btnNoMemoryMode.Name = "btnNoMemoryMode";
            this.btnNoMemoryMode.Size = new System.Drawing.Size(75, 23);
            this.btnNoMemoryMode.TabIndex = 6;
            this.btnNoMemoryMode.Text = "Skip";
            this.btnNoMemoryMode.UseVisualStyleBackColor = true;
            this.btnNoMemoryMode.Click += new System.EventHandler(this.btnNoMemoryMode_Click);
            // 
            // OpenSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(377, 59);
            this.Controls.Add(this.btnNoMemoryMode);
            this.Controls.Add(this.lblProcNameDesc);
            this.Controls.Add(this.tbProcess);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpenSetup";
            this.ShowInTaskbar = false;
            this.Text = "FormLoad";
            this.pDrag.ResumeLayout(false);
            this.pDrag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Panel pDrag;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox tbProcess;
        private System.Windows.Forms.Label lblProcNameDesc;
        private System.Windows.Forms.Button btnNoMemoryMode;
    }
}