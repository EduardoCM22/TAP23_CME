using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesEjercicio
{
    public class ChangeSelectorArgs : EventArgs
    {
        public int Valor { get; set; }
        //Creacion de la propiedad Mes para su difucion en el control
        public Months Mes { get; set; }
    }
}
