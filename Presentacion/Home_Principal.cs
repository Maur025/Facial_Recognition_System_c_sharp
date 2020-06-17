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
using Soporte.Cache;

namespace Presentacion
{
    public partial class Home_Principal : Form
    {
        public Home_Principal()
        {
            InitializeComponent();
            FechaHora.Start();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Btmenu_Click(object sender, EventArgs e)
        {
            if (menu_vert.Width == 250)
            {
                menu_vert.Width = 48;
                pictureBox2.Image = pictureBox3.Image;
                pictureBox3.Image =pictureBox4.Image;
                btLogout.Width = 40;
                btLogout.Height = 40;
            }
            else
            {
                menu_vert.Width = 250;
                pictureBox3.Image = pictureBox2.Image;
                btLogout.Width = 50;
                btLogout.Height = 50;
                //pictureBox2.Invalidate();
            }
        }

        private void Btcerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea Cerrar la aplicación?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            Application.Exit();
        }
        //Cap´turar posicion y tamaño para restaurar despues de maximizar
        int lx, ly;
        int sw, sh;

        private void Btmaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.WindowState = FormWindowState.Maximized;
            btrestaurar.Visible = true;
            btmaximizar.Visible = false;
        }

        private void Btrestaurar_Click(object sender, EventArgs e)
        {
            //this.Size = new Size(sw, sh);
            //this.Location = new Point(lx, ly);
            this.WindowState = FormWindowState.Normal;
            btrestaurar.Visible = false;
            btmaximizar.Visible = true;
        }

        private void Btminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel_superior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Esta forma de abrir formularios sirve pero sobrecarga la memoria si se abre muchos formularios

        //private void CargarFormenPanel(object FormHijo) {//
        //    if (this.panel_contenido.Controls.Count > 0)
        //        this.panel_contenido.Controls.RemoveAt(0);
        //    Form fohi = FormHijo as Form;
        //    fohi.TopLevel = false;
        //    fohi.Dock = DockStyle.Fill;
        //    this.panel_contenido.Controls.Add(fohi);
        //    this.panel_contenido.Tag = fohi;
        //    fohi.Show();
        //}

        //Metodo Abrir Formularios
        private void AbrirFormulario<MiForm>() where MiForm : Form, new() {
            Form formulario;
            formulario = panel_contenido.Controls.OfType<MiForm>().FirstOrDefault();//busca en la coleccion del formulario
            // si el formulario /instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                //para quitar los bordes
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel_contenido.Controls.Add(formulario);
                panel_contenido.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(Cerrarpest );
            }
            //si el formulario/instancia existe
            else {
                formulario.BringToFront();
            }
        }
        private void AbrirFormulario2<MiForm>() where MiForm : Form, new()
        {
            //Form formulario;
            //formulario = panel_contenido.Controls.OfType<MiForm>().FirstOrDefault();//busca en la coleccion del formulario
            // si el formulario /instancia no existe
            FrmPrincipal formulario = new FrmPrincipal();
            formulario.groupBox1.Visible = false;
            formulario.chopcion2.Visible = false;
            //if (formulario == null)
            //{
                //formulario = new MiForm();
                formulario.TopLevel = false;
                //para quitar los bordes
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel_contenido.Controls.Add(formulario);
                panel_contenido.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(Cerrarpest);
            //}
            //si el formulario/instancia existe
            //else
            //{
            //    formulario.BringToFront();
            //}
        }

        private void Btregistro_Click(object sender, EventArgs e)//
        {
            //CargarFormenPanel(new Registro());
            AbrirFormulario<Registro>();
            btregistro.BackColor = Color.FromArgb(89, 14, 14);
        }



        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void FechaHora_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
            lbFecha.Text = DateTime.Now.ToLongDateString();
        }


        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelprincipal.Region = region;
            this.Invalidate();
        }

        private void Btbuscar_Click(object sender, EventArgs e)
        {
            AbrirFormulario2<FrmPrincipal>();            
            //btbuscar.BackColor = Color.FromArgb(89, 14, 14);

        }

        private void BtLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Se cerrará la Session actual ¿Desea Continuar?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            this.Close();
        }

        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(64, 64, 64));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            //base.OnPaint(e);
            //ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent , sizeGripRectangle);
        }

        private void Home_Principal_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
        }

        private void Btusuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Lista_usuario>();
            btusuarios.BackColor = Color.FromArgb(89, 14, 14);
        }

        private void Btnewuser_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Agregar_usu>();
            btnewuser.BackColor = Color.FromArgb(89, 14, 14);
        }

        private void Btbuscar2_Click(object sender, EventArgs e)
        {
            AbrirFormulario2<FrmPrincipal>();
            //btbuscar.BackColor = Color.FromArgb(89, 14, 14);
        }

        private void Btregistro2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Registro>();
            btregistro.BackColor = Color.FromArgb(89, 14, 14);
        }

        private void Btusuario2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Lista_usuario>();
            btusuarios.BackColor = Color.FromArgb(89, 14, 14);
        }

        private void Btregfac_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmPrincipal>();
            btregfac.BackColor = Color.FromArgb(89, 14, 14);
        }

        private void Cerrarpest(object sender, FormClosedEventArgs e) {//quita el color al cerrar las pestañas
            if (Application.OpenForms["Registro"] == null)
                btregistro.BackColor = Color.FromArgb(140, 15, 15);
            if (Application.OpenForms["FrmPrincipal"] == null)
                btregfac.BackColor = Color.FromArgb(140, 15, 15);
            if (Application.OpenForms["Lista_usuario"] == null)
                btusuarios.BackColor = Color.FromArgb(140, 15, 15);
            if (Application.OpenForms["Agregar_usu"] == null)
                btnewuser.BackColor = Color.FromArgb(140, 15, 15);
        }
        private void CargarDatosUsuario() {
            lbNombreus.Text = CacheLoginUser.nombre + " "+CacheLoginUser.apellidopat+" "+CacheLoginUser.apellidomat;
            lbusuario.Text = CacheLoginUser.nomuser.ToUpper();
            lbcargo.Text = CacheLoginUser.cargo;
            if(CacheLoginUser.privilegios==1)
            {
                lbtipo.Text = "Empleado";
            }
            if (CacheLoginUser.privilegios == 0)
            {
                lbtipo.Text = "Administrador";
            }
        }
    }
}
