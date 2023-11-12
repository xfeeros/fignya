using System;

class Program1
{
    public static void SomeMethod()
    {
        // Создаем экземпляр класса Soldier, который является наследником абстрактного класса Unit
        Soldier soldier = new Soldier();

        // Устанавливаем значения свойств экземпляра
        soldier.Name = "Пехотинец";
        soldier.Damage = 25;
        soldier.Health = 70;

        // Вызываем метод экземпляра для вывода информации о персоне
        soldier.PrintInfo();
    }
}

// Абстрактный класс Unit
abstract class Unit
{
    // Свойства абстрактного класса Unit
    public string Name { get; set; }
    public int Damage { get; set; }
    public int Health { get; set; }

    // Абстрактный метод для вывода информации о персоне
    public abstract void PrintInfo();
}

// Класс Soldier наследуется от абстрактного класса Unit
class Soldier : Unit
{
    // Реализация метода для вывода информации о персоне
    public override void PrintInfo()
    {
        Console.WriteLine($"Имя: {Name}");
        Console.WriteLine($"Урон: {Damage}");
        Console.WriteLine($"Здоровье: {Health}");
    }
}