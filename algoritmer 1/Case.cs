

namespace CaseManagmaentSystem.algoritmer_1
{
    public class Case
    {
        public string CaseId { get; }
        public int Priority { get; }

        //Priority: A number indicating its priority (higher means more urgent).


        public Case(string caseId, int priority)
        {
            CaseId = caseId;
            Priority = priority;
        }
    }
}
