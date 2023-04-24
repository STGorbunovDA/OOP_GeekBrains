using HomeWork_5.Infrastructure.ExceptionBase;
using HomeWork_5.Infrastructure.Interfaces;
using HomeWork_5.Models.Base;

namespace HomeWork_5.Models
{
    internal class Student : Human, ILearning
    {
        /// <summary> Название университета </summary>
        protected string NameUniversity { get; private set; }

        /// <summary> Факультет </summary>
        protected string Faculty { get; private set; }

        /// <summary> Специальность </summary>
        protected string Specialty { get; private set; }

        /// <summary> Курс </summary>
        protected int Course { get; private set; }

        public Student(string nameUniversity, string faculty, string specialty, int course, 
            int id, string name, int lastName, int age)
            : base(id, name, lastName, age)
        {
            NameUniversity = nameUniversity;
            Faculty = faculty;
            Specialty = specialty;
            if (age < 13)
                new AppException("Возраст студента должен быть с 14 лет");
            if (course < 0 || course > 6)
                new AppException("Крус студента должен быть от 1 до 5");
            else Course = course;
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
                $"Возраст: {Age}\n" +
                $"Университет: {NameUniversity}\n" +
                $"Факультет: {Faculty}\n" +
                $"Specialty: {Specialty}\n" +
                $"Курс: {Course}\n";
        }
    }
}
