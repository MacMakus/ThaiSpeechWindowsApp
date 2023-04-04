namespace ThaiSpeechWindowsApp
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
            this.NewThaiWordButton = new System.Windows.Forms.Button();
            this.ReadSpeechButton = new System.Windows.Forms.Button();
            this.ThaiWordLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewThaiWordButton
            // 
            this.NewThaiWordButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewThaiWordButton.Location = new System.Drawing.Point(304, 226);
            this.NewThaiWordButton.Name = "NewThaiWordButton";
            this.NewThaiWordButton.Size = new System.Drawing.Size(142, 63);
            this.NewThaiWordButton.TabIndex = 1;
            this.NewThaiWordButton.Text = "สร้างคำใหม่";
            this.NewThaiWordButton.UseVisualStyleBackColor = true;
            this.NewThaiWordButton.Click += new System.EventHandler(this.NewThaiWordButton_Click);
            // 
            // ReadSpeechButton
            // 
            this.ReadSpeechButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReadSpeechButton.Location = new System.Drawing.Point(304, 335);
            this.ReadSpeechButton.Name = "ReadSpeechButton";
            this.ReadSpeechButton.Size = new System.Drawing.Size(142, 63);
            this.ReadSpeechButton.TabIndex = 2;
            this.ReadSpeechButton.Text = "อ่านออกเสียง";
            this.ReadSpeechButton.UseVisualStyleBackColor = true;
            this.ReadSpeechButton.Click += new System.EventHandler(this.ReadSpeechButton_Click);
            // 
            // ThaiWordLabel
            // 
            this.ThaiWordLabel.AutoSize = true;
            this.ThaiWordLabel.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThaiWordLabel.Location = new System.Drawing.Point(304, 86);
            this.ThaiWordLabel.Name = "ThaiWordLabel";
            this.ThaiWordLabel.Size = new System.Drawing.Size(137, 59);
            this.ThaiWordLabel.TabIndex = 3;
            this.ThaiWordLabel.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(488, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ThaiWordLabel);
            this.Controls.Add(this.ReadSpeechButton);
            this.Controls.Add(this.NewThaiWordButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button NewThaiWordButton;
        private Button ReadSpeechButton;
        private Label ThaiWordLabel;
        private TextBox textBox1;
    }
}