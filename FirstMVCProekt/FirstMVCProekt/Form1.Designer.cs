namespace FirstMVCProekt
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RemoveToolStrip = new System.Windows.Forms.ToolStrip();
            this.RemoveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RemoveToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemoveToolStrip
            // 
            this.RemoveToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveToolStripButton});
            this.RemoveToolStrip.Location = new System.Drawing.Point(0, 0);
            this.RemoveToolStrip.Name = "RemoveToolStrip";
            this.RemoveToolStrip.Size = new System.Drawing.Size(800, 67);
            this.RemoveToolStrip.TabIndex = 0;
            this.RemoveToolStrip.Text = "toolStrip1";
            // 
            // RemoveToolStripButton
            // 
            this.RemoveToolStripButton.AutoSize = false;
            this.RemoveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveToolStripButton.Image")));
            this.RemoveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveToolStripButton.Name = "RemoveToolStripButton";
            this.RemoveToolStripButton.Size = new System.Drawing.Size(64, 64);
            this.RemoveToolStripButton.Text = "toolStripButton1";
            this.RemoveToolStripButton.Click += new System.EventHandler(this.RemoveToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemoveToolStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.RemoveToolStrip.ResumeLayout(false);
            this.RemoveToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip RemoveToolStrip;
        private System.Windows.Forms.ToolStripButton RemoveToolStripButton;
    }
}

