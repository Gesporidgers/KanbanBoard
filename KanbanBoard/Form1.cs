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
        bool changed = false;
        private void button1_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.ShowDialog();
            string nm = formAdd.getName();
            program.addTask(nm);
            UpdAll();
        }

        private void clearTool_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            UpdAll();
        }

        public void UpdAll()
        {
            Planned.Items.Clear();
            InProcess.Items.Clear();
            Delayed.Items.Clear();
            Done.Items.Clear();
            tasksF = program.GetTasks();
            foreach (KTask task in tasksF)
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

        private void toolInProc1_Click(object sender, EventArgs e)
        {
            int index = Planned.SelectedIndex;
            program.makeInProc(Planned.Items[index].ToString());
            changed = true;
            UpdAll();
        }

        private void saveTool_Click(object sender, EventArgs e)
        {
            program.saveAll();
            changed = false;
        }

        private void toolDone_Click(object sender, EventArgs e)
        {
            int index = InProcess.SelectedIndex;
            program.makeDone(InProcess.Items[index].ToString());
            UpdAll();
            changed = true;
        }

        private void toolDelayed_Click(object sender, EventArgs e)
        {
            int index = InProcess.SelectedIndex;
            program.makeDelayed(InProcess.Items[index].ToString());
            UpdAll();
            changed = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(changed)
            {
                DialogResult res = MessageBox.Show("Имеются несохраненные изменения, хотите ли их сохранить?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(res == DialogResult.Yes)
                    program.saveAll();
            }
        }
    }
}
