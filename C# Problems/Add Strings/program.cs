public class Solution {
public string AddStrings(string num1, string num2) {
    int i = num1.Length - 1, j = num2.Length - 1;
    int carry = 0;
    StringBuilder sb = new StringBuilder();
    
    while (i >= 0 || j >= 0 || carry > 0) {
        int n1 = i >= 0 ? num1[i--] - '0' : 0;
        int n2 = j >= 0 ? num2[j--] - '0' : 0;
        int sum = n1 + n2 + carry;
        sb.Append(sum % 10);
        carry = sum / 10;
    }
    
    char[] result = sb.ToString().ToCharArray();
    Array.Reverse(result);
    return new string(result);
}


}
