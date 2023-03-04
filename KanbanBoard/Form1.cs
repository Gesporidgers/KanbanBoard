using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Planned.Items.Add("Task1");
            Planned.Items.Add("Task2");
        }

        private void clearTool_Click(object sender, EventArgs e)
        {
            Planned.Items.Clear();
        }
    }
}
