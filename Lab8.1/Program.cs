using System;
using System.IO;
using System.Xml.Serialization;
using Animal;

namespace part_01.seriakize
{
    class Programm
    {
        static void Main()
        {
            Pig pig = new Pig("Russia", "Beer", "Anatoliy", "Pig");

            pig.FavoriteFood = eFavoriteFood.Everything;
            pig.ClassificationAnimal = eClassificationAnimal.Herbivores;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Pig));

            using (FileStream fs = new FileStream("test.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, pig);

                Console.WriteLine("Object has been serialized");
            }

        }
    }
}