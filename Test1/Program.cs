using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    public static void SomeOtherMethod()
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