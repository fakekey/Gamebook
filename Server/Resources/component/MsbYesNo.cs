using System.Drawing;
using System.Windows.Forms;

namespace Server
{
    public partial class MsbYesNo : Form
    {
        public MsbYesNo()
        {
            InitializeComponent();
            InitializeUI();
        }
        public string Message
        {
            get => this.lbMessage.Text;
            set => this.lbMessage.Text = value;
        }
        public string Title
        {
            get => this.lbTitle.Text;
            set => this.lbTitle.Text = value;
        }
        public Image Icons
        {
            get => this.pbIcon.Image;
            set => this.pbIcon.Image = value;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            DragControl.mouseDown(this);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            DragControl.mouseMove(this);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            DragControl.mouseUp();
        }
    }
}
