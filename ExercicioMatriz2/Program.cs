internal class Program
{
    private static void Main(string[] args)
    {

        int[,] m = new int[5,5];
        Random sorteio = new Random();

        //Carregar valores na matriz
        for (int c = 0; c < m.GetLength(1); c++)
        {  
            for (int l = 0; l < m.GetLength(0); l++)
            {
                m[l, c] = sorteio.Next(10000);
            }
        }

        //Gerar números aleatórios
        for (int l = 0; l < m.GetLength(0); l++)
        {
            for (int c = 0; c < m.GetLength(1); c++)
            {
                Console.Write("\tm" + "[" + l + "," + c + "]" + "=" + m[l, c]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("Soma das linhas...");
        for (int l = 0; l<m.GetLength(0); l++) //Fixei a linha
        {
            Console.Write("Soma da linha [" + l + "]= ");

            int somalinha = 0;

            for(int c=0; c<m.GetLength(1); c++)//Percorreu as colunas dessa linha
            {
                somalinha = somalinha + m[l, c];
            }
            Console.WriteLine(somalinha);
        }

        Console.WriteLine();

        Console.WriteLine("Soma das colunas...");
        for (int c = 0; c < m.GetLength(1); c++) //Fixei a coluna
        {
            Console.Write("Soma da coluna [" + c + "]= ");

            int somacoluna = 0;

            for (int l = 0; l < m.GetLength(0); l++) //Percorreu as linhas dessa coluna
            {
                somacoluna = somacoluna + m[l, c];
            }
            Console.WriteLine(somacoluna);
        }

        Console.WriteLine();

        Console.WriteLine("Soma da diagonal principal...");
        int diagonal = 0;
        for (int c = 0; c < m.GetLength(1); c++) //Fixei a coluna
        {
            diagonal = diagonal + m[c, c]; 
        }
        Console.WriteLine(diagonal);
        Console.WriteLine();

        Console.WriteLine("Soma da diagonal secundária...");
        int diagonalsecundaria = 0;
        for (int c = 0; c < m.GetLength(1); c++) //Fixei a coluna
        {
            diagonalsecundaria = diagonalsecundaria + m[c, m.GetLength(1)-c-1];
        }
        Console.WriteLine(diagonalsecundaria);
    }
}