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

namespace WindowsFormsApp3.GUI
{
    public partial class FormKhachHang : Form
    {
        private SqlConnection cnn;
        private Connecter connecter = new Connecter();
        private List<Classes.KhachHang> listKH = new List<Classes.KhachHang>();
        public FormKhachHang()
        {
            InitializeComponent();
            hien_thi();

        }
        public void hien_thi()
        {
            cnn = connecter.connecting();
            string query = "SELECT * FROM [khach_hang]";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            this.dataGridView1.DataSource = dt;
            cnn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Classes.KhachHang kh = new Classes.KhachHang();
            kh.setTen(txtTenKhachHang.Text);
            kh.setCccd(txtCccd.Text);
            kh.setEmail(txtEmail.Text);
            kh.setSdt(txtSoDienThoai.Text);
            cnn = connecter.connecting();
            cnn.Open();
            string query = "INSERT INTO khach_hang(ten, cccd, email, sdt) values(@ten,@cccd,@email,@sdt)";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@ten", kh.getTen());
            cmd.Parameters.AddWithValue("@cccd", kh.getCccd());
            cmd.Parameters.AddWithValue("@email", kh.getEmail());
            cmd.Parameters.AddWithValue("@sdt", kh.getSdt());
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien_thi();
            txtTenKhachHang.Text = "";
            txtSoDienThoai.Text = "";
            txtEmail.Text = "";
            txtCccd.Text = "";
            MessageBox.Show("Tạo khách hàng mới thành công");
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        
        }
    }
}
