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
        public List<KTask> tasks;
        string json;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
        public void Load()
        {
            try
            {
                tasks = JsonSerializer.Deserialize<List<KTask>>(File.ReadAllText("board.json"));
            }
            catch (FileNotFoundException)
            {
                File.WriteAllText("board.json", "[]");
                tasks = JsonSerializer.Deserialize<List<KTask>>(File.ReadAllText("board.json"));
            }
        }
        public void  addTask(string name)
        {
            KTask task = new KTask {Name = name, Status = 0 };
            tasks.Add(task);            
            json = JsonSerializer.Serialize(tasks);
            
        }

        public void clearT()
        {
            tasks.Clear();
            json = "[]";
            File.WriteAllText("board.json",json);
        }

        public void saveAll()
        {
            if (json != null)
                File.WriteAllText("board.json", json);
            else
                File.WriteAllText("board.json", "[]");
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

        public void makeInProc(string name)
        {
            //KTask task = new KTask { Name = name, Status = 0 };

            int index = 0;
            foreach (KTask task in tasks)
            {
                if (task.Name == name) 
                    break;
                else
                    index++;
            }
            tasks[index].Status = 1;
            json = JsonSerializer.Serialize(tasks);
            
        }

        public void makeDelayed(string name)
        {
            
            int index = 0;
            foreach (KTask task in tasks)
            {
                if (task.Name == name) ;
                else
                    index++;
            }
            tasks[index].Status= 2;
            json = JsonSerializer.Serialize(tasks);
        }

        public void makeDone(string name)
        {
            int index = 0;
            foreach (KTask task in tasks)
            {
                if (task.Name == name) ;
                else
                    index++;
            }
            tasks[index].Status = 3;
            json = JsonSerializer.Serialize(tasks);
        }
    }
}
