using System.Linq;

public class Solution 
{
    public string solution(string s) 
    {
        int[] nums = s.Split().Select(int.Parse).ToArray();
        
        int max = Max(nums);
        int min = Min(nums);
        
        string answer = string.Format($"{min} {max}");
        return answer;
    }
    
    public int Max(int[] nums)
    {
        int max = int.MinValue;
        foreach (int num in nums)
        {
            if (max < num)
                max = num;
        }
        return max;
    }
    
    public int Min(int[] nums)
    {
        int min = int.MaxValue;
        foreach (int num in nums)
        {
            if (min > num)
                min = num;
        }
        return min;
    }
}