namespace Logger
{
    partial class LoggerInterface
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogButton = new System.Windows.Forms.Button();
            this.FileBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.DimGray;
            this.TextBox.ForeColor = System.Drawing.Color.White;
            this.TextBox.Location = new System.Drawing.Point(12, 39);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(258, 75);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "Enter what you would like to log here.";
            this.TextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseClick);
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text To Log";
            // 
            // LogButton
            // 
            this.LogButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.LogButton.ForeColor = System.Drawing.Color.White;
            this.LogButton.Location = new System.Drawing.Point(12, 220);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(258, 23);
            this.LogButton.TabIndex = 2;
            this.LogButton.Text = "Log It!";
            this.LogButton.UseVisualStyleBackColor = false;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // FileBox
            // 
            this.FileBox.BackColor = System.Drawing.Color.DimGray;
            this.FileBox.ForeColor = System.Drawing.Color.White;
            this.FileBox.Location = new System.Drawing.Point(12, 192);
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(258, 22);
            this.FileBox.TabIndex = 3;
            this.FileBox.Text = "Enter file name here.";
            this.FileBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FileBox_MouseClick);
            this.FileBox.TextChanged += new System.EventHandler(this.FileBox_TextChanged);
            this.FileBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileBox_KeyDown);
            this.FileBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FileBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "File To Log";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(109, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "OR";
            // 
            // LoggerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FileBox);
            this.Controls.Add(this.LogButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox);
            this.Name = "LoggerInterface";
            this.Text = "Logger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.TextBox FileBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

