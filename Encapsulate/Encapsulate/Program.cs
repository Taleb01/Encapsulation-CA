﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Program
    {
        static void Main(string[] args)
        {

            PersonHandler ph = new PersonHandler();
            List<Person> personList = new List<Person>();

            personList.Add(ph.CreatePerson(lName: "Ceasar", fName: "Billy", age: 18, weight: 280, height: 170));
            personList.Add(ph.CreatePerson(90, "Karl", "Ceasar", 190, 70));
            personList.Add(ph.CreatePerson(8, "Ricard", "O'lamp", weight: 80));
            personList.Add(ph.CreatePerson(180, "Old", "Man", 130, 60));
            personList.Add(ph.CreatePerson(37, "Brark", "Hoblama", 190, 110));

            foreach (Person p in personList)
            {
                Console.WriteLine(ph.PrintPerson(p));
            }
            Console.ReadLine();




            Console.Clear(); // stop print out personal class


            List<Animal> animals = new List<Animal>();
            Horse horsy = new Horse(true, 3000, "Devil Hourse", true);
            Dog dogy = new Dog(false, 4, "Dopper-man", 0);
            Pelican pely = new Pelican(true, 10, "flappy-big-mouth", 120, true);
            Swan rageMonster = new Swan(true, 900000000, "white-hot-rage", 300, 239);
            animals.Add(horsy);
            animals.Add(dogy);
            animals.Add(pely);
            animals.Add(rageMonster);

            foreach (Animal a in animals)
            {
                // Console.WriteLine(a.stats());
                Console.WriteLine(a.GetType().Name); //show actual name of the animal
            }

            Console.ReadLine();
            List<Dog> dogs = new List<Dog>();
            Dog dogy2 = new Dog(true, 12, "Wulf", 10);
            Dog dogy3 = new Dog(false, 7, "Poddle", 3);
            dogs.Add(dogy);
            dogs.Add(dogy2);
            dogs.Add(dogy3);
            animals.Add(dogy3);


            //foreach(Dog a in dags) you will get dog list 
            foreach (Animal a in animals)
            {
                if (a.GetType().Name == "Dog")
                    Console.WriteLine(a.Stats());
            }
            Console.ReadLine();
            Console.Clear();

            foreach (Animal a in animals.OfType<Dog>())
            {

                Console.WriteLine(a.Stats());
            }
            Console.ReadLine();
            Console.Clear();


            foreach (Animal a in animals)
            {
                if (a.GetType().Name == "Dog")
                    Console.WriteLine(a.Stats() + "\n" + ((Dog)a).Speak());// the megic of scope you will find speak medthod when you use scope

                else
                {
                    Console.WriteLine(a.Stats());
                }

                Console.ReadLine();
                Console.Clear();

            }
        }

    }
}