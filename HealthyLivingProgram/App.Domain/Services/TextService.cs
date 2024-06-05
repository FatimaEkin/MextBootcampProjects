namespace App.Domain;

public class TextService
{
    public void SaveText(string line)
    {
        string filePath = "bmi_logs.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(line);
            }
    }
}
