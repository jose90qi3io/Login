using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Login_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
            
        private void ID_Enter(object sender, EventArgs e)
        {
            if (ID.Text == "ID") 
            {
                ID.Text = "";
                ID.ForeColor = Color.DarkGray;
            }
        }

        private void ID_Leave(object sender, EventArgs e)
        {
            if (ID.Text == "") 
            {
                ID.Text = "ID";
                ID.ForeColor = Color.DarkGray;
            
            }
        }

        private void PASSWORD_Enter(object sender, EventArgs e)
        {
            if (PASSWORD.Text == "PASSWORD") 
            {
                PASSWORD.Text = "";
                PASSWORD.ForeColor = Color.DarkGray;
                PASSWORD.UseSystemPasswordChar = true;
            }
        }

        private void PASSWORD_Leave(object sender, EventArgs e)
        {
            if (PASSWORD.Text == "") 
            {
                PASSWORD.Text = "PASSWORD";
                PASSWORD.ForeColor = Color.DarkGray;
                PASSWORD.UseSystemPasswordChar = false;
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Z_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0 );
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
