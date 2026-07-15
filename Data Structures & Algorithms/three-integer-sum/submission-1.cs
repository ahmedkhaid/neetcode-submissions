public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
    Array.Sort(nums);
    int l;
    int h;
    List<List<int>>result=new List<List<int>>();
    for(int i =0;i<nums.Length;i++)
    {
        l=i+1;
        h=nums.Length-1;
        int offset = 0-nums[i];
        
        if(i>0 && nums[i]==nums[i-1])
            continue;
        while(l<h)
        {
            if(offset < nums[l]+nums[h])
                h--;
            else if(offset > nums[l]+nums[h])
                l++;
            else{
                List<int>entry=new List<int>(); 
                entry.Add(nums[l]);
                entry.Add(nums[h]);
                entry.Add(nums[i]);
                result.Add(entry);
                while(l<h && nums[l] == nums[l+1]){l++;}
                while(l<h && nums[h] == nums[h-1]){h--;}
                h--;
                l++;
            }
        }
    }
    return result;
    }
}
