using System;

class Program {
    static void Main() {
        double n1 = double.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine());
        double n3 = double.Parse(Console.ReadLine());
        double media = (n1 + n2 + n3) / 3;
        Console.WriteLine(media);
    }
}
