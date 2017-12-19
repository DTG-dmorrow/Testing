namespace DTG.ACKProgram
{
    partial class AckResponseList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AckResponseTable = new System.Windows.Forms.DataGridView();
            this.Ack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Response = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AckResponseTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AckResponseTable
            // 
            this.AckResponseTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AckResponseTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AckResponseTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AckResponseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AckResponseTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ack,
            this.Response});
            this.AckResponseTable.Location = new System.Drawing.Point(12, 12);
            this.AckResponseTable.Name = "AckResponseTable";
            this.AckResponseTable.RowTemplate.Height = 24;
            this.AckResponseTable.Size = new System.Drawing.Size(550, 245);
            this.AckResponseTable.TabIndex = 0;
            // 
            // Ack
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gold;
            this.Ack.DefaultCellStyle = dataGridViewCellStyle1;
            this.Ack.HeaderText = "Ack";
            this.Ack.Name = "Ack";
            // 
            // Response
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gold;
            this.Response.DefaultCellStyle = dataGridViewCellStyle2;
            this.Response.HeaderText = "Response";
            this.Response.Name = "Response";
            // 
            // AckResponseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(574, 269);
            this.Controls.Add(this.AckResponseTable);
            this.Name = "AckResponseList";
            this.Text = "Ack/Response List";
            ((System.ComponentModel.ISupportInitialize)(this.AckResponseTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AckResponseTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Response;
    }
}