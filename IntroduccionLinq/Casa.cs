using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // Nueva clase creada para almacenar informacion
    public class Casa
    {
        public int Id { get; set; }

        public string Direccion { get; set; }

        public string Ciudad { get; set; }

        public int numeroHabitaciones { get; set; }

        public string dameDatosCasa()
        {
            // Aquí se crea una cadena con la dirección, ciudad y número de habitaciones que cumplan con cierta condicion
            return $"Dirección es {Direccion} en la ciudad de {Ciudad} con número de habitaciones {numeroHabitaciones}";
        }
    }
}
