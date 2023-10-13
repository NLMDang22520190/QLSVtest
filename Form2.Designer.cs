namespace QLSVtest
{
    partial class Form2
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
            mssvTextBox = new TextBox();
            hoTenTextBox = new TextBox();
            dAnhTextBox = new TextBox();
            dVanTextBox = new TextBox();
            dToanTextBox = new TextBox();
            maLopTextBox = new TextBox();
            mssvLabel = new Label();
            hoTenLabel = new Label();
            maLopLabel = new Label();
            dToanLabel = new Label();
            dAnhLabel = new Label();
            dVanLabel = new Label();
            addSVBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // mssvTextBox
            // 
            mssvTextBox.Location = new Point(197, 63);
            mssvTextBox.Name = "mssvTextBox";
            mssvTextBox.Size = new Size(150, 31);
            mssvTextBox.TabIndex = 0;
            // 
            // hoTenTextBox
            // 
            hoTenTextBox.Location = new Point(197, 100);
            hoTenTextBox.Name = "hoTenTextBox";
            hoTenTextBox.Size = new Size(150, 31);
            hoTenTextBox.TabIndex = 1;
            // 
            // dAnhTextBox
            // 
            dAnhTextBox.Location = new Point(197, 211);
            dAnhTextBox.Name = "dAnhTextBox";
            dAnhTextBox.Size = new Size(150, 31);
            dAnhTextBox.TabIndex = 2;
            // 
            // dVanTextBox
            // 
            dVanTextBox.Location = new Point(197, 248);
            dVanTextBox.Name = "dVanTextBox";
            dVanTextBox.Size = new Size(150, 31);
            dVanTextBox.TabIndex = 3;
            // 
            // dToanTextBox
            // 
            dToanTextBox.Location = new Point(197, 174);
            dToanTextBox.Name = "dToanTextBox";
            dToanTextBox.Size = new Size(150, 31);
            dToanTextBox.TabIndex = 4;
            // 
            // maLopTextBox
            // 
            maLopTextBox.Location = new Point(197, 137);
            maLopTextBox.Name = "maLopTextBox";
            maLopTextBox.Size = new Size(150, 31);
            maLopTextBox.TabIndex = 5;
            // 
            // mssvLabel
            // 
            mssvLabel.AutoSize = true;
            mssvLabel.Location = new Point(81, 69);
            mssvLabel.Name = "mssvLabel";
            mssvLabel.Size = new Size(59, 25);
            mssvLabel.TabIndex = 6;
            mssvLabel.Text = "MSSV";
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new Point(81, 106);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new Size(67, 25);
            hoTenLabel.TabIndex = 7;
            hoTenLabel.Text = "Ho Ten";
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Location = new Point(81, 143);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new Size(72, 25);
            maLopLabel.TabIndex = 8;
            maLopLabel.Text = "Ma Lop";
            // 
            // dToanLabel
            // 
            dToanLabel.AutoSize = true;
            dToanLabel.Location = new Point(81, 180);
            dToanLabel.Name = "dToanLabel";
            dToanLabel.Size = new Size(96, 25);
            dToanLabel.TabIndex = 9;
            dToanLabel.Text = "Diem Toan";
            // 
            // dAnhLabel
            // 
            dAnhLabel.AutoSize = true;
            dAnhLabel.Location = new Point(81, 217);
            dAnhLabel.Name = "dAnhLabel";
            dAnhLabel.Size = new Size(91, 25);
            dAnhLabel.TabIndex = 10;
            dAnhLabel.Text = "Diem Anh";
            // 
            // dVanLabel
            // 
            dVanLabel.AutoSize = true;
            dVanLabel.Location = new Point(81, 254);
            dVanLabel.Name = "dVanLabel";
            dVanLabel.Size = new Size(88, 25);
            dVanLabel.TabIndex = 11;
            dVanLabel.Text = "Diem Van";
            // 
            // addSVBtn
            // 
            addSVBtn.Location = new Point(81, 311);
            addSVBtn.Name = "addSVBtn";
            addSVBtn.Size = new Size(118, 40);
            addSVBtn.TabIndex = 12;
            addSVBtn.Text = "AddSV";
            addSVBtn.UseVisualStyleBackColor = true;
            addSVBtn.Click += addSVBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(218, 311);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(129, 40);
            cancelBtn.TabIndex = 13;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 450);
            Controls.Add(cancelBtn);
            Controls.Add(addSVBtn);
            Controls.Add(dVanLabel);
            Controls.Add(dAnhLabel);
            Controls.Add(dToanLabel);
            Controls.Add(maLopLabel);
            Controls.Add(hoTenLabel);
            Controls.Add(mssvLabel);
            Controls.Add(maLopTextBox);
            Controls.Add(dToanTextBox);
            Controls.Add(dVanTextBox);
            Controls.Add(dAnhTextBox);
            Controls.Add(hoTenTextBox);
            Controls.Add(mssvTextBox);
            Name = "Form2";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox mssvTextBox;
        private TextBox hoTenTextBox;
        private TextBox dAnhTextBox;
        private TextBox dVanTextBox;
        private TextBox dToanTextBox;
        private TextBox maLopTextBox;
        private Label mssvLabel;
        private Label hoTenLabel;
        private Label maLopLabel;
        private Label dToanLabel;
        private Label dAnhLabel;
        private Label dVanLabel;
        private Button addSVBtn;
        private Button cancelBtn;
    }
}