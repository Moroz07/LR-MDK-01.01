namespace NewWinForms
{
    partial class MainForms
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            panel4 = new Panel();
            PictureArea = new PictureBox();
            panel1 = new Panel();
            FileNamesListBox = new ListBox();
            panel3 = new Panel();
            DeleteButton = new Button();
            EditButton = new Button();
            LoadButton = new Button();
            SaveButton = new Button();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureArea).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 450);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(PictureArea);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(200, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(600, 382);
            panel4.TabIndex = 2;
            // 
            // PictureArea
            // 
            PictureArea.Dock = DockStyle.Fill;
            PictureArea.Location = new Point(0, 0);
            PictureArea.Name = "PictureArea";
            PictureArea.Size = new Size(600, 382);
            PictureArea.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureArea.TabIndex = 0;
            PictureArea.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(FileNamesListBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 382);
            panel1.TabIndex = 1;
            // 
            // FileNamesListBox
            // 
            FileNamesListBox.Dock = DockStyle.Fill;
            FileNamesListBox.FormattingEnabled = true;
            FileNamesListBox.ItemHeight = 15;
            FileNamesListBox.Location = new Point(0, 0);
            FileNamesListBox.Name = "FileNamesListBox";
            FileNamesListBox.Size = new Size(200, 382);
            FileNamesListBox.TabIndex = 0;
            FileNamesListBox.SelectedIndexChanged += FileNamesListBox_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(DeleteButton);
            panel3.Controls.Add(EditButton);
            panel3.Controls.Add(LoadButton);
            panel3.Controls.Add(SaveButton);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 382);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 68);
            panel3.TabIndex = 0;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(622, 24);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(107, 29);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(435, 24);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(109, 29);
            EditButton.TabIndex = 2;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(234, 24);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(115, 29);
            LoadButton.TabIndex = 1;
            LoadButton.Text = "Загрузить";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(47, 24);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(119, 29);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // MainForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Name = "MainForms";
            Text = "Test";
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureArea).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel4;
        private Panel panel1;
        private Panel panel3;
        private PictureBox PictureArea;
        private ListBox FileNamesListBox;
        private Button DeleteButton;
        private Button EditButton;
        private Button LoadButton;
        private Button SaveButton;
    }
}
