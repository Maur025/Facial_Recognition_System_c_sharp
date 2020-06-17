using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class Lista_usuario : Form
    {
        bool edita = false;
        string identificador=null;
        string passwordu = null;
        int nive=0;
        //M_Listar_usuarios objetousu = new M_Listar_usuarios();// se usa de este modo si los datos no requieren ser actualizados 
        public Lista_usuario()
        {
            InitializeComponent();
        }

        private void Lista_usuario_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
            //Eliminar la columna password
            DataGridViewColumn Column = dataGridView1.Columns[6];
            Column.Visible = false;
        }
        private void MostrarUsuarios() {
            M_Listar_usuarios objetousu = new M_Listar_usuarios();
            dataGridView1.DataSource = objetousu.Mostrarusu();
        }

        private void Btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            string priv;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //txnombre.Text = dataGridView1.CurrentRow.Cells["nombre_p"].Value.ToString();
                //txappat.Text = dataGridView1.CurrentRow.Cells["ap_pat"].Value.ToString();
                //txapmat.Text = dataGridView1.CurrentRow.Cells["ap_mat"].Value.ToString();
                //txusername.Text = dataGridView1.CurrentRow.Cells["nombre_us"].Value.ToString();
                //txcarg.Text = dataGridView1.CurrentRow.Cells["cargo"].Value.ToString();
                //txnuci.Text = dataGridView1.CurrentRow.Cells["nuci"].Value.ToString();
                //identificador = dataGridView1.CurrentRow.Cells["id_us"].Value.ToString();
                //passwordu = dataGridView1.CurrentRow.Cells["pass"].Value.ToString();
                //priv = dataGridView1.CurrentRow.Cells["nivel"].Value.ToString();
                txnombre.Text = dataGridView1.CurrentRow.Cells["Nombres"].Value.ToString();
                txappat.Text = dataGridView1.CurrentRow.Cells["Paterno"].Value.ToString();
                txapmat.Text = dataGridView1.CurrentRow.Cells["Materno"].Value.ToString();
                txusername.Text = dataGridView1.CurrentRow.Cells["Usuario"].Value.ToString();
                txcarg.Text = dataGridView1.CurrentRow.Cells["Cargo"].Value.ToString();
                txnuci.Text = dataGridView1.CurrentRow.Cells["CI"].Value.ToString();
                identificador = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                passwordu = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();                
                priv = dataGridView1.CurrentRow.Cells["Privilegios"].Value.ToString();
                if (int.Parse(priv) == 0)
                {
                    copriv.Text = "ADMINISTRADOR";
                }
                else if (int.Parse(priv) == 1) {
                    copriv.Text = "EMPLEADO";
                }

                //aparecen
                txnuci.Visible = true;
                txnombre.Visible = true;
                txappat.Visible = true;
                txapmat.Visible = true;
                txusername.Visible = true;
                txcarg.Visible = true;
                copriv.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                lineShape1.Visible = true;
                lineShape2.Visible = true;
                lineShape3.Visible = true;
                lineShape4.Visible = true;
                lineShape5.Visible = true;
                lineShape6.Visible = true;
                btguardar.Visible = true;
                edita = true;

            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar");
            }
        }

        private void Btguardar_Click(object sender, EventArgs e)
        {
            if (edita == true) {

                try
                {
                    M_Listar_usuarios objetousu = new M_Listar_usuarios();
                    if (copriv.Text == "ADMINISTRADOR")
                    {
                        nive = 0;
                    }
                    else if (copriv.Text == "EMPLEADO")
                    {
                        nive = 1;
                    }
                    objetousu.EditarUsu(identificador,txnombre.Text,txappat.Text,txapmat.Text,txusername.Text,passwordu,nive,txcarg.Text,txnuci.Text);
                    txnuci.Visible = false;
                    txnombre.Visible = false;
                    txappat.Visible = false;
                    txapmat.Visible = false;
                    txusername.Visible = false;
                    txcarg.Visible = false;
                    copriv.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    lineShape1.Visible = false;
                    lineShape2.Visible = false;
                    lineShape3.Visible = false;
                    lineShape4.Visible = false;
                    lineShape5.Visible = false;
                    lineShape6.Visible = false;
                    btguardar.Visible = false;
                    MessageBox.Show("Datos Actualizados Correctamente");
                    MostrarUsuarios();
                    edita = false;


                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por :" + ex);
                }               
                
            }
            

        }

        private void Bteliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                identificador = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                M_Listar_usuarios objetousu = new M_Listar_usuarios();
                objetousu.EliminarUsu(identificador);
                MostrarUsuarios();
                MessageBox.Show("Eliminación exitosa");
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
    }
}
