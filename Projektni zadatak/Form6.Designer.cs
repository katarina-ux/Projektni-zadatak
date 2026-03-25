namespace Projektni_zadatak
{
    partial class Form6
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
			this.Statistika = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// Statistika
			// 
			this.Statistika.FormattingEnabled = true;
			this.Statistika.ItemHeight = 16;
			this.Statistika.Location = new System.Drawing.Point(49, 33);
			this.Statistika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Statistika.Name = "Statistika";
			this.Statistika.Size = new System.Drawing.Size(384, 500);
			this.Statistika.TabIndex = 0;
			// 
			// Form6
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1040, 608);
			this.Controls.Add(this.Statistika);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form6";
			this.Text = "Form6";
			this.Load += new System.EventHandler(this.Form6_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Statistika;
    }
}