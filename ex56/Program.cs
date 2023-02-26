int [,] CreatedArray ()
{
    Console.Write("input count of rows: ");
    int user_rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input count of columns: ");
    int user_columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input minimum value: ");
    int user_min = Convert.ToInt32(Console.ReadLine());
    Console.Write("input maximum value: ");
    int user_max = Convert.ToInt32(Console.ReadLine());
    int [,] createdArray = new int[user_rows,user_columns];
    for (int i =0; i< user_rows; i++)
    {
        for (int j =0; j < user_columns; j++)
        {
            createdArray[i,j] = new Random().Next(user_min, user_max+1);
        }
    }
    return createdArray;
}

void ShowArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,]sumofArray (int [,] array)
{
    int sum = 100000;   
    int idex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int mean = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            {
                mean = mean + array[i,j];
            }
        if (mean < sum)
        {
            sum = mean;
            idex = i;
        }
         
    }
    Console.Write(idex+1);
    return array;
}

int [,] myArray = CreatedArray();
ShowArray(myArray);
sumofArray(myArray);