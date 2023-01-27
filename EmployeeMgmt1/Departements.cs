using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMgmt1
{
    public partial class Departements : Form
    {
        Functions con;
        public Departements()
        {
            InitializeComponent();
            con = new Functions();
            ShowDepartments();

        }

        private void ShowDepartments()
        {
            String Query = "Select * from DepartmentTb1";
            DepList.DataSource = con.GetData(Query);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data|||");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "insert into Department1 values ('{0}')";
                    Query = string.Format(DepNameTb.Text);
                    con.SetData(Query);

                }
            }
    }
}
