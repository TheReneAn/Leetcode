namespace Leetcode
{
    class TopKFrequentElements
    {
        static void Main(string[] args)
        {
            // Example test cases
            int[] num1 = [1, 1, 1, 2, 2, 3];
            int[] num2 = [1];

            var resultNum1 = Answer1_TopKFrequent(num1, 2); // Expected output: [1, 2]
            var resultNum2 = Answer1_TopKFrequent(num2, 1); // Expected output: [1]

            // Print results
            Console.WriteLine(string.Join(" ", resultNum1));
            Console.WriteLine(string.Join(" ", resultNum2));
        }
        
        // Method to find the k most frequent elements in the array
        static int[] Answer1_TopKFrequent(int[] nums, int k)
        {
            // Dictionary to count the frequency of each element
            var frequentCountList = new Dictionary<int, int>();

            foreach (var item in nums)
            {
                // Increment count if exists, otherwise initialize to 1
                if (frequentCountList.ContainsKey(item))
                {
                    frequentCountList[item]++;
                }
                else
                {
                    frequentCountList[item] = 1;
                }
            }

            // Result array to store top k frequent elements
            var frequentElementList = new int[k];

            for (var i = 0; i < k; i++)
            {
                int maxKey = default;
                int maxCount = -1;

                // Find the element with the highest frequency
                foreach (var pair in frequentCountList)
                {
                    if (pair.Value > maxCount)
                    {
                        maxCount = pair.Value;
                        maxKey = pair.Key;
                    }
                }

                // Store the element and remove it from the dictionary to avoid reuse
                frequentElementList[i] = maxKey;
                frequentCountList.Remove(maxKey);
            }

            return frequentElementList;
        }
    }
}