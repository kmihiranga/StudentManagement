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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentRegistration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpStudentDetails = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.dateDOB = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbFeMale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkPHD = new System.Windows.Forms.CheckBox();
            this.chkPG = new System.Windows.Forms.CheckBox();
            this.chkUG = new System.Windows.Forms.CheckBox();
            this.chkDIP = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.grpStudentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).BeginInit();
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
            this.grpStudentDetails.Controls.Add(this.label11);
            this.grpStudentDetails.Controls.Add(this.btnNew);
            this.grpStudentDetails.Controls.Add(this.label10);
            this.grpStudentDetails.Controls.Add(this.btnUpdate);
            this.grpStudentDetails.Controls.Add(this.lblID);
            this.grpStudentDetails.Controls.Add(this.label9);
            this.grpStudentDetails.Controls.Add(this.btnDelete);
            this.grpStudentDetails.Controls.Add(this.dateDOB);
            this.grpStudentDetails.Controls.Add(this.label8);
            this.grpStudentDetails.Controls.Add(this.btnSave);
            this.grpStudentDetails.Controls.Add(this.txtAddress);
            this.grpStudentDetails.Controls.Add(this.label7);
            this.grpStudentDetails.Controls.Add(this.rbFeMale);
            this.grpStudentDetails.Controls.Add(this.rbMale);
            this.grpStudentDetails.Controls.Add(this.label6);
            this.grpStudentDetails.Controls.Add(this.label5);
            this.grpStudentDetails.Controls.Add(this.cmbCity);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(1184, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 23);
            this.label11.TabIndex = 28;
            this.label11.Text = "New";
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(1154, 178);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(99, 97);
            this.btnNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNew.TabIndex = 27;
            this.btnNew.TabStop = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1037, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 23);
            this.label10.TabIndex = 26;
            this.label10.Text = "Update";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(1013, 178);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 97);
            this.btnUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(687, 224);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 20);
            this.lblID.TabIndex = 24;
            this.lblID.Text = "lblID";
            this.lblID.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1184, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Delete";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1154, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 97);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 22;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dateDOB
            // 
            this.dateDOB.CustomFormat = "yyyy-MM-dd";
            this.dateDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDOB.Location = new System.Drawing.Point(113, 202);
            this.dateDOB.Name = "dateDOB";
            this.dateDOB.Size = new System.Drawing.Size(299, 27);
            this.dateDOB.TabIndex = 21;
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
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(1013, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 97);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSave.TabIndex = 19;
            this.btnSave.TabStop = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "Panadura",
            "Colombo",
            "Kaluthara",
            "Piliyandala"});
            this.cmbCity.Location = new System.Drawing.Point(113, 95);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(299, 28);
            this.cmbCity.TabIndex = 11;
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
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 412);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 29;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(1340, 364);
            this.dataGridViewStudents.TabIndex = 2;
            this.dataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellClick);
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // errorCity
            // 
            this.errorCity.ContainerControl = this;
            // 
            // errorDate
            // 
            this.errorDate.ContainerControl = this;
            // 
            // errorAddress
            // 
            this.errorAddress.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).EndInit();
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
        private ComboBox cmbCity;
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
        private PictureBox btnSave;
        private DateTimePicker dateDOB;
        private Label label9;
        private PictureBox btnDelete;
        private Label lblID;
        private Label label10;
        private PictureBox btnUpdate;
        private Label label11;
        private PictureBox btnNew;
        private ErrorProvider errorName;
        private ErrorProvider errorCity;
        private ErrorProvider errorDate;
        private ErrorProvider errorAddress;
    }
}