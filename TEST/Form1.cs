using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TEST
{
    public partial class Form1 : Form
    {
        // tạo 2 biến cục bộ
        string strCon = @"Data Source=DESKTOP-VGDP77D\SQLEXPRESS;Initial Catalog=SHOES1;Integrated Security=True"; // @ để nó hiểu là 1 chuỗi
        // Đối tượng kết nối
        SqlConnection SqlCon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void KetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (SqlCon == null)
                {
                    // Nếu chưa kết nối tiến hành thực hiện kết nối
                    SqlCon = new SqlConnection(strCon);
                }

                // Sau khi kết nối tiến hành mở
                if (SqlCon.State == System.Data.ConnectionState.Closed)  // Trạng thái hiện tại của SqlConnection mà đóng thì mở
                {
                    SqlCon.Open();
                    MessageBox.Show("Kết nối thành công!");
                }
                else MessageBox.Show("Đã tạo kết nối rồi!");

                if (SqlCon.State == System.Data.ConnectionState.Open)
                {
                    // lấy đối tượng thực hiện truy vấn
                    SqlCommand SqlCmd = new SqlCommand();
                    SqlCmd.CommandType = System.Data.CommandType.Text;
                    SqlCmd.CommandText = "SELECT COUNT(*) FROM KHACH_HANG";

                    // Gửi truy vấn vào CSDL
                    SqlCmd.Connection = SqlCon;

                    // Gán giá trị vào 1 biến
                    int sl = (int)SqlCmd.ExecuteScalar();

                    label1.Text = "Số lượng khách hàng hiện có: " + sl.ToString();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DongKN_Click(object sender, EventArgs e)
        {
            // Kiểm tra thực hiện đóng kết nối
            if (SqlCon != null && SqlCon.State == System.Data.ConnectionState.Open)
            {
                SqlCon.Close(); // đóng kết nối lại và xuất thông báo
                label1.Text = "";
                HoTentxt.Text = "";
                SDTtxt.Text = "";
                DiaChitxt.Text = "";
                MessageBox.Show("Ngắt kết nối thành công!");
            }
            else
            {
                MessageBox.Show("Không có kết nối nào để ngắt !!!"); // chưa tạo kết nối không thể đóng được
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Seach_Click(object sender, EventArgs e)
        {
            try
            {
                if (SqlCon == null)
                {
                    // Nếu chưa kết nối tiến hành thực hiện kết nối
                    SqlCon = new SqlConnection(strCon);
                }

                // Sau khi kết nối tiến hành mở
                if (SqlCon.State == System.Data.ConnectionState.Closed)  // Trạng thái hiện tại của SqlConnection mà đóng thì mở
                {
                    SqlCon.Open();
                    MessageBox.Show("Quên kết nối kìa để kết nối giúp luôn cho!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // lấy họ tên từ texbox1
            string Ma = MaKH.Text;

            // đối tượng truy vấn
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.CommandType = System.Data.CommandType.Text;
            SqlCmd.CommandText = "SELECT * FROM KHACH_HANG WHERE MaKhachHang = '" + Ma + "'";
            // thêm phần định nghĩa pameter


            // gửi truy vấn vào kết nối CSDL
            SqlCmd.Connection = SqlCon;

            // Thực thi
            SqlDataReader reader = SqlCmd.ExecuteReader(); // tạo đầu đọc
            if (reader.Read())
            {
                string TenKH = reader.GetString(1);
                string SDT = reader.GetString(2);
                string DC = reader.GetString(3);
                // Hiển thị ra lại màn hình
                HoTentxt.Text = TenKH;
                SDTtxt.Text = SDT;
                DiaChitxt.Text = DC;
            }
            reader.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Tim2_Click(object sender, EventArgs e)
        {
            try
            {
                if (SqlCon == null)
                {
                    // Nếu chưa kết nối tiến hành thực hiện kết nối
                    SqlCon = new SqlConnection(strCon);
                }

                // Sau khi kết nối tiến hành mở
                if (SqlCon.State == System.Data.ConnectionState.Closed)  // Trạng thái hiện tại của SqlConnection mà đóng thì mở
                {
                    SqlCon.Open();
                    MessageBox.Show("Quên kết nối kìa để kết nối giúp luôn cho!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // đối tượng truy vấn
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.CommandType = System.Data.CommandType.Text;
            SqlCmd.CommandText = "SELECT * FROM KHACH_HANG";

            // gửi truy vấn vào kết nối CSDL
            SqlCmd.Connection = SqlCon;

            // Thực thi
            SqlDataReader reader = SqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string KH = reader.GetString(0);
                string HT = reader.GetString(1);
                string SDT = reader.GetString(2);
                string DC = reader.GetString(3);

                // Hiển thị lên giao diện
                ListViewItem lvi = new ListViewItem(KH);
                lvi.SubItems.Add(HT);
                lvi.SubItems.Add(SDT);
                lvi.SubItems.Add(DC);

                listView1.Items.Add(lvi); // list view chính có tên là listView1
            }
            reader.Close();
        }
    }
}
