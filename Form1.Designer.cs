namespace Converter
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
            weightButton = new Button();
            speedButton = new Button();
            valueButton = new Button();
            SuspendLayout();
            // 
            // weightButton
            // 
            weightButton.Location = new Point(152, 117);
            weightButton.Name = "weightButton";
            weightButton.Size = new Size(100, 30);
            weightButton.TabIndex = 0;
            weightButton.Text = "Вес";
            weightButton.UseVisualStyleBackColor = true;
            weightButton.Click += weightButton_Click;
            // 
            // speedButton
            // 
            speedButton.Location = new Point(152, 226);
            speedButton.Name = "speedButton";
            speedButton.Size = new Size(100, 30);
            speedButton.TabIndex = 3;
            speedButton.Text = "Скорость";
            speedButton.UseVisualStyleBackColor = true;
            speedButton.Click += speedButton_Click;
            // 
            // valueButton
            // 
            valueButton.Location = new Point(152, 339);
            valueButton.Name = "valueButton";
            valueButton.Size = new Size(100, 30);
            valueButton.TabIndex = 4;
            valueButton.Text = "Валюта";
            valueButton.UseVisualStyleBackColor = true;
            valueButton.Click += valueButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 461);
            Controls.Add(valueButton);
            Controls.Add(speedButton);
            Controls.Add(weightButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Converter";
            ResumeLayout(false);
        }

        #endregion

        private Button weightButton;
        private Button speedButton;
        private Button valueButton;
    }
}
