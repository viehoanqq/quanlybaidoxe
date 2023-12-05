using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingManagementSystem
{
    public partial class formStaff : Form
    {
        public formStaff()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            formStaffDetail form = new formStaffDetail();
            form.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formStaffDetail form = new formStaffDetail();
            form.ShowDialog();
        }
    }
}
