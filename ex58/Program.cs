int [,] Created1Array (int rows, int columns, int minV, int maxV)
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
int [,] Created2Array (int rows, int columns, int minV, int maxV)
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

int [,] MultiMatrix(int [,] fisrtMatrix, int [,] secondMatrix)
{
    int [,] multi = new int [fisrtMatrix.GetLength(0), secondMatrix.GetLength(1)];
    if(fisrtMatrix.GetLength(1) != secondMatrix.GetLength(0))
        Console.WriteLine("wrong size of array");
    else 
    {
    
    for (int i = 0; i < fisrtMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            multi[i,j] = 0;
        for (int n = 0; n < fisrtMatrix.GetLength(1); n++)
        {
            
            multi[i,j] += fisrtMatrix[i,n] * secondMatrix[n,j];
        }
        }
    }
    }
    return multi;
}


Console.Write("input count of rows first array: ");
int user_firstRows = Convert.ToInt32(Console.ReadLine());
Console.Write("input count of columns first array: ");
int user_firstColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("input minimum value of first array: ");
int user_firstMin = Convert.ToInt32(Console.ReadLine());
Console.Write("input maximum value of first array: ");
int user_firstMax = Convert.ToInt32(Console.ReadLine());

Console.Write("input count of rows second array: ");
int user_secondRows = Convert.ToInt32(Console.ReadLine());
Console.Write("input count of columns second array: ");
int user_secondColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("input minimum value of second array: ");
int user_secondMin = Convert.ToInt32(Console.ReadLine());
Console.Write("input maximum value of second array: ");
int user_secondMax = Convert.ToInt32(Console.ReadLine());

int [,] my1Array = Created1Array(user_firstRows, user_firstColumns, user_firstMin, user_firstMax);
int [,] my2Array = Created2Array(user_secondRows, user_secondColumns, user_secondMin, user_secondMax);
ShowArray(my1Array);
ShowArray(my2Array);
ShowArray(MultiMatrix(my1Array,my2Array));