using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management
{
    public partial class EmployeeManageForm : Form
    {
        public EmployeeManageForm()
        {
            InitializeComponent();
        }

        MyDB mydb = new MyDB();
        STAFF staff = new STAFF();
        ACCOUNT acc = new ACCOUNT();
        private void EmployeeManageForm_Load(object sender, EventArgs e)
        {
            fillListview();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbSearch.Text.Trim() != "")
            {
                DataTable table = staff.getEmployee(txbSearch.Text);
                dataEmployeeList.DataSource = table;
            }
            //else
            //{
            //    fillListview();
            //}
        }

        


        private void fillListview()
        {
            this.dataEmployeeList.DataSource = null;
            dataEmployeeList.Refresh();
            DataTable table = staff.getAllEmployees();

            dataEmployeeList.ForeColor = Color.Black;
            
            dataEmployeeList.DataSource = table;
            
            dataEmployeeList.Columns[0].HeaderText = "ID";
            dataEmployeeList.Columns[1].HeaderText = "Name";
            dataEmployeeList.Columns[2].HeaderText = "DOB";
            dataEmployeeList.Columns[2].DefaultCellStyle.Format = "MM/dd/yy";
            dataEmployeeList.Columns[3].HeaderText = "Address";
            dataEmployeeList.Columns[4].HeaderText = "Phone";
            dataEmployeeList.Columns[5].HeaderText = "Sex";
            dataEmployeeList.Columns[6].HeaderText = "Type";
            dataEmployeeList.Columns[7].HeaderText = "Username";
            dataEmployeeList.Columns[8].HeaderText = "Pic";
            dataEmployeeList.Columns[8].Visible = false;
            dataEmployeeList.Columns[9].HeaderText = "UsernameID";
            dataEmployeeList.Columns[9].Visible = false;



        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            //check if staff id is a number or text
            if (!txbID.Text.All(char.IsDigit))
            {
                MessageBox.Show("This is not a valid ID", "Add staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (staff.existed(txbID.Text))
            {
                MessageBox.Show("A staff with this ID already exists", "Add staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (acc.usernameExist(txbUsername.Text))
            {
                MessageBox.Show("This username has been taken", "Add staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (picBox.Image == null)
            {
                MessageBox.Show("Please choose a picture", "Edit staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MemoryStream pic = new MemoryStream();
            picBox.Image.Save(pic, picBox.Image.RawFormat);



            if (staff.insertEmployee(txbID.Text, txbName.Text, dtpDOB.Value, txbAddress.Text, txbPhone.Text, comboBoxSex.SelectedItem.ToString(), comboBoxType.SelectedItem.ToString(),txbUsername.Text, pic))
            {
                MessageBox.Show("Add new staff successfully!", "Add staff");
                ACCOUNT acc = new ACCOUNT();
                acc.insertAccount(txbUsername.Text, "123456", perm());
                staff.setUsernameID(txbUsername.Text);
                fillListview();

            }
            else
            {
                MessageBox.Show("Add staff failed!", "Add staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int perm()
        {
            int perm = 0;
            if (comboBoxType.SelectedItem.ToString() == "Manager")
            {
                perm = 1;
            }
            else if (comboBoxType.SelectedItem.ToString() == "Receptionist")
            {
                perm = 2;
            }
            else if (comboBoxType.SelectedItem.ToString() == "Janitor")
            {
                perm = 0;
            }
            return perm;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!staff.existed(txbID.Text))
            {
                MessageBox.Show("Can't find any staff with this ID", "Edit staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (picBox.Image == null)
            {
                MessageBox.Show("Please choose a picture", "Edit staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            MemoryStream pic = new MemoryStream();
            picBox.Image.Save(pic, picBox.Image.RawFormat);

            MessageBox.Show("New DOB: " + dtpDOB.Value);

            //s.updateEmployee(EmployeeID, txbName.Text, dateTimePicker1.Value, txbAddress.Text, txbPhone.Text, comboBoxSex.SelectedItem.ToString(), txbType.Text, txbUsername.Text, pic);
            if (staff.updateEmployee(txbID.Text, txbName.Text, dtpDOB.Value, txbAddress.Text, txbPhone.Text, comboBoxSex.SelectedItem.ToString(), comboBoxType.SelectedItem.ToString(), txbUsername.Text, pic))
            {
                MessageBox.Show("Edit staff successfully!", "Edit staff");
                fillListview();
            }
            else
            {
                MessageBox.Show("Edit staff failed!", "Edit staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!staff.existed(txbID.Text))
            {
                MessageBox.Show("Can't find any staff with this ID", "Delete staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (staff.deleteEmployee(txbID.Text))
            {
                MessageBox.Show("Delete staff successfully!", "Delete staff");
                fillListview();
            }
            else
            {
                MessageBox.Show("Delete staff failed!", "Delete staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            fillListview();
        }

        private void txbImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txbImg.Text = open.FileName;
                picBox.Image = new Bitmap(open.FileName);
            }
        }

        private void txbImg_Enter(object sender, EventArgs e)
        {
            txbImg_Click(sender, e);
        }

        private void dataEmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbImg.Text = "";
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dataEmployeeList.Rows[index];
                txbID.Text = row.Cells[0].Value.ToString();
                txbID.Enabled = false;
                txbName.Text = row.Cells[1].Value.ToString();
                dtpDOB.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                txbAddress.Text = row.Cells[3].Value.ToString();
                txbPhone.Text = row.Cells[4].Value.ToString();
                comboBoxSex.SelectedItem = row.Cells[5].Value;
                comboBoxType.SelectedItem = row.Cells[6].Value;
                txbUsername.Text = row.Cells[7].Value.ToString();
                txbUsername.Enabled = false;

                byte[] arr = (byte[])row.Cells[8].Value;
                MemoryStream ms = new MemoryStream(arr);

                picBox.Image = Image.FromStream(ms);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all fields
            txbID.Text = "";
            txbID.Enabled = true;
            txbName.Text = "";
            dtpDOB.Value = DateTime.Now;
            txbAddress.Text = "";
            txbPhone.Text = "";
            comboBoxSex.SelectedIndex = -1;
            comboBoxType.SelectedIndex = -1;
            txbUsername.Text = "";
            txbUsername.Enabled = true;
            picBox.Image = null;
            txbImg.Text = "";
        }
    }
}
