namespace Exercicios
{
    class ConversorDeMoeda
    {
        static double iof = 1.06;
        
        public static double ValorTotal(double cotacao, double qtdDolares)
        {
            return cotacao * qtdDolares * iof;
        }
    }
}
