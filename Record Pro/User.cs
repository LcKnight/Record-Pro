using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Record_Pro
{
    public partial class User : Form
    {
        private Api api;
        private List<UserBills> userbills;
        public User(string token)
        {
            InitializeComponent();
            api = new Api();
            api.Token = token;
        }

        private void GetList_Click(object sender, EventArgs e)
        {
            userbills = api.GetUserBillsAsync(api.Token, 5);
        }
    }
}
