class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
         unordered_map<string,vector<string>>table;
        for(const string &str:strs)
        {
            string sortedStr=str;
            sort(sortedStr.begin(),sortedStr.end());
            table[sortedStr].push_back(str);
        }
        vector<vector<string>>result;
        for(auto &pair:table)
        {
            result.push_back(pair.second);
        }
        return result;
    }
};
