using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Classes
{
    class KhachHang
    {
        private string ten;
        public string getTen()
        {
            return this.ten;
        }
        public void setTen(string newvalue)
        {
            this.ten = newvalue;
        }
        private string email;
        public string getEmail()
        {
            return this.email;
        }
        public void setEmail(string newvalue)
        {
            this.email = newvalue;
        }
        private string sdt;
        public string getSdt()
        {
            return this.sdt;
        }
        public void setSdt(string newvalue)
        {
            this.sdt = newvalue;
        }
        private string cccd;
        public string getCccd()
        {
            return this.cccd;
        }
        public void setCccd(string newvalue)
        {
            this.cccd = newvalue;
        }
    }
}
