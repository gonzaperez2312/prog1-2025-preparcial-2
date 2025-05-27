namespace ClassLibrary1
{
    public class HerramientaElectrica : Herramienta
    {
        public double Potencia { get; set; }
        public TipoHerramienta Tipo { get; set; }
        public DateTime FechaFinGarantia { get; set; }

        //Slide https://docs.google.com/presentation/d/1s3VZ__Gody-peL_iiHOi8ostMpmVoDo5s5eqldfzWvA/edit?slide=id.g2c3399d384d_1_123#slide=id.g2c3399d384d_1_123
        public override string ObtenerDetalle()
        {
            return $"Esta es una herramienta eléctrica que tiene una potencia de {Potencia} watts y que tiene garantía hasta el {FechaFinGarantia.ToShortDateString()}";
        }
    }
} 