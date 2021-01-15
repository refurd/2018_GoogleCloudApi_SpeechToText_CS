namespace Respiration_SpeechControl_v01_00
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txbContents = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.dgvCommands = new System.Windows.Forms.DataGridView();
            this.btnTeszt = new System.Windows.Forms.Button();
            this.dgvCommandsDynamic = new System.Windows.Forms.DataGridView();
            this.btnFindVerb = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandsDynamic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 568);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(429, 568);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txbContents
            // 
            this.txbContents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txbContents.Location = new System.Drawing.Point(12, 395);
            this.txbContents.Multiline = true;
            this.txbContents.Name = "txbContents";
            this.txbContents.Size = new System.Drawing.Size(1110, 167);
            this.txbContents.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(348, 568);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txbMessage
            // 
            this.txbMessage.Location = new System.Drawing.Point(106, 570);
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(236, 20);
            this.txbMessage.TabIndex = 4;
            // 
            // dgvCommands
            // 
            this.dgvCommands.AllowUserToAddRows = false;
            this.dgvCommands.AllowUserToDeleteRows = false;
            this.dgvCommands.AllowUserToResizeColumns = false;
            this.dgvCommands.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCommands.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCommands.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCommands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCommands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCommands.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCommands.Location = new System.Drawing.Point(12, 12);
            this.dgvCommands.Name = "dgvCommands";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCommands.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCommands.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCommands.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCommands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCommands.Size = new System.Drawing.Size(1110, 175);
            this.dgvCommands.TabIndex = 5;
            // 
            // btnTeszt
            // 
            this.btnTeszt.Location = new System.Drawing.Point(986, 568);
            this.btnTeszt.Name = "btnTeszt";
            this.btnTeszt.Size = new System.Drawing.Size(108, 23);
            this.btnTeszt.TabIndex = 6;
            this.btnTeszt.Text = "Teszt";
            this.btnTeszt.UseVisualStyleBackColor = true;
            this.btnTeszt.Click += new System.EventHandler(this.btnLoadCommands_Click);
            // 
            // dgvCommandsDynamic
            // 
            this.dgvCommandsDynamic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvCommandsDynamic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommandsDynamic.Location = new System.Drawing.Point(12, 193);
            this.dgvCommandsDynamic.Name = "dgvCommandsDynamic";
            this.dgvCommandsDynamic.Size = new System.Drawing.Size(1110, 196);
            this.dgvCommandsDynamic.TabIndex = 7;
            // 
            // btnFindVerb
            // 
            this.btnFindVerb.Location = new System.Drawing.Point(543, 568);
            this.btnFindVerb.Name = "btnFindVerb";
            this.btnFindVerb.Size = new System.Drawing.Size(75, 23);
            this.btnFindVerb.TabIndex = 8;
            this.btnFindVerb.Text = "Find Verb";
            this.btnFindVerb.UseVisualStyleBackColor = true;
            this.btnFindVerb.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(841, 564);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 23);
            this.btnFill.TabIndex = 9;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.Location = new System.Drawing.Point(624, 568);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(75, 23);
            this.btnSubject.TabIndex = 10;
            this.btnSubject.Text = "Find Subject";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1131, 603);
            this.Controls.Add(this.btnSubject);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnFindVerb);
            this.Controls.Add(this.dgvCommandsDynamic);
            this.Controls.Add(this.btnTeszt);
            this.Controls.Add(this.dgvCommands);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txbContents);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Opacity = 0.8D;
            this.Text = "Respiration Smart Systems";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandsDynamic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txbContents;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.DataGridView dgvCommands;
        private System.Windows.Forms.Button btnTeszt;
        private System.Windows.Forms.DataGridView dgvCommandsDynamic;
        private System.Windows.Forms.Button btnFindVerb;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnSubject;
    }
}

