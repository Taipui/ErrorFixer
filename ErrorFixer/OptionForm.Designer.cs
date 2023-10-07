namespace ErrorFixer
{
    partial class OptionForm
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
            ErrorFixCheckBox = new CheckBox();
            RenderingFixCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // ErrorFixCheckBox
            // 
            ErrorFixCheckBox.AutoSize = true;
            ErrorFixCheckBox.Location = new Point(12, 12);
            ErrorFixCheckBox.Name = "ErrorFixCheckBox";
            ErrorFixCheckBox.Size = new Size(155, 29);
            ErrorFixCheckBox.TabIndex = 0;
            ErrorFixCheckBox.Text = "エラーを修復する";
            ErrorFixCheckBox.UseVisualStyleBackColor = true;
            // 
            // RenderingFixCheckBox
            // 
            RenderingFixCheckBox.AutoSize = true;
            RenderingFixCheckBox.Location = new Point(12, 47);
            RenderingFixCheckBox.Name = "RenderingFixCheckBox";
            RenderingFixCheckBox.Size = new Size(235, 29);
            RenderingFixCheckBox.TabIndex = 1;
            RenderingFixCheckBox.Text = "両目で描画されるようにする";
            RenderingFixCheckBox.UseVisualStyleBackColor = true;
            // 
            // OptionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 89);
            Controls.Add(RenderingFixCheckBox);
            Controls.Add(ErrorFixCheckBox);
            Name = "OptionForm";
            Text = "OptionForm";
            FormClosing += OptionForm_FormClosing;
            Load += OptionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ErrorFixCheckBox;
        private CheckBox RenderingFixCheckBox;
    }
}