namespace Domain;

public class NoteService
{
   private string dosyaYolu = "/Users/fatimaekin/NotApp2/Console/notlar.txt";

        public void AddNote(string note)
        {
            File.AppendAllText(dosyaYolu, note + "\n");
        }

        public string GetAllNotes()
        {
            if (File.Exists(dosyaYolu))
            {
                return File.ReadAllText(dosyaYolu);
            }
            else
            {
                return "Henüz kaydedilmiş bir not yok.";
            }
}
}
