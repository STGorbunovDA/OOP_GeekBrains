using HomeWork_5.Infrastructure.List;
using HomeWork_5.Models;
using HomeWork_5.Models.Base;
using System.Collections.ObjectModel;
using static HomeWork_5.Infrastructure.List.ChouseHumanEnum;

namespace HomeWork_5.Repositories
{
    internal class HumanRepository
    {
        Random random = new();
        internal ObservableCollection<Human> GetHumanPlaneForInformationSystemBase(string name, int countHuman,
            int chouse)
        {
            ObservableCollection<Human> result = new();
            int count = 1;
            if (chouse == 1)
            {
                for (int i = 0; i < countHuman; i++)
                {
                    Human human = new Worker(
                        name,
                        ListJobDescription.JobDescription.GetValue(random.Next(ListJobDescription.JobDescription.Length)).ToString(),
                        random.Next(25000, 150000),
                        count++,
                        ListNameHuman.NameHuman.GetValue(random.Next(ListNameHuman.NameHuman.Length)).ToString(),
                        ListLastName.LastName.GetValue(random.Next(ListNameHuman.NameHuman.Length)).ToString(),
                        random.Next(14, 65)
                        );
                    result.Add(human);
                }
                return result;
            }
            else if (chouse == 2)
            {
                for (int i = 0; i < countHuman; i++)
                {
                    Human human = new Student(
                         name,
                         ListNameFaculties.NameFaculties.GetValue(random.Next(ListNameFaculties.NameFaculties.Length)).ToString(),
                         random.Next(1, 6),
                         count++,
                         ListNameHuman.NameHuman.GetValue(random.Next(ListNameHuman.NameHuman.Length)).ToString(),
                         ListLastName.LastName.GetValue(random.Next(ListNameHuman.NameHuman.Length)).ToString(),
                         random.Next(14, 65)
                        );
                    result.Add(human);
                }
                return result;
            }
            else if (chouse == 3)
            {
                for (int i = 0; i < countHuman; i++)
                {
                    Human human = new Schoolboy(
                       name,
                       random.Next(1, 12),
                       count++,
                       ListNameHuman.NameHuman.GetValue(random.Next(ListNameHuman.NameHuman.Length)).ToString(),
                       ListLastName.LastName.GetValue(random.Next(ListNameHuman.NameHuman.Length)).ToString(),
                       random.Next(6, 18));
                    result.Add(human);
                }
                return result;
            }
            else return result;
        }
    }
}
