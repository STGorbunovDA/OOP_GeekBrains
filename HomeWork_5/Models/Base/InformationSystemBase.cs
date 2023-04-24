using System.Collections.ObjectModel;

namespace HomeWork_5.Models.Base
{
    internal class InformationSystemBase
    {
        /// <summary> Название </summary>
        protected string NameInformationSystemBase { get; private set; }

        /// <summary> Коллекция</summary>
        protected ObservableCollection<Type> ObservableCollectionType { get; set; }

        /// <summary> Кол-во </summary>
        protected int CountCollection { get; private set; }
    }
}
