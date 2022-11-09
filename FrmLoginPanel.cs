using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace $safeprojectname$
{
    public partial class FrmAdminPage : Form
    {
        public FrmAdminPage()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HQ272PM;Initial Catalog=hotel_database;Integrated Security=True");  

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                string sql = "select * from AdminPage where Username = @Username and Password = @Password";
                SqlParameter prm1 = new SqlParameter("Username", TxtUsername.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Password", TxtPassword.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    FrmMainForm fr = new FrmMainForm();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Username or Password !");
            }
            baglanti.Close();
        }
    }
}
