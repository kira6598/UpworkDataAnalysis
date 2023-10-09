namespace UpworkDataAnalysis.UserControls
{
    partial class UpworkAnalysis
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
            this.UpWork = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Experiment = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.JobType = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UpWork
            // 
            this.UpWork.AutoSize = true;
            this.UpWork.BackColor = System.Drawing.Color.FloralWhite;
            this.UpWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpWork.Location = new System.Drawing.Point(186, 43);
            this.UpWork.Name = "UpWork";
            this.UpWork.Size = new System.Drawing.Size(467, 25);
            this.UpWork.TabIndex = 0;
            this.UpWork.Text = "Vui lòng cho chúng tôi biết bạn cần phân tích gì";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(49, 111);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(85, 25);
            this.Category.TabIndex = 1;
            this.Category.Text = "Lĩnh vực";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kế toán và quản trị",
            "Dịch vụ ",
            "Data Science & Analysis",
            "Design & Creative",
            "Engineering & Achitecture",
            "IT & Network",
            "Luật",
            "Sale & Marketing",
            "Dịch thuật",
            "Phát triển web, app ",
            "Writing"});
            this.comboBox1.Location = new System.Drawing.Point(141, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // Experiment
            // 
            this.Experiment.AutoSize = true;
            this.Experiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Experiment.Location = new System.Drawing.Point(341, 112);
            this.Experiment.Name = "Experiment";
            this.Experiment.Size = new System.Drawing.Size(121, 25);
            this.Experiment.TabIndex = 3;
            this.Experiment.Text = "Kinh nghiệm";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Nhập môn",
            "Middle",
            "Chuyên gia"});
            this.comboBox2.Location = new System.Drawing.Point(469, 114);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(166, 24);
            this.comboBox2.TabIndex = 4;
            // 
            // JobType
            // 
            this.JobType.AutoSize = true;
            this.JobType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobType.Location = new System.Drawing.Point(659, 116);
            this.JobType.Name = "JobType";
            this.JobType.Size = new System.Drawing.Size(137, 25);
            this.JobType.TabIndex = 5;
            this.JobType.Text = "Loại công việc";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Theo giờ",
            "Theo project"});
            this.comboBox3.Location = new System.Drawing.Point(802, 115);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(139, 24);
            this.comboBox3.TabIndex = 6;
            // 
            // UpworkAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.JobType);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Experiment);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.UpWork);
            this.Name = "UpworkAnalysis";
            this.Size = new System.Drawing.Size(988, 593);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpWork;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Experiment;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label JobType;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}
