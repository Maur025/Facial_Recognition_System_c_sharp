using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Dominio;

namespace Presentacion
{
    public partial class Agregar_usu : Form
    {
        public Agregar_usu()
        {
            InitializeComponent();
        }
        int cont = 0;

        private void Agregar_usu_Load(object sender, EventArgs e)
        {

        }

        private void Btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btguardar_Click(object sender, EventArgs e)
        {
            string cod2,cod1,codigo,enc;
            codigo = "";
            enc = "";            
            if (txnombre.Text != "" && txnuci.Text != "" && txapmat.Text != "" && txappat.Text != "" && txusername.Text != "" && txpassw.Text != "" && txreppassw.Text != "")
            {
                cod1 = txnuci.Text.Substring(0, 4);
                cod2 = txnombre.Text.Substring(0, 3);
                codigo = cod1 + cod2;
                if (txpassw.Text == txreppassw.Text)
                {
                    Modelo_agregar_usu agreganewuser = new Modelo_agregar_usu();
                    enc = Encrypt.GetMD5(txpassw.Text);
                    try
                    {
                        agreganewuser.insertarUsuario(codigo, txnombre.Text, txappat.Text, txapmat.Text, txnuci.Text, txusername.Text, enc, copriv.Text, txcarg.Text);
                        MessageBox.Show("Registro Exitoso");
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Se presento el siguiente error:" + x);
                    }
                    
                }
                else
                {
                    msgError("Las contraseñas no son iguales");
                }
            }
            else
            {
                msgError("Por Favor rellene el formulario");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (txreppassw.UseSystemPasswordChar == true)
            {
                txreppassw.UseSystemPasswordChar = false;
            }
            else
            {
                txreppassw.UseSystemPasswordChar = true;
            }
        }

        private void Btvis1_Click(object sender, EventArgs e)
        {
            if (txpassw.UseSystemPasswordChar == true)
            {
                txpassw.UseSystemPasswordChar = false;
            }
            else
            {
                txpassw.UseSystemPasswordChar = true;
            }
        }
        private void msgError(string msg)
        {
            lberror.Text = "      " + msg;
            //lberror.Visible = true;
            error.Start();
        }

        private void Error_Tick(object sender, EventArgs e)
        {
            if (cont != 90)
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
    }
}
