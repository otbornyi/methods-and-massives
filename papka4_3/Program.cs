int[] array = {12, 73, 11, 83, 85, 93};
int n = array.Length;
int find = 85;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    Console.WriteLine(index);
    index++;
}