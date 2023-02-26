int [,] CreatedArray (int rows, int columns, int minV, int maxV)
{
    
    int [,] createdArray = new int[rows,columns];
    for (int i =0; i< rows; i++)
    {
        for (int j =0; j < columns; j++)
        {
            createdArray[i,j] = new Random().Next(minV, maxV+1);
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

void  FindNumbers (int [,] array, int minV,int maxV)
{
    for (int k = minV; k < maxV; k++)
    {
        int count =0 ;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
                if (k == array[i,j] )
                {
                count ++;
                }
        }
    }
        if (count!=0)
           Console.WriteLine($"number {k} meets {count} times");
    }
}

Console.Write("input count of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input count of columns: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input minimum value: ");
int user_min = Convert.ToInt32(Console.ReadLine());
Console.Write("input maximum value: ");
int user_max = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreatedArray(user_rows, user_columns, user_min, user_max);
ShowArray(myArray);
FindNumbers(myArray, user_min, user_max);