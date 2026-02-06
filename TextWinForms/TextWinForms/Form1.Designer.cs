namespace TextWinForms
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.StatisticRichBox = new System.Windows.Forms.RichTextBox();
            this.CountDownTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите число от 1 до 100:";
            // 
            // NumberBox
            // 
            this.NumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberBox.Location = new System.Drawing.Point(487, 143);
            this.NumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.NumberBox.Multiline = true;
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(193, 37);
            this.NumberBox.TabIndex = 1;
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckButton.Location = new System.Drawing.Point(173, 228);
            this.CheckButton.Margin = new System.Windows.Forms.Padding(4);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(232, 80);
            this.CheckButton.TabIndex = 2;
            this.CheckButton.Text = "Проверить";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // StatisticRichBox
            // 
            this.StatisticRichBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatisticRichBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatisticRichBox.Location = new System.Drawing.Point(0, 376);
            this.StatisticRichBox.Margin = new System.Windows.Forms.Padding(4);
            this.StatisticRichBox.Name = "StatisticRichBox";
            this.StatisticRichBox.Size = new System.Drawing.Size(808, 242);
            this.StatisticRichBox.TabIndex = 0;
            this.StatisticRichBox.Text = "";
            // 
            // CountDownTime
            // 
            this.CountDownTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountDownTime.CustomFormat = "MM:ss";
            this.CountDownTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountDownTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.CountDownTime.Location = new System.Drawing.Point(335, 47);
            this.CountDownTime.Margin = new System.Windows.Forms.Padding(4);
            this.CountDownTime.Name = "CountDownTime";
            this.CountDownTime.Size = new System.Drawing.Size(196, 37);
            this.CountDownTime.TabIndex = 4;
            this.CountDownTime.Value = new System.DateTime(2026, 2, 6, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Обратный отсчёт";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 618);
            this.Controls.Add(this.StatisticRichBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CountDownTime);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.RichTextBox StatisticRichBox;
        private System.Windows.Forms.DateTimePicker CountDownTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer;
    }
}

