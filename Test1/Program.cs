using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main()
    {
        // Создаем экземпляр класса Person
        Person personality = new Person();

        // Устанавливаем значения свойств экземпляра
        personality.Name = "Пехотинец";
        personality.Damage = 25;
        personality.Health = 70;
        // Вызываем метод экземпляра для вывода информации о персоне
        personality.PrintInfo();
    }
}

class Person
{
    // Свойства класса Person
    public string Name { get; set; }
    public int Damage { get; set; }
    public int Health  { get; set; }
    // Метод для вывода информации о персоне
    public void PrintInfo()
    {
     Console.WriteLine($"Имя: {Name}");
     Console.WriteLine($"Урон: {Damage}");
     Console.WriteLine($"Здоровье: {Health}");
    }
}

abstract class Person1
{
    public string Name1 { get; protected set; }
    public int Damage1 { get; protected set; }
    public int Health1 { get; protected set; }

    public void PrintInfo1()
    {
        Console.WriteLine($"Имя1: {Name1}");
        Console.WriteLine($"Урон1: {Damage1}");
        Console.WriteLine($"Здоровье1: {Health1}");
    }
}