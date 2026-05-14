class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
    unordered_map<int,int>count;
    for(int sum:nums)
    {
        count[sum]++;
    }
    vector<pair<int,int>>sorting;
    for(const auto& pair: count)
    {
        sorting.push_back({pair.second, pair.first});
    }
    sort(sorting.rbegin(),sorting.rend());
    vector<int>result;
    for( int i=0;i<k;++i)
    {
        result.push_back(sorting[i].second);
    }
    return result;
    }
};

