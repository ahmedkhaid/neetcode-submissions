public class Solution {
   
    public List<List<int>> CombinationSum(int[] nums, int target) {
       List<int>curr = new List<int>();
       List<List<int>>result = new List<List<int>>();
       void Dfs(int index , int total)
       {
        if(total == target)
        {
            result.Add(new List<int>(curr));
            return;
        }
        if(index >= nums.Length  || total > target)
            return;
        curr.Add(nums[index]);
        Dfs(index,total+nums[index]);
        curr.RemoveAt(curr.Count - 1);
        Dfs(index+1 , total);
       }
       Dfs(0,0);
       return result;
    }
}
