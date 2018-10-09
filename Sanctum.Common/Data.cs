using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanctum.Common
{
    public struct AttributeData
    {
        int Strength;
        int Agility;
        int Intellect;
        int Charisma;
        int Constitution;
        int Wisdom;

        public AttributeData(int strength, int agility, int intellect, int charisma, int constitution, int wisdom)
        {
            this.Strength = strength;
            this.Agility = agility;
            this.Intellect = intellect;
            this.Charisma = charisma;
            this.Constitution = constitution;
            this.Wisdom = wisdom;
        }

        #region "Operator Overloads"
        public static AttributeData operator -(AttributeData d1)
        {
            return new AttributeData(-d1.Strength, -d1.Agility, -d1.Intellect, -d1.Charisma, -d1.Constitution, -d1.Wisdom);
        }

        public static AttributeData operator +(AttributeData d1, AttributeData d2)
        {
            return new AttributeData(d1.Strength + d2.Strength, d1.Agility + d2.Agility, d1.Intellect + d2.Intellect, d1.Charisma + d2.Charisma, d1.Constitution + d2.Constitution, d1.Wisdom + d2.Wisdom);
        }

        public static AttributeData operator -(AttributeData d1, AttributeData d2)
        {
            return d1 + (-d2);
        }

        public static AttributeData operator *(AttributeData d1, int n)
        {
            return new AttributeData(d1.Strength * n, d1.Agility * n, d1.Intellect * n, d1.Charisma * n, d1.Constitution * n, d1.Wisdom * n);
        }
        #endregion
    }

    public struct ElementData
    {
        float Fire { get; set; }
        float Earth { get; set; }
        float Air { get; set; }
        float Water { get; set; }

        float Light { get; set; }
        float Darkness { get; set; }

        public ElementData(float fire, float earth, float air, float water, float light, float darkness)
        {
            this.Fire = fire;
            this.Earth = earth;
            this.Air = air;
            this.Water = water;
            this.Light = light;
            this.Darkness = darkness;
        }

        #region "Operator Overloads"
        public static ElementData operator-(ElementData d1)
        {
            return new ElementData(-d1.Fire, -d1.Earth, -d1.Air, -d1.Water, -d1.Light, -d1.Darkness);
        }

        public static ElementData operator+(ElementData d1, ElementData d2)
        {
            return new ElementData(d1.Fire + d2.Fire, d1.Earth + d2.Earth, d1.Air + d2.Air, d1.Water + d2.Water, d1.Light + d2.Light, d1.Darkness + d2.Darkness);
        }

        public static ElementData operator -(ElementData d1, ElementData d2)
        {
            return d1 + (-d2);
        }

        public static ElementData operator *(ElementData d1, float n)
        {
            return new ElementData(d1.Fire * n, d1.Earth * n, d1.Air * n, d1.Water * n, d1.Light * n, d1.Darkness * n);
        }
        #endregion
    }

    public struct LocationData
    {
        uint Map { get; set; }
        uint X { get; set; }
        uint Y { get; set; }

        #region "Serialization"
        public string Serialize()
        {
            return string.Format("{0},{1},{2}", Map, X, Y);
        }

        public static LocationData Deserialize(string data)
        {
            string[] location = data.Split(',');

            return new LocationData() { Map = Convert.ToUInt32(location[0]), X = Convert.ToUInt32(location[1]), Y = Convert.ToUInt32(location[2]) };
        }
        #endregion
    }
}
