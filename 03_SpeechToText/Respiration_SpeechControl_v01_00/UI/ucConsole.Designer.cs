namespace Respiration_SpeechControl_v01_00
{
    partial class console1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbConsole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbConsole
            // 
            this.txbConsole.BackColor = System.Drawing.Color.Black;
            this.txbConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbConsole.Dock = System.Windows.Forms.DockStyle.Top;
            this.txbConsole.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConsole.ForeColor = System.Drawing.Color.White;
            this.txbConsole.Location = new System.Drawing.Point(0, 0);
            this.txbConsole.Margin = new System.Windows.Forms.Padding(10);
            this.txbConsole.Multiline = true;
            this.txbConsole.Name = "txbConsole";
            this.txbConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbConsole.Size = new System.Drawing.Size(509, 303);
            this.txbConsole.TabIndex = 0;
            this.txbConsole.Text = "Microsoft Windows [Version 10.0.18362.592]";
            // 
            // console1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbConsole);
            this.Name = "console1";
            this.Size = new System.Drawing.Size(509, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbConsole;
    }
}
