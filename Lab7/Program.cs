using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;

class Program 
{
    static void Main()
    {

        // Phần a
        Console.WriteLine("Binh phuong cua cac so lon hon 4:");
        List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 8, 9 };
        var kq1 = nums.Where(x => x > 4).Select(x => x);
        foreach (var num in kq1)
        {
            Console.WriteLine(num + " ");
        }

        // Cach 2 
        var kq2 = from n in nums
                  where n > 4
                  select n * n;
        foreach (var num in kq2)
        {
            Console.WriteLine(num + " ");
        }

        // Phần b
        Console.WriteLine("So lan xuat hien cua tung chu:");
        string strB = "chao mung den voi binh nguyen vo tan";
        var charCount = strB.Replace(" ", "")
                            .GroupBy(c => c)
                            .ToDictionary(g => g.Key, g => g.Count());

        foreach (var kvp in charCount)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        // Phần c
        Console.WriteLine("Nhung chuoi duoc viet hoa toan bo:");
        string strC = "CHAO mung DEN Voi binh nguyen vo tan";
        var upperWords = strC.Split(' ')
                             .Where(word => word.All(char.IsUpper));

        foreach (var word in upperWords)
        {
            Console.WriteLine(word);
        }
    }
}