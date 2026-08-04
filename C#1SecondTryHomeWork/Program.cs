namespace C_1SecondTryHomeWork;
using System;


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Бой начинается\n");

        Orc orc1 = new Orc("Орк1");
        Orc orc2 = new Orc("Орк2");

        Dragon dragon1 = new Dragon("Дракон1");
        Dragon dragon2 = new Dragon("Дракон2");

        Skeleton skeleton1 = new Skeleton("Скелет1");
        Skeleton skeleton2 = new Skeleton("Скелет2");

        Werewolf wolf1 = new Werewolf("Оборотень1");
        Werewolf wolf2 = new Werewolf("Оборотень2");

        Zombie zombie1 = new Zombie("Зомби1");
        Zombie zombie2 = new Zombie("Зомби2");

        Vampire vampire1 = new Vampire("Вампир1");
        Vampire vampire2 = new Vampire("Вампир2");

        orc1.Attack(dragon1);        
        skeleton1.Attack(orc1);      
        dragon2.Attack(skeleton1);   
        wolf1.Attack(zombie1);       
        vampire1.Attack(wolf1);    
        zombie2.Attack(vampire1);    
        orc2.Attack(skeleton2);      
        skeleton2.Attack(dragon2);   
        dragon1.Attack(orc2);        
        wolf2.Attack(vampire2);     
        vampire2.Attack(zombie2);    
        zombie1.Attack(wolf2);       
        orc1.Attack(vampire1);       
        vampire1.Attack(orc1);       
        skeleton1.Attack(zombie1);   
        dragon2.Attack(wolf1);       
        wolf1.Attack(dragon2);       
        zombie2.Attack(orc2);        
        orc2.Attack(zombie2);        
        vampire2.Attack(dragon1);    

        Console.WriteLine("Бой завершён");


        }
    }
