public class Solution {
    public int FindMin(int[] nums) {
        int res = nums[0];
int l = 0;
int r=nums.Length-1;
int mid = (l+r)/2;
while (l<=r)
{
    if (nums[l]<nums[r])
    {
        res=int.Min(res, nums[l]);
        
        break;
    }

    mid= (l+r)/2;
    res=int.Min(res, nums[mid]);
    if (nums[mid]>=nums[l])
    { l=mid+1; }
    else { r=mid-1; }
}
return res;
        
    }
}
