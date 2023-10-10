int[] nums = { 1, 2, 3 };
int num = 1;

bool status = false;
bool Find(int[] nums, int num)
{
    for (int i = 0; i < nums.Length; i++){
        if (num == nums[i])
        {
            status = true;
        }
    }
    return status;
}
Console.WriteLine(Find(nums, num));