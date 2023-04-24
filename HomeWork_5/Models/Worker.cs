using HomeWork_5.Infrastructure.ExceptionBase;
using HomeWork_5.Infrastructure.Interfaces;
using HomeWork_5.Models.Base;

namespace HomeWork_5.Models
{
    internal class Worker : Human, IWork
    {
        /// <summary> Должность </summary>
        protected string JobDescription { get; private set; }

        /// <summary> Зарплата </summary>
        protected int Salary { get; private set; }

        public Worker(string jobDescription, int salary, int id, string name, int lastName, int age)
            : base(id, name, lastName, age)
        {
            if (age < 13)
                new AppException("Возраст рабочего должен быть с 14 лет");
            JobDescription = jobDescription;
            Salary = salary;
        }

        public string Work()
        {
            return $"{Name} работает";
        }
        public override string ToString()
        {
            return $"{Id}. " +
                $"Имя: {Name}\n" +
                $"Фамилия: {LastName}\n" +
                $"Возраст: {Age}\n" +
                $"Должность: {JobDescription}\n" +
                $"Зарпалата: {Salary}\n";
        }
    }
}
