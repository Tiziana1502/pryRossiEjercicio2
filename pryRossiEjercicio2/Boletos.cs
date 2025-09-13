namespace pryRossiEjercicio2
{
    public partial class Boletos : Form
    {
        public Boletos()
        {
            InitializeComponent();
        }

        int PrecioKm = 5;
        double Descuento = 0.5; //utilizado para números decimales
        int diasEstancia; 
        double Distancia;
        double disTotal;
        double Precio;
        private void nudDias_ValueChanged(object sender, EventArgs e)
        {
            if (nudDias.Value > 0)
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            if (txtDistancia.Text != "")
            {
                nudDias.Enabled = true;
            }
            else
            {
                nudDias.Enabled = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            diasEstancia = Convert.ToInt32(nudDias.Value);
            Distancia = Convert.ToDouble(txtDistancia.Text.ToString());

            //Realizo las validaciones
            if (Distancia <= 0)
            {
                MessageBox.Show("La distancia debe ser mayor a 0 km.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (diasEstancia < 1 || diasEstancia > 30)
            {
                MessageBox.Show("Los días de estancia deben estar entre 1 y 30.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Cálculo del costo ida y vuelta
            disTotal = Distancia * 2;
            Precio = disTotal * PrecioKm;

            // Aplico descuento si corresponde
            if (Distancia >= 100 && diasEstancia >= 7)
            {
                Precio = Precio - (Precio * Descuento);
            }

            // Muestro resultado
            MessageBox.Show($"El precio del boleto es: {Precio} pesos",
                            "Resultado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);                            
            }
        }    
    }

