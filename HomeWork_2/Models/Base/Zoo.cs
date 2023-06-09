﻿using HomeWork_2.Repositories;
using System.Collections;
using System.Collections.ObjectModel;
using static HomeWork_2.Infrastructure.BreedEnums;
using static HomeWork_2.Infrastructure.ClassAnimalEnums;
using static HomeWork_2.Infrastructure.ColorEnums;
using static HomeWork_2.Infrastructure.NicknamesEnums;

namespace HomeWork_2.Models.Base
{
    public class Zoo : IAnimal, IEnumerable
    {
        AnimalRepository animalRepository;
        protected ObservableCollection<Animal> AnimalZoo { get; set; }

        Random random;

        public Zoo()
        {
            random = new Random();
            animalRepository = new AnimalRepository();
            AnimalZoo = new ObservableCollection<Animal>();
        }

        #region Заполнить зоопарк рандомными животными

        public void AddRandomAnimalInZoo()
        {
            AnimalZoo = animalRepository.GetAnimalsZoo();
        }


        #endregion

        #region Печать всех животных зоопарка

        public IEnumerator GetEnumerator()
        {
            foreach (var animal in AnimalZoo)
                yield return animal;
        }


        ///// <summary> Старый метод< /summary>
        //public void ShowAllAnimalsZoo()
        //{
        //    if (AnimalZoo == null)
        //        return;
        //    foreach (var animal in AnimalZoo)
        //        Console.WriteLine(animal);
        //}

        #endregion

        #region Показать выбранное животное 

        public Animal this[int id]
        {
            get
            {
                Animal animal = AnimalZoo.FirstOrDefault(c => c.Id == id);
                if (animal == null)
                    return new UnknownAnimal(0);
                return animal;
            }
        }


        /// <summary> Старый метод </summary>
        //public Animal ShowAnimal(string id)
        //{
        //    int _id = Convert.ToInt32(id);
        //    foreach (var animal in AnimalZoo)
        //        if (animal.Id == _id)
        //            return animal;
        //    return new UnknownAnimal(0);
        //}



        #endregion

        #region Добавить животное 
        
        //Использование Null Object pattern
        public void CreateAnimal(string name)
        {
            AnimalZoo.Add(name.ToLower() switch
            {
                "кот" => new Cat(
                        AnimalZoo.Count + 1,
                        ClassAnimal.Кот.ToString(),
                        random.Next(25, 61),
                        random.Next(2, 7),
                        ((Colors)random.Next(5)).ToString(),
                        ((Nicknames)random.Next(5)).ToString(),
                        ((Breed)random.Next(5)).ToString(),
                        random.Next(1, 11),
                        ((Colors)random.Next(5)).ToString(),
                        $"{random.Next(1, 32)}.{random.Next(1, 13)}.2021",
                        true),

                "курица" => new Chicken(
                        AnimalZoo.Count + 1,
                        ClassAnimal.Курица.ToString(),
                        random.Next(20, 40),
                        random.Next(2, 7),
                        ((Colors)random.Next(5)).ToString(),
                        random.Next(3, 5)),

                "cобака" => new Dog(
                        AnimalZoo.Count + 1,
                        ClassAnimal.Собака.ToString(),
                        random.Next(20, 75),
                        random.Next(5, 50),
                        ((Colors)random.Next(5)).ToString(),
                        ((Nicknames)random.Next(5)).ToString(),
                        ((Breed)random.Next(5)).ToString(),
                        random.Next(1, 11),
                        ((Colors)random.Next(5)).ToString(),
                        $"{random.Next(1, 32)}.{random.Next(1, 13)}.2021",
                        true),

                "aист" => new Stork(
                        AnimalZoo.Count + 1,
                        ClassAnimal.Аист.ToString(),
                        random.Next(100, 125),
                        random.Next(4, 6),
                        ((Colors)random.Next(5)).ToString(),
                        random.Next(1000, 3300)),

                "тигр" => new Tiger(
                        AnimalZoo.Count + 1,
                        ClassAnimal.Тигр.ToString(),
                        random.Next(2, 4),
                        random.Next(180, 251),
                        ((Colors)random.Next(5)).ToString(),
                        "Африка",
                        $"{random.Next(1, 32)}.{random.Next(1, 13)}.2021"),

                "волк" => new Wolf(
                        AnimalZoo.Count + 1,
                        ClassAnimal.Волк.ToString(),
                        random.Next(66, 97),
                        random.Next(27, 46),
                        ((Colors)random.Next(5)).ToString(),
                        "Сибирь",
                        $"{random.Next(1, 32)}.{random.Next(1, 13)}.2021",
                        true),
                _ => new UnknownAnimal(AnimalZoo.Count + 1)
            });
        }

        #endregion 

        #region Издать звук животному

        public string VoiceAnimal(int id)
        {
            Animal animal = AnimalZoo.FirstOrDefault(c => c.Id == id);
            if (animal == null)
                return string.Empty;
            if (animal is ISoundAnimal sound)
                return sound.MakeSound();
            else return string.Empty;


        }

        #endregion

        #region Издать звук всех животных

        public IEnumerable VoicesAnimal()
        {
            //List<string> voicesAnimalList = new List<string>();
            foreach (var animal in AnimalZoo)
                if (animal is ISoundAnimal sound)
                    yield return sound.MakeSound();
        }

        #endregion

        #region Удалить животное из зоопарка

        public bool RemoveAnimal(int id)
        {
            Animal animal = AnimalZoo.FirstOrDefault(c => c.Id == id);
            if (animal != null)
            {
                AnimalZoo.Remove(animal);
                return true;
            }
            else return false;


            //int _id = Convert.ToInt32(id);
            //foreach (var animal in AnimalZoo)
            //    if (animal.Id == _id)
            //    {
            //        AnimalZoo.Remove(animal);
            //        break;
            //    }

        }

        #endregion  

        #region выполнить универсальные методы для всех animal

        public IEnumerable UniversalMethodsAnimal()
        {
            //List<string> universalMethodsAnimalList = new List<string>();

            foreach (var animal in AnimalZoo)
            {
                if (animal is IFlying flying)
                    yield return flying.Flying();
                if (animal is IShowingAffection showingAffection)
                    yield return showingAffection.ShowingAffection();
                if (animal is ITraining training)
                    yield return training.Training();
            }
        }



        #endregion

        #region Сортировка всех животных по весу в базовом абстрактном классе реализован Animal: IComparable

        public void SortAnimal()
        {
            AnimalZoo = new ObservableCollection<Animal>(AnimalZoo.OrderBy(i => i));  
        }

        #endregion
    }
}
