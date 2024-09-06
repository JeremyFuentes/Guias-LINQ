using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // Clase creada para almacenar datos de habitantes 
    public class Habitante
    {
        public int IdHabitante { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int IdCasa { get; set; }

        public string datosHabitante()
        {
            //Retorna el nombre la edad y el id de las personas que cumplan con x condicion 
            return $"Soy {Nombre} con edad de {Edad} años vividos en {IdCasa}";
        }
    }
}
