using System.Text;
using Self;

Console.OutputEncoding = Encoding.UTF8;
Console.ForegroundColor = ConsoleColor.Green;

if(today.self > yesterday.self)
{
    Console.WriteLine($"Tôi đã nổ lực hôm nay = {today.self} hơn hôm qua = {yesterday.self} !");
}
else
{
    Console.WriteLine("Tôi thất bại rồi!");
}
Console.ReadLine();
Console.ResetColor();