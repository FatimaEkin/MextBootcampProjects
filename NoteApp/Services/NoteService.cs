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

        public void SaveNote(string text)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(noteFilePath, append: true))
                {
                    writer.WriteLine(text);
                }
                Console.WriteLine("Not başarıyla kaydedildi.");
            }
            catch (IOException e)
            {
                Console.WriteLine($"Not kaydedilirken bir hata oluştu: {e.Message}");
            }
        }
}
