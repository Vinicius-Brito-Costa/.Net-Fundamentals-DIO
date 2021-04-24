using System;
namespace Metodos
{
    public class Ref
    {
        static void InverterREF(ref int x, ref int y){
            //Ref faz com que os valores sejam passado como referencia,
            //Assim qualquer alteração feita nesses valores, vai ser refletido nas
            // variaveis originais.
            int temp = x;
            x = y;
            y = temp;
        }
        public static void Inverter(){
            int a = 1, b = 2;
            Console.WriteLine($"Antes: A: {a} B: {b}");
            InverterREF(ref a, ref b);
            Console.WriteLine($"Depois: A: {a} B: {b}");
        }
    }
}