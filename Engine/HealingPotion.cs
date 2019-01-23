using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // HealingPoition est un enfant d'Item
    public class HealingPotion : Item
    {
        public int AmountToHeal { get; set; }

        public HealingPotion(int id, string name, string namePlural, int amountToHeal) : base(id, name, namePlural)
        {
            AmountToHeal = amountToHeal;
        }
    }
}
