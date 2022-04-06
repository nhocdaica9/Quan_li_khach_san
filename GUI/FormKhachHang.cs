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
        public FormKhachHang()
        {
            InitializeComponent();
            
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
            hien_thi();
        }
    }
}
