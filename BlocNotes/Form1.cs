using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocNotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBox1.WordWrap == true)
            {
                textBox1.WordWrap = false;
            }
            else
            {
                textBox1.WordWrap = true;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
            textBox1.Text = "";
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new window
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab1 = new AboutBox1();
            ab1.Show();
           
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            textBox1.Width = Width-15;
            textBox1.Height = Height-90;
        }

        private void splashScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSplashScreen fsc = new FormSplashScreen();
            fsc.Show();
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = " Mouse : " + e.X.ToString() + " : " + e.Y.ToString();
         
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }
        /*


NewWindow

Save
Save As
Open

Print
Page Setup


Copy
Cut
Paste
Delete

Find
Next
Previews

Replace
Goto
TimeDate

Font

Zoom
Zoom In
Zoom Out
Zoom Reset
Status Bar

Help
Feedback

*/
    }
}
