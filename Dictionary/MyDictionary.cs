using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class MyDictionary<nT, aT>
    {
        nT[] names;
        aT[] ages;

        public MyDictionary()
        {
            names = new nT[0];
            ages = new aT[0];
        }

        public int Count()
        {
            return names.Length;
        }

        public void Add(nT name, aT age)
        {
            nT[] tempNames = names;

            names = new nT[names.Length + 1];

            for (int i = 0; i < tempNames.Length; i++)
            {
                names[i] = tempNames[i];
            }
            names[names.Length - 1] = name;

            aT[] tempAges = ages;

            ages = new aT[ages.Length + 1];

            for (int j = 0; j < tempAges.Length; j++)
            {
                ages[j] = tempAges[j];
            }

            ages[ages.Length - 1] = age;

            Console.WriteLine(name + " " + age);
        }

    }
}
