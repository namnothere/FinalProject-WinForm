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
        
        private void EmployeeManageForm_Load(object sender, EventArgs e)
        {
            fillListview();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable table = staff.getEmployee(txbSearch.Text);
            lvwStaffList.Items.Clear();
            string[] arr = new string[4];
            ListViewItem item = new ListViewItem();


            
            foreach (DataRow row in table.Rows)
            {
                arr[0] = row["Id"].ToString();
                arr[1] = row["name"].ToString();
                //arr[2] = row["dob"].ToString();
                //arr[3] = row["address"].ToString();
                //arr[4] = row["phone"].ToString();
                arr[2] = row["type"].ToString();
                arr[3] = row["username"].ToString();
                item = new ListViewItem(arr);
                lvwStaffList.Items.Add(item);
                
            }
        }

        


        private void fillListview()
        {
            lvwStaffList.Columns.Clear();
            lvwStaffList.Items.Clear();
            DataTable table = staff.getAllEmployees();
            string[] arr = new string[4];
            ListViewItem item;
            lvwStaffList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            lvwStaffList.Columns.Add("ID", 70, HorizontalAlignment.Center);
            lvwStaffList.Columns.Add("Name", 100, HorizontalAlignment.Center);
            //lvwStaffList.Columns.Add("D.O.B", 100, HorizontalAlignment.Center);
            //lvwStaffList.Columns.Add("Address", 100, HorizontalAlignment.Center);
            //lvwStaffList.Columns.Add("Phone", 100, HorizontalAlignment.Center);
            lvwStaffList.Columns.Add("Position", 100, HorizontalAlignment.Center);
            lvwStaffList.Columns.Add("Username", 100, HorizontalAlignment.Center);


            foreach (DataRow row in table.Rows)
            {
                arr[0] = row["Id"].ToString();
                arr[1] = row["name"].ToString();
                //arr[2] = row["dob"].ToString();
                //arr[3] = row["address"].ToString();
                //arr[4] = row["phone"].ToString();
                arr[2] = row["type"].ToString();
                arr[3] = row["username"].ToString();
                
                item = new ListViewItem(arr);
                lvwStaffList.Items.Add(item);
            }
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

            if (picBox.Image == null)
            {
                MessageBox.Show("Please choose a picture", "Edit staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MemoryStream pic = new MemoryStream();
            picBox.Image.Save(pic, picBox.Image.RawFormat);

            if (staff.insertEmployee(txbID.Text, txbName.Text, dtpDOB.Value, txbAddress.Text, txbPhone.Text, "N/A", txbUsername.Text, pic))
            {
                MessageBox.Show("Add new staff successfully!", "Add staff");
                ACCOUNT acc = new ACCOUNT();
                acc.insertAccount(txbUsername.Text, "123456");
                    
            }
            else
            {
                MessageBox.Show("Add staff failed!", "Add staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            if (staff.updateEmployee(txbID.Text, txbName.Text, dtpDOB.Value, txbAddress.Text, txbPhone.Text, "N/A", txbUsername.Text, pic))
            {
                MessageBox.Show("Edit staff successfully!", "Edit staff");
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
            }
            else
            {
                MessageBox.Show("Delete staff failed!", "Delete staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {

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

        //private void lvwStaffList_ColumnClick(object sender, ColumnClickEventArgs e)
        //{
        //    //fill data in column to textbox
        //    if (lvwStaffList.SelectedItems.Count > 0)
        //    {
        //        txbID.Text = lvwStaffList.SelectedItems[0].SubItems[0].Text;
        //        txbName.Text = lvwStaffList.SelectedItems[0].SubItems[1].Text;
        //        //dtpDOB.Text = lvwStaffList.SelectedItems[0].SubItems[2].Text;
        //        //txbAddress.Text = lvwStaffList.SelectedItems[0].SubItems[3].Text;
        //        //txbPhone.Text = lvwStaffList.SelectedItems[0].SubItems[4].Text;
        //        comboBoxType.SelectedItem = lvwStaffList.SelectedItems[0].SubItems[2].Text;
        //        txbUsername.Text = lvwStaffList.SelectedItems[0].SubItems[3].Text;
        //    }
        //}

        private void lvwStaffList_ColumnClick(object sender, EventArgs e)
        {
            if (lvwStaffList.SelectedItems.Count > 0)
            {
                txbID.Text = lvwStaffList.SelectedItems[0].SubItems[0].Text;
                txbName.Text = lvwStaffList.SelectedItems[0].SubItems[1].Text;
                //dtpDOB.Text = lvwStaffList.SelectedItems[0].SubItems[2].Text;
                //txbAddress.Text = lvwStaffList.SelectedItems[0].SubItems[3].Text;
                //txbPhone.Text = lvwStaffList.SelectedItems[0].SubItems[4].Text;
                comboBoxType.SelectedItem = lvwStaffList.SelectedItems[0].SubItems[2].Text;
                txbUsername.Text = lvwStaffList.SelectedItems[0].SubItems[3].Text;
            }
        }
    }
}
