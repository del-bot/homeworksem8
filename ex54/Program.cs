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

int [,] arrayRowsChange (int [,] arrayStart)
{
    for (int i = 0; i < arrayStart.GetLength(0); i++)
    {
        for (int j = 0; j < arrayStart.GetLength(1); j++)
        {
            for (int k =0; k < arrayStart.GetLength(1)-1; k++)
        {
            if (arrayStart[i, k] < arrayStart[i, k+1] )
                {
                    int temp = arrayStart[i, k+1];
                    arrayStart[i, k+1] = arrayStart[i, k];
                    arrayStart[i,k] = temp;
                }
        }
        }
    }
   return arrayStart;
}

int [,] myArray = CreatedArray();
ShowArray(myArray);
ShowArray(arrayRowsChange(myArray));
