using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingReview
{
    [CodeReview("Daneil", "02/08/2023", true)]
    public class Todo
    {
        public int Id { get; private set; }
        public string Task { get; set; }
        public bool IsDone { get; set; }

        private static int nextId = 1;

        public Todo(string task)
        {
            Id = nextId++;
            Task = task;
            IsDone = false;
        }

        public void MarkAsDone()
        {
            IsDone = true;
        }

        [CodeReview("Daneil", "02/08/2023", true)]
        public override string ToString()
        {
            string status = IsDone ? "Done" : "Not Done";
            return $"[#{Id}] {Task} - Status: {status}";
        }
    }
}
