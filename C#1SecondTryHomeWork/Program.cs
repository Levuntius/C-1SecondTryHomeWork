namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;


            {
                int health = 100;
                int mana = 100;
                int level = 1;

                // вывод характеристик
                void ShowStats()
                {
                    Console.WriteLine("=== Характеристики персонажа ===");
                    Console.WriteLine($"Уровень: {level}");
                    Console.WriteLine($"Здоровье: {health}");
                    Console.WriteLine($"Мана: {mana}");
                    Console.WriteLine("================================");
                }

                // получение урона
                int TakeDamage(int damage)
                {
                    health -= damage;
                    if health < 0
                        health = 0;
                    return health;
                }

                // лечение на 5 HP
                void Heal()
                {
                    health += 5;
                    if health > 100
                        health = 100;
                }

                // лечение на определённое значение
                void Heal(int amount)
                {
                    health += amount;
                    if health > 100
                        health = 100;
                }

                // использование заклинания
                bool UseSpell(int manaCost, out int newMana)
                {
                    if (mana >= manaCost)
                    {
                        mana -= manaCost;
                        newMana = mana;
                        return true;
                    }
                    else
                    {
                        newMana = mana;
                        return false;
                    }
                }

                // повышение уровня
                void LevelUp()
                {
                    level++;
                    health = 100;
                    mana = 100;
                }

                // отображение характеристик
                while (true)
                {
                    Console.WriteLine("\nВыберите действие:");
                    Console.WriteLine("1  Показать характеристики");
                    Console.WriteLine("2  Получить урон");
                    Console.WriteLine("3  Вылечиться");
                    Console.WriteLine("4  Использовать заклинание");
                    Console.WriteLine("5  Повысить уровень");
                    Console.WriteLine("0  Выход");

                    Console.Write("Ваш выбор: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            ShowStats();
                            break;

                        case "2":
                            Console.Write("Введите величину урона: ");
                            int dmg = int.Parse(Console.ReadLine());
                            int newHp = TakeDamage(dmg);
                            Console.WriteLine($"Персонаж получил урон. Новое здоровье: {newHp}");
                            break;

                        case "3":
                            Console.WriteLine("1  Лечение на 5 HP");
                            Console.WriteLine("2  Лечение на заданное значение: ");
                            string healChoice = Console.ReadLine();

                            if (healChoice == "1")
                            {
                                Heal();
                                Console.WriteLine($"Здоровье восстановлено на 5. Текущее здоровье: {health}");
                            }
                            else if (healChoice == "2")
                            {
                                Console.Write("Введите количество HP для восстановления: ");
                                int healAmount = int.Parse(Console.ReadLine());
                                Heal(healAmount);
                                Console.WriteLine($"Здоровье восстановлено. Текущее здоровье: {health}");
                            }
                            break;

                        case "4":
                            Console.Write("Введите стоимость заклинания по мане: ");
                            int cost = int.Parse(Console.ReadLine());
                            bool used = UseSpell(cost, out int newManaValue);

                            if (used)
                                Console.WriteLine($"Заклинание использовано! Новая мана: {newManaValue}");
                            else
                                Console.WriteLine("Недостаточно маны для заклинания.");
                            break;

                        case "5":
                            LevelUp();
                            Console.WriteLine("Уровень повышен! Здоровье и мана восстановлены.");
                            break;

                        case "0":
                            return;

                        default:
                            Console.WriteLine("Неизвестная команда.");
                            break;
                    }
                }
            }
        }


    }
}
}
