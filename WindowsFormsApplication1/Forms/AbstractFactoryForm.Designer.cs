namespace WindowsFormsApplication1
{
    partial class AbstractFactoryForm
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.DogRadioButton = new System.Windows.Forms.RadioButton();
            this.CatRadioButton = new System.Windows.Forms.RadioButton();
            this.createButton = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.DogRadioButton);
            this.groupBox.Controls.Add(this.CatRadioButton);
            this.groupBox.Location = new System.Drawing.Point(216, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(85, 68);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Вещи для:";
            // 
            // DogRadioButton
            // 
            this.DogRadioButton.AutoSize = true;
            this.DogRadioButton.Location = new System.Drawing.Point(6, 42);
            this.DogRadioButton.Name = "DogRadioButton";
            this.DogRadioButton.Size = new System.Drawing.Size(62, 17);
            this.DogRadioButton.TabIndex = 1;
            this.DogRadioButton.TabStop = true;
            this.DogRadioButton.Text = "Собаки";
            this.DogRadioButton.UseVisualStyleBackColor = true;
            // 
            // CatRadioButton
            // 
            this.CatRadioButton.AutoSize = true;
            this.CatRadioButton.Location = new System.Drawing.Point(6, 19);
            this.CatRadioButton.Name = "CatRadioButton";
            this.CatRadioButton.Size = new System.Drawing.Size(58, 17);
            this.CatRadioButton.TabIndex = 0;
            this.CatRadioButton.TabStop = true;
            this.CatRadioButton.Text = "Кошки";
            this.CatRadioButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(222, 86);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(78, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 12);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(198, 198);
            this.richTextBox.TabIndex = 4;
            this.richTextBox.Text = "";
            // 
            // AbstractFactoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 219);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.createButton);
            this.Name = "AbstractFactoryForm";
            this.Text = "Абстрактная фабрика";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton DogRadioButton;
        private System.Windows.Forms.RadioButton CatRadioButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}