using System;

namespace ClassLibrary1
{
    public class Note
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreationData { get; private set; }

        public Note()
        {
            Title = string.Empty;
            Text = string.Empty;
            CreationData = new DateTime();
        }

        public Note(string noteName, string text, DateTime creationData)
        {
            Text = text;
            Title = noteName;
            CreationData = creationData;
        }
    }
}
