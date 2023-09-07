public class Solution {
    public int RomanToInt(string s) {
        if (string.IsNullOrEmpty(s)) {
            return 0;
        }

        int result = 0;

        for (int i = 0; i < s.Length; i++) {
            int value = RomanNumeralValue(s[i]);
            if (i < s.Length - 1 && value < RomanNumeralValue(s[i + 1])) {
                result -= value;
            } else {
                result += value;
            }
        }

        return result;
    }

    private int RomanNumeralValue(char c) {
        switch (c) {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
}
