using Notes.Models;
using Notes.Repositories;
using Notes.View.Base;

namespace Notes.Presenters
{
    internal class ConfigsPresenter
    {

        private readonly IView view;

        private readonly NotesRepository notesRepository;

        internal List<NoteModel> NotesCollection { get; set; }

        public ConfigsPresenter(IView view)
        {
            this.view = view;
            notesRepository = new NotesRepository();
            NotesCollection = new List<NoteModel>();
        }

        public void AppRun()
        {
            while (true)
            {
                view.ShowMenuOne();
                view.ShowMessage("Выберите пункт меню: ");
                int choose = view.ReadChooseInt();
                if (choose == -1)
                {
                    Console.Clear();
                    view.ShowMessage("Ошибка! Вы ввели не число!");
                    Console.ReadLine();
                    continue;
                }
                if (choose == 0)
                    break;
                if (choose < 0 || choose > 5)
                {
                    Console.Clear();
                    view.ShowMessage("Ошибка! Такого пункта меню не существует.");
                    Console.ReadLine();
                    continue;
                }
                ProcessInput(choose);
            }
        }

        private void ProcessInput(int choose)
        {
            string textNotes;
            int idNotesCollection;
            if (choose == 1)
            {
                view.ShowMessage("Введите текст записи: ");
                textNotes = view.ReadString();
                NotesCollection = notesRepository.CreateNote(
                    NotesCollection,NotesCollection.Count + 1,
                    textNotes, DateTime.Now);
            }
            if (NotesCollection.Count == 0)
            {
                view.ShowMessage("Коллекция пуста! Добавь записи в коллекцию.");
                Console.ReadLine();
                return;
            }
            if (choose == 2)
            {
                view.ShowMessage("Введите Id записи: ");
                idNotesCollection = view.ReadChooseInt();
                if (idNotesCollection < 0 || idNotesCollection > NotesCollection.Count)
                    view.ShowMessage($"Такой записи, с введённым id: \"{idNotesCollection}\" нет!");
                view.ShowMessage("Введите новый текст записи: ");
                textNotes = view.ReadString();
                NotesCollection = notesRepository.ChangeNote(
                    NotesCollection, idNotesCollection, textNotes, DateTime.Now);
            }
            if (choose == 3)
            {
                view.ShowMessage("Введите Id записи: ");
                idNotesCollection = view.ReadChooseInt();
                if (idNotesCollection < 0 || idNotesCollection > NotesCollection.Count)
                    view.ShowMessage($"Такой записи, с введённым id: \"{idNotesCollection}\" нет!");
                view.ShowMessage(
                    notesRepository.GetNoteById(NotesCollection, idNotesCollection).ToString());
                Console.ReadLine();
            }
            if (choose == 4)
            {
                view.ShowMessage("Введите Id записи: ");
                idNotesCollection = view.ReadChooseInt();
                if (idNotesCollection < 0 || idNotesCollection > NotesCollection.Count)
                    view.ShowMessage($"Такой записи, с введённым id: \"{idNotesCollection}\" нет!");
                NotesCollection = notesRepository.DeleteNote(NotesCollection, idNotesCollection);
            }
            if (choose == 5)
            {
                view.ShowMessage("Текущие записи: ");
                foreach (NoteModel item in NotesCollection)
                    view.ShowMessage(item.ToString());
                Console.ReadLine();
            }
        }
    }
}
