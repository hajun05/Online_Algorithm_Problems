using System;

public class Solution 
{
    public string solution(string myString) 
    {
        char[] myCharArr = myString.ToCharArray();
        for (int i = 0; i < myCharArr.Length; i++)
        {
            if (myCharArr[i] <= 'l')
                myCharArr[i] = 'l';
        }
        string answer = new string(myCharArr);
        return answer;
    }
}