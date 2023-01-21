// Задача 43. Найти точку пересечения двух прямых
Console.Clear();

Console.WriteLine("Задайте точку b1");
decimal b1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Задайте точку k1");
decimal k1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Задайте точку b2");
decimal b2 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Задайте точку k2");
decimal k2 = Convert.ToDecimal(Console.ReadLine());

if (b1 == b2 && k1 == k2){
    Console.WriteLine("Эти линии параллельны. Они имеют бесконечное множество точек.");
} else {
    decimal x = (b2 - b1) / (k1 - k2);
    decimal y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения {x}; {y}");
}
