using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanctum.Common
{
    public enum ItemType : int
    {
        Miscellaneous = 0,
        Consumable = 1,
        Equippable = 2,
        Book = 3,
        Scripted = 4
    }

    public enum ItemConsumableType : int
    {
        Potion = 0,
        Skill = 1,
        Warp = 2
    }

    public enum ItemEquippableType : int
    {
        Clothing = 0,
        Primary = 1,
        Secondary = 2,
        Head = 3,
        Shoes = 4,
        Ring = 5,
        Artifact = 6
    }

    public enum ItemRarityType : int
    {
        Common = 0,
        Uncommon = 1,
        Rare = 2,
        Epic = 3,
        Legendary = 4,

        Junk = 5,
        Quest = 6,

        Collectable = 7

    }
}
