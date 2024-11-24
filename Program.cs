
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0) return 0;

        int indexToWrite = 0;
        int elementsWihtoutVal = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                elementsWihtoutVal += 1;
                nums[indexToWrite] = nums[i];
                indexToWrite += 1;
            }
        }

        for (int i = indexToWrite; i < nums.Length; i++)
        {
            nums[i] = -1;
        }

        /*
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + ", ");
        }
        Console.WriteLine();
        */

        return elementsWihtoutVal;
    }

    static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine(s.RemoveElement([3, 2, 2, 3], 3));

        Console.WriteLine(s.RemoveElement([0, 1, 2, 2, 3, 0, 4, 2], 2));
    }
}