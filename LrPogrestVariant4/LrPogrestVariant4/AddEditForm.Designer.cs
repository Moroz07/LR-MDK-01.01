namespace LrPogrestVariant4
{
    partial class AddEditForm
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
            this.YearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CloseButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.MarkTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // YearNumericUpDown
            // 
            this.YearNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearNumericUpDown.Location = new System.Drawing.Point(114, 128);
            this.YearNumericUpDown.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.YearNumericUpDown.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.YearNumericUpDown.Name = "YearNumericUpDown";
            this.YearNumericUpDown.Size = new System.Drawing.Size(246, 26);
            this.YearNumericUpDown.TabIndex = 4;
            this.YearNumericUpDown.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.YearNumericUpDown.ValueChanged += new System.EventHandler(this.YearNumericUpDown_ValueChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(118, 178);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(101, 26);
            this.CloseButton.TabIndex = 21;
            this.CloseButton.Text = "Отмена";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptButton.Location = new System.Drawing.Point(225, 178);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(109, 26);
            this.AcceptButton.TabIndex = 20;
            this.AcceptButton.Text = "Применить";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addbutton.Location = new System.Drawing.Point(19, 178);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(93, 26);
            this.Addbutton.TabIndex = 19;
            this.Addbutton.Text = "Oк";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Год выпуска";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Модель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Марка";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelTextBox.Location = new System.Drawing.Point(114, 62);
            this.ModelTextBox.Multiline = true;
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(246, 28);
            this.ModelTextBox.TabIndex = 2;
            this.ModelTextBox.TextChanged += new System.EventHandler(this.ModelTextBox_TextChanged);
            // 
            // MarkTextBox
            // 
            this.MarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarkTextBox.Location = new System.Drawing.Point(114, 28);
            this.MarkTextBox.Multiline = true;
            this.MarkTextBox.Name = "MarkTextBox";
            this.MarkTextBox.Size = new System.Drawing.Size(246, 28);
            this.MarkTextBox.TabIndex = 1;
            this.MarkTextBox.TextChanged += new System.EventHandler(this.MarkTextBox_TextChanged);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PriceTextBox.Location = new System.Drawing.Point(114, 96);
            this.PriceTextBox.Multiline = true;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(246, 28);
            this.PriceTextBox.TabIndex = 3;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 248);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.YearNumericUpDown);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.MarkTextBox);
            this.Name = "AddEditForm";
            this.Text = "AddEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown YearNumericUpDown;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox MarkTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
    }
}