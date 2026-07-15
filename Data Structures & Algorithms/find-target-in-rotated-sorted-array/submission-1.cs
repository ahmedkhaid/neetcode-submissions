public class Solution {
    public int Search(int[] nums, int target) {
        //Binary search it is a way to Decrease teh time from on2 
        //into nLogn time for the sorting ,
        int l =0;
       int n = nums.Length;
        int r = n-1;
        while(l<r)
        {
            int mid = (l+r)/2;
            if(nums[mid]>nums[r])
            {
                l = mid+1;
            }
            else{
                r=mid;
            }

        }
        int minIndex = l;
        if(minIndex == 0)
        {
            l=0;
            r=n-1;
        } 
         else if (target >= nums[0] && target <=nums[minIndex-1])
         {
            l=0;
            r = minIndex;
         }
         else{
            l=minIndex;
            r=n-1;
         }
     while(l<=r)
     {
        int mid = (l+r)/2;
        if(nums[mid]==target)
        {
            return mid;
        }
        else if(target>nums[mid])
        {
            l=mid+1;
        }
        else{
            r=mid-1;
        }
     }
     return -1;

    }
}
