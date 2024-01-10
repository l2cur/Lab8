using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Xml.Serialization;
using Animal;


namespace Part1_deserilizar
{
    class Programm
    {
        static void Main()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Pig));

            using (FileStream fs = new FileStream("C:\\Users\\XPPro\\Desktop\\Programs\\3sem\\Lab8.1\\Lab8.1\\bin\\Debug\\test.xml", FileMode.Open))
            {
                Pig pig = xmlSerializer.Deserialize(fs) as Pig;
                Console.WriteLine($"Type: {pig?.WhatAnimal}, Name: {pig?.Name}, Country: {pig?.Country}, Hide from: {pig.HideFromOtherAnimal}, Favorite food: {pig.FavoriteFood}");
            }
        }
    }
}
