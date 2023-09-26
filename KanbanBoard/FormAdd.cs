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
        //Program program = new Program();

        private void buttonAddPL_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                this.Close();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Поле не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string getName()
        {
            return richTextBox1.Text;
        }

    }
}
