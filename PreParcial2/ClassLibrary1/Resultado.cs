namespace ClassLibrary1
{
    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

        public Resultado()
        {
            Exitoso = true;
        }

        public Resultado(string mensaje)
        {
            Exitoso = false;
            Mensaje = mensaje;
        }
    }
} 