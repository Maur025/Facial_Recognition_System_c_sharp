// Detección y reconocimiento de rostros múltiples en tiempo real.
// Uso de la plataforma multiplataforma .Net de EmguCV para la biblioteca de procesamiento de imágenes Intel OpenCV para C # .Net

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using Dominio;
using Soporte.Cache;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        // Declaración de todas las variables
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
#pragma warning disable CS0169 // El campo 'FrmPrincipal.eye' nunca se usa
        HaarCascade eye;
#pragma warning restore CS0169 // El campo 'FrmPrincipal.eye' nunca se usa
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels= new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null;

        Modelo_registro newinsertu = new Modelo_registro();
        string cimagen="";


        public FrmPrincipal()
        {
            InitializeComponent();          
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            // eye = new HaarCascade ("haarcascade_eye.xml");
            try
            {
                // Carga de caras y etiquetas entrenadas previas para cada imagen.
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels+1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }
            
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch(Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                //MessageBox.Show(e.ToString());
                MessageBox.Show("No hay nada en la base de datos binaria, agregue al menos una cara (Simplemente entrene el prototipo con el botón Agregar cara).", "Caras triaminadas de carga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Inicializar el dispositivo de captura.
            //grabber = new Capture();
           // grabber.QueryFrame();
            // Inicializar el evento FrameGraber.
           // Application.Idle += new EventHandler(FrameGrabber);
           // button1.Enabled = false;
        }

        private void Btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Chopcion_CheckedChanged(object sender, EventArgs e)
        {
            txap.Visible = true;
            txam.Visible = true;
            txed.Visible = true;
            comge.Visible = true;
            lineShape3.Visible = true;
            lineShape4.Visible = true;
            lineShape5.Visible = true;
            chopcion.Visible = false;
            chopcion.Checked = false;
            chopcion2.Visible = true;

        }

        private void Chopcion2_CheckedChanged(object sender, EventArgs e)
        {
            txap.Visible = false;
            txam.Visible = false;
            txed.Visible = false;
            comge.Visible = false;
            lineShape3.Visible = false;
            lineShape4.Visible = false;
            lineShape5.Visible = false;
            chopcion.Visible = true;
            chopcion2.Visible = false;
            chopcion2.Checked = true;
        }

        private void Txci_Enter(object sender, EventArgs e)
        {
            if (txci.Text == "NÚMERO CI")
            {
                txci.Text = "";
                txci.ForeColor = Color.LightGray;
            }
        }

        private void Txci_Leave(object sender, EventArgs e)
        {
            if (txci.Text == "")
            {
                txci.Text = "NÚMERO CI";
                txci.ForeColor = Color.DimGray;
            }
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "NOMBRE")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "NOMBRE";
                textBox1.ForeColor = Color.DimGray;
            }
        }

        private void Txap_Enter(object sender, EventArgs e)
        {
            if (txap.Text == "APELLIDO PATERNO")
            {
                txap.Text = "";
                txap.ForeColor = Color.LightGray;
            }
        }

        private void Txap_Leave(object sender, EventArgs e)
        {
            if (txap.Text == "")
            {
                txap.Text = "APELLIDO PATERNO";
                txap.ForeColor = Color.DimGray;
            }
        }

        private void Txam_Enter(object sender, EventArgs e)
        {
            if (txam.Text == "APELLIDO MATERNO")
            {
                txam.Text = "";
                txam.ForeColor = Color.LightGray;
            }
        }

        private void Txam_Leave(object sender, EventArgs e)
        {
            if (txam.Text == "")
            {
                txam.Text = "APELLIDO MATERNO";
                txam.ForeColor = Color.DimGray;
            }
        }

        private void Txed_Enter(object sender, EventArgs e)
        {
            if (txed.Text == "EDAD")
            {
                txed.Text = "";
                txed.ForeColor = Color.LightGray;
            }
        }

        private void Txed_Leave(object sender, EventArgs e)
        {
            if (txed.Text == "")
            {
                txed.Text = "EDAD";
                txed.ForeColor = Color.DimGray;
            }
        }

        private void imageBoxFrameGrabber_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            string usuid;
            try
            {
                // Contador de caras entrenadas.
                ContTrain = ContTrain + 1;

                // Obtener un marco gris del dispositivo de captura.
                gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //Reconocimiento facial
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                face,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

                // Acción por cada elemento detectado.
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }

                // redimensionar la imagen de la cara detectada para forzar a comparar el mismo tamaño con la imagen de prueba con el método de tipo de interpolación cúbica.
                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                trainingImages.Add(TrainedFace);
                labels.Add(textBox1.Text);

                // Mostrar rostro añadido en escala de grises.
                imageBox1.Image = TrainedFace;

                // Escriba el número de caras controladas en un texto de archivo para una carga adicional.
                File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

                // Escriba las etiquetas(labels) de las caras controladas en un texto de archivo para una carga adicional.
                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
                    cimagen = "/TrainedFaces/face" + i + ".bmp";
                }

                usuid = CacheLoginUser.iduser.ToString();
                try
                {
                    newinsertu.insertarusu(txci.Text, textBox1.Text, txap.Text, txam.Text, txed.Text, comge.Text, cimagen, usuid);
                    MessageBox.Show("Registro Exitoso");
                    txci.Text = "NÚMERO CI";
                    txci.ForeColor = Color.DimGray;
                    textBox1.Text = "NOMBRE";
                    textBox1.ForeColor = Color.DimGray;
                    txap.Text = "APELLIDO PATERNO";
                    txap.ForeColor = Color.DimGray;
                    txam.Text = "APELLIDO MATERNO";
                    txam.ForeColor = Color.DimGray;
                    txed.Text = "EDAD";
                    txed.ForeColor = Color.DimGray;
                    comge.Text = "GÉNERO";
                    comge.ForeColor = Color.DimGray;
                }
                catch(Exception x)
                {
                    MessageBox.Show("Se presento el siguiente error:" + x);
                }
                

                MessageBox.Show(textBox1.Text + " Cara detectada y agregada:)", "Entrenamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Habilitar primero la detección de rostros", "Falla en el entrenamiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        void FrameGrabber(object sender, EventArgs e)
        {
            label3.Text = "0";
            //label4.Text = "";
            NamePersons.Add("");


            // Obtener el dispositivo de captura de forma de marco actual.
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                    // Convertirlo en escala de grises.
                    gray = currentFrame.Convert<Gray, Byte>();

                    //Reconocimiento Facial
                    MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                  face,
                  1.2,
                  10,
                  Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                  new Size(20, 20));

                    // Acción por cada elemento detectado.
                    foreach (MCvAvgComp f in facesDetected[0])
                    {
                        t = t + 1;
                        result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                        //dibujar la cara detectada en el canal 0 (gris) con color azul
                        currentFrame.Draw(f.rect, new Bgr(Color.DarkRed), 2);


                        if (trainingImages.ToArray().Length != 0)
                        {
                    //TermCriteria para reconocimiento facial con números de imágenes entrenadas como maxIteration.
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                        //Reconocedor de cara Eigen.
                        EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                           trainingImages.ToArray(),
                           labels.ToArray(),
                           3000,
                           ref termCrit);

                        name = recognizer.Recognize(result);

                            //Dibujar la etiqueta para cada cara detectada y reconocida.
                        currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.DarkRed));

                        }

                            NamePersons[t-1] = name;
                            NamePersons.Add("");                        
                        label3.Text = facesDetected[0].Length.ToString();                      
                    }
                        t = 0;
                    for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
                    {
                        names = names + NamePersons[nnn] + ", ";
                    }
                    imageBoxFrameGrabber.Image = currentFrame;
                    label4.Text = names;
                    names = "";
                    NamePersons.Clear();

                }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // Inicializar el dispositivo de captura.
            grabber = new Capture();
            grabber.QueryFrame();
            // Inicializar el evento FrameGraber.
            Application.Idle += new EventHandler(FrameGrabber);
        }

    }
}