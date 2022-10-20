
using System.Data;

Console.WriteLine("Введите список из 5 фамилий для сортировки");


List<String> array = new List<String>();

array.Add(Console.ReadLine());
array.Add(Console.ReadLine());
array.Add(Console.ReadLine());
array.Add(Console.ReadLine());
array.Add(Console.ReadLine());

Console.WriteLine("Ведите 1 для сортировки от А до Я или введите 2 для сортировки от Я до А");
byte value = 0;
try
{
    value = Convert.ToByte(Console.ReadLine());
    if (value == 1)
    {
        Sort(array);
    }
    else if (value == 2)
    {
        Sort(array);
        AntiSort(array);
    }
    if (value != 1 && value != 2)
        try
        {
            throw new MyException();
        }
        catch (MyException ex) { Console.WriteLine(ex.Message); }
}
catch (FormatException ex)
{

    Console.WriteLine("Введено не число");
}





void Sort(List<String> value)
{
    value.Sort();
    foreach (var item in value) Console.WriteLine(item);
}

void AntiSort(List<String> value)
{
    List<string> array2 = new List<string>();
    for (int i = value.Count - 1; i >= 0; i--)
    {
        array2.Add(value[i]);
    }
    Console.WriteLine("");
    foreach (var item in array2) Console.WriteLine(item);
}



public class MyException : System.FormatException
{
    public MyException() : base()
    {
        Console.WriteLine("Вы ввели не 1 и не 2!!!");
    }

}
