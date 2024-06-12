namespace Domain;

public interface INoteService
{
    void AddNote(string note);
    string GetAllNotes();
}
