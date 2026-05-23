class Solution {
public:
    
bool search(std::vector<int> &nums, int target) {
  int low = 0;
  int high = nums.size() - 1; 
  while (low <= high)
  {
    int mid = low + (high - low) / 2; 

    if (nums[mid] == target)
      return true; 
    
    if (nums[mid] > target)
      high = mid - 1; 
    else 
      low = mid + 1;
  }
  return false;
}

bool searchMatrix(std::vector<std::vector<int>> &matrix, int target) {
  std::vector<int> elements; 
  for (int i = 0; i < matrix.size(); i++)
  {
    for (int j = 0; j < matrix[i].size(); j++)
    {
      elements.push_back(matrix[i][j]);
    }
  }
  return search(elements, target);

}

};
