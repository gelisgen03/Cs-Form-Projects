using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9_12_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            int artis = 0;
            int artis2 = 0;
            int bosluk = 2;

            for (int i = 0; i < 21; i++)
            {
                if (i % 7 == 2 || i % 7 == 6)

                {
                    artis2 += 40;
                    continue;
                    
            
                }
                Button button = new Button();
                button.Text = i.ToString();
                button.Location = new Point(30 + artis2, 10);
                button.Size = new Size(40, 40);
                button.BackColor = Color.Black;
                button.ForeColor = Color.Black;
                button.Visible = true;
                button.BringToFront();
                this.Controls.Add(button);
                artis2 += 40;




            }

            for (int i=0;i<21;i++)
            {
                Button button = new Button();
                button.Text = i.ToString();
                button.Location = new Point(10+artis, 10);
                button.Size = new Size(40, 90);
                button.BackColor = Color.Turquoise;
                button.ForeColor = Color.Black;
                button.Visible = true;
                button.BringToFront();
                this.Controls.Add(button);
                artis += 40;

            }

           


            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
