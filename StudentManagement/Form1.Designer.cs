namespace StudentManagement
{
    partial class frmStudentRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentRegistration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpStudentDetails = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbFeMale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkPHD = new System.Windows.Forms.CheckBox();
            this.chkPG = new System.Windows.Forms.CheckBox();
            this.chkUG = new System.Windows.Forms.CheckBox();
            this.chkDIP = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpStudentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 68);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(564, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration";
            // 
            // grpStudentDetails
            // 
            this.grpStudentDetails.Controls.Add(this.label8);
            this.grpStudentDetails.Controls.Add(this.pictureBox1);
            this.grpStudentDetails.Controls.Add(this.txtAddress);
            this.grpStudentDetails.Controls.Add(this.label7);
            this.grpStudentDetails.Controls.Add(this.rbFeMale);
            this.grpStudentDetails.Controls.Add(this.rbMale);
            this.grpStudentDetails.Controls.Add(this.label6);
            this.grpStudentDetails.Controls.Add(this.label5);
            this.grpStudentDetails.Controls.Add(this.txtDOB);
            this.grpStudentDetails.Controls.Add(this.txtCity);
            this.grpStudentDetails.Controls.Add(this.txtName);
            this.grpStudentDetails.Controls.Add(this.chkPHD);
            this.grpStudentDetails.Controls.Add(this.chkPG);
            this.grpStudentDetails.Controls.Add(this.chkUG);
            this.grpStudentDetails.Controls.Add(this.chkDIP);
            this.grpStudentDetails.Controls.Add(this.label4);
            this.grpStudentDetails.Controls.Add(this.label3);
            this.grpStudentDetails.Controls.Add(this.label2);
            this.grpStudentDetails.Location = new System.Drawing.Point(12, 86);
            this.grpStudentDetails.Name = "grpStudentDetails";
            this.grpStudentDetails.Size = new System.Drawing.Size(1340, 320);
            this.grpStudentDetails.TabIndex = 1;
            this.grpStudentDetails.TabStop = false;
            this.grpStudentDetails.Text = "Add Student Details";
            this.grpStudentDetails.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(599, 43);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(346, 129);
            this.txtAddress.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Address";
            // 
            // rbFeMale
            // 
            this.rbFeMale.AutoSize = true;
            this.rbFeMale.Location = new System.Drawing.Point(254, 265);
            this.rbFeMale.Name = "rbFeMale";
            this.rbFeMale.Size = new System.Drawing.Size(78, 24);
            this.rbFeMale.TabIndex = 16;
            this.rbFeMale.TabStop = true;
            this.rbFeMale.Text = "Female";
            this.rbFeMale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(113, 265);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(63, 24);
            this.rbMale.TabIndex = 15;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "D.O.B";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(114, 200);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(298, 27);
            this.txtDOB.TabIndex = 12;
            // 
            // txtCity
            // 
            this.txtCity.FormattingEnabled = true;
            this.txtCity.Location = new System.Drawing.Point(113, 95);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(299, 28);
            this.txtCity.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(299, 27);
            this.txtName.TabIndex = 10;
            // 
            // chkPHD
            // 
            this.chkPHD.AutoSize = true;
            this.chkPHD.Location = new System.Drawing.Point(363, 152);
            this.chkPHD.Name = "chkPHD";
            this.chkPHD.Size = new System.Drawing.Size(61, 24);
            this.chkPHD.TabIndex = 9;
            this.chkPHD.Text = "PHD";
            this.chkPHD.UseVisualStyleBackColor = true;
            // 
            // chkPG
            // 
            this.chkPG.AutoSize = true;
            this.chkPG.Location = new System.Drawing.Point(287, 152);
            this.chkPG.Name = "chkPG";
            this.chkPG.Size = new System.Drawing.Size(49, 24);
            this.chkPG.TabIndex = 8;
            this.chkPG.Text = "PG";
            this.chkPG.UseVisualStyleBackColor = true;
            // 
            // chkUG
            // 
            this.chkUG.AutoSize = true;
            this.chkUG.Location = new System.Drawing.Point(207, 152);
            this.chkUG.Name = "chkUG";
            this.chkUG.Size = new System.Drawing.Size(51, 24);
            this.chkUG.TabIndex = 7;
            this.chkUG.Text = "UG";
            this.chkUG.UseVisualStyleBackColor = true;
            // 
            // chkDIP
            // 
            this.chkDIP.AutoSize = true;
            this.chkDIP.Location = new System.Drawing.Point(114, 152);
            this.chkDIP.Name = "chkDIP";
            this.chkDIP.Size = new System.Drawing.Size(54, 24);
            this.chkDIP.TabIndex = 6;
            this.chkDIP.Text = "DIP";
            this.chkDIP.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Courses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CIty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 412);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 29;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(1340, 364);
            this.dataGridViewStudents.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1002, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1037, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Save";
            // 
            // frmStudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 788);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.grpStudentDetails);
            this.Controls.Add(this.panel1);
            this.Name = "frmStudentRegistration";
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.frmStudentRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpStudentDetails.ResumeLayout(false);
            this.grpStudentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox grpStudentDetails;
        private DataGridView dataGridViewStudents;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox txtDOB;
        private ComboBox txtCity;
        private TextBox txtName;
        private CheckBox chkPHD;
        private CheckBox chkPG;
        private CheckBox chkUG;
        private CheckBox chkDIP;
        private TextBox txtAddress;
        private Label label7;
        private RadioButton rbFeMale;
        private RadioButton rbMale;
        private Label label6;
        private Label label8;
        private PictureBox pictureBox1;
    }
}