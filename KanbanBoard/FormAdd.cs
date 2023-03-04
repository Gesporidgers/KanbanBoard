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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }
        Program program = new Program();

        private void buttonAddPL_Click(object sender, EventArgs e)
        {
            program.addTask(richTextBox1.Text);
            this.Close();
        }
    }
}
