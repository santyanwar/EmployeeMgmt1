﻿using System;
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


    }
}
