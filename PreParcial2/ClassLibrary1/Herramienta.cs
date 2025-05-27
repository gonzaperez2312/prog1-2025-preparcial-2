namespace ClassLibrary1
{

    public abstract class Herramienta
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        //Slide https://docs.google.com/presentation/d/1s3VZ__Gody-peL_iiHOi8ostMpmVoDo5s5eqldfzWvA/edit?slide=id.g2c3399d384d_1_138#slide=id.g2c3399d384d_1_138
        public abstract string ObtenerDetalle();
    }
} 