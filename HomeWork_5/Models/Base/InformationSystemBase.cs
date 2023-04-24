using HomeWork_5.Infrastructure.List;
using System.Collections;
using System.Collections.ObjectModel;

namespace HomeWork_5.Models.Base
{
    internal class InformationSystemBase : IEnumerable
    {
        Random random;
        /// <summary> Название </summary>
        protected string NameInformationSystemBase { get; private set; }

        /// <summary> Коллекция</summary>
        protected ObservableCollection<Human> HumanColl { get; set; }

        public InformationSystemBase(string nameInformationSystemBase,
            ObservableCollection<Human> observableCollectionType)
        {
            NameInformationSystemBase = nameInformationSystemBase;
            HumanColl = observableCollectionType;
            random = new Random();
        }

        #region Печать всех людей

        public IEnumerator GetEnumerator()
        {
            foreach (var figura in HumanColl)
                yield return figura;
        }

        #endregion

        #region Добавить человека 

        public bool CreateHuman(int chooseHumanColl, string name)
        {
            if (chooseHumanColl == 1)
            {
                HumanColl.Add(new Worker(
                    name,
                    ListJobDescription.JobDescription.GetValue(random.Next(ListJobDescription.JobDescription.Length)).ToString(),
                    random.Next(25000, 150000),
                    HumanColl.Count + 1,
                    ListNameHuman.NameHuman.GetValue(random.Next(ListNameHuman.NameHuman.Length)).ToString(),
                    ListLastName.LastName.GetValue(random.Next(ListNameHuman.NameHuman.Length)).ToString(),
                    random.Next(14, 65)));
                return true;
            }
            if (chooseHumanColl == 2)
            {
                HumanColl.Add(new Student(
                         name,
                         ListNameFaculties.NameFaculties.GetValue(random.Next(ListNameFaculties.NameFaculties.Length)).ToString(),
                         random.Next(1, 6),
                         HumanColl.Count + 1,
                         ListNameHuman.NameHuman.GetValue(random.Next(ListNameHuman.NameHuman.Length)).ToString(),
                         ListLastName.LastName.GetValue(random.Next(ListNameHuman.NameHuman.Length)).ToString(),
                         random.Next(14, 65)));
                return true;
            }
            if (chooseHumanColl == 3)
            {
                HumanColl.Add(new Schoolboy(
                       name,
                       random.Next(1, 12),
                       HumanColl.Count + 1,
                       ListNameHuman.NameHuman.GetValue(random.Next(ListNameHuman.NameHuman.Length)).ToString(),
                       ListLastName.LastName.GetValue(random.Next(ListNameHuman.NameHuman.Length)).ToString(),
                       random.Next(6, 18)));
                
                return true;
            }
            else return false;
        }


        #endregion

        #region Сортировка ID человека

        public void SortIdHuman()
        {
            HumanColl = new ObservableCollection<Human>(HumanColl.OrderBy(i => i));
        }

        #endregion
    }
}
