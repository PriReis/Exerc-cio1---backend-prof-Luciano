using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercicio1
{
    public class Exercicio1
    {
        public static void Main()
        {
            int convidadosNoivo = 300;
            int convidadosNoiva = 600;
            int convidadosPresentesNoivo = 400;
            int convidadosPresentesNoiva = 400;

            if (convidadosNoiva < convidadosNoivo || convidadosNoivo > convidadosNoiva)
                Console.WriteLine("O número de convidados da noiva é inferior ao número de convidados do noivo");

            if (convidadosNoiva > convidadosNoivo || convidadosNoivo < convidadosNoiva)
                Console.WriteLine("O número de convidados da noiva é superior ao número de convidados do noivo");

            if (convidadosPresentesNoivo <= 400 && convidadosPresentesNoiva <= 400)
                Console.WriteLine("Não há penetras na festa. Número de convidados dentro do esperado.");

            if (convidadosPresentesNoiva > 400 || convidadosPresentesNoivo > 400)
                Console.WriteLine("Existem penetras pois o número de convidados presentes é maior que o numero de convidados do noivo ou da noiva.");

        }
    };
}
