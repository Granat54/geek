import java.util.Arrays;

public class HW1_2 {
        public static void main(String[] args) {
            int[] nums = {3, 2, 2, 3};
            int val = 3;
            int j = 0;
            for (int i = 0; i < nums.length; i++) {
                if (nums[i] != val) {
                    if(i != j) {
                        int temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;
                    }
                    j++;
                }
            }
            System.out.println(Arrays.toString(nums));
        }
    }

