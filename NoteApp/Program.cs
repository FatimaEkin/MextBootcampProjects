
using NoteApp;

Console.WriteLine("Not defterine hoş geldiniz!");
Console.WriteLine("Lütfen bir not girin veya çıkmak için 'exit' yazın:");

NoteService noteService = new NoteService();

string input;
while ((input = Console.ReadLine()) != "exit")
{
    noteService.SaveNote(input);
    Console.WriteLine("Lütfen bir not girin veya çıkmak için 'exit' yazın:");
}

Console.WriteLine("Girdiğiniz notlar:");
Console.WriteLine(noteService.GetNote());
