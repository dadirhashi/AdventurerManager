using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventurerManager.Models
{
    public class Quest
    {
        public string Titel { get; set; }
        public string Descripton { get; set; }
        public DateTime DuaDate { get; set; }
        public PriorityLevel priority {  get; set; }

        public bool IsCompleted { get; set; }

      
    }

    public enum PriorityLevel
    {
        Low,
        Medium,
        High,
        Critical
    }
}
