using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class FrmMainForm : Form
    {
        public FrmMainForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmAdminPage fr = new FrmAdminPage();
            fr.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FrmNewCustomer fr = new FrmNewCustomer();
            fr.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FrmRooms fr = new FrmRooms();
            fr.Show();
        }

        private void BtnGuests_Click(object sender, EventArgs e)
        {
            Reservations fr = new Reservations();
            fr.Show();
        }
    }
}
