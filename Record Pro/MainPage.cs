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
            user = new UserBase(Username.Text, Password.Text);
            bool a=api.SignIn(user);
            User form1 = new User(api.Token);
            this.Hide();
            form1.Show();
            //MessageBox.Show(api.Token);
        }

         private void SignUp_Click(object sender, EventArgs e)
        {

            user = new UserBase(Username.Text, Password.Text);
            string result=api.SignUpUserAsync(user);
            if(result=="Created")
            {
                MessageBox.Show("Created");
            }
            else if(result=="Conflict")
            {
                MessageBox.Show("Conflict");
            }
        }
    }
}
