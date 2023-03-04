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
        List<KTask> tasks = new List<KTask>();
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
            string json = JsonSerializer.Serialize<List<KTask>>(tasks);
            File.WriteAllText("board.json", json);
        }

        public List<KTask> GetTasks()
        {
            tasks = JsonSerializer.Deserialize<List<KTask>>(File.ReadAllText("board.json"));
            return tasks;
        }
    }
}
