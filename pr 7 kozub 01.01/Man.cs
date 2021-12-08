using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_7_kozub_01._01
{
    internal class Man
    {
        private string _name;
        private char _sex;
        private int _age;
        private int _weight;
        public string Name { get { return _name; } set { _name = value; } }

        public char Sex
        {
            get { return _sex; }
            set
            {
                if (value == 'М' || value == 'м' || value == 'Ж' || value == 'ж')
                    _sex = value;
                else throw new ArgumentException();
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException();
                else _age = value;
            }
        }


        public int Weight
        {
            get { return _weight; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException();
                else _weight = value;
            }
        }

        public Man()
        {
            _name = "Unnamed";
            _sex = Sex;
            _age = 0;
            _weight = 0;
        }

        public Man(string name, char sex, int age, int weight)
        {
            Name = name;
            Sex = sex;
            Age = age;
            Weight = weight;
        }


        public void SetParams(string name)
        {
            Name = name;
        }


        public static bool operator >(Man firstHuman, Man secondHuman)
        {
            if (firstHuman.Weight > secondHuman.Weight)
                return true;
            else return false;
        }

        public static bool operator <(Man firstHuman, Man secondHuman)
        {
            return firstHuman.Weight < secondHuman.Weight;
        }

        public static Man operator ++(Man human)
        {
            human.Age++;
            return human;
        }
    }
}
