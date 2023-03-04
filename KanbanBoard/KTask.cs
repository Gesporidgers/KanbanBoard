using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard
{
    internal class KTask
    {
        public string Name { get; set; }
        public int Status { get; set; } // 0 - запланировано; 1 - в процессе; 2 - отложено; 3 - выполнено
    }
}
