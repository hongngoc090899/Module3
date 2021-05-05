using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODULE_3
{
    public partial class Form3 : Form
    {
        CSDLDataContext db = new CSDLDataContext();
       // List<DataGridViewRow> ds = new List<DataGridViewRow>();
        public Form3()
        {
            InitializeComponent();
        }

        void loadData()
        {
            this.CenterToScreen();
            List<DataGridViewRow> ds = new List<DataGridViewRow>();
            ds = Form1.dongMoi;
            DataGridViewRow d1 = new DataGridViewRow();
            DataGridViewRow d2 = new DataGridViewRow();

            d1 = ds[0];
            string t1 = d1.Cells[5].Value.ToString();
            int t = int.Parse(t1.Replace("$", "").Replace(",", ""));
            if (Form1.checkOneWay == false)
            {
                d2 = ds[1];
                string t2 = d2.Cells[5].Value.ToString();
                t += int.Parse(t2.Replace("$", "").Replace(",", ""));
            }
            lable_total_amount.Text = (t * Form1.soKH).ToString("C0");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loadData();
           
        }

        //lay ngau nhien 1 ki tu 
        public Random r = new Random();
        public string layKiTu()
        {
            string chuoi = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM0123456789";
            string kiTu = "";
            for (int i = 0; i < 6; i++)
                kiTu += chuoi[r.Next(0, chuoi.Length - 1)];
            return kiTu;

        }
        List<Ticket> dsVe = new List<Ticket>();
        void themVe(string chuoi, List<DataGridViewRow> dsKhach, DateTime dt, string soHieu)
        {

            for (int i = 0; i < dsKhach.Count; i++)
            {
                Ticket ve = new Ticket();
                ve.UserID = 1;
                //lay so hieu chuyen bay
                ve.ScheduleID = db.Schedules.Where(p => p.Date >= dt && p.FlightNumber == soHieu).Select(p => p.ID).FirstOrDefault();
                ve.CabinTypeID = db.CabinTypes.Where(p => p.Name == Form1.cabinn).Select(p => p.ID).FirstOrDefault();
                ve.BookingReference = chuoi;
                ve.Firstname = dsKhach[i].Cells[0].Value.ToString();
                ve.Lastname = dsKhach[i].Cells[1].Value.ToString();
                ve.Email = null;
                ve.PassportNumber = dsKhach[i].Cells[3].Value.ToString();
                string a = dsKhach[i].Cells[4].Value.ToString();
                ve.PassportCountryID = db.Countries.Where(p => p.Name == a).Select(p => p.ID).FirstOrDefault();
                ve.Phone = dsKhach[i].Cells[5].Value.ToString();
                ve.Confirmed = true;
                dsVe.Add(ve);
            }
        }


        private void btn_Issue_tickets_Click(object sender, EventArgs e)
        {

            string chuoi = "";
            //kiem tra da ton tai chuoi ki tu hay chua
            while (true)
            {
                chuoi = layKiTu();
                var data = db.Tickets.Where(p => p.BookingReference == chuoi).ToList();
                if (data.Count == 0)
                    break;
            }
            List<DataGridViewRow> dsKhach = new List<DataGridViewRow>();
            dsKhach = Form2.dsHanhKhach;
            List<DataGridViewRow> dsMayBay = new List<DataGridViewRow>();
            dsMayBay = Form1.dongMoi;
            var d1 = dsMayBay[0];

            string date = d1.Cells[2].Value.ToString();
            DateTime dt = DateTime.ParseExact(date, "MM/dd/yyyy", null);
            //12-32-32 -> [12, 32, 32]
            string[] s = d1.Cells[4].Value.ToString().Split('-');
            foreach (var soHieu in s)
                themVe(chuoi, dsKhach, dt, soHieu);
            if (Form1.checkOneWay == false)
            {
                var d2 = dsMayBay[1];
                string[] s1 = d2.Cells[4].Value.ToString().Split('-');
                foreach (var soHieu in s1)
                    themVe(chuoi, dsKhach, dt, soHieu);
            }
            db.Tickets.InsertAllOnSubmit(dsVe);
            db.SubmitChanges();
            MessageBox.Show("Đặt vé thành công", "Thông báo");
        }
    }
}
