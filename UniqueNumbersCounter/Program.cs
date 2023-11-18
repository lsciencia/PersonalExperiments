// count how many numbers do not repeat themselves in a given array
// it must be as fast as possible



int[] arr1 = { 1, 2, 3, 3, 4 };
int[] arr2 = { 3, 1, 2, 3, 4 };
int[] arr3 = { 1, 2, 3, 4, 5, 1, 2, 4, 5, 8, 12, 45, 13 };
int[] arr4 = { 1, 1, 1, 1, 1, 1, 2 };

Console.WriteLine("for arr1: " + CountUniques(arr1).ToString());
Console.WriteLine("for arr2: " + CountUniques(arr2).ToString());
Console.WriteLine("for arr3: " + CountUniques(arr3).ToString());
Console.WriteLine("for arr4: " + CountUniques(arr4).ToString());

int CountUniques(int[] arr)
{
    List<int> list = new List<int>();
    List<int> removedItems = new List<int>();
    for (int i = 0; i < arr.Length; i++)
    {
        if (!list.Contains(arr[i])
            && !removedItems.Contains(arr[i]))
        {
            list.Add(arr[i]);
        }
        else
        {
            removedItems.Add(arr[i]);
            list.Remove(arr[i]);
        }
    }
    return list.Count();

    /* THIS WORKS, NOT GOOD, OVERLY COMPLEX
     * List<int> verifiedNum = new List<int>();
    int count = 0;
     * 
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
            {
                if (!verifiedNum.Contains(arr[j]))
                {
                    verifiedNum.Add(arr[j]);
                }
                count++;
                break;
            }
        }
    }
    return arr.Length - verifiedNum.Count - count;*/


    /* THIS WORKS, BUT I WANT TO MAKE IT FASTER
    int count = 0;
     * 
    for (int i = 0; i < arr.Length; i++)
    {
        bool isUnique = true;
        for (int j = 0; j < arr.Length; j++)
        {
            if (j != i && arr[i] == arr[j])
            {
                isUnique = false;
                break;
            }
        }
        if (isUnique) count++;
    }
    return count;
    */

}