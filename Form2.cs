using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void show_winform(Form value) {
            this.panel1.Controls.Clear();
            value.TopLevel = false;
            value.AutoScroll = true;
            value.Dock = DockStyle.Fill;
            value.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(value);
            value.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
         {
            Form khachHang = new GUI.FormKhachHang();
            show_winform(khachHang);
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
