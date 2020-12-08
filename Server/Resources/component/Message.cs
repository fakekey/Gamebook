using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Message : UserControl
    {
        public Message()
        {
            InitializeComponent();
        }
        public string mText { get => lbText.Text; set => lbText.Text = value; }
        public Size mSize { get => panelRadius1.rSize; set => panelRadius1.rSize = value; }
        public bool Hien { set => triangle1.Visible = panelRadius1.Visible = value; }
    }
}
