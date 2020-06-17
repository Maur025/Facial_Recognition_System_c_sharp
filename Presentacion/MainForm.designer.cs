namespace Presentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chopcion = new System.Windows.Forms.CheckBox();
            this.txed = new System.Windows.Forms.TextBox();
            this.comge = new System.Windows.Forms.ComboBox();
            this.txam = new System.Windows.Forms.TextBox();
            this.txap = new System.Windows.Forms.TextBox();
            this.txci = new System.Windows.Forms.TextBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btcerrar = new System.Windows.Forms.Label();
            this.chopcion2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(31, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(20, 201);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 18);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "NOMBRE";
            this.textBox1.Enter += new System.EventHandler(this.TextBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.TextBox1_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chopcion);
            this.groupBox1.Controls.Add(this.txed);
            this.groupBox1.Controls.Add(this.comge);
            this.groupBox1.Controls.Add(this.txam);
            this.groupBox1.Controls.Add(this.txap);
            this.groupBox1.Controls.Add(this.txci);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.shapeContainer1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(39, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Persona";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chopcion
            // 
            this.chopcion.AutoSize = true;
            this.chopcion.ForeColor = System.Drawing.Color.LightGray;
            this.chopcion.Location = new System.Drawing.Point(24, 232);
            this.chopcion.Name = "chopcion";
            this.chopcion.Size = new System.Drawing.Size(125, 23);
            this.chopcion.TabIndex = 3;
            this.chopcion.Text = "Detallar Datos";
            this.chopcion.UseVisualStyleBackColor = true;
            this.chopcion.CheckedChanged += new System.EventHandler(this.Chopcion_CheckedChanged);
            // 
            // txed
            // 
            this.txed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txed.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txed.ForeColor = System.Drawing.Color.DimGray;
            this.txed.Location = new System.Drawing.Point(19, 298);
            this.txed.MaxLength = 2;
            this.txed.Name = "txed";
            this.txed.Size = new System.Drawing.Size(70, 18);
            this.txed.TabIndex = 6;
            this.txed.Text = "EDAD";
            this.txed.Visible = false;
            this.txed.Enter += new System.EventHandler(this.Txed_Enter);
            this.txed.Leave += new System.EventHandler(this.Txed_Leave);
            // 
            // comge
            // 
            this.comge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.comge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comge.ForeColor = System.Drawing.Color.DimGray;
            this.comge.FormattingEnabled = true;
            this.comge.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO"});
            this.comge.Location = new System.Drawing.Point(111, 295);
            this.comge.Name = "comge";
            this.comge.Size = new System.Drawing.Size(107, 25);
            this.comge.TabIndex = 7;
            this.comge.Text = "GÉNERO";
            this.comge.Visible = false;
            // 
            // txam
            // 
            this.txam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txam.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txam.ForeColor = System.Drawing.Color.DimGray;
            this.txam.Location = new System.Drawing.Point(19, 263);
            this.txam.MaxLength = 15;
            this.txam.Name = "txam";
            this.txam.Size = new System.Drawing.Size(198, 18);
            this.txam.TabIndex = 5;
            this.txam.Text = "APELLIDO MATERNO";
            this.txam.Visible = false;
            this.txam.Enter += new System.EventHandler(this.Txam_Enter);
            this.txam.Leave += new System.EventHandler(this.Txam_Leave);
            // 
            // txap
            // 
            this.txap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txap.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txap.ForeColor = System.Drawing.Color.DimGray;
            this.txap.Location = new System.Drawing.Point(19, 232);
            this.txap.MaxLength = 15;
            this.txap.Name = "txap";
            this.txap.Size = new System.Drawing.Size(198, 18);
            this.txap.TabIndex = 4;
            this.txap.Text = "APELLIDO PATERNO";
            this.txap.Visible = false;
            this.txap.Enter += new System.EventHandler(this.Txap_Enter);
            this.txap.Leave += new System.EventHandler(this.Txap_Leave);
            // 
            // txci
            // 
            this.txci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txci.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txci.ForeColor = System.Drawing.Color.DimGray;
            this.txci.Location = new System.Drawing.Point(20, 168);
            this.txci.MaxLength = 9;
            this.txci.Name = "txci";
            this.txci.Size = new System.Drawing.Size(198, 18);
            this.txci.TabIndex = 1;
            this.txci.Text = "NÚMERO CI";
            this.txci.Enter += new System.EventHandler(this.Txci_Enter);
            this.txci.Leave += new System.EventHandler(this.Txci_Leave);
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(37, 28);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(163, 124);
            this.imageBox1.TabIndex = 5;
            this.imageBox1.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 20);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(236, 343);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape5.Enabled = false;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.Visible = false;
            this.lineShape5.X1 = 11;
            this.lineShape5.X2 = 89;
            this.lineShape5.Y1 = 300;
            this.lineShape5.Y2 = 300;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape4.Enabled = false;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.Visible = false;
            this.lineShape4.X1 = 13;
            this.lineShape4.X2 = 212;
            this.lineShape4.Y1 = 266;
            this.lineShape4.Y2 = 266;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.Visible = false;
            this.lineShape3.X1 = 13;
            this.lineShape3.X2 = 212;
            this.lineShape3.Y1 = 235;
            this.lineShape3.Y2 = 235;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 14;
            this.lineShape2.X2 = 213;
            this.lineShape2.Y1 = 204;
            this.lineShape2.Y2 = 204;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 14;
            this.lineShape1.X2 = 213;
            this.lineShape1.Y1 = 171;
            this.lineShape1.Y2 = 171;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(39, 413);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 85);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(9, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Personas presentes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(9, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nadie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(198, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.label2.Location = new System.Drawing.Point(-9, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Número de rotros detectados:";
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.imageBoxFrameGrabber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(331, 51);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(571, 420);
            this.imageBoxFrameGrabber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxFrameGrabber.TabIndex = 4;
            this.imageBoxFrameGrabber.TabStop = false;
            this.imageBoxFrameGrabber.Click += new System.EventHandler(this.imageBoxFrameGrabber_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.btcerrar);
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 36);
            this.panel1.TabIndex = 10;
            // 
            // btcerrar
            // 
            this.btcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btcerrar.AutoSize = true;
            this.btcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btcerrar.Location = new System.Drawing.Point(1025, 11);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.Size = new System.Drawing.Size(20, 20);
            this.btcerrar.TabIndex = 1;
            this.btcerrar.Text = "X";
            this.btcerrar.Click += new System.EventHandler(this.Btcerrar_Click);
            // 
            // chopcion2
            // 
            this.chopcion2.AutoSize = true;
            this.chopcion2.Checked = true;
            this.chopcion2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chopcion2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chopcion2.ForeColor = System.Drawing.Color.LightGray;
            this.chopcion2.Location = new System.Drawing.Point(331, 477);
            this.chopcion2.Name = "chopcion2";
            this.chopcion2.Size = new System.Drawing.Size(125, 23);
            this.chopcion2.TabIndex = 10;
            this.chopcion2.Text = "Detallar Datos";
            this.chopcion2.UseVisualStyleBackColor = true;
            this.chopcion2.Visible = false;
            this.chopcion2.CheckedChanged += new System.EventHandler(this.Chopcion2_CheckedChanged);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1050, 510);
            this.Controls.Add(this.chopcion2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto Feria";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btcerrar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txed;
        private System.Windows.Forms.ComboBox comge;
        private System.Windows.Forms.TextBox txam;
        private System.Windows.Forms.TextBox txap;
        private System.Windows.Forms.TextBox txci;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.CheckBox chopcion;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox chopcion2;
    }
}

