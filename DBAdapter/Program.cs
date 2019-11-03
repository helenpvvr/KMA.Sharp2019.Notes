using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;

namespace KMA.Sharp2019.Notes.MoreThanNotes.DBAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = EntityWrapper.UserByLogin("111");
            /*Note note1 = new Note("My first note", "Do smth at home", user1);
            EntityWrapper.AddNote(note1);*/

            Note note1 = user1.Notes.First();
            /*note1.Title += " ... Add this text";
            Console.WriteLine(note1.Title);
            EntityWrapper.SaveNote(note1);
            */
            Console.WriteLine(note1.Title);
            EntityWrapper.DeleteNote(note1);
            Console.WriteLine(user1.Notes.Count);

            using (var context = new MoreThanNotesDBContext())
            {
                
                //EntityWrapper.AddUser(user1);

               // Note note1 = user1.Notes.First();
               // Console.WriteLine(note1.Title);
               // Console.WriteLine();
               //// note1.Title += "Add text to title";
               // EntityWrapper.DeleteNote(note1);

               // foreach (var note in user1.Notes)
               // {
               //     Console.WriteLine(note.Guid);
               //     Console.WriteLine(note.Title);
               //     Console.WriteLine();
               // }

                Console.WriteLine(" ....... All notes: ..............................................................");

                foreach (var note in context.Notes)
                {
                    Console.WriteLine(note.Guid);
                    Console.WriteLine(note.Title);
                    Console.WriteLine();
                    //context.Notes.Attach(note);
                    //context.Notes.Remove(note);
                }

                Console.WriteLine(" ....... All users: ..............................................................");

                foreach (var note in context.Users)
                {
                    //context.Users.Attach(note);
                    //context.Users.Remove(note);
                    Console.WriteLine(note.Guid);
                    Console.WriteLine(note.Login);
                    Console.WriteLine();
                }
            }

            /*
            User user1 = new User("user2", "user2@gmail.com", "1234");
            Note note11 = new Note("FIRST note", "It is my first note", user1);
            Note note12 = new Note("Second note", "this note was created to test program", user1);

            EntityWrapper.AddUser(user1);
            //EntityWrapper.AddNote(note11);
            //EntityWrapper.AddNote(note12);

            using (var context = new MoreThanNotesDBContext())
            {
                foreach (var user in context.Users)
                {
                    Console.WriteLine(user.ToString());
                    foreach (var note in user.Notes)
                        Console.WriteLine(note.Title);
                }

            }
            */
            

            Console.WriteLine("Finish...");
            Console.ReadKey();
        }

    }
}
