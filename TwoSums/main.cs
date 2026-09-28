public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var hashArray = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++) {

        var atual = target - nums[i];

        if(hashArray.TryGetValue(atual, out var indiceAnterior)) {
            return [indiceAnterior, i];
        } 
            hashArray.TryAdd(nums[i], i);
        }
        return nums;
    }
}
