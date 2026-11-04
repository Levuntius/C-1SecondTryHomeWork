namespace C_1SecondTryHomeWork
{
    public class Turret
    {
        public Predicate<Enemy> TargetFilter { get; set; }
        public Func<Enemy, int> DamageFormula { get;  set; }
        public Action<Enemy> OnHit { get;  set; }

        public void TryShoot(Enemy enemy)
        {
            if (enemy == null) return;

            // фильтр цели
            if (TargetFilter == null || !TargetFilter.Invoke(enemy))
            {
                Console.WriteLine($"   Турель проигнорировала цель: {enemy.Name}");
                return;
            }

            // Расчет урона 
            int damage = DamageFormula != null ? DamageFormula.Invoke(enemy) : 0;

            // Выстрел и нанесение урона
            Console.WriteLine($">> Турель атакует цель: {enemy.Name}!");
            enemy.TakeDamage(damage);

            // Эффект попадания
            OnHit?.Invoke(enemy);
        }
    }
}
