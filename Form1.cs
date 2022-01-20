using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVPTarea.Vista;
using MVPTarea.Presentador;
namespace MVPTarea
{ 
    public partial class Form1 : Form,IRectangulo
    {
        // metodo del form
        public Form1()
        {
            InitializeComponent();
        }


        //metodo donde estan las propiedades del largo
        public string LengthText
        {
            get
            {

                return textLength.Text;
            }
            set
            {

                textLength.Text = value;
            }

         // metodo donde estaan las propiedades del ancho
        }
        public string BreadthText
        {

            get
            {

                return textBreadth.Text;
            }

            set
            {
                textBreadth.Text= value;
            }
        //metodo donde estan las propiedades del area
        }
        public string AreaText
        {
            get
            {

                return lblArea.Text;
            }

            set
            {

                lblArea.Text = value;
            }

            //botones del forms 
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RectanguloPresentador presentador = new RectanguloPresentador(this);
            presentador.CalcularArea();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
