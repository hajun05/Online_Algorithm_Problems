public class Solution 
{
    public int[] solution(int[] arr) 
    {
        int min = arr[0];
        int min_index = -1;
        
        for(int i = 0; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
                min_index = i;
            }
        }
        
        if (min_index < 0)
            return new int[] { -1 };
            //System.Array.Fill(answer, -1);
        else
        {
            int[] answer = new int[arr.Length - 1];
            
            for(int i = 0, j = 0; i < arr.Length; i++, j++)
            {
                if (i == min_index)
                {
                    j--;
                    continue;
                }
                answer[j] = arr[i];
            }
            
            return answer;
        }
    }
}