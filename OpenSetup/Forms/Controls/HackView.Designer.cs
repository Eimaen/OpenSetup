
namespace OpenSetup.Forms.Controls
{
    partial class HackView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHackName = new System.Windows.Forms.Label();
            this.lblHackDesc = new System.Windows.Forms.Label();
            this.cbHackActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblHackName
            // 
            this.lblHackName.AutoSize = true;
            this.lblHackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHackName.Location = new System.Drawing.Point(3, 0);
            this.lblHackName.Name = "lblHackName";
            this.lblHackName.Size = new System.Drawing.Size(139, 25);
            this.lblHackName.TabIndex = 0;
            this.lblHackName.Text = "lblHackName";
            // 
            // lblHackDesc
            // 
            this.lblHackDesc.Location = new System.Drawing.Point(5, 28);
            this.lblHackDesc.Name = "lblHackDesc";
            this.lblHackDesc.Size = new System.Drawing.Size(580, 29);
            this.lblHackDesc.TabIndex = 1;
            this.lblHackDesc.Text = "lblHackDesc";
            // 
            // cbHackActive
            // 
            this.cbHackActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHackActive.AutoSize = true;
            this.cbHackActive.Location = new System.Drawing.Point(525, 62);
            this.cbHackActive.Name = "cbHackActive";
            this.cbHackActive.Size = new System.Drawing.Size(56, 17);
            this.cbHackActive.TabIndex = 2;
            this.cbHackActive.Text = "Active";
            this.cbHackActive.UseVisualStyleBackColor = true;
            this.cbHackActive.CheckedChanged += new System.EventHandler(this.cbHackActive_CheckedChanged);
            // 
            // HackView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbHackActive);
            this.Controls.Add(this.lblHackDesc);
            this.Controls.Add(this.lblHackName);
            this.Name = "HackView";
            this.Size = new System.Drawing.Size(588, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHackName;
        private System.Windows.Forms.Label lblHackDesc;
        private System.Windows.Forms.CheckBox cbHackActive;
    }
}
