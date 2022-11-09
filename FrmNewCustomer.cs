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
    public partial class FrmNewCustomer : Form
    {
        public FrmNewCustomer()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HQ272PM;Initial Catalog=hotel_database;Integrated Security=True");

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {

        }

        private void BtnRoom101_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "101";
        }

        private void BtnRoom102_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "102";
        }

        private void BtnRoom103_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "103";
        }

        private void BtnRoom104_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "104";
        }

        private void BtnRoom105_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "105";
        }

        private void BtnRoom106_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "106";
        }

        private void BtnRoom107_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "107";
        }

        private void BtnRoom201_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "201";
        }

        private void BtnRoom202_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "202";
        }

        private void BtnRoom203_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "203";
        }

        private void BtnRoom204_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "204";
        }

        private void BtnRoom205_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "205";
        }

        private void BtnRoom206_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "206";
        }

        private void BtnRoom207_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "207";
        }

        private void BtnRoom301_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "301";
        }

        private void BtnRoom302_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "302";
        }

        private void BtnRoom303_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "303";
        }

        private void BtnRoom304_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "304";
        }

        private void BtnRoom305_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "305";
        }

        private void BtnRoom306_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "306";
        }

        private void BtnRoom307_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "307";
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void DtpCheckout_ValueChanged(object sender, EventArgs e)
        {
            int payment;
            DateTime indate = Convert.ToDateTime(DtpCheckin.Text);
            DateTime outdate = Convert.ToDateTime(DtpCheckout.Text);
            TimeSpan day = outdate - indate;
            TxtDays.Text = day.TotalDays.ToString();
            payment = Convert.ToInt32(TxtDays.Text) * 50;
            TxtPayment.Text = payment.ToString();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into Guests (TcNumber,Name,Lastname,Address,DateofBirth,Gender,Email,PhoneNumber) values ('" + TxtTcnumber.Text + "','" + TxtName.Text + "','" + TxtSurname.Text + "','" + TxtAddress.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + comboBox1.Text + "','" + TxtEmail.Text + "','" + MskTxtPhoneNumber.Text + "')", baglanti);
            komut1.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("insert into Reservations(TcNumber,Checkin,Checkout,NumofDays,RoomID,Payment) values ('" + TxtTcnumber.Text + "','" + DtpCheckin.Value.ToString("yyyy-MM-dd") + "','" + DtpCheckout.Value.ToString("yyyy-MM-dd") + "','" + TxtDays.Text + "','" + TxtRoomNumber.Text + "','" + TxtPayment.Text + "')", baglanti);
            komut2.ExecuteNonQuery();
            SqlCommand komut3 = new SqlCommand("update Rooms set Status='"+"Full"+"' where RoomID = " + TxtRoomNumber.Text + "", baglanti);
            komut3.ExecuteNonQuery();
            MessageBox.Show("Reservation Complate ! ");
            baglanti.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateofbirth = Convert.ToDateTime(dateTimePicker1.Text);
            TimeSpan age = DateTime.Today - dateofbirth;
            string age_1 = age.TotalDays.ToString();
            int age_2 = Convert.ToInt32(age_1);
            textBox1.Text = (Convert.ToInt32(age_2 / 365.2425)).ToString();
        }

        private void DtpCheckin_ValueChanged(object sender, EventArgs e)
        {
            int payment;
            DateTime indate = Convert.ToDateTime(DtpCheckin.Text);
            DateTime outdate = Convert.ToDateTime(DtpCheckout.Text);
            TimeSpan day = outdate - indate;
            TxtDays.Text = day.TotalDays.ToString();
            payment = Convert.ToInt32(TxtDays.Text) * 50;
            TxtPayment.Text = payment.ToString();
        }
    }
}
// Data Source=DESKTOP-HQ272PM;Initial Catalog=hotel_database;Integrated Security=True