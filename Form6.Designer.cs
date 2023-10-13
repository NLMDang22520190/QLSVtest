namespace QLSVtest
{
    partial class Form6
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
            highBtn = new RadioButton();
            lowBtn = new RadioButton();
            topBtn = new Button();
            cancelBtn = new Button();
            topLabel = new Label();
            topTextBox = new TextBox();
            SuspendLayout();
            // 
            // highBtn
            // 
            highBtn.AutoSize = true;
            highBtn.Location = new Point(280, 34);
            highBtn.Name = "highBtn";
            highBtn.Size = new Size(143, 29);
            highBtn.TabIndex = 0;
            highBtn.TabStop = true;
            highBtn.Text = "Highest Point";
            highBtn.UseVisualStyleBackColor = true;
            highBtn.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // lowBtn
            // 
            lowBtn.AutoSize = true;
            lowBtn.Location = new Point(280, 69);
            lowBtn.Name = "lowBtn";
            lowBtn.Size = new Size(137, 29);
            lowBtn.TabIndex = 1;
            lowBtn.TabStop = true;
            lowBtn.Text = "Lowest Point";
            lowBtn.UseVisualStyleBackColor = true;
            // 
            // topBtn
            // 
            topBtn.Location = new Point(77, 118);
            topBtn.Name = "topBtn";
            topBtn.Size = new Size(112, 34);
            topBtn.TabIndex = 2;
            topBtn.Text = "Confirm";
            topBtn.UseVisualStyleBackColor = true;
            topBtn.Click += topBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(222, 118);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(112, 34);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // topLabel
            // 
            topLabel.AutoSize = true;
            topLabel.Location = new Point(89, 55);
            topLabel.Name = "topLabel";
            topLabel.Size = new Size(44, 25);
            topLabel.TabIndex = 4;
            topLabel.Text = "TOP";
            // 
            // topTextBox
            // 
            topTextBox.Location = new Point(166, 52);
            topTextBox.Name = "topTextBox";
            topTextBox.Size = new Size(88, 31);
            topTextBox.TabIndex = 5;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 192);
            Controls.Add(topTextBox);
            Controls.Add(topLabel);
            Controls.Add(cancelBtn);
            Controls.Add(topBtn);
            Controls.Add(lowBtn);
            Controls.Add(highBtn);
            Name = "Form6";
            Text = "Top";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton highBtn;
        private RadioButton lowBtn;
        private Button topBtn;
        private Button cancelBtn;
        private Label topLabel;
        private TextBox topTextBox;
    }
}