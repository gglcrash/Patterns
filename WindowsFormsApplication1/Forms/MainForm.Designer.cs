namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FlyweightRadioButton = new System.Windows.Forms.RadioButton();
            this.AbstractFactoyRadioButton = new System.Windows.Forms.RadioButton();
            this.checkButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FlyweightRadioButton);
            this.groupBox1.Controls.Add(this.AbstractFactoyRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбрать паттерн";
            // 
            // FlyweightRadioButton
            // 
            this.FlyweightRadioButton.AutoSize = true;
            this.FlyweightRadioButton.Location = new System.Drawing.Point(6, 42);
            this.FlyweightRadioButton.Name = "FlyweightRadioButton";
            this.FlyweightRadioButton.Size = new System.Drawing.Size(111, 17);
            this.FlyweightRadioButton.TabIndex = 1;
            this.FlyweightRadioButton.TabStop = true;
            this.FlyweightRadioButton.Text = "Приспособленец";
            this.FlyweightRadioButton.UseVisualStyleBackColor = true;
            // 
            // AbstractFactoyRadioButton
            // 
            this.AbstractFactoyRadioButton.AutoSize = true;
            this.AbstractFactoyRadioButton.Location = new System.Drawing.Point(6, 19);
            this.AbstractFactoyRadioButton.Name = "AbstractFactoyRadioButton";
            this.AbstractFactoyRadioButton.Size = new System.Drawing.Size(137, 17);
            this.AbstractFactoyRadioButton.TabIndex = 0;
            this.AbstractFactoyRadioButton.TabStop = true;
            this.AbstractFactoyRadioButton.Text = "Абстрактная фабрика";
            this.AbstractFactoyRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(18, 86);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(137, 23);
            this.checkButton.TabIndex = 1;
            this.checkButton.Text = "Проверить";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 116);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Patterns";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FlyweightRadioButton;
        private System.Windows.Forms.RadioButton AbstractFactoyRadioButton;
        private System.Windows.Forms.Button checkButton;
    }
}

