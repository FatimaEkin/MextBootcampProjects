using Domain;

NoteService noteService = new NoteService();
            
            string secim = "";

            while (secim != "3")
            {
                Console.WriteLine("1. Not Ekle");
                Console.WriteLine("2. Notları Göster");
                Console.WriteLine("3. Çıkış");
                Console.Write("Seçiminizi yapın: ");

                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.Write("Lütfen notunuzu girin: ");
                        string not = Console.ReadLine();
                        noteService.AddNote(not);
                        Console.WriteLine("Not kaydedildi.\n");
                        break;

                    case "2":
                        Console.WriteLine("Kaydedilmiş Notlar:");
                        Console.WriteLine(noteService.GetAllNotes());
                        break;

                    case "3":
                        Console.WriteLine("Programdan çıkılıyor.");
                        break;

                    default:
                        Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                        break;
                }
            }








