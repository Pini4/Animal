using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Cat
    {
        public string Name;
        public int Age;
        public int Health;
        
        public string GetTalk()
        {
            return "Гав-Гав!";
        }
        public string GetDamage()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Health = 100;

            int b = Health - x;
            return $"У вашего пса осталось {b} здоровья. Я думаю вам следуюет его полечисть";
            
        }
        public string GetHealh()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Health = 100;

            int j = Health + x;
            return $"Ура!Вы полечили собаку , теперь у него {j} здоровья";
        }
        public string GetInfo()
        {
            return $"Кот по кличке {Name} с возрастом {Age} имеет {Health} здоровья";
        }
        
    }
    
}
