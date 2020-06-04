using System;
using System.Drawing;
using System.Windows.Forms;

namespace Labyrinth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        private void label71_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = new Point(this.Location.X + 55, this.Location.Y + 60); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor.Position = new Point(this.Location.X + 55, this.Location.Y + 60);
        }

     
        private void labelFinish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("З ПЕРЕМОГОЮ ВАС!!!","МОЇ ВІТАННЯ!!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void label39_Click(object sender, EventArgs e)
        {

        }
    }
}
