using HomeWork_5.Infrastructure.ExceptionBase;
using HomeWork_5.Infrastructure.Interfaces;
using HomeWork_5.Models.Base;

namespace HomeWork_5.Models
{
    internal class Worker : Human, IWork
    {
        /// <summary> Название организации </summary>
        protected string NameCompany { get; private set; }

        /// <summary> Должность </summary>
        protected string JobDescription { get; private set; }

        /// <summary> Зарплата </summary>
        protected int Salary { get; private set; }

        public Worker(string nameCompany, string jobDescription, int salary, int id, string name, string lastName, int age)
            : base(id, name, lastName, age)
        {
            NameCompany = nameCompany;
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
                $"ИФ: {Name} {LastName}\n" +
                $"Возраст: {Age}\n" +
                $"Название организации: {NameCompany}\n" +
                $"Должность: {JobDescription}\n" +
                $"Зарпалата: {Salary}\n";
        }
    }
}
