namespace UpworkDataAnalysis
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Upwork = new System.Windows.Forms.Button();
            this.Facebook = new System.Windows.Forms.Button();
            this.Feedback = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UpworkDataAnalysis.Properties.Resources.purple_brg;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 616);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Upwork, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Facebook, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Feedback, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 155);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(246, 190);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Upwork
            // 
            this.Upwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Upwork.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Upwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upwork.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Upwork.Location = new System.Drawing.Point(3, 3);
            this.Upwork.Name = "Upwork";
            this.Upwork.Size = new System.Drawing.Size(240, 50);
            this.Upwork.TabIndex = 0;
            this.Upwork.Text = "Upwork";
            this.Upwork.UseVisualStyleBackColor = true;
            this.Upwork.Click += new System.EventHandler(this.Upwork_Click);
            // 
            // Facebook
            // 
            this.Facebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Facebook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Facebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facebook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Facebook.Location = new System.Drawing.Point(3, 59);
            this.Facebook.Name = "Facebook";
            this.Facebook.Size = new System.Drawing.Size(240, 50);
            this.Facebook.TabIndex = 1;
            this.Facebook.Text = "Facebook";
            this.Facebook.UseVisualStyleBackColor = true;
            this.Facebook.Click += new System.EventHandler(this.Facebook_Click);
            // 
            // Feedback
            // 
            this.Feedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Feedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feedback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Feedback.Location = new System.Drawing.Point(3, 115);
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size(240, 50);
            this.Feedback.TabIndex = 2;
            this.Feedback.Text = "Feedback";
            this.Feedback.UseVisualStyleBackColor = true;
            this.Feedback.Click += new System.EventHandler(this.Feedback_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(246, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 616);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Upwork;
        private System.Windows.Forms.Button Facebook;
        private System.Windows.Forms.Button Feedback;
    }
}

