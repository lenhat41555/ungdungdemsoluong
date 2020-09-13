using System;

namespace ungdungdemsoluong
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
int[] array;
do
{
     Console.WriteLine("Nhập kích thước:");
     size = Int32.Parse(Console.ReadLine());
     if (size > 30)
        Console.WriteLine("kích thước không được vượt quá 30");

} while (size > 30);
array = new int[size];
 int i = 0;
 while (i < array.Length) 
 {
     Console.WriteLine("nhập điểm cho học sinh " + (i + 1) + ": ");
     array[i] =  Int32.Parse(Console.ReadLine());
     i++;
 }
 int count = 0;
Console.WriteLine("danh sách nhãn hiệu: ");
 for (int j = 0; j < array.Length; j++) 
 {
     Console.WriteLine(array[j] + "\t");
     if (array[j] >= 5 && array[j] <= 10)
         count++;
 }
 Console.WriteLine("\n số học sinh thi đậu là " + count);
        }
    }
}
