using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    class Manager
    {
        public static List<Note> notes { get; private set; } = new List<Note>();
        public static void CreateNote(string noteName, string text, DateTime creationData)
        {
            notes.Add(new Note(noteName, text, creationData));
        }
        public static string TakeTextNote(string notename) => notes.Find(x => x.Title == notename).Text;
        public static void DeleteNote(string noteName)
        {
            notes.RemoveAt(notes.FindIndex(item => item.Title == noteName));
        }
        public static void SaveAllNotes(string path)
        {
            if (path.EndsWith(".txt"))
                NoteFile.SaveNotes(path, notes.ToArray());
            
            else
            {
                path += ".txt";
                NoteFile.SaveNotes(path, notes.ToArray());
            }
        }
        public static void SaveNote(string noteName, string path)
        {
            NoteFile.SaveNote(path, notes.Find(item => item.Title == noteName));
        }
        public static void ReadNotesFromFile(string path)
        {
            notes = NoteFile.ReadFromFile(path);
        }
    }
}
