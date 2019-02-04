using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakee
{
    public partial class Form1 : Form
    {
        Snake snake;
        public Form1()
        {
            InitializeComponent();
            
            Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Start()
        {
            snake = new Snake(Field);
            snake.Draw();
        }
    }
}
