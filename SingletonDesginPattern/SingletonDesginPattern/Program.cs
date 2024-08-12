// See https://aka.ms/new-console-template for more information
using SingletonDesginPattern;

Console.WriteLine("Hello, World!");

var intance1 = SingeltonClass.Instance;
var intance2 = SingeltonClass.Instance;
if(intance1== intance2)
{
    Console.WriteLine("Same Instance");
}
Console.ReadLine();
