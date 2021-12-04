using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagement
{
    public partial class frmStudentRegistration : Form
    {
        // sql connection class
        SqlConnection conn = connectionDB.conString();
        SqlCommand cmd = new SqlCommand();

        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        // get student list
        void loadStudenList() 
        {
            try {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT id as 'ID', name as 'NAME', course as 'COURSE', city as 'CITY', dob as 'DOB', gender as 'GENDER', address as 'ADDRESS' from dbo.dbStudentDetail";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewStudents.DataSource = dt;
                conn.Close();
                dataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewStudents.AllowUserToResizeColumns = false;

            } catch (SqlException ex) {
                MessageBox.Show(ex.Message);
            }
            dataGridViewStudents.Sort(dataGridViewStudents.Columns[0], ListSortDirection.Descending); // filter id by descending
            dataGridViewStudents.AllowUserToAddRows = false; // remove emply rows
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // constructor
        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
            loadStudenList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            validateAndSave();
        }

        // validate and save
        void validateAndSave() 
        {
            if (txtName.Text == "") {
                errorName.SetError(txtName, "Name Cannot be Empty!");
                errorAddress.Clear();
                errorCity.Clear();
                errorDate.Clear();
            } else if (cmbCity.Text == "") {
                errorCity.SetError(txtName, "City Cannot be Empty!");
                errorAddress.Clear();
                errorName.Clear();
                errorDate.Clear();
            } else if (dateDOB.Text == "") {
                errorDate.SetError(txtName, "Date Cannot be Empty!");
                errorAddress.Clear();
                errorName.Clear();
                errorCity.Clear();
            } else if (txtAddress.Text == "") {
                errorAddress.SetError(txtName, "Address Cannot be Empty!");
                errorName.Clear();
                errorName.Clear();
                errorDate.Clear();
            }
            else {
                createStudent();
            }
        }

        // save details
        void createStudent() 
        {
            try
            {
                // get gender values 
                String gender = "";
                if (rbMale.Checked == true){
                    gender = "Male";
                } else{
                    gender = "Female";
                }

                // get selected course
                String course = "";
                if (chkDIP.Checked == true){
                    course = "DIP";
                } else if (chkPG.Checked == true) {
                    course = "PG";
                } else if (chkPHD.Checked == true) {
                    course = "PHD";
                } else if (chkUG.Checked == true) {
                    course = "UG";
                }

                // open connection
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO dbo.dbStudentDetail(name, city, dob, gender, address, course) values('" + txtName.Text + "', '" + cmbCity.Text + "', '" + dateDOB.Text + "', '" + gender + "', '" + txtAddress.Text + "', '" + course + "')";
                int i = cmd.ExecuteNonQuery();
                if (i > 0) {
                    MessageBox.Show("Student Details Added Successfully!", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                conn.Close();
                loadStudenList();
            } catch (SqlException ex) {
                MessageBox.Show(ex.Message, "Error Saving Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // clear fields
        void clearFields() 
        {
            txtName.Text = "";
            cmbCity.Text = "";
            chkDIP.Checked = false;
            chkPG.Checked = false;
            chkPHD.Checked = false;
            chkUG.Checked = false;
            lblID.Text = "";
            txtAddress.Text = "";
            dateDOB.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearFields();
            if (e.RowIndex >= 0) {
                DataGridViewRow row = this.dataGridViewStudents.Rows[e.RowIndex];

                lblID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                cmbCity.Text = row.Cells[3].Value.ToString();
                // check course
                if (row.Cells[2].Value.ToString() == "DIP") {
                    chkDIP.Checked = true;
                } else if (row.Cells[2].Value.ToString() == "UG") {
                    chkUG.Checked = true;
                } else if (row.Cells[2].Value.ToString() == "PG") {
                    chkPG.Checked = true;
                } else{
                    chkPHD.Checked = true;
                }
                dateDOB.Text = row.Cells[4].Value.ToString();
                // select gender
                if (row.Cells[5].Value.ToString() == "Male") {
                    rbMale.Checked = true;
                } else if (row.Cells[5].Value.ToString() == "Female") {
                    rbFeMale.Checked = true;
                }else
                {
                    rbMale.Checked = false;
                    rbFeMale.Checked = false;
                }
                txtAddress.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteStudent();
        }

        // delete 
        void deleteStudent() 
        {
            try
            {
                DialogResult exit;
                exit = MessageBox.Show("Are you sure you want to delete this record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (exit == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE FROM dbo.dbStudentDetail WHERE id='" + int.Parse(lblID.Text) + "'";
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Successfully Deleted Data", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        conn.Close();
                        loadStudenList();
                        clearFields();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateStudentDetails();
        }

        // update details
        void updateStudentDetails() 
        {
            try
            {
                // get gender values 
                String gender = "";
                if (rbMale.Checked == true)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }

                // get selected course
                String course = "";
                if (chkDIP.Checked == true)
                {
                    course = "DIP";
                }
                else if (chkPG.Checked == true)
                {
                    course = "PG";
                }
                else if (chkPHD.Checked == true)
                {
                    course = "PHD";
                }
                else if (chkUG.Checked == true)
                {
                    course = "UG";
                }

                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE dbo.dbStudentDetail SET name='" + txtName.Text + "', city='" + cmbCity.Text + "', course='" + course + "', dob='" + dateDOB.Text + "', gender='"+gender+"', address='"+txtAddress.Text+"' WHERE id='"+lblID.Text+"'";
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Update Details Successfully", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                conn.Close();
                loadStudenList();
                clearFields();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearFields();
            txtName.Focus();
        }
    }
}