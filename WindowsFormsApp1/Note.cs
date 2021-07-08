using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Note : Control
    {
        Label time = new Label();
        Label date = new Label();
        TextBox noteText = new TextBox();
        TextBox title = new TextBox();

        public Note() : base()
        {
            this.Size = new Size(200, 200);
            this.Location = new Point(15, 20);
            this.BackColor = Color.DarkSeaGreen;
            
            title.Text = "Title";
            title.Location = new Point(10, 20);
            title.BackColor = Color.FloralWhite;
            title.Size = new Size(180, 120);
            title.Click += (sender, args) =>
            {
                this.title.Text = String.Empty;
            };

            noteText.Text = "Text";
            noteText.Location = new Point(title.Location.X, title.Location.Y + 30);
            noteText.BackColor = Color.AntiqueWhite;
            noteText.Size = new Size(180, 100);
            noteText.Multiline = true;
            noteText.ScrollBars = ScrollBars.Vertical;
            noteText.Click += (sender, args) =>
            {
                this.noteText.Text = String.Empty;
            };

            time.Text = $"{DateTime.Now}";
            time.Location = new Point(noteText.Location.X + 20, noteText.Location.Y + 115);
            time.BackColor = Color.DarkSeaGreen;

            date.Text = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}";
            date.Location = new Point(time.Location.X + 90, time.Location.Y);
            date.BackColor = Color.DarkSeaGreen;

            this.Controls.Add(date);
            this.Controls.Add(time);
            this.Controls.Add(title);
            this.Controls.Add(noteText);
        }
    }

}
