using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sanctum.Common;

namespace Sanctum.Pub
{
    public class Item : PubItem
    {
        string Name { get; set; }
        string Description { get; set; }

        uint Weight { get; set; }
        uint Value { get; set; }

        bool Droppable { get; set; }
        bool Sellable { get; set; }

        uint LevelRequirement { get; set; }

        ItemType Type { get; set; }

        AttributeData Attributes { get; set; }
        ElementData Elements { get; set; }

        // Consumable
        ItemConsumableType ConsumableType { get; set; }
        int Health { get; set; }
        int Mana { get; set; }

        LocationData WarpLocation { get; set; }

        string UseText { get; set; }

        // Equippable
        ItemEquippableType EquippableType { get; set; }
        bool Cursed { get; set; }

        uint MinimumDamage { get; set; }
        uint MaximumDamage { get; set; }

        // Book
        uint BookDialog { get; set; }
    }
}
