namespace Notes.Models
{
    internal class NoteModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Date { get; set; }

        public NoteModel(int id, string text, DateTime date)
        {
            Id = id;
            Text = text;
            Date = date.ToString("dd.MM.yyyy HH:mm:ss");
        }

        public override string ToString()
        {
            return $"{Id}. {Text}\t {Date}";
        }
    }
}
