public class Solution {
    public bool IsPalindrome(string s) {
        
        string xStringLimpa = new string( 
            s.Where(char.IsLetterOrDigit)
             .Select(char.ToLowerInvariant)
             .ToArray()
        );

        char[] xStringInvertida = xStringLimpa.Reverse().ToArray(); //amanaplanacanalpanama 

        for(int i = 0; i < xStringLimpa.Length; i++) {

            if(xStringLimpa[i] != xStringInvertida[i]) {
                return false;
            }
        }

        return true;
    }
}
