using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //codigo para movilizar el formulario
using Dominio;
using System.Security.Cryptography;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        int cont = 0;
        //para mover formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Txuser_Enter(object sender, EventArgs e)
        {
            if (txuser.Text == "USUARIO") {
                txuser.Text = "";
                txuser.ForeColor = Color.LightGray;
            }
        }

        private void Txuser_Leave(object sender, EventArgs e)
        {
            if (txuser.Text == "") {
                txuser.Text = "USUARIO";
                txuser.ForeColor = Color.DimGray;
            }
        }

        private void Txpass_Enter(object sender, EventArgs e)
        {
            if (txpass.Text == "CONTRASEÑA"){
                txpass.Text = "";
                txpass.ForeColor = Color.LightGray;
                txpass.UseSystemPasswordChar = true;
            }
        }

        private void Txpass_Leave(object sender, EventArgs e)
        {
            if (txpass.Text == "") {
                txpass.Text = "CONTRASEÑA";
                txpass.ForeColor = Color.DimGray;
                txpass.UseSystemPasswordChar = false;
            }
        }

        private void Btcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)//para mover el formulario
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Encriptacion MD5
        public class Encrypt
        {
            public static string GetMD5(string str)
            {
                MD5 md5 = MD5CryptoServiceProvider.Create();
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] stream = null;
                StringBuilder sb = new StringBuilder();
                stream = md5.ComputeHash(encoding.GetBytes(str));
                for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
                return sb.ToString();
            }
        }

        private void Btacceder_Click(object sender, EventArgs e)
        {
            string enc;
            if (txuser.Text != "USUARIO")
            {
                if (txpass.Text != "CONTRASEÑA")
                {
                    Modelo_usuario user = new Modelo_usuario();
                    enc = Encrypt.GetMD5(txpass.Text);//encryp antes de comprobar contraseña
                    var loginval = user.LoginUser(txuser.Text,enc);
                    if (loginval == true)
                    {
                        this.Hide();
                        FormularioBienvenida welcome = new FormularioBienvenida();
                        welcome.ShowDialog();
                        Home_Principal mainmenu = new Home_Principal();
                        mainmenu.Show();
                        mainmenu.FormClosed += Logout;
                        
                    }
                    else
                    {
                        msgError("Usuario o Contraseña incorrecto/a. \n            Por favor intente de nuevo.");
                        txpass.Text = "CONTRASEÑA";
                        txpass.UseSystemPasswordChar = false;
                        txpass.ForeColor = Color.DimGray;
                        txuser.Focus();
                    }
                }
                else
                {
                    msgError("Ingrese Contraseña");
                }
            }
            else
                msgError("Por Favor Ingrese un nombre de Usuario");
        }
        private void msgError(string msg)
        {
            lberror.Text = "      " + msg;
            //lberror.Visible = true;
            error.Start();
        }
        private void Logout(object sender,FormClosedEventArgs e)
        {
            //txpass.Clear();
            txpass.Text = "CONTRASEÑA";
            txpass.UseSystemPasswordChar = false;
            //txuser.Clear();
            txuser.Text = "USUARIO";
            txpass.ForeColor = Color.DimGray;
            txuser.ForeColor = Color.DimGray;
            lberror.Visible = false;
            this.Show();
        }

        private void Error_Tick(object sender, EventArgs e)
        {
            if (cont != 70)
            {
                lberror.Visible = true;
                cont += 1;
            }
            else
            {
                lberror.Visible = false;
                cont = 0;
                error.Stop();
            }
        }
    }
}
