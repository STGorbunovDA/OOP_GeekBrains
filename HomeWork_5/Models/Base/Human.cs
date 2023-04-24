using HomeWork_5.Infrastructure.ExceptionBase;

namespace HomeWork_5.Models.Base
{
    internal abstract class Human : IComparable
    {

        /// <summary> Id животного </summary>
        internal int Id { get; private set; }

        /// <summary> Имя </summary>
        protected string Name { get; private set; }

        /// <summary> Фамилия </summary>
        protected int LastName { get; private set; }

        /// <summary> Дата рождения </summary>
        protected int Age { get; private set; }

        protected Human(int id, string name, int lastName, int age)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Age = age;
        }

        public int CompareTo(object obj)
        {
            Human p = obj as Human;

            if (p != null)
            {
                if (Id < p.Id)
                    return -1;
                else if (Id > p.Id)
                    return 1;
                else return 0;
            }
            else throw new CompareException("Ошибка IComparable");
        }
    }
}
