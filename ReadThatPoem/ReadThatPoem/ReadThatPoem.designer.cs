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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.SwitchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InputBox.ForeColor = System.Drawing.Color.Lime;
            this.InputBox.Location = new System.Drawing.Point(88, 36);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(573, 136);
            this.InputBox.TabIndex = 0;
            this.InputBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(343, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OutputBox.ForeColor = System.Drawing.Color.Lime;
            this.OutputBox.Location = new System.Drawing.Point(88, 273);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(573, 136);
            this.OutputBox.TabIndex = 3;
            // 
            // SwitchButton
            // 
            this.SwitchButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SwitchButton.ForeColor = System.Drawing.Color.Lime;
            this.SwitchButton.Location = new System.Drawing.Point(586, 204);
            this.SwitchButton.Name = "SwitchButton";
            this.SwitchButton.Size = new System.Drawing.Size(75, 23);
            this.SwitchButton.TabIndex = 4;
            this.SwitchButton.Text = "Switch";
            this.SwitchButton.UseVisualStyleBackColor = false;
            this.SwitchButton.Click += new System.EventHandler(this.SwitchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(85, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(85, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output:";
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InputLabel.ForeColor = System.Drawing.Color.Lime;
            this.InputLabel.Location = new System.Drawing.Point(134, 16);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(48, 17);
            this.InputLabel.TabIndex = 7;
            this.InputLabel.Text = "Binary";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OutputLabel.ForeColor = System.Drawing.Color.Lime;
            this.OutputLabel.Location = new System.Drawing.Point(146, 253);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(41, 17);
            this.OutputLabel.TabIndex = 8;
            this.OutputLabel.Text = "ASCII";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearButton.ForeColor = System.Drawing.Color.Lime;
            this.ClearButton.Location = new System.Drawing.Point(88, 204);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.DragonBackground;
            this.ClientSize = new System.Drawing.Size(757, 455);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SwitchButton);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputBox);
            this.Name = "Form1";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button SwitchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button ClearButton;
    }
}

