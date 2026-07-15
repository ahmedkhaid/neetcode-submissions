public class Solution {
 public int LongestConsecutive(int[] nums)
{
    int LongetsStreak = 0;
    HashSet<int> set = nums.ToHashSet();
    foreach(int num in set) {
        if (!set.Contains(num-1))
        {
            int currentStreak=1;
            int currentNum = num;
            while (set.Contains (currentNum+1)) {
                currentNum++;
                currentStreak++;
            }
           LongetsStreak= int.Max(currentStreak,LongetsStreak);
        }
    }
    return LongetsStreak;
}
}
