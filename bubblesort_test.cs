public class BubbleSorter
{
    public static void MyBubbleSortTest(ref int[] toSort)
    {
            int count = 0;
        while(true)
        {
            bool sorted = true;
            for(int i = 0; i < toSort.Length - 1 - count; i++)
            {
                if (toSort[i] > toSort[i+1])
                {
                    int temp = toSort[i];
                    toSort[i] = toSort[i+1];
                    toSort[i+1] = temp;
                    sorted = false;
                }
            }
            if (!sorted)
            {
                sorted = true;
                count++;
                continue;
            }
            break;
        }

    }

    public static void FoundBubbleSortTest(ref int[] arr){
        int temp = 0;
        for (int write = 0; write < arr.Length; write++) {
            for (int sort = 0; sort < arr.Length - 1; sort++) {
                if (arr[sort] > arr[sort + 1]) {
                    temp = arr[sort + 1];
                    arr[sort + 1] = arr[sort];
                    arr[sort] = temp;
                }
            }
        }
    }

    public static string printArray(int[] arr){
        string result = "";
        foreach(int i in arr){
            result += i + ",";
        }
        result = result.Trim(',');
        return result;
    }

}