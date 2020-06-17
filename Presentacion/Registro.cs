using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class Registro : Form
    {
        //M_Lista_registros objetoreg = new M_Lista_registros();
        string identificador;
        public Registro()
        {
            InitializeComponent();
        }

        private void Btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            Mostrarregistro();
        }
        private void Mostrarregistro()
        {
            M_Lista_registros objetoreg = new M_Lista_registros();
            dataGridView1.DataSource = objetoreg.Mostrarreg();
        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string genero;
            string dir_imagen,dir_image2;
            VerRegistro editreg = new VerRegistro();
            editreg.txci.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            editreg.txnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            editreg.txap.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            editreg.txam.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            editreg.txed.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            genero= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (genero == "M")
            {
                editreg.comge.Text = "MASCULINO";
            }
            else if (genero == "F")
            {
                editreg.comge.Text = "FEMENINO";
            }
            else
            {
                editreg.comge.Text = "GÉNERO";
            }
            dir_image2="";
            try
            {
                dir_imagen = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dir_image2 = dir_imagen.Replace("/", "\\");
                editreg.pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath + dir_image2));
                editreg.ShowDialog();
            }
            catch(Exception x)
            {
                MessageBox.Show("se presento el siguiente error: " + x);
                MessageBox.Show("impresion: " + dir_image2);
                MessageBox.Show("impresion2: " + Application.StartupPath);
            }
            


        }

        private void Bteliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                identificador = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                M_Lista_registros objetoreg = new M_Lista_registros();
                objetoreg.EliminarRegis(identificador);
                Mostrarregistro();
                MessageBox.Show("Eliminación exitosa");
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
    }
}
