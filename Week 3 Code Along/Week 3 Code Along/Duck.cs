using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Week_3_code_along
{
    class Goose
    {
        public string Name;
        public int Age;
        public int AttackDamage;

        public void Honque()
        {
            MessageBox.Show("Honque Honque, my fluffy baguette. I am Monsieur " + Name + ". I am " + Age + " white flags old.");
        }

        public void Dueling()
        {
            MessageBox.Show("I jab at you with my sabre, dealing " + AttackDamage + " honques of damage.");
        }
    }
}
