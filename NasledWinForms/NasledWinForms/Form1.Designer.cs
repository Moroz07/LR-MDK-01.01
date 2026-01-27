namespace NasledWinForms
{
    partial class MainForm
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
            this.StudentrichTextBox = new System.Windows.Forms.RichTextBox();
            this.HomoSapiensrichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentrichTextBox
            // 
            this.StudentrichTextBox.Location = new System.Drawing.Point(84, 99);
            this.StudentrichTextBox.Name = "StudentrichTextBox";
            this.StudentrichTextBox.Size = new System.Drawing.Size(223, 162);
            this.StudentrichTextBox.TabIndex = 0;
            this.StudentrichTextBox.Text = "";
            // 
            // HomoSapiensrichTextBox
            // 
            this.HomoSapiensrichTextBox.Location = new System.Drawing.Point(364, 99);
            this.HomoSapiensrichTextBox.Name = "HomoSapiensrichTextBox";
            this.HomoSapiensrichTextBox.Size = new System.Drawing.Size(228, 162);
            this.HomoSapiensrichTextBox.TabIndex = 1;
            this.HomoSapiensrichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Информация о студенте";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Информация о человеке разумном";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HomoSapiensrichTextBox);
            this.Controls.Add(this.StudentrichTextBox);
            this.Name = "MainForm";
            this.Text = "Наследование";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox StudentrichTextBox;
        private System.Windows.Forms.RichTextBox HomoSapiensrichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

