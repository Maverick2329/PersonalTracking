using BusinessLogicLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PersonalTracking
{
    public partial class FrmPosition : Form
    {
        public FrmPosition()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<DEPARTMENT> departmentList = new List<DEPARTMENT>();

        private void FrmPosition_Load(object sender, EventArgs e)
        {
            departmentList = DepartmentBLL.GetDepartments();
            cmbDepartment.DataSource = departmentList;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPosition.Text.Trim() == "")
                MessageBox.Show("Please fill the position name");
            else if (cmbDepartment.SelectedIndex == -1)
                MessageBox.Show("Please select a department");
            else
            {
                POSITION position = new POSITION();
                position.PositionName = txtPosition.Text;
                position.DepartmentId = Convert.ToInt32(cmbDepartment.SelectedValue);
                BusinessLogicLayer.PositionBLL.AddPosition(position);
                MessageBox.Show("Position was added");
                txtPosition.Clear();
                cmbDepartment.SelectedIndex = -1;
            }
        }
    }
}
