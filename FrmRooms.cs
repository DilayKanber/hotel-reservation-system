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
    public partial class FrmRooms : Form
    {
        public FrmRooms()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HQ272PM;Initial Catalog=hotel_database;Integrated Security=True");

        private void verilergoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Rooms", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["RoomID"].ToString();
                ekle.SubItems.Add(oku["Status"].ToString());
                ekle.SubItems.Add(oku["NumofSingleBed"].ToString());
                ekle.SubItems.Add(oku["NumofDoubleBed"].ToString());
                ekle.SubItems.Add(oku["DailyPayment"].ToString());
                ekle.SubItems.Add(oku["Floor"].ToString());
                ekle.SubItems.Add(oku["Extras"].ToString());

                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRooms_Load(object sender, EventArgs e)
        {

        }

        private void BtnRefresh_Click_1(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Rooms set RoomID='" + TxtRoomID.Text + "',Status='" + comboBox1.Text + "',NumofSingleBed ='" + TxtNumofSingleBed.Text + "',NumofDoubleBed='" + TxtNumofDoubleBed.Text + "',DailyPayment ='" + TxtDailyPayment.Text + "',Floor ='" + TxtFloor.Text + "',Extras='" + TxtExtras.Text + "' where RoomID = " + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }

        long id = 0;

        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtRoomID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtNumofSingleBed.Text = listView1.SelectedItems[0].SubItems[2].Text;
            TxtNumofDoubleBed.Text = listView1.SelectedItems[0].SubItems[3].Text;
            TxtDailyPayment.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtFloor.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtExtras.Text = listView1.SelectedItems[0].SubItems[6].Text;
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtRoomID.Clear();
            TxtNumofSingleBed.Clear();
            TxtNumofDoubleBed.Clear();
            TxtFloor.Clear();
            TxtExtras.Clear();
            TxtDailyPayment.Clear();
            comboBox1.ResetText();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from Rooms where RoomID = (" + id + ")",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Rooms (RoomID,Status,NumofSingleBed,NumofDoubleBed,DailyPayment,Floor,Extras) values ('" + TxtRoomID.Text + "','" + comboBox1.Text + "','" + TxtNumofSingleBed.Text + "','" + TxtNumofDoubleBed.Text + "','" + TxtDailyPayment.Text + "','" + TxtFloor.Text + "','" + TxtExtras.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Rooms  where Extras like '%" + textBox1.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["RoomID"].ToString();
                ekle.SubItems.Add(oku["Status"].ToString());
                ekle.SubItems.Add(oku["NumofSingleBed"].ToString());
                ekle.SubItems.Add(oku["NumofDoubleBed"].ToString());
                ekle.SubItems.Add(oku["DailyPayment"].ToString());
                ekle.SubItems.Add(oku["Floor"].ToString());
                ekle.SubItems.Add(oku["Extras"].ToString());

                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }
    }
}
