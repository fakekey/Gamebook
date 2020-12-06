using System.Windows.Forms;

namespace Server
{
    public static class DragControl
    {
        static bool isDragging;
        static int mouseX;
        static int mouseY;
        public static void mouseDown(Control obj)
        {
            isDragging = true;
            mouseX = Cursor.Position.X - obj.Left;
            mouseY = Cursor.Position.Y - obj.Top;
        }
        public static void mouseMove(Control obj)
        {
            if (isDragging)
            {
                obj.Left = Cursor.Position.X - mouseX;
                obj.Top = Cursor.Position.Y - mouseY;
            }
        }
        public static void mouseUp()
        {
            isDragging = false;
        }
    }
}
