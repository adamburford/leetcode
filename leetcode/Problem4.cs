using System;

namespace leetcode
{
    class Problem4
    {
  //      static void Main(string[] args)
  //      {
		//	int[] test1 = { };
		//	int[] test2 = { 1,2,3,4,5};

		//	var a = new Problem4();

		//	Console.WriteLine(a.FindMedianSortedArrays(test1, test2));
		//}

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int totalLength = nums1.Length + nums2.Length;
            int median = totalLength / 2;

            int index1 = 0;
            int index2 = 0;
            int i = 0;
    

            if ((totalLength & 1) == 1)
            {
                while ((i < median) && (index1 < nums1.Length) && (index2 < nums2.Length))
                {
                    
                    if (nums1[index1] < nums2[index2])
                    {
                        index1++;
						i++;
                    }
                    else
                    {
                        index2++;
						i++;
                    }

                }

                if (i < median)
                {
                    if (index1 == nums1.Length)
                        index2 += median - i;
                    else
                        index1 += median - i;
                }

                if (index1 == nums1.Length)
                    return nums2[index2];
                else if (index2 == nums2.Length)
                    return nums1[index1];
                else
                    return nums1[index1] < nums2[index2] ? nums1[index1] : nums2[index2];
            }
            else
			{
                while ((i < median - 1) && (index1 < nums1.Length) && (index2 < nums2.Length))
                {
                    if (nums1[index1] < nums2[index2])
                    {
                        index1++;
						i++;
                    }
                    else
                    {
                        index2++;
						i++;
                    }

                }

                if (i < median - 1)
                {
                    if (index1 == nums1.Length)
                        index2 += median - 1 - i;
                    else
                        index1 += median - 1 - i;
                }

                int a;
                
                if (index1 == nums1.Length)
					return (nums2[index2] + nums2[index2 + 1]) / 2.0;
				else if (index2 == nums2.Length)
					return (nums1[index1] + nums1[index1 + 1]) / 2.0;
				else
				{
					if (nums1[index1] < nums2[index2])
					{
						a = nums1[index1];
						index1++;
					}
					else
					{
						a = nums2[index2];
						index2++;
					}

					if (index1 == nums1.Length)
						return (a + nums2[index2]) / 2.0;
					else if (index2 == nums2.Length)
						return (a + nums1[index1]) / 2.0;
					else
						return ( a + (nums1[index1] < nums2[index2] ? nums1[index1] : nums2[index2])) / 2.0;
				}
            } 
        }
    }
}
