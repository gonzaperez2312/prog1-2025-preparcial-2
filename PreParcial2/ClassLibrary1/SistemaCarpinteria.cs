using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class SistemaCarpinteria
    {
        //Slide https://docs.google.com/presentation/d/1bPWDDUlXMT9r6jAxf-UZnvU13ud5vd8-RrJ9wQldBOI/edit?slide=id.g1f4005b99c6_4_145#slide=id.g1f4005b99c6_4_145
        private List<Herramienta> herramientas;
        private List<Trabajo> trabajos;

        //Slide https://docs.google.com/presentation/d/1bPWDDUlXMT9r6jAxf-UZnvU13ud5vd8-RrJ9wQldBOI/edit?slide=id.g1f4005b99c6_4_101#slide=id.g1f4005b99c6_4_101
        public SistemaCarpinteria()
        {
            herramientas = new List<Herramienta>();
            trabajos = new List<Trabajo>();
        }

        public void AgregarHerramientaManual(HerramientaManual herramienta)
        {
            herramienta.Codigo = herramientas.Count + 1;
            herramientas.Add(herramienta);
        }

        public void AgregarHerramientaElectrica(HerramientaElectrica herramienta)
        {
            herramienta.Codigo = herramientas.Count + 1;
            herramientas.Add(herramienta);
        }

        public Resultado ObtenerDetalleHerramienta(int codigo)
        {
            //Slide https://docs.google.com/presentation/d/1s3VZ__Gody-peL_iiHOi8ostMpmVoDo5s5eqldfzWvA/edit?slide=id.g2c3399d384d_1_118#slide=id.g2c3399d384d_1_118
            var herramienta = herramientas.FirstOrDefault(h => h.Codigo == codigo);
            if (herramienta == null)
            {
                return new Resultado($"No se encontró una herramienta con el código {codigo}");
            }

            var resultado = new Resultado();
            resultado.Mensaje = herramienta.ObtenerDetalle();
            return resultado;
        }

        public Resultado AgregarTrabajo(string titulo, string descripcion, List<int> codigosHerramientas, DateTime fechaInicio)
        {
            var herramientasSeleccionadas = new List<Herramienta>();
            foreach (var codigo in codigosHerramientas)
            {
                var herramienta = herramientas.FirstOrDefault(h => h.Codigo == codigo);
                if (herramienta == null)
                {
                    return new Resultado($"No se encontró la herramienta con código {codigo}");
                }

                //Slide https://docs.google.com/presentation/d/1s3VZ__Gody-peL_iiHOi8ostMpmVoDo5s5eqldfzWvA/edit?slide=id.g2c3399d384d_1_118#slide=id.g2c3399d384d_1_118
                herramientasSeleccionadas.Add(herramienta);
            }

            var trabajo = new Trabajo
            {
                Codigo = trabajos.Count + 1,
                Titulo = titulo,
                Descripcion = descripcion,
                Herramientas = herramientasSeleccionadas,
                FechaInicio = fechaInicio
            };
            trabajo.CalcularFechaEstimadaEntrega();
            
            trabajos.Add(trabajo);
            return new Resultado();
        }

        public List<Herramienta> ObtenerHerramientas()
        {
            return herramientas.ToList();
        }

        public List<Trabajo> ObtenerTrabajos()
        {
            return trabajos.ToList();
        }
    }
} 