namespace ErrorFixer
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
            ProcessButton = new Button();
            MessageLabel = new Label();
            FolderSelectionButton = new Button();
            label1 = new Label();
            PathLabel = new Label();
            OptionButton = new Button();
            SuspendLayout();
            // 
            // ProcessButton
            // 
            ProcessButton.Location = new Point(12, 102);
            ProcessButton.Name = "ProcessButton";
            ProcessButton.Size = new Size(112, 34);
            ProcessButton.TabIndex = 0;
            ProcessButton.Text = "実行";
            ProcessButton.UseVisualStyleBackColor = true;
            ProcessButton.Click += ProcessButton_Click;
            // 
            // MessageLabel
            // 
            MessageLabel.AutoSize = true;
            MessageLabel.Location = new Point(12, 139);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(0, 25);
            MessageLabel.TabIndex = 1;
            // 
            // FolderSelectionButton
            // 
            FolderSelectionButton.Location = new Point(12, 37);
            FolderSelectionButton.Name = "FolderSelectionButton";
            FolderSelectionButton.Size = new Size(112, 34);
            FolderSelectionButton.TabIndex = 2;
            FolderSelectionButton.Text = "選択";
            FolderSelectionButton.UseVisualStyleBackColor = true;
            FolderSelectionButton.Click += FolderSelectionButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(355, 25);
            label1.TabIndex = 3;
            label1.Text = "Unityのプロジェクトのフォルダーを選択してください";
            // 
            // PathLabel
            // 
            PathLabel.AutoSize = true;
            PathLabel.Location = new Point(12, 74);
            PathLabel.Name = "PathLabel";
            PathLabel.Size = new Size(0, 25);
            PathLabel.TabIndex = 4;
            // 
            // OptionButton
            // 
            OptionButton.Location = new Point(248, 102);
            OptionButton.Name = "OptionButton";
            OptionButton.Size = new Size(112, 34);
            OptionButton.TabIndex = 5;
            OptionButton.Text = "設定";
            OptionButton.UseVisualStyleBackColor = true;
            OptionButton.Click += OptionButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 174);
            Controls.Add(OptionButton);
            Controls.Add(PathLabel);
            Controls.Add(label1);
            Controls.Add(FolderSelectionButton);
            Controls.Add(MessageLabel);
            Controls.Add(ProcessButton);
            Name = "Form1";
            Text = "エラー修復ツール v1.1.0";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ProcessButton;
        private Label MessageLabel;
        private Button FolderSelectionButton;
        private Label label1;
        private Label PathLabel;
        private Button OptionButton;
    }
}