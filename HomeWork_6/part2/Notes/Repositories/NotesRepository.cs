using Notes.Models;

namespace Notes.Repositories
{
    internal class NotesRepository 
    {
        public List<NoteModel> CreateNote(
            List<NoteModel> NotesCollection,
            int id, string textNotes, DateTime dateTimeNote)
        {
            NotesCollection.Add(new NoteModel(id, textNotes, dateTimeNote));
            return NotesCollection;
        }

        public List<NoteModel> ChangeNote(
            List<NoteModel> NotesCollection,
            int idNotesCollection, string textNotesChange, DateTime dateTimeNote)
        {
            foreach (var item in NotesCollection)
            {
                if (item.Id == idNotesCollection)
                {
                    NotesCollection[NotesCollection.IndexOf(item)] =
                    new NoteModel(idNotesCollection, textNotesChange, dateTimeNote);
                    return NotesCollection;
                }
            }
            return NotesCollection;
        }

        public List<NoteModel> DeleteNote(
            List<NoteModel> NotesCollection, int idNotesCollection)
        {
            foreach (NoteModel item in NotesCollection)
                if (item.Id == idNotesCollection)
                {
                    NotesCollection.Remove(item);
                    return NotesCollection;
                }
            return NotesCollection;
        }

        internal NoteModel GetNoteById(
            List<NoteModel> NotesCollection, int idNotesCollection)
        {
            foreach (NoteModel item in NotesCollection)
                if (item.Id == idNotesCollection)
                    return item;
            return null;
        }
    }
}
