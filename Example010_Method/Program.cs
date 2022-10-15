int[] array = { 18, 22, 83, 74, 15, 96, 857, 98, 96 };

int n = array.Length;
int find = 96;

int index = 0;
 while (index < n)
 {

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index = index + 1;
 }