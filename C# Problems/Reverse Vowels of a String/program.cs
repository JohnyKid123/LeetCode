public class Solution {
 static bool IsVowel(char ch)
    {
        return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U';
    }

    public string ReverseVowels(string s)
    {
        char[] charArray = s.ToCharArray();
        int low = 0;
        int high = s.Length - 1;

        while (low < high)
        {
            while (low < high && !IsVowel(charArray[low]))
            {
                low++;
            }

            while (low < high && !IsVowel(charArray[high]))
            {
                high--;
            }

            char temp = charArray[low];
            charArray[low] = charArray[high];
            charArray[high] = temp;

            low++;
            high--;
        }

        return new string(charArray);
    }

}
