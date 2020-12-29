using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
	class Problem14
	{
		static void Main(string[] args)
		{
			string[] strs = { "abcde123", "abcde123", "" };
			var test = new Problem14();

			Console.WriteLine(test.LongestCommonPrefix(strs));
		}

		public string LongestCommonPrefix(string[] strs)
		{
			if (strs.Length == 0)
				return string.Empty;

			int length = 0;
			string prefix = "";
			char current;
			bool exit;

			while (strs[0].Length > length)
			{
				current = strs[0][length];

				exit = false;
				foreach (var s in strs)
				{
					if (length < s.Length)
					{
						if (s[length] != current)
						{
							exit = true;
							break;
						}
					}
					else
					{
						exit = true;
						break;
					}
				}

				if (!exit)
				{
					prefix += current;
					length++;
				}
				else
					break;
			}

			return prefix;
		}
	}
}
