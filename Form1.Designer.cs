namespace QLSVtest
{
    partial class Form1
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
            addBtn = new Button();
            rmBtn = new Button();
            srchBtn = new Button();
            expBtn = new Button();
            topBtn = new Button();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(157, 90);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(112, 34);
            addBtn.TabIndex = 0;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // rmBtn
            // 
            rmBtn.Location = new Point(491, 90);
            rmBtn.Name = "rmBtn";
            rmBtn.Size = new Size(112, 34);
            rmBtn.TabIndex = 1;
            rmBtn.Text = "REMOVE";
            rmBtn.UseVisualStyleBackColor = true;
            rmBtn.Click += rmBtn_Click;
            // 
            // srchBtn
            // 
            srchBtn.Location = new Point(157, 251);
            srchBtn.Name = "srchBtn";
            srchBtn.Size = new Size(112, 34);
            srchBtn.TabIndex = 2;
            srchBtn.Text = "SEARCH";
            srchBtn.UseVisualStyleBackColor = true;
            srchBtn.Click += srchBtn_Click;
            // 
            // expBtn
            // 
            expBtn.Location = new Point(491, 251);
            expBtn.Name = "expBtn";
            expBtn.Size = new Size(112, 34);
            expBtn.TabIndex = 3;
            expBtn.Text = "EXPORT";
            expBtn.UseVisualStyleBackColor = true;
            // 
            // topBtn
            // 
            topBtn.Location = new Point(322, 172);
            topBtn.Name = "topBtn";
            topBtn.Size = new Size(112, 34);
            topBtn.TabIndex = 4;
            topBtn.Text = "TOP";
            topBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(topBtn);
            Controls.Add(expBtn);
            Controls.Add(srchBtn);
            Controls.Add(rmBtn);
            Controls.Add(addBtn);
            Name = "Form1";
            Text = "QLSV";
            ResumeLayout(false);
        }

        #endregion

        private Button addBtn;
        private Button rmBtn;
        private Button srchBtn;
        private Button expBtn;
        private Button topBtn;
    }
}