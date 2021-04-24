namespace Metodos
{
    public class Out
    {
        static (int, int) DividirOUT(int x, int y, out int resultado, out int resto){
            resultado = x / y;
            resto = x % y;
            //Out faz com que as variaveis sejam criadas e preenchidas
            //Assim com a execução deste método temos duas novas variaveis já populadas
            return (resultado, resto); //Tambem podemos utilizar o return para retornar mais de um valor
        }
        public static void Dividir(){
            int resultado = 0;
            int resto = 1;
            System.Console.WriteLine($"Antes: RESULTADO: {resultado} RESTO: {resto}");
            int res, rest;
            (res, rest) = DividirOUT(15, 4, out resultado, out resto);
            System.Console.WriteLine($"Depois com out: RESULTADO: {res} RESTO: {rest}");
            System.Console.WriteLine($"Depois com return: RESULTADO: {resultado} RESTO: {resto}");
        }

    }
}