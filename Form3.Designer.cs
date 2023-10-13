namespace QLSVtest
{
    partial class Form3
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
            mssvLabel = new Label();
            mssvTextBox = new TextBox();
            rmBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // mssvLabel
            // 
            mssvLabel.AutoSize = true;
            mssvLabel.Location = new Point(39, 82);
            mssvLabel.Name = "mssvLabel";
            mssvLabel.Size = new Size(59, 25);
            mssvLabel.TabIndex = 0;
            mssvLabel.Text = "MSSV";
            // 
            // mssvTextBox
            // 
            mssvTextBox.Location = new Point(104, 79);
            mssvTextBox.Name = "mssvTextBox";
            mssvTextBox.Size = new Size(128, 31);
            mssvTextBox.TabIndex = 1;
            // 
            // rmBtn
            // 
            rmBtn.Location = new Point(39, 152);
            rmBtn.Name = "rmBtn";
            rmBtn.Size = new Size(92, 34);
            rmBtn.TabIndex = 2;
            rmBtn.Text = "Remove";
            rmBtn.UseVisualStyleBackColor = true;
            rmBtn.Click += rmBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(137, 152);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(92, 34);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 244);
            Controls.Add(cancelBtn);
            Controls.Add(rmBtn);
            Controls.Add(mssvTextBox);
            Controls.Add(mssvLabel);
            Name = "Form3";
            Text = "RemoveForm";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mssvLabel;
        private TextBox mssvTextBox;
        private Button rmBtn;
        private Button cancelBtn;
    }
}