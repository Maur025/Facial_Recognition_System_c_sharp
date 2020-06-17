namespace Presentacion
{
    partial class Agregar_usu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_usu));
            this.btcerrar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txnuci = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.copriv = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txcarg = new System.Windows.Forms.TextBox();
            this.txusername = new System.Windows.Forms.TextBox();
            this.txapmat = new System.Windows.Forms.TextBox();
            this.txappat = new System.Windows.Forms.TextBox();
            this.txnombre = new System.Windows.Forms.TextBox();
            this.btguardar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label8 = new System.Windows.Forms.Label();
            this.txpassw = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txreppassw = new System.Windows.Forms.TextBox();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btvis1 = new System.Windows.Forms.Button();
            this.btvis2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lberror = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btcerrar
            // 
            this.btcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btcerrar.AutoSize = true;
            this.btcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btcerrar.Location = new System.Drawing.Point(1021, 8);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.Size = new System.Drawing.Size(20, 20);
            this.btcerrar.TabIndex = 1;
            this.btcerrar.Text = "X";
            this.btcerrar.Click += new System.EventHandler(this.Btcerrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(149, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Número de CI";
            // 
            // txnuci
            // 
            this.txnuci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txnuci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txnuci.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txnuci.ForeColor = System.Drawing.Color.LightGray;
            this.txnuci.Location = new System.Drawing.Point(149, 56);
            this.txnuci.Name = "txnuci";
            this.txnuci.Size = new System.Drawing.Size(276, 15);
            this.txnuci.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(149, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cargo";
            // 
            // copriv
            // 
            this.copriv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.copriv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copriv.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copriv.ForeColor = System.Drawing.Color.LightGray;
            this.copriv.FormattingEnabled = true;
            this.copriv.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "EMPLEADO"});
            this.copriv.Location = new System.Drawing.Point(149, 347);
            this.copriv.Name = "copriv";
            this.copriv.Size = new System.Drawing.Size(276, 25);
            this.copriv.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(149, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Privilegios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(149, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(149, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(149, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Apellido Paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(149, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre";
            // 
            // txcarg
            // 
            this.txcarg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txcarg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txcarg.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txcarg.ForeColor = System.Drawing.Color.LightGray;
            this.txcarg.Location = new System.Drawing.Point(149, 397);
            this.txcarg.Name = "txcarg";
            this.txcarg.Size = new System.Drawing.Size(276, 15);
            this.txcarg.TabIndex = 9;
            // 
            // txusername
            // 
            this.txusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txusername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txusername.ForeColor = System.Drawing.Color.LightGray;
            this.txusername.Location = new System.Drawing.Point(149, 250);
            this.txusername.Name = "txusername";
            this.txusername.Size = new System.Drawing.Size(276, 15);
            this.txusername.TabIndex = 5;
            // 
            // txapmat
            // 
            this.txapmat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txapmat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txapmat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txapmat.ForeColor = System.Drawing.Color.LightGray;
            this.txapmat.Location = new System.Drawing.Point(149, 199);
            this.txapmat.Name = "txapmat";
            this.txapmat.Size = new System.Drawing.Size(276, 15);
            this.txapmat.TabIndex = 4;
            // 
            // txappat
            // 
            this.txappat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txappat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txappat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txappat.ForeColor = System.Drawing.Color.LightGray;
            this.txappat.Location = new System.Drawing.Point(149, 151);
            this.txappat.Name = "txappat";
            this.txappat.Size = new System.Drawing.Size(276, 15);
            this.txappat.TabIndex = 3;
            // 
            // txnombre
            // 
            this.txnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txnombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txnombre.ForeColor = System.Drawing.Color.LightGray;
            this.txnombre.Location = new System.Drawing.Point(149, 100);
            this.txnombre.Name = "txnombre";
            this.txnombre.Size = new System.Drawing.Size(276, 15);
            this.txnombre.TabIndex = 2;
            // 
            // btguardar
            // 
            this.btguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btguardar.FlatAppearance.BorderSize = 0;
            this.btguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btguardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btguardar.ForeColor = System.Drawing.Color.LightGray;
            this.btguardar.Location = new System.Drawing.Point(621, 461);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(108, 37);
            this.btguardar.TabIndex = 10;
            this.btguardar.Text = "Guardar";
            this.btguardar.UseVisualStyleBackColor = false;
            this.btguardar.Click += new System.EventHandler(this.Btguardar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btcancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcancelar.FlatAppearance.BorderSize = 0;
            this.btcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btcancelar.Location = new System.Drawing.Point(17, 461);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(108, 37);
            this.btcancelar.TabIndex = 11;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.Btcancelar_Click);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 141;
            this.lineShape1.X2 = 431;
            this.lineShape1.Y1 = 75;
            this.lineShape1.Y2 = 75;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape8,
            this.lineShape7,
            this.lineShape6,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1050, 510);
            this.shapeContainer1.TabIndex = 35;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 140;
            this.lineShape2.X2 = 430;
            this.lineShape2.Y1 = 121;
            this.lineShape2.Y2 = 121;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 141;
            this.lineShape3.X2 = 431;
            this.lineShape3.Y1 = 171;
            this.lineShape3.Y2 = 171;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape4.Enabled = false;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 141;
            this.lineShape4.X2 = 431;
            this.lineShape4.Y1 = 219;
            this.lineShape4.Y2 = 219;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape5.Enabled = false;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 141;
            this.lineShape5.X2 = 431;
            this.lineShape5.Y1 = 269;
            this.lineShape5.Y2 = 269;
            // 
            // lineShape6
            // 
            this.lineShape6.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape6.Enabled = false;
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 141;
            this.lineShape6.X2 = 431;
            this.lineShape6.Y1 = 417;
            this.lineShape6.Y2 = 417;
            // 
            // lineShape7
            // 
            this.lineShape7.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape7.Enabled = false;
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 140;
            this.lineShape7.X2 = 430;
            this.lineShape7.Y1 = 317;
            this.lineShape7.Y2 = 317;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(149, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "Contraseña";
            // 
            // txpassw
            // 
            this.txpassw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txpassw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txpassw.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txpassw.ForeColor = System.Drawing.Color.LightGray;
            this.txpassw.Location = new System.Drawing.Point(149, 297);
            this.txpassw.Name = "txpassw";
            this.txpassw.Size = new System.Drawing.Size(276, 15);
            this.txpassw.TabIndex = 6;
            this.txpassw.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(504, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 19);
            this.label9.TabIndex = 38;
            this.label9.Text = "Repetir Contraseña";
            // 
            // txreppassw
            // 
            this.txreppassw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txreppassw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txreppassw.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txreppassw.ForeColor = System.Drawing.Color.LightGray;
            this.txreppassw.Location = new System.Drawing.Point(506, 297);
            this.txreppassw.Name = "txreppassw";
            this.txreppassw.Size = new System.Drawing.Size(221, 15);
            this.txreppassw.TabIndex = 7;
            this.txreppassw.UseSystemPasswordChar = true;
            // 
            // lineShape8
            // 
            this.lineShape8.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape8.Enabled = false;
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 501;
            this.lineShape8.X2 = 728;
            this.lineShape8.Y1 = 318;
            this.lineShape8.Y2 = 318;
            // 
            // btvis1
            // 
            this.btvis1.FlatAppearance.BorderSize = 0;
            this.btvis1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btvis1.Image = ((System.Drawing.Image)(resources.GetObject("btvis1.Image")));
            this.btvis1.Location = new System.Drawing.Point(92, 294);
            this.btvis1.Name = "btvis1";
            this.btvis1.Size = new System.Drawing.Size(33, 23);
            this.btvis1.TabIndex = 40;
            this.btvis1.UseVisualStyleBackColor = true;
            this.btvis1.Click += new System.EventHandler(this.Btvis1_Click);
            // 
            // btvis2
            // 
            this.btvis2.FlatAppearance.BorderSize = 0;
            this.btvis2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btvis2.Image = ((System.Drawing.Image)(resources.GetObject("btvis2.Image")));
            this.btvis2.Location = new System.Drawing.Point(459, 294);
            this.btvis2.Name = "btvis2";
            this.btvis2.Size = new System.Drawing.Size(33, 23);
            this.btvis2.TabIndex = 41;
            this.btvis2.UseVisualStyleBackColor = true;
            this.btvis2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(508, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // lberror
            // 
            this.lberror.AutoSize = true;
            this.lberror.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberror.ForeColor = System.Drawing.Color.DimGray;
            this.lberror.Image = ((System.Drawing.Image)(resources.GetObject("lberror.Image")));
            this.lberror.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lberror.Location = new System.Drawing.Point(477, 353);
            this.lberror.Name = "lberror";
            this.lberror.Size = new System.Drawing.Size(101, 19);
            this.lberror.TabIndex = 43;
            this.lberror.Text = "Mensaje error";
            this.lberror.Visible = false;
            // 
            // error
            // 
            this.error.Tick += new System.EventHandler(this.Error_Tick);
            // 
            // Agregar_usu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1050, 510);
            this.Controls.Add(this.lberror);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btvis2);
            this.Controls.Add(this.btvis1);
            this.Controls.Add(this.txreppassw);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txpassw);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txnuci);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.copriv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txcarg);
            this.Controls.Add(this.txusername);
            this.Controls.Add(this.txapmat);
            this.Controls.Add(this.txappat);
            this.Controls.Add(this.txnombre);
            this.Controls.Add(this.btcerrar);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar_usu";
            this.Text = "Agregar_usu";
            this.Load += new System.EventHandler(this.Agregar_usu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btcerrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txnuci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox copriv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txcarg;
        private System.Windows.Forms.TextBox txusername;
        private System.Windows.Forms.TextBox txapmat;
        private System.Windows.Forms.TextBox txappat;
        private System.Windows.Forms.TextBox txnombre;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.Button btcancelar;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txpassw;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txreppassw;
        private System.Windows.Forms.Button btvis1;
        private System.Windows.Forms.Button btvis2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lberror;
        private System.Windows.Forms.Timer error;
    }
}