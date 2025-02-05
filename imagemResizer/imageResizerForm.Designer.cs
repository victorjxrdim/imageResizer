namespace imagemResizer
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
            heightTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            imageSelectButton = new Button();
            label3 = new Label();
            filePathButton = new Button();
            label4 = new Label();
            button1 = new Button();
            selectedImage = new PictureBox();
            label5 = new Label();
            fileLabel = new Label();
            label6 = new Label();
            widthTextBox = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)selectedImage).BeginInit();
            SuspendLayout();
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(18, 98);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.PlaceholderText = "Example: 1080";
            heightTextBox.Size = new Size(175, 23);
            heightTextBox.TabIndex = 0;
            heightTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(31, 80);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 1;
            label1.Text = "Choose your image height";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(22, 134);
            label2.Name = "label2";
            label2.Size = new Size(156, 15);
            label2.TabIndex = 2;
            label2.Text = "Choose your image to resize";
            // 
            // imageSelectButton
            // 
            imageSelectButton.FlatStyle = FlatStyle.System;
            imageSelectButton.ForeColor = SystemColors.ActiveCaptionText;
            imageSelectButton.Location = new Point(32, 155);
            imageSelectButton.Name = "imageSelectButton";
            imageSelectButton.Size = new Size(133, 45);
            imageSelectButton.TabIndex = 3;
            imageSelectButton.Text = "Click here to choose";
            imageSelectButton.UseVisualStyleBackColor = true;
            imageSelectButton.Click += SelectImageButton;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 211);
            label3.Name = "label3";
            label3.Size = new Size(174, 15);
            label3.TabIndex = 4;
            label3.Text = "Choose where you want to save";
            // 
            // filePathButton
            // 
            filePathButton.FlatStyle = FlatStyle.System;
            filePathButton.ForeColor = SystemColors.ActiveCaptionText;
            filePathButton.Location = new Point(32, 239);
            filePathButton.Name = "filePathButton";
            filePathButton.Size = new Size(133, 45);
            filePathButton.TabIndex = 5;
            filePathButton.Text = "Click here to choose";
            filePathButton.UseVisualStyleBackColor = true;
            filePathButton.Click += SelectDestinyPath;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(136, 343);
            label4.Name = "label4";
            label4.Size = new Size(249, 15);
            label4.TabIndex = 6;
            label4.Text = "Click in the button below to resize your image";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(226, 371);
            button1.Name = "button1";
            button1.Size = new Size(83, 45);
            button1.TabIndex = 7;
            button1.Text = "Resize";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ResizeImage;
            // 
            // selectedImage
            // 
            selectedImage.Enabled = false;
            selectedImage.Location = new Point(293, 61);
            selectedImage.Name = "selectedImage";
            selectedImage.Size = new Size(190, 190);
            selectedImage.TabIndex = 8;
            selectedImage.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(349, 43);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 9;
            label5.Text = "Image selected:";
            // 
            // fileLabel
            // 
            fileLabel.AutoSize = true;
            fileLabel.ForeColor = SystemColors.ActiveCaptionText;
            fileLabel.Location = new Point(309, 271);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new Size(0, 15);
            fileLabel.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(321, 254);
            label6.Name = "label6";
            label6.Size = new Size(131, 15);
            label6.TabIndex = 11;
            label6.Text = "The file will be saved in:";
            // 
            // widthTextBox
            // 
            widthTextBox.Location = new Point(18, 44);
            widthTextBox.Name = "widthTextBox";
            widthTextBox.PlaceholderText = "Example: 1920";
            widthTextBox.Size = new Size(175, 23);
            widthTextBox.TabIndex = 12;
            widthTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(31, 26);
            label7.Name = "label7";
            label7.Size = new Size(143, 15);
            label7.TabIndex = 13;
            label7.Text = "Choose your image width";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(525, 450);
            Controls.Add(label7);
            Controls.Add(widthTextBox);
            Controls.Add(label6);
            Controls.Add(fileLabel);
            Controls.Add(label5);
            Controls.Add(selectedImage);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(filePathButton);
            Controls.Add(label3);
            Controls.Add(imageSelectButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(heightTextBox);
            ForeColor = SystemColors.ControlDark;
            KeyPreview = true;
            Name = "Form1";
            Text = "Resize your image";
            ((System.ComponentModel.ISupportInitialize)selectedImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox heightTextBox;
        private Label label1;
        private Label label2;
        private Button imageSelectButton;
        private Label label3;
        private Button filePathButton;
        private Label label4;
        private Button button1;
        private PictureBox selectedImage;
        private Label label5;
        private Label fileLabel;
        private Label label6;
        private TextBox widthTextBox;
        private Label label7;
    }
}
