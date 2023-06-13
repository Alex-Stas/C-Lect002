int[] array = { 11, 29, 13, 27, 55, 16, 27, 78, 19 };

int n = array.Length;

int find = 27;
int index = 0;

while (index < n )
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    } 
    // index = index + 1;
    index++;
}

