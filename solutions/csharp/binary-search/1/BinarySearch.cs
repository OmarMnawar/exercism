public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        if (input == null || input.Length == 0) {
            return -1;
        }
        
        int min = 0;
        int max = input.Length - 1;
        
        while (min <= max) {
            
            int mid = min + (max - min) / 2;
            
            if (input[mid] == value) {
                return mid;
            }
            else if (input[mid] < value) {
                min = mid + 1;
            }
            else {
                max = mid - 1;
            }
        }

        return -1;
    }
}