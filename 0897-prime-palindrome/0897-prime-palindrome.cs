public class Solution {
    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num == 2 || num == 3) return true;
        if (num % 2 == 0 || num % 3 == 0) return false;

        for (int i = 5; i * i <= num; i += 6)
        {
            if (num % i == 0 || num % (i + 2) == 0)
                return false;
        }
        return true;
    }
    static bool IsPalindrome(int num)
    {
        char[] ns = num.ToString().ToCharArray();
        Array.Reverse(ns);
        return num == int.Parse(new string(ns));
    }
    public int PrimePalindrome(int n) {
        if (n <= 2) return 2;
        int i=n;
        while(true){
            if (i > 2 && i % 2 == 0)
            {
                i++;
                continue;
            }
            if (i > 11 && i.ToString().Length % 2 == 0)
            {
                i = (int)Math.Pow(10, i.ToString().Length) + 1; 
                continue;
            }
            if (IsPalindrome(i) && IsPrime(i))
                return i;
            i++;
        }
    }
}