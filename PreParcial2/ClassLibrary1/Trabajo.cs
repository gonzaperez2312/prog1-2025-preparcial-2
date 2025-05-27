namespace ClassLibrary1
{
    public class Trabajo
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<Herramienta> Herramientas { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaEstimadaEntrega { get; set; }

        public Trabajo()
        {
            Herramientas = new List<Herramienta>();
        }

        public void CalcularFechaEstimadaEntrega()
        {
            FechaEstimadaEntrega = FechaInicio;

            //Slide contenido teorico: https://docs.google.com/presentation/d/1s3VZ__Gody-peL_iiHOi8ostMpmVoDo5s5eqldfzWvA/edit?slide=id.g35bf4dacb86_0_0#slide=id.g35bf4dacb86_0_0
            int herramientasElectricas = Herramientas.Count(h => h is HerramientaElectrica);
            int herramientasManuales = Herramientas.Count(h => h is HerramientaManual);

            if (herramientasElectricas > 3)
            {
                FechaEstimadaEntrega = FechaEstimadaEntrega.AddDays(5);
            }
            else
            {
                FechaEstimadaEntrega = FechaEstimadaEntrega.AddDays(3);
            }

            if (herramientasManuales > 5)
            {
                FechaEstimadaEntrega = FechaEstimadaEntrega.AddDays(10);
            }
            else
            {
                FechaEstimadaEntrega = FechaEstimadaEntrega.AddDays(2);
            }
        }
    }
} 