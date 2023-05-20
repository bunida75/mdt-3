class Program
{
    static void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.Write("Enter an operator (+/-) or any other character to exit: ");
            char operatorChar = Convert.ToChar(Console.ReadLine());

            if (operatorChar == '+' || operatorChar == '-')
            {
                Console.Write("Enter the size of the matrix: ");
                int size = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a real number: ");
                double realNumber = Convert.ToDouble(Console.ReadLine());

                double[,] matrix = new double[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write("Enter a value for matrix[{0},{1}]: ", i, j);
                        matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                }

                if (operatorChar == '+')
                {
                    AddMatrix(matrix, realNumber);
                }
                else if (operatorChar == '-')
                {
                    SubtractMatrix(matrix, realNumber);
                }
            }
            else
            {
                continueProgram = false;
            }
        }
    }

    static void AddMatrix(double[,] matrix, double realNumber)
    {
        int size = matrix.GetLength(0);

        Console.WriteLine("Result:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                double result = matrix[i, j] + realNumber;
                Console.Write("{0} ", result);
            }
            Console.WriteLine();
        }
    }

    static void SubtractMatrix(double[,] matrix, double realNumber)
    {
        int size = matrix.GetLength(0);

        Console.WriteLine("Result:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                double result = matrix[i, j] - realNumber;
                Console.Write("{0} ", result);
            }
            Console.WriteLine();
        }
    }
}
