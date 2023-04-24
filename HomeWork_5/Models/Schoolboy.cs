using HomeWork_5.Infrastructure.ExceptionBase;
using HomeWork_5.Infrastructure.Interfaces;
using HomeWork_5.Models.Base;

namespace HomeWork_5.Models
{
    internal class Schoolboy : Human, ILearning
    {
        /// <summary> Название Школы </summary>
        protected string NameSchool { get; private set; }

        /// <summary> Класс </summary>
        protected int ClassSchool { get; private set; }

        public Schoolboy(string nameSchool, int classSchool, int id, string name, int lastName, int age) 
            : base(id, name, lastName, age)
        {
            NameSchool = nameSchool;
            if (age < 5)
                new AppException("Возраст школьника должен быть с 6 лет");
            if (classSchool < 0 || classSchool > 12)
                new AppException("Класс школьника должен быть от 1 до 11");
            else ClassSchool = classSchool;

        }

        public string Learning()
        {
            return $"{Name} учится";
        }
        public override string ToString()
        {
            return $"{Id}. " +
                $"Имя: {Name}\n" +
                $"Фамилия: {LastName}\n" +
                $"Возраст:  {Age}\n" +
                $"Школа: {NameSchool}\n" +
                $"Класс: {ClassSchool}\n";
        }
    }
}
