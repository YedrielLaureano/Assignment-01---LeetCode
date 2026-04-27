// 217. Contains Duplicate
// Yedriel Laureano

#include <vector>
#include <unordered_set>
using namespace std;

class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {
      unordered_set<int> visited;
        return check(nums, 0, visited);
    }
private:
    bool check(vector<int>& nums, int index, unordered_set<int>& visited) {

        if (index == nums.size())
            return false;

        if (visited.count(nums[index]))
            return true;

        visited.insert(nums[index]);
        return check(nums, index + 1, visited);
    }
};