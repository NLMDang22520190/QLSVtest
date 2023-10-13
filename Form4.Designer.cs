namespace QLSVtest
{
    partial class Form4
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
            srchLabel = new Label();
            srchTextBox = new TextBox();
            srchBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // srchLabel
            // 
            srchLabel.AutoSize = true;
            srchLabel.Location = new Point(29, 20);
            srchLabel.Name = "srchLabel";
            srchLabel.Size = new Size(180, 25);
            srchLabel.TabIndex = 0;
            srchLabel.Text = "Search MSSV/HOTEN";
            srchLabel.Click += label1_Click;
            // 
            // srchTextBox
            // 
            srchTextBox.Location = new Point(231, 17);
            srchTextBox.Name = "srchTextBox";
            srchTextBox.Size = new Size(152, 31);
            srchTextBox.TabIndex = 1;
            // 
            // srchBtn
            // 
            srchBtn.Location = new Point(97, 69);
            srchBtn.Name = "srchBtn";
            srchBtn.Size = new Size(112, 34);
            srchBtn.TabIndex = 2;
            srchBtn.Text = "Search";
            srchBtn.UseVisualStyleBackColor = true;
            srchBtn.Click += srchBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(231, 69);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(112, 34);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 125);
            Controls.Add(cancelBtn);
            Controls.Add(srchBtn);
            Controls.Add(srchTextBox);
            Controls.Add(srchLabel);
            Name = "Form4";
            Text = "Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label srchLabel;
        private TextBox srchTextBox;
        private Button srchBtn;
        private Button cancelBtn;
    }
}