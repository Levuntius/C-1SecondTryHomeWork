using System;
using System.Collections.Generic;
namespace C_1SecondTryHomeWork

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем список врагов
            List<Enemy> enemies = new List<Enemy>
            {
                new Enemy("Пехотинец-гоблин", 50, false),
                new Enemy("Бронированный огр", 150, false),
                new Enemy("Летающий дракон", 100, true)
            };

            Turret turret = new Turret();

            Console.WriteLine("=== Раунд 1: Обычный режим (Охранник) ===");
            // Фильтр: стрелять по всем без исключения
            turret.TargetFilter = (enemy) => true;
            // Урон: фиксированные 25 единиц
            turret.DamageFormula = (enemy) => 25;
            // Эффект: стандартный трассирующий выстрел
            turret.OnHit = (enemy) => Console.WriteLine("трассирующий выстрел");

            foreach (var enemy in enemies)
            {
                turret.TryShoot(enemy);
            }

            Console.WriteLine("\n Раунд 2: Режим ПВО (Смена фильтра Predicate) ");
            // Фильтр: атакуем исключительно летающих
            turret.TargetFilter = (enemy) => enemy.IsFlying;

            // Прогоняем наземного огра и летающего дракона
            turret.TryShoot(enemies[1]); // Огр (должен быть проигнорирован)
            turret.TryShoot(enemies[2]); // Дракон (должен быть атакован)

            Console.WriteLine("\nРаунд 3: Босс-киллер (Смена формулы и эффекта)");
            // Фильтр атакуем всех, у кого HP больше 100
            turret.TargetFilter = (enemy) => enemy.Hp > 100;
            // Критический урон
            turret.DamageFormula = (enemy) => (int)(enemy.Hp * 0.3) + 10;
            // плазменный взрыв, уменьшающий броню
            turret.OnHit = (enemy) => Console.WriteLine("Плазменный взрыв! Зафиксирован критический всплеск энергии.");

            // Проверяем на оставшихся в живых врагах
            foreach (var enemy in enemies)
            {
                turret.TryShoot(enemy);
            }
        }



    }
}