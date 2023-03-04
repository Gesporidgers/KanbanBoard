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
        Program program = new Program();
        List<KTask> tasksF = new List<KTask>();
        private void button1_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.ShowDialog();
        }

        private void clearTool_Click(object sender, EventArgs e)
        {
            Planned.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tasksF = program.GetTasks();
            UpdAll();
        }

        private void UpdAll()
        {
            foreach(KTask task in tasksF)
            {
                switch (task.Status)
                {
                    case 0: Planned.Items.Add(task.Name); break;
                    case 1: InProcess.Items.Add(task.Name); break;
                    case 2: Delayed.Items.Add(task.Name); break;
                    case 3: Done.Items.Add(task.Name); break;
                }
            }
        }
    }
}
