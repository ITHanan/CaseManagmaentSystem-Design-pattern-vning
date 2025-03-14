


namespace CaseManagmaentSystem.algoritmer_1
{
    public class CaseManager
    {

        // This class handles the priority queue (a special data structure that processes the most urgent cases first).

        private PriorityQueue<Case, int> caseQueue = new PriorityQueue<Case, int>();//  ensures that cases with the highest priority are processed first.

        public void AddCase(string caseId, int priority)
        {
            // The first parameter is the case object itself.

            // The second parameter (-priority) ensures that cases with higher priority numbers are processed first.
            caseQueue.Enqueue(new Case(caseId, priority), -priority); // Negativ prioritet för högst först
            Console.WriteLine($"Case {caseId} added with priority {priority}");
        }

        public void ProcessNextCase()
        {
            if (caseQueue.TryDequeue(out Case nextCase, out _))// Removes the highest priority case from the queue.

            {
                Console.WriteLine($"Processing case {nextCase.CaseId} with priority {nextCase.Priority}");// If successful, stores it in nextCase.

            }
            else
            {
                Console.WriteLine("No cases to process.");// If there’s nothing to process, prints "No cases to process."

            }
        }

    }
}
