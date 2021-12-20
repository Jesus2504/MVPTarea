using System;
using System.Collections.Generic;
using System.Text;
using MVPTarea.Vista;
using MVPTarea.Modelo;
namespace MVPTarea.Presentador
{
    public class RectanguloPresentador
    {
        IRectangulo rectanguloVista;
        public RectanguloPresentador(IRectangulo vista)
        {
            rectanguloVista = vista;
        }

        public void CalcularArea()
        {
            Rectangulo rectangulo = new Rectangulo();
            rectangulo.Length = double.Parse(rectanguloVista.LengthText);
            rectangulo.Breadth = double.Parse(rectanguloVista.BreadthText);

            rectanguloVista.AreaText = rectangulo.CalcularArea().ToString();

        }

    }
}
