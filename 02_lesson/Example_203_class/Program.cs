// Example_203_class по алгоритму на лекции

int[] array = {80, 1, 52, 853, 4, 853, 36, 7785, 8};

int n = array.Length;
int find = 853;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}