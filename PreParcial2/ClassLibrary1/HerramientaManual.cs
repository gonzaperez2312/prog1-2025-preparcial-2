namespace ClassLibrary1
{
    public class HerramientaManual : Herramienta
    {
        public DateTime FechaAdquisicion { get; set; }

        //Slide https://docs.google.com/presentation/d/1s3VZ__Gody-peL_iiHOi8ostMpmVoDo5s5eqldfzWvA/edit?slide=id.g2c3399d384d_1_123#slide=id.g2c3399d384d_1_123
        public override string ObtenerDetalle()
        {
            return $"Esta es una herramienta manual que se adquirió en {FechaAdquisicion.ToShortDateString()}";
        }
    }
} 