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
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HQ272PM;Initial Catalog=hotel_database;Integrated Security=True");

        private void verilergoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Guests inner join Reservations on Guests.TcNumber = Reservations.TcNumber", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["TcNumber"].ToString();
                ekle.SubItems.Add(oku["Name"].ToString());
                ekle.SubItems.Add(oku["LastName"].ToString());
                ekle.SubItems.Add(oku["Address"].ToString());
                ekle.SubItems.Add(oku["DateofBirth"].ToString());
                ekle.SubItems.Add(oku["Gender"].ToString());
                ekle.SubItems.Add(oku["Email"].ToString());
                ekle.SubItems.Add(oku["PhoneNumber"].ToString());
                ekle.SubItems.Add(oku["Checkin"].ToString());
                ekle.SubItems.Add(oku["Checkout"].ToString());
                ekle.SubItems.Add(oku["NumofDays"].ToString());
                ekle.SubItems.Add(oku["RoomID"].ToString());
                ekle.SubItems.Add(oku["Payment"].ToString());

                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void FrmGuests_Load(object sender, EventArgs e)
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

        long id = 0;
        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = long.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtTcnumber.Text = listView1.SelectedItems[0].SubItems[0].Text;
            TxtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSurname.Text = listView1.SelectedItems[0].SubItems[2].Text;
            TxtAddress.Text = listView1.SelectedItems[0].SubItems[3].Text;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtEmail.Text = listView1.SelectedItems[0].SubItems[6].Text;
            MskTxtPhoneNumber.Text = listView1.SelectedItems[0].SubItems[7].Text;
            DtpCheckin.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpCheckout.Text = listView1.SelectedItems[0].SubItems[9].Text;
            TxtDays.Text = listView1.SelectedItems[0].SubItems[10].Text;
            TxtRoomNumber.Text = listView1.SelectedItems[0].SubItems[11].Text;
            TxtPayment.Text = listView1.SelectedItems[0].SubItems[12].Text;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Delete from Guest where TcNumber=(" + id + ")",baglanti);
            komut1.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("Delete from Reservations where TcNumber=(" + id + ")", baglanti);
            komut2.ExecuteNonQuery();
            SqlCommand komut3 = new SqlCommand("update Rooms  set Status='" + "Empty" + "' where RoomID = " + TxtRoomNumber.Text + "", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtTcnumber.Clear();
            TxtName.Clear();
            TxtSurname.Clear();
            TxtAddress.Clear();
            TxtDays.Clear();
            MskTxtPhoneNumber.Clear();
            TxtEmail.Clear();
            TxtPayment.Clear();
            TxtRoomNumber.Clear();
            dateTimePicker1.ResetText();
            DtpCheckin.ResetText();
            DtpCheckout.ResetText();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("update Guests set TcNumber='" + TxtTcnumber.Text + "',Name='" + TxtName.Text + "',LastName ='" + TxtSurname.Text + "',Address='" + TxtAddress.Text + "',DateofBirth ='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',Gender='" + comboBox1.Text + "',Email ='" + TxtEmail.Text + "',PhoneNumber='" + MskTxtPhoneNumber.Text + "' where TcNumber = " + id + "", baglanti);
            komut1.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("update Reservations set TcNumber='" + TxtTcnumber.Text + "',Checkin='" + DtpCheckin.Value.ToString("yyyy-MM-dd") + "',Checkout ='" + DtpCheckout.Value.ToString("yyyy-MM-dd") + "',NumofDays='" + TxtDays.Text + "',RoomID = '" + TxtRoomNumber.Text + "',Payment='" + TxtPayment.Text + "' where TcNumber = " + id + "", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Guests inner join Reservations on Guests.TcNumber = Reservations.TcNumber where Name like '%"+textBox1.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["TcNumber"].ToString();
                ekle.SubItems.Add(oku["Name"].ToString());
                ekle.SubItems.Add(oku["LastName"].ToString());
                ekle.SubItems.Add(oku["Address"].ToString());
                ekle.SubItems.Add(oku["DateofBirth"].ToString());
                ekle.SubItems.Add(oku["Gender"].ToString());
                ekle.SubItems.Add(oku["Email"].ToString());
                ekle.SubItems.Add(oku["PhoneNumber"].ToString());
                ekle.SubItems.Add(oku["Checkin"].ToString());
                ekle.SubItems.Add(oku["Checkout"].ToString());
                ekle.SubItems.Add(oku["NumofDays"].ToString());
                ekle.SubItems.Add(oku["RoomID"].ToString());
                ekle.SubItems.Add(oku["Payment"].ToString());

                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }
    }
}
// Data Source=DESKTOP-HQ272PM;Initial Catalog=hotel_database;Integrated Security=True
