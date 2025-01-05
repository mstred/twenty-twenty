﻿/*
You're developing an application for the Contoso Petting Zoo that coordinates school visits. The Contoso Petting Zoo is home to 18 different species of animals. At the zoo, visiting students are assigned to groups, and each group has a set of animals assigned to it. After visiting their set of animals, the students will rotate groups until they've seen all the animals at the petting zoo.

By default, the students are divided into 6 groups. However, there are some classes that have a small or large number of students, so the number of groups must be adjusted accordingly. The animals should also be randomly assigned to each group, so as to keep the experience unique.

The design specification for the Contoso Petting Zoo application is as follows:

- There will be three visiting schools
    - School A has six visiting groups (the default number)
    - School B has three visiting groups
    - School C has two visiting groups

- For each visiting school, perform the following tasks
    - Randomize the animals ✅
    - Assign the animals to the correct number of groups
    - Print the school name
    - Print the animal groups
*/

using System;

string[] pettingZoo = 
[
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
];

RandomizeAnimals();
// string[,] group = AssignGroup();
Console.WriteLine("School A");
// PrintGroup(group);

void RandomizeAnimals()
{
    Random random = new();
    var pettingZooLength = pettingZoo.Length;

    for (int i = 0; i < pettingZooLength; i++)
    {
        int r = random.Next(i, pettingZooLength);

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }
}
