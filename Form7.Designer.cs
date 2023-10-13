namespace QLSVtest
{
    partial class Form7
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
            folderBrowserDialog1 = new FolderBrowserDialog();
            typeLabel = new Label();
            pathLabel = new Label();
            lopTextBox = new TextBox();
            allBtn = new RadioButton();
            lopBtn = new RadioButton();
            openBtn = new Button();
            pathTextBox = new TextBox();
            exportBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(46, 36);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(181, 25);
            typeLabel.TabIndex = 0;
            typeLabel.Text = "Select Type Of Export";
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Location = new Point(46, 131);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new Size(46, 25);
            pathLabel.TabIndex = 1;
            pathLabel.Text = "Path";
            // 
            // lopTextBox
            // 
            lopTextBox.Location = new Point(443, 71);
            lopTextBox.Name = "lopTextBox";
            lopTextBox.Size = new Size(189, 31);
            lopTextBox.TabIndex = 2;
            // 
            // allBtn
            // 
            allBtn.AutoSize = true;
            allBtn.Location = new Point(274, 36);
            allBtn.Name = "allBtn";
            allBtn.Size = new Size(57, 29);
            allBtn.TabIndex = 3;
            allBtn.TabStop = true;
            allBtn.Text = "All";
            allBtn.UseVisualStyleBackColor = true;
            allBtn.CheckedChanged += allBtn_CheckedChanged;
            // 
            // lopBtn
            // 
            lopBtn.AutoSize = true;
            lopBtn.Location = new Point(274, 71);
            lopBtn.Name = "lopBtn";
            lopBtn.Size = new Size(132, 29);
            lopBtn.TabIndex = 4;
            lopBtn.TabStop = true;
            lopBtn.Text = "Specific Lop";
            lopBtn.UseVisualStyleBackColor = true;
            lopBtn.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // openBtn
            // 
            openBtn.Location = new Point(527, 131);
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(66, 34);
            openBtn.TabIndex = 5;
            openBtn.Text = "Open";
            openBtn.UseVisualStyleBackColor = true;
            openBtn.Click += openBtn_Click;
            // 
            // pathTextBox
            // 
            pathTextBox.Location = new Point(111, 131);
            pathTextBox.Name = "pathTextBox";
            pathTextBox.Size = new Size(410, 31);
            pathTextBox.TabIndex = 6;
            // 
            // exportBtn
            // 
            exportBtn.Location = new Point(599, 131);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(88, 34);
            exportBtn.TabIndex = 7;
            exportBtn.Text = "Export";
            exportBtn.UseVisualStyleBackColor = true;
            exportBtn.Click += exportBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(693, 131);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(88, 34);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 233);
            Controls.Add(cancelBtn);
            Controls.Add(exportBtn);
            Controls.Add(pathTextBox);
            Controls.Add(openBtn);
            Controls.Add(lopBtn);
            Controls.Add(allBtn);
            Controls.Add(lopTextBox);
            Controls.Add(pathLabel);
            Controls.Add(typeLabel);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Label typeLabel;
        private Label pathLabel;
        private TextBox lopTextBox;
        private RadioButton allBtn;
        private RadioButton lopBtn;
        private Button openBtn;
        private TextBox pathTextBox;
        private Button exportBtn;
        private Button cancelBtn;
    }
}