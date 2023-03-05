using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;


namespace KanbanBoard
{
    internal class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        List<KTask> tasks = JsonSerializer.Deserialize<List<KTask>>(File.ReadAllText("board.json"));
        string json;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public void  addTask(string name)
        {
            KTask task = new KTask {Name = name, Status = 0 };
            tasks.Add(task);            
            json = JsonSerializer.Serialize(tasks);
            
        }

        public void saveAll()
        {
            File.WriteAllText("board.json", json);
        }

        public List<KTask> GetTasks()
        {
            if (json == null)
                return tasks;
            else
            { tasks = JsonSerializer.Deserialize<List<KTask>>(json);
                return tasks;
                    }
            
        }

        public void makeInProc(int index)
        {
            tasks[index].Status = 1;
            json = JsonSerializer.Serialize(tasks);
        }
    }
}
