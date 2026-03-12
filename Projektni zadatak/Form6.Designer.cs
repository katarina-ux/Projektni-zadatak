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
            this.statistika = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // statistika
            // 
            this.statistika.FormattingEnabled = true;
            this.statistika.Location = new System.Drawing.Point(37, 27);
            this.statistika.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statistika.Name = "statistika";
            this.statistika.Size = new System.Drawing.Size(289, 407);
            this.statistika.TabIndex = 0;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 494);
            this.Controls.Add(this.statistika);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox statistika;
    }
}