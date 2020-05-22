using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace Record_Pro
{
    
    public partial class MainPage : Form
    {
        private Api api;
        private UserBase user;
        private UserInfo usr;
        public MainPage()
        {
            InitializeComponent();
            api = new Api();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            
        }

        async private void SignUp_Click(object sender, EventArgs e)
        {

            user = new UserBase(Username.Text, Password.Text);
            string json = JsonConvert.SerializeObject(user);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            if(await api.SignUpUserAsync(content))
            {
                MessageBox.Show("Successful");
            }
            else
            {
                MessageBox.Show("dead");
            }
        }
    }
}
