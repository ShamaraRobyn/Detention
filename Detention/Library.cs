using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detention
{
    class Library
    {
        List<Task> tasks;
        Random rand;
        string name;

        public Library()
        {
            tasks = new List<Task>();
            rand = new Random();
        }

        public void addTask(Task t)
        {
            tasks.Add(t);
        }

        public Task getRandomTask()
        {
            return tasks[rand.Next(0, tasks.Count - 1)];
        }
    }
}
