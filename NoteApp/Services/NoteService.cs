namespace NoteApp;

public class NoteService : INoteService
{
   private string noteFilePath = "notlar.txt";

        public string GetNote()
        {
            string note = "";
            try
            {
                note = File.ReadAllText(noteFilePath);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Not dosyası bulunamadı.");
            }
            return note;
        }

        
}
