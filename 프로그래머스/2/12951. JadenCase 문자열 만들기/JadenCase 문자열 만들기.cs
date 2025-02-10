public class Solution 
{
    public string solution(string s) 
    {
        string[] JadenCase = s.Split(' ');
        
        for (int i = 0; i < JadenCase.Length; i++)
        {
            string word = JadenCase[i];
            
            if (!string.IsNullOrEmpty(word))
            {
                string upper = char.ToUpper(word[0]).ToString();
                string rest = word.Substring(1).ToLower();
                JadenCase[i] = upper + rest;
            }
        }
        
        string answer = string.Join(" ", JadenCase);
        return answer;
    }
}