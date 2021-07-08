using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Note : Control
    {
        public Note() : base()
        {
            this.Size = new Size(150, 150);
            this.Location = new Point(20, 20);
            this.BackColor = Color.DarkSeaGreen;
        }
    }
}
