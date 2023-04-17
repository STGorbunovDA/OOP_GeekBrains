using HomeWork_2.Models;
using HomeWork_2.Models.Base;
using System.Collections.ObjectModel;
using static HomeWork_2.Infrastructure.BreedEnums;
using static HomeWork_2.Infrastructure.ClassAnimalEnums;
using static HomeWork_2.Infrastructure.ColorEnums;
using static HomeWork_2.Infrastructure.NicknamesEnums;

namespace HomeWork_2.Repositories
{
    internal class AnimalRepository
    {
        Random random = new Random();
        internal ObservableCollection<Animal> GetAnimalsZoo()
        {
            ObservableCollection<Animal> animalsZoo = new ObservableCollection<Animal>();
            int count = 1;
            for (int i = 0; i < 1; i++)
            {
                Animal cat = new Cat(
                    count++,
                    ClassAnimal.Кот.ToString(),
                    random.Next(25, 61),
                    random.Next(2, 7),
                    ((Colors)random.Next(5)).ToString(),
                    ((Nicknames)random.Next(5)).ToString(),
                    ((Breed)random.Next(5)).ToString(),
                    i + random.Next(1, 11),
                    ((Colors)random.Next(5)).ToString(),
                    $"{random.Next(1, 32)}.{random.Next(1, 13)}.2021",
                    true);

                Animal chicken = new Chicken(
                    count++,
                    ClassAnimal.Курица.ToString(),
                    random.Next(20, 40),
                    random.Next(2, 7),
                    ((Colors)random.Next(5)).ToString(),
                    random.Next(3, 5));

                Animal dog = new Dog(
                    count++,
                    ClassAnimal.Собака.ToString(),
                    random.Next(20, 75),
                    random.Next(5, 50),
                    ((Colors)random.Next(5)).ToString(),
                    ((Nicknames)random.Next(5)).ToString(),
                    ((Breed)random.Next(5)).ToString(),
                     i + random.Next(1, 11),
                     ((Colors)random.Next(5)).ToString(),
                     $"{random.Next(1, 32)}.{random.Next(1, 13)}.2021",
                     true);

                Animal stork = new Stork(
                    count++,
                    ClassAnimal.Аист.ToString(),
                    random.Next(100, 125),
                    random.Next(4, 6),
                    ((Colors)random.Next(5)).ToString(),
                    random.Next(1000, 3300));

                Animal tiger = new Tiger(
                   count++,
                   ClassAnimal.Тигр.ToString(),
                   random.Next(2, 4),
                   random.Next(180, 251),
                   ((Colors)random.Next(5)).ToString(),
                   "Африка",
                   $"{random.Next(1, 32)}.{random.Next(1, 13)}.2021");

                Animal wolf = new Wolf(
                    count++,
                    ClassAnimal.Волк.ToString(),
                    random.Next(66, 97),
                    random.Next(27, 46),
                     ((Colors)random.Next(5)).ToString(),
                     "Сибирь",
                     $"{random.Next(1, 32)}.{random.Next(1, 13)}.2021",
                     true);

                animalsZoo.Add(cat);
                animalsZoo.Add(chicken);
                animalsZoo.Add(dog);
                animalsZoo.Add(stork);
                animalsZoo.Add(tiger);
                animalsZoo.Add(wolf);
            }

            return animalsZoo;
        }
    }
}
