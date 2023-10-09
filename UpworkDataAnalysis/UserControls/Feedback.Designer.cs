namespace UpworkDataAnalysis.UserControls
{
    partial class Feedback
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
            this.feedback_element = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // feedback_element
            // 
            this.feedback_element.AutoSize = true;
            this.feedback_element.BackColor = System.Drawing.SystemColors.Control;
            this.feedback_element.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedback_element.Location = new System.Drawing.Point(311, 268);
            this.feedback_element.Name = "feedback_element";
            this.feedback_element.Size = new System.Drawing.Size(405, 29);
            this.feedback_element.TabIndex = 0;
            this.feedback_element.Text = "Feedback Content (Developing...)";
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.feedback_element);
            this.Name = "Feedback";
            this.Size = new System.Drawing.Size(1000, 569);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label feedback_element;
    }
}
