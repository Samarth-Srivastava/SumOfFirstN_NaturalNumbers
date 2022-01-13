using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
        string number_str = Console.ReadLine();
        int N = Convert.ToInt32(number_str);

        Console.WriteLine((N*(N+1))/2);
    }
}
