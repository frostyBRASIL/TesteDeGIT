// https://leetcode.com/problems/palindrome-number/description/
public class Solution 
{
    public static bool IsPalindrome(int x) 
    {
        string x_str = x.ToString();
        int[] digs = new int [x_str.Length];
        bool palindrome = false;

        for (int i = 0; i < x_str.Length; i++)
        {
            digs[i] = int.Parse(digs[i].ToString());
        }

        int[] reversedDigs = new int[digs.Length];
        Array.Copy(digs, reversedDigs, digs.Length);
        Array.Reverse(reversedDigs);

        for (int i = 0; i < digs.Length; i++)
        {
            if (digs[i] != reversedDigs[i])
            {
                palindrome = false;
            }
            else
            {
                palindrome = true;
            }
        }

        return palindrome;

    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(Solution.IsPalindrome(2021));
    }
}