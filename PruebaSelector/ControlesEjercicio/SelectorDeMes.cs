using System;
using System.Windows.Forms;

namespace ControlesEjercicio
{
    //Creacion de enum de valores validos para la propiedad Mes, Se inicializa Enero en 1 para que
    //tengan correspondencia todos los meses.
    public enum Months
    {
        Enero = 1, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto,
        Sepetiembre, Octubre, Noviembre, Diciembre
    }

    public partial class SelectorDeMes : UserControl
    {
        public event EventHandler<ChangeSelectorArgs> Change;

        private String[] meses = new string[] {"Enero", "Febrero", "Marzo", "Abril", "Mayo",
            "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

        private int valor = 1;
        public int Valor
        {
            get { return valor; }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    //Asignacion de los meses correspondientes segun el cambio del control.
                    valor = value;
                    mes = (Months)Enum.GetValues(typeof(Months)).GetValue(valor - 1);
                    //Cambio de lugar de la creacion e invocacion del evento debido a que de esta forma
                    //se evita que se genere el mensaje de cambio cuando realmente no lo hay.
                    ChangeSelectorArgs datos = new ChangeSelectorArgs();
                    datos.Valor = Valor;
                    datos.Mes = Mes;
                    Change?.Invoke(this, datos);
                }
                else if (value < 1)
                {
                    valor = 1;
                }
                else
                {
                    valor = 12;
                }
                lblMes.Text = meses[valor - 1];
            }
        }

        //Creacion de la propiedad Mes y asignacion del valor por default del control
        private Months mes = Months.Enero;
        public Months Mes
        {
            get { return mes; }
            set
            {
                mes = value;
                valor = (int)mes;
                lblMes.Text = meses[valor - 1];
            }
        }

        public SelectorDeMes()
        {
            InitializeComponent();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Valor--;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Valor++;
        }
    }
}
