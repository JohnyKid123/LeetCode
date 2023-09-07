public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) 
    {
        int count = 0;
        int i = 0;

        while (i < flowerbed.Length)
        {
            if (flowerbed[i] == 0)
            {
                bool canPlace = (i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0);
                if (canPlace)
                {
                    flowerbed[i] = 1; 
                    count++;
                }
            }

            i++;
        }

        return count >= n;
    }
}
