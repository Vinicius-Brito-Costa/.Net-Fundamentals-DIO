namespace Heranca
{
    public class Ponto3D : Ponto
    {
        public int z;
        //base traz a execução original para o filho
        public Ponto3D(int x, int y, int z) : base (x, y){
            this.z = z;
            CalcularDistancia();
        }
        public static int Calcular(int x, int y, int z){
            return x + y + z;
            //Metodos estaticos não são acessiveis atraves da instancia
            /*
                Ponto3D p1 = new Ponto3D(3, 2, 1);
                p1.Calcular(10, 15, 20) ERRADO

                Ponto3D.Calcular(10, 15, 20) CERTO
            */
        }
        public override void CalcularDistancia3()
        {
            // Esse método foi criado na classe pai, mas por ser do tipo "virtual"
            // ele pode ser sobreescrito com outras funcionalidades.
            // Caso queira apenas extender oque ele já fazia antes
            // você pode utilizar base.CalcularDistancia3() para trazer as antigas funcionalidades.
        }
    }
}