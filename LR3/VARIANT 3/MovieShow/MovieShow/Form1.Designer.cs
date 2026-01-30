namespace MovieShow
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
            this.ListBoxGenre = new System.Windows.Forms.ListBox();
            this.ComboBoxMovie = new System.Windows.Forms.ComboBox();
            this.PictureBoxMovie = new System.Windows.Forms.PictureBox();
            this.ButtonShowMovie = new System.Windows.Forms.Button();
            this.RichTextBoxInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxGenre
            // 
            this.ListBoxGenre.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBoxGenre.FormattingEnabled = true;
            this.ListBoxGenre.ItemHeight = 16;
            this.ListBoxGenre.Location = new System.Drawing.Point(0, 0);
            this.ListBoxGenre.Name = "ListBoxGenre";
            this.ListBoxGenre.Size = new System.Drawing.Size(120, 479);
            this.ListBoxGenre.TabIndex = 0;
            this.ListBoxGenre.SelectedIndexChanged += new System.EventHandler(this.ListBoxGenre_SelectedIndexChanged);
            // 
            // ComboBoxMovie
            // 
            this.ComboBoxMovie.FormattingEnabled = true;
            this.ComboBoxMovie.Location = new System.Drawing.Point(140, 24);
            this.ComboBoxMovie.Name = "ComboBoxMovie";
            this.ComboBoxMovie.Size = new System.Drawing.Size(219, 21);
            this.ComboBoxMovie.TabIndex = 1;
            // 
            // PictureBoxMovie
            // 
            this.PictureBoxMovie.Location = new System.Drawing.Point(432, 0);
            this.PictureBoxMovie.Name = "PictureBoxMovie";
            this.PictureBoxMovie.Size = new System.Drawing.Size(395, 303);
            this.PictureBoxMovie.TabIndex = 2;
            this.PictureBoxMovie.TabStop = false;
            // 
            // ButtonShowMovie
            // 
            this.ButtonShowMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonShowMovie.Location = new System.Drawing.Point(155, 368);
            this.ButtonShowMovie.Name = "ButtonShowMovie";
            this.ButtonShowMovie.Size = new System.Drawing.Size(125, 38);
            this.ButtonShowMovie.TabIndex = 3;
            this.ButtonShowMovie.Text = "Отчёт";
            this.ButtonShowMovie.UseVisualStyleBackColor = true;
            this.ButtonShowMovie.Click += new System.EventHandler(this.ButtonShowMovie_Click);
            // 
            // RichTextBoxInfo
            // 
            this.RichTextBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBoxInfo.Location = new System.Drawing.Point(432, 310);
            this.RichTextBoxInfo.Name = "RichTextBoxInfo";
            this.RichTextBoxInfo.Size = new System.Drawing.Size(395, 157);
            this.RichTextBoxInfo.TabIndex = 4;
            this.RichTextBoxInfo.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 479);
            this.Controls.Add(this.RichTextBoxInfo);
            this.Controls.Add(this.ButtonShowMovie);
            this.Controls.Add(this.PictureBoxMovie);
            this.Controls.Add(this.ComboBoxMovie);
            this.Controls.Add(this.ListBoxGenre);
            this.Name = "MainForm";
            this.Text = "Прокат фильмов";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxGenre;
        private System.Windows.Forms.ComboBox ComboBoxMovie;
        private System.Windows.Forms.PictureBox PictureBoxMovie;
        private System.Windows.Forms.Button ButtonShowMovie;
        private System.Windows.Forms.RichTextBox RichTextBoxInfo;
    }
}

