using System;

namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Выберите питомца:
1 - Собака,
2 - Кот");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Dog sharik = new Dog();
                sharik.Name = "Шарик";
                sharik.Age = 5;
                sharik.Health = 100;
                Console.WriteLine(sharik.GetInfo());
                Console.WriteLine(@"Выберите действие:
1-убрать здоровье,
2-поднять здоровье");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        Console.WriteLine("На сколько hp вы хотите понизить здоровье?");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int b = sharik.Health - x;
                        Console.WriteLine($"У вашего питомца осталось {b} здоровья. Я думаю вам следуюет его полечить");
                        if (b <= 0)
                        {
                            Console.WriteLine("Ваш питомец умер (");
                        }
                        break;
                    case "2":
                        Console.WriteLine("На сколько hp вы хотите поднять здоровье?");
                        int y = Convert.ToInt32(Console.ReadLine());
                        int j = sharik.Health + y;
                        Console.WriteLine($"Ура , вы полечили питомца , у него осталось {j} здоровья.");
                        Console.WriteLine("На сколько hp вы хотите поднять здоровье?");
                        int i = Convert.ToInt32(Console.ReadLine());
                        int k = sharik.Health + y;
                        Console.WriteLine($"Ура , вы полечили питомца , у него осталось {k} здоровья.");
                        break;
                }
            }
            //Dog sharik = new Dog();
            //sharik.Name = "Шарик";
            //sharik.Age = 5;
            //sharik.Health = 100;
            //Console.WriteLine(sharik.GetInfo());
            else if (a == 2)
            {
                Cat pushok = new Cat();
                pushok.Name = "Пушок";
                pushok.Age = 3;
                pushok.Health = 100;
                Console.WriteLine(pushok.GetInfo());
                Console.WriteLine(@"Выберите действие:
1-убрать здоровье,
2-поднять здоровье");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        Console.WriteLine("На сколько hp вы хотите понизить здоровье?");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int b = pushok.Health - x;
                        Console.WriteLine($"У вашего питомца осталось {b} здоровья. Я думаю вам следуюет его полечить");
                        if (b <= 0)
                        {
                            Console.WriteLine("Ваш питомец умер (");
                        }
                        break;
                    case "2":
                        Console.WriteLine("На сколько hp вы хотите поднять здоровье?");
                        int y = Convert.ToInt32(Console.ReadLine());
                        int j = pushok.Health + y;
                        Console.WriteLine($"Ура , вы полечили питомца , у него осталось {j} здоровья.");
                        Console.WriteLine("На сколько hp вы хотите поднять здоровье?");
                        int i = Convert.ToInt32(Console.ReadLine());
                        int k = pushok.Health + y;
                        Console.WriteLine($"Ура , вы полечили питомца , у него осталось {k} здоровья.");
                        break;
                }
            }
            //pushok.Name = "Пушок";
            //pushok.Age = 3;
            //pushok.Health = 100;
            //Console.WriteLine(pushok.GetInfo());

//            Console.WriteLine(@"Выберите действие:
//1-убрать здоровье,
//2-поднять здоровье");
//            string action = Console.ReadLine();
//            switch (action)
//            {
//                case "1":
//                    Console.WriteLine("На сколько hp вы хотите понизить здоровье?");
//                    int x = Convert.ToInt32(Console.ReadLine());
//                    int b = sharik.Health - x;
//                    Console.WriteLine($"У вашего питомца осталось {b} здоровья. Я думаю вам следуюет его полечисть");
//                    if (b < 0)
//                    {
//                        Console.WriteLine("Ваш питомец умер (");
//                    }
//                    break;
//                case "2":
//                    Console.WriteLine("На сколько hp вы хотите поднять здоровье?");
//                    int y = Convert.ToInt32(Console.ReadLine());
//                    int j = sharik.Health + y;
//                    Console.WriteLine($"Ура , вы полечили питомца , у него осталось {j} здоровья.");
//                    Console.WriteLine("На сколько hp вы хотите поднять здоровье?");
//                    int i = Convert.ToInt32(Console.ReadLine());
//                    int k = sharik.Health + y;
//                    Console.WriteLine($"Ура , вы полечили питомца , у него осталось {k} здоровья.");
//                    break;
//            }
           





        }
    }
}
