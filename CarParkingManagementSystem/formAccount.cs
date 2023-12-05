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
    public partial class formAccount : Form
    {
        public formAccount()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            formAccountDetail form = new formAccountDetail();
            form.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formAccountDetail form = new formAccountDetail();
            form.ShowDialog();
        }
    }
}
