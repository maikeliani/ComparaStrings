internal class Program
{
    private static void Main(string[] args)
    {   string textoA, textoB;

        Console.WriteLine(" Informe o primeiro texto: ");
        textoA = Console.ReadLine();

        Console.WriteLine(" \nInforme o segundo texto para comparação: ");
        textoB = Console.ReadLine();

        Console.WriteLine(ComparaStrings(textoA, textoB));


        string ComparaStrings(string a, string b)
        {
            
            if (a.Equals(b))
            {
                return " As strings são iguais";
            }
            return " São diferentes";
        }


    }


}