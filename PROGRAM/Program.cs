string[] array = { "hello", "2", "world", ":-)", "gg" };
int index = 0;
int count = 3;

while (index < array.Length)
{
    string str = array[index];
    char[] arr = str.ToCharArray();
    int i = 0;
    if (arr.Length <= count)
    {
        string result = new string(arr);
        System.Console.Write("[" + string.Join(", ", result) + "]");
        array[i]=result;
        i++;
        index++;
    }
    else
    {
        index++;
    }
    
    
}
