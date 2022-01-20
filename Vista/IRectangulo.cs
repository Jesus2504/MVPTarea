using System;
using System.Collections.Generic;
using System.Text;

namespace MVPTarea.Vista
{
   //metodo donde esta la iteface del largo, ancho y area
        public interface IRectangulo
        {
            string LengthText { get; set; }
            string BreadthText { get; set; }
            string AreaText { get; set; }
        }
    }

