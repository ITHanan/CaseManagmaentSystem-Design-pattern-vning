

namespace CaseManagmaentSystem.algoritmer_1
{
    public class CaseSearch
    {
        public  int BinarySearch(int[] caseIds, int targetId)
        {
            int left = 0, right = caseIds.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (caseIds[mid] == targetId)
                    return mid; // Hittat ärendet

                if (caseIds[mid] < targetId)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1; // Ärendet hittades inte

        }
    }
}