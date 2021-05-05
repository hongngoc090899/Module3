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
    public partial class Form2 : Form
    {
        CSDLDataContext db = new CSDLDataContext();

        public static Schedule schedule = null;
        public static List<DataGridViewRow> dsHanhKhach = new List<DataGridViewRow>();
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_firstName.Text == "" || txt_lastName.Text == "" || txt_passportNumber.Text == ""
            || dt_birthDate.Text == "" || txt_phone.Text == "" || cb_passportCountry.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin", "Cảnh báo!");
                return;
            }
            DataGridViewRow dongmoi = (DataGridViewRow)dgv_passengersList.Rows[0].Clone();
            dongmoi.Cells[0].Value = txt_firstName.Text;
            dongmoi.Cells[1].Value = txt_lastName.Text;
            dongmoi.Cells[2].Value = dt_birthDate.Text;
            dongmoi.Cells[3].Value = txt_passportNumber.Text;
            dongmoi.Cells[4].Value = cb_passportCountry.Text;
            dongmoi.Cells[5].Value = txt_phone.Text;
            if (dgv_passengersList.Rows.Count - 1 == Form1.soKH)
            {
                MessageBox.Show("Bạn đã đặt đủ số lượng vé", "Thông báo");
                return;
            }
            for (int i = 0; i < dgv_passengersList.Rows.Count - 1; i++)
            {
                if (dongmoi.Cells[3].Value.ToString() == dgv_passengersList.Rows[i].Cells[3].Value.ToString())
                {
                    MessageBox.Show("đã tồn tại passport này !", "ERROR");
                    return;
                }
            }
            dgv_passengersList.Rows.Add(dongmoi);
            return;
        }

      
        private void cb_passportCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void taoCombobox()
        {
            var contries = from x in db.Countries select x;
            cb_passportCountry.ValueMember = "name";
            cb_passportCountry.DataSource = contries;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            taoCombobox();
            this.CenterToParent();
            List<DataGridViewRow> listRow = new List<DataGridViewRow>();
            listRow = (List<DataGridViewRow>)this.Tag;
            DataGridViewRow d1 = new DataGridViewRow();
            DataGridViewRow d2 = new DataGridViewRow();

            d1 = listRow[0];
            d2 = listRow[1];
            lb_from_outbound.Text = d1.Cells[0].Value.ToString();
            lb_to_outbound.Text = d1.Cells[1].Value.ToString();
            lb_cabintype_outbound.Text = Form1.cabinn;
            lb_date_outbound.Text = d1.Cells[2].Value.ToString();
            lb_flightnumber_outbound.Text = d1.Cells[4].Value.ToString();
            gr_return.Visible = false;
            if (Form1.checkOneWay == false)
            {
                lb_from_return.Text = d2.Cells[0].Value.ToString();
                lb_to_return.Text = d2.Cells[1].Value.ToString();
                lb_cabintype_return.Text = Form1.cabinn;
                lb_date_return.Text = d2.Cells[2].Value.ToString();
                lb_flightnumber_return.Text = d2.Cells[4].Value.ToString();
                gr_return.Visible = true;
            }
        }
        public static List<List<string>> list_passenger_dgv = new List<List<string>>();
        private void button4_Click(object sender, EventArgs e)
        {
            if (dgv_passengersList.Rows.Count - 1 != Form1.soKH)
            {
                MessageBox.Show("chưa đủ số lượng vé, mời đặt thêm");
                return;
            }
            dsHanhKhach.Clear();
            for (int i = 0; i < dgv_passengersList.Rows.Count - 1; i++)
                dsHanhKhach.Add((DataGridViewRow)dgv_passengersList.Rows[i]);
            Form3 myform = new Form3();
            myform.ShowDialog();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int xoa = dgv_passengersList.CurrentRow.Index;
            dgv_passengersList.Rows.RemoveAt(xoa);
            clear_text();
        }
        private void clear_text()
        {
            txt_firstName.Clear();
            txt_lastName.Clear();
            txt_passportNumber.Clear();
            txt_phone.Clear();
        }
        private void dgv_passengersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
