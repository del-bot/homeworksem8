int [, , ] CreatedArray (int xIndex, int yIndex, int zIndex )
{
    
    int [, ,] createdArray = new int[xIndex, yIndex, zIndex];
    for (int i =0; i< xIndex; i++)
    {
        for (int j =0; j < yIndex; j++)
        {
            for (int n=0; n < zIndex; n++ )
            createdArray[i,j,n] = new Random().Next(10, 100);
        }
    }
    return createdArray;
}

void ShowArray (int [,,] array, int xIndex, int yIndex, int zIndex)
{
    for (int i = 0; i < xIndex; i++)
    {
        for (int j = 0; j < yIndex; j++)
        for (int n = 0; n < zIndex; n++ )
        {
        {
            Console.Write(array[i,j,n] + " " + $"({i}, {j}, {n})");
        }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("input size of x index: ");
int user_xIndex = Convert.ToInt32(Console.ReadLine());
Console.Write("input size of y index: ");
int user_yIndex = Convert.ToInt32(Console.ReadLine());
Console.Write("input size of z index: ");
int user_zIndex = Convert.ToInt32(Console.ReadLine());

int [,,] myArray = CreatedArray(user_xIndex, user_yIndex, user_zIndex);
ShowArray(myArray, user_xIndex, user_yIndex, user_zIndex);

