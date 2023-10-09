namespace UpworkDataAnalysis.UserControls
{
    partial class FacebookAnalysis
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
            this.Facebook = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Facebook
            // 
            this.Facebook.AutoSize = true;
            this.Facebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facebook.Location = new System.Drawing.Point(347, 265);
            this.Facebook.Name = "Facebook";
            this.Facebook.Size = new System.Drawing.Size(405, 29);
            this.Facebook.TabIndex = 0;
            this.Facebook.Text = "Facebook Content (Developing...)";
            // 
            // FacebookAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.Facebook);
            this.Name = "FacebookAnalysis";
            this.Size = new System.Drawing.Size(1002, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Facebook;
    }
}
