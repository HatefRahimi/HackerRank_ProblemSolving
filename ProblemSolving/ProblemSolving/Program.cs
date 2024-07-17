using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        #region [-1-solveMeFirst-]
        static int solveMeFirst(int a, int b)
        {

            return a + b;

        }
        #endregion

        #region [-2-simpleArraySum-]
        static int simpleArraySum(int[] ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            return sum;
        }
        #endregion

        #region [-3-compareTriplets(List<int> a, List<int> b)-]
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var list = new List<int>() { 0, 0 };
            int alice = 0;
            int bob = 0;
            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i])
                    alice++;
                if (a[i] < b[i])
                    bob++;
            }
            //if (a[0] > b[0])
            //    alice++;
            //else
            //    bob++;
            //if (a[1] > b[1])
            //    alice++; This makes the condition wrong. Because if a[1] is not greater than the other(if they are =) else block will get executed.
            //else
            //    bob++;
            //if (a[2] > b[2])
            //    alice++;
            //else
            //    bob++;

            list[0] = alice;
            list[1] = bob;
            return list;
        }
        #endregion

        #region [-4-aVeryBigSum(long[] ar)-]
        static long AVeryBigSum(long[] ar)
        {
            long sum = 0;
            foreach (var number in ar)
            {
                sum += number;
            }
            return sum;
        }
        #endregion

        #region [-5-diagonalDifference(List<List<int>> arr)-]
        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftToRightSum = 0;
            int rightToLeftSum = 0;
            int rowLength = arr[0].Count;
            // Because it's square, we get the number of rows and colums by getting the count of the first row. We can get it from everything since it is square but first one is safer.
            for (int i = 0; i < rowLength; i++)
            {
                leftToRightSum += arr[i][i];
                rightToLeftSum += arr[i][rowLength - i - 1];
            }

            return Math.Abs(leftToRightSum - rightToLeftSum);
        }
        #endregion

        #region [-6-plusMinus(int[] arr)-With Lists-]
        static void plusMinus(int[] arr)
        {
            var positive = new List<int>();
            var negative = new List<int>();
            var zero = new List<int>();
            foreach (var number in arr)
            {
                if (number < 0)
                    negative.Add(number);
                if (number == 0)
                    zero.Add(number);
                if (number > 0)
                    positive.Add(number);
            }

            Console.WriteLine((decimal)positive.Count / arr.Length);
            Console.WriteLine((decimal)negative.Count / arr.Length);
            Console.WriteLine((decimal)zero.Count / arr.Length);
        }
        #endregion

        #region [-7-plusMinus1(int[] arr)-Without lists-]
        static void plusMinus1(int[] arr)
        {
            int sumPositive = 0;
            int sumNegative = 0;
            int sumZero = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    sumPositive++;
                else if (arr[i] < 0)
                    sumNegative++;
                else
                    sumZero++;
            }
            Console.WriteLine((decimal)sumPositive / (decimal)arr.Length);
            Console.WriteLine((decimal)sumNegative / (decimal)arr.Length);
            Console.WriteLine((decimal)sumZero / (decimal)arr.Length);
        }
        #endregion

        #region [-8-staircase(int n)-]
        static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(j);
                }

                for (int j = 0; j <= i; j++)
                {

                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region [-9-miniMaxSum(int[] arr)-]
        static void miniMaxSum(int[] arr)
        {
            long sum = 0;
            foreach (var number in arr)
            {
                sum += number;
            }
            Console.Write((long)sum - arr.Max() + " ");
            Console.Write((long)sum - arr.Min());
        }
        #endregion

        #region [-10-birthdayCakeCandles(List<int> candles)-]
        public static int birthdayCakeCandles(List<int> candles)
        {
            int tallest = 0;
            int tallestCandle = candles.Max();

            foreach (var candle in candles)
            {
                if (candle == tallestCandle)
                {
                    tallest += 1;
                }

            }
            return tallest;
        }

        #endregion

        #region [-11-timeConversion(string s)- Using C# Built-in Methods-]
        static string timeConversion(string s)
        {
            //07:05:45PM
            //19:05:45
            var time = Convert.ToDateTime(s);
            var hour = time.ToString("HH:mm:ss");
            return hour;
        }
        #endregion

        #region [-12-timeConversion(string s)-Without Using C# Built-in Methods-]
        static string timeConversion1(string s)
        {
            var time = s.Substring(0, s.Length - 2);
            var amOrPm = s.Substring(s.Length - 2);
            var timeComponents = time.Split(':');
            var hour = timeComponents[0];
            var minute = timeComponents[1];
            var second = timeComponents[2];
            if (amOrPm == "PM")
            {
                if (hour != "12")
                    hour = (Convert.ToInt32(hour) + 12).ToString();
            }
            if (amOrPm == "AM")
            {
                if (hour == "12")
                    hour = "00";
            }

            return hour + ":" + minute + ":" + second;

        }
        #endregion

        #region [-13-gradingStudents(List<int> grades)-]
        public static List<int> gradingStudents(List<int> grades)
        {
            var finalGrade = new List<int>();
            foreach (var score in grades)
            {
                if (score % 5 < 3 || score < 38)
                {
                    finalGrade.Add(score);
                }
                else
                {
                    finalGrade.Add(score + (5 - score % 5));
                }
            }
            return finalGrade;
        }
        #endregion

        #region [-14-Apple and Orange-]
        static void countApplesAndOranges
          (int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            var sumApple = 0;
            var sumOrange = 0;
            foreach (var apple in apples)
            {
                if ((apple + a) <= t && (apple + a) >= s)
                    sumApple++;
            }
            foreach (var orange in oranges)
            {
                if ((orange + b) <= t && (orange + b) >= s)
                    sumOrange++;
            }

            Console.WriteLine(sumApple);
            Console.WriteLine(sumOrange);
        }
        #endregion

        #region [-15-Number Line Jumps- Kangaroo]


        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 > v2)
                if ((x2 - x1) % (v2 - v1) == 0) // If the remainder of the equation we had equals zero, it means that the number of jumps got equal.
                    return "YES";
            return "NO";
        }
        #endregion

        #region [**-16-Between Two Sets-**]
        public static int getTotalX(List<int> a, List<int> b)
        {
            int firstElement = a[a.Count - 1];
            int lastElement = b[0];
            var multipleOfFirstElement = firstElement;
            int count = 0;
            var counter = 1;
            while (multipleOfFirstElement <= lastElement)
            {
                bool firstCondition = true;
                foreach (var element in a)
                {
                    if ((multipleOfFirstElement % element) != 0)
                    {
                        firstCondition = false;
                        break;
                    }
                }
                if (firstCondition)
                {
                    foreach (var element in b)
                    {
                        if ((element % multipleOfFirstElement) != 0)
                        {
                            firstCondition = false;
                            break;
                        }
                    }
                }

                if (firstCondition)
                    count++;
                counter++;
                multipleOfFirstElement = counter * firstElement;
                // We cannot directly multiply our firstElement(Maximum of A) by counter and add up one number to it simultaneously.
                // Because it exceeds While condition sooner than we want.
            }

            return count;
        }
        #endregion

        #region [-**-16-Between Two Sets-**-]
        public static int getTotalX()
        {
            var a = new List<int>() { 2, 4 };
            var b = new List<int>() { 16, 32, 96 };
            int firstElement = a[a.Count - 1];
            int lastElement = b[0];
            int sum = 0;
            while (firstElement <= lastElement)
            {
                bool condition = true;
                foreach (var element in a)
                {
                    if ((firstElement) % element != 0)
                        condition = false;
                }
                if (condition)
                {
                    foreach (var element in b)
                    {
                        if (element % (firstElement) != 0)
                            condition = false;
                    }
                }
                if (condition)
                    sum++;

                firstElement++;
            }

            return sum;
        }
        #endregion

        #region [-17-breakingRecords(int[] scores)-]
        static int[] breakingRecords(int[] scores)
        {
            var minimum = scores[0];
            var maximum = scores[0];
            var bufferMax = new List<int>();
            var bufferMin = new List<int>();
            foreach (var score in scores)
            {
                if (score > maximum)
                {
                    maximum = score;
                    bufferMax.Add(maximum);
                }
                if (score < minimum)
                {
                    minimum = score;
                    bufferMin.Add(minimum);
                }
            }
            int[] result = new int[] { bufferMax.Count(), bufferMin.Count() };
            return result;
        }
        #endregion

        #region [**-18-Subarray Division-**]
        static int birthday(List<int> s, int d, int m)
        {
            int currentSum = 0;
            int ways = 0;
            for (int i = 0; i < s.Count; i++)
            {
                currentSum += s[i];
                if (i >= m - 1)
                {
                    if (currentSum == d)
                        ways++;

                    // Sliding Window Pattern algorithm (fixed form)
                    currentSum -= s[i - (m - 1)];
                }
            }
            return ways;
        }
        #endregion

        #region [-**-18-Subarray Division-**-]
        static int birthday()
        {
            // Slower version, especially when our array is big and our m is also big.
            int[] s = { 2, 2, 1, 3, 2 };
            var d = 4;
            var m = 2;
            var ways = 0;
            for (int i = 0, j = 0, tmp = 0; i < s.Length - 1; j = 0, tmp = 0, i++)
            {
                for (; j < m; j++)
                    tmp += s[j + i];

                if (tmp == d)
                    ways++;
            }
            return ways;
        }
        #endregion

        #region [-**-18-Subarray Division-**-]
        public static int birthdayy(List<int> s, int d, int m)
        {
            var ways = 0;
            for (int i = 0; i < s.Count - m; i++)
            {
                int currentRunningSum = 0;
                for (int j = i; j < i + m; j++)
                {
                    currentRunningSum += s[j];
                }

                if (currentRunningSum == d)
                {
                    ways++;
                }
            }

            return ways;
        }
        #endregion


        #region [-19-divisibleSumPairs(int n, int k, int[] ar)-]
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            // n equals to ar.Length
            var ways = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = i + 1; j < ar.Length; j++) // Will not be terminated till j value reaches 6(size of array)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        ways++;
                    }
                }
            }
            return ways;
        }
        #endregion

        #region [-20-migratoryBirds(List<int> arr)-]
        static int migratoryBirds(List<int> arr)
        {
            var storage = new List<int>() { 0, 0, 0, 0 };
            foreach (var birdId in arr)
            {
                if (birdId == 1)
                    storage[0]++;
                if (birdId == 2)
                    storage[1]++;
                if (birdId == 3)
                    storage[2]++;
                if (birdId == 4)
                    storage[3]++;
                if (birdId == 5)
                    storage[4]++;
            }
            var max = storage[0];
            int result = 0;
            for (int i = 0; i < storage.Count; i++)
            {
                if (storage[i] > max)
                {
                    max = storage[i];
                    result = i;
                }
            }
            return result + 1;
        }
        #endregion

        #region [-21-camelCase(string s)-]
        static void camelCase(string s)
        {
            //var s = "oneTwoThree";
            var count = 1;// Counting first letter here.
            for (int i = 0; i < s.Length; i++)
            {
                if (char.ToUpper(s[i]) == s[i]) //char.toUpper() converts a value into the uppercase
                    count++;
            }
            Console.WriteLine(count);
        }
        #endregion

        #region [-**-22-MinimumPassword(int n, string password)-**-]
        static int MinimumPassword(int n, string password)
        {
            char[] upperCase = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] lowerCase = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] specialChars = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+' };
            char[] digits = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            int required = 0;
            if (password.IndexOfAny(upperCase) == -1) required++;
            if (password.IndexOfAny(lowerCase) == -1) required++;
            if (password.IndexOfAny(specialChars) == -1) required++;
            if (password.IndexOfAny(digits) == -1) required++;
            var result = required > (6 - password.Length) ? required : 6 - password.Length;
            return result;

            //Password should be least 6 charecters.
            //So, if required charecters are more than the minumum password length(like 1234@), it should return the required chaecters(2 in this case)
            // If not(like 12), it should return minimum charecters neccessary for our password(4 in this case)

            //Returns
            //Int32
            //The zero-based index position of the first occurrence in this instance where any character in anyOf was found; -1 if no character in anyOf was found.
        }

        #endregion

        #region [23-SalesbyMatch(int[] ar)-]
        static int SalesbyMatch(int[] ar)
        {
            //int[] ar = new int[] { 1, 2, 1, 2, 1, 3, 2 };
            var set = new List<int>();
            int pair = 0;

            foreach (var i in ar)
            {
                if (set.Contains(i))
                    continue;
                int[] matchedItems = Array.FindAll(ar, x => x == i);// This line goes through each element and finds the items that satisfy this condtition
                // for eg=> in first iteration, it tries to match ar[0](1) with all the other elements to the end of ar.Length(the number of ones is 3)
                // Then it goes to the next number and does the same thing.
                int occurancies = matchedItems.Length;
                if (occurancies > 1)
                    pair += ((occurancies - (occurancies % 2)) / 2);
                set.Add(i);
            }

            return pair;

        }
        #endregion

        #region [23-SalesByMatch(int[] ar)-]
        static int SalesByMatch(int[] ar)
        {
            //int[] numbers = { 10, 10, 10, 10, 20, 20, 20, 30, 50, 54 };
            var numberList = new List<int>();
            int max = ar.Max() + 1;
            int count = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == max)
                    continue;
                else
                {
                    for (int j = i + 1; j < ar.Length; j++)
                    {
                        if (ar[i] == ar[j])
                        {

                            ar[i] = max;
                            ar[j] = max;
                            count++;
                            break;
                        }
                    }
                }
            }
            return count;
        }
        #endregion

        #region [24-DayOfProgrammer(int year)-]
        static string DayOfProgrammer(int year)
        {
            if (year < 1918)
            {
                if (year % 4 == 0)
                    return $"12.09.{year}";
                else
                    return $"13.09.{year}";
            }
            if (year > 1918)
            {
                if (year % 400 == 0 && year % 100 != 0)
                    return $"12.09.{year}";
                else
                    return $"13.09.{year}";
            }
            return "year";
        }
        #endregion

        #region [25-countingValleys(int steps, string path)-]
        static int countingValleys(int steps, string path)
        {
            // How we can find out that we have passed a valley?
            // When we are going uphill and back to sea level again!
            var currentLevel = 0;
            var numberOfValleys = 0;

            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == 'U')
                    currentLevel++;
                if (path[i] == 'D')
                    currentLevel--;
                if (currentLevel == 0 && path[i] == 'U')
                    numberOfValleys++;
            }
            return numberOfValleys;
        }
        #endregion

        #region [-26-Electronic Shops-]
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            var jaggedArray = new int[2][];
            jaggedArray[0] = keyboards;
            jaggedArray[1] = drives;
            var results = new List<int>();
            int sum = 0;
            for (int j = 0, i = 0; j < jaggedArray[0].Length; i = 0, j++)
            {
                for (; i < jaggedArray[1].Length; i++)
                {
                    sum = jaggedArray[0][j] + jaggedArray[1][i];
                    if (sum <= b)
                        results.Add(sum);
                }
            }
            if (!results.Any())
                return -1;
            return results.Max();
        }
        #endregion

        #region [-27-formingMagicSquare(int[][] s)-]
        public static int formingMagicSquare(int[][] s)
        {
            var squares = new int[][]
            {
                 new int[] {8,3,4,1,5,9,6,7,2 },
                 new int[] {4,3,8,9,5,1,2,7,6 },
                 new int[] {8,1,6,3,5,7,4,9,2 },
                 new int[] {6,1,8,7,5,3,2,9,4 },
                 new int[] {2,9,4,7,5,3,6,1,8 },
                 new int[] {4,9,2,3,5,7,8,1,6 },
                 new int[] {2,7,6,9,5,1,4,3,8 },
                 new int[] {6,7,2,1,5,9,8,3,4 }
             };

            int min = int.MaxValue;
            for (int i = 0; i < squares.Length; i++)
            {
                int total = 0;
                for (int j = 0; j < squares[i].Length; j++)
                {
                    total += Math.Abs(s[j / 3][j % 3] - squares[i][j]);
                }

                if (total < min)
                    min = total;
            }
            return min;
        }
        #endregion

        #region [-28-PickingNumbers(List<int> a)-]
        public static int PickingNumbers(List<int> a)
        {
            var numbers = a.ToArray();
            Array.Sort(numbers);
            int max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int temp = 0;
                for (int j = i; j < numbers.Length; j++)
                {

                    if (Math.Abs(numbers[i] - numbers[j]) <= 1) temp += 1;

                    if (temp > max)
                        max = temp;
                }
            }
            return max;
        }
        #endregion

        #region [-29-Sherlock and the squares-]
        public static int squares(int a, int b)
        {
            var x1 = (int)Math.Ceiling(Math.Sqrt(a));
            var x2 = (int)Math.Floor(Math.Sqrt(b));

            int result = Convert.ToInt32((x2 - x1) + 1);

            return result;

        }
        #endregion

        #region [-FindDigits(int n)-]
        public static int FindDigits(int n)
        {
            //12
            var input = n.ToString();
            var count = 0;
            var numbers = new List<double>();
            for (int i = 0; i < input.Length; i++)
            {
                numbers.Add(char.GetNumericValue(input[i]));
            }
            foreach (var number in numbers)
            {
                if (n % number == 0)
                    count += 1;
            }

            return count;

        }
        #endregion

        #region [-FindDigits1(int n)-]
        public static int FindDigits1(int n)
        {
            //12
            // Numeric value of 1 is 1. If we don't use this method, computer sees the ascii code behind 1,
            // Which is 49!
            var input = n.ToString();
            var count = 0;
            var numbers = new List<double>();
            for (int i = 0; i < input.Length; i++)
            {
                if (n % char.GetNumericValue(input[i]) == 0)
                    count += 1;
            }
            return count;

        }
        #endregion

        #region [-hurdleRace-]
        public static int hurdleRace(int k, List<int> height)
        {
            var numberBuffer = new List<int>();
            foreach (var number in height)
            {
                if (k < number)
                    numberBuffer.Add(number);
            }

            return numberBuffer.Count >= 1 ? numberBuffer.Max() - k : 0;

        }
        #endregion

        #region [Iterpret From Leetcode]
        public static string Interpret(string command)
        {
            string emptyString = "";
            int i = 0;
            while (i < command.Length)
            {
                if (command[i] == 'G')
                {
                    emptyString += 'G';
                    i++;
                }
                else if (command.Substring(i, 2) == "()")
                {
                    emptyString += 'o';
                    i += 2;
                }
                else if (command.Substring(i, 4) == "(al)")
                {
                    emptyString += "al";
                    i += 4;
                }
                else
                {
                    i++;
                }
            }

            return emptyString;
        }
        #endregion


        #region [CountConsistentStrings From Leetcode]
        // You are given a string allowed consisting of distinct characters and an array of strings words.A string is consistent if all characters in the string appear in the string allowed.
        // You are given a string allowed consisting of distinct characters and an array of strings words.A string is consistent if all characters in the string appear in the string allowed.
        //Return the number of consistent strings in the array words.
        public static int CountConsistentStrings(string allowed, string[] words)
        {
            var allowedCharacters = new List<char>();
            var consistentStrings = new List<string>();

            foreach (var character in allowed)
            {
                allowedCharacters.Add(character);
            }

            foreach (var word in words)
            {
                bool isConsistent = true;
                foreach (var character in word)
                {
                    if (!allowedCharacters.Contains(character))
                    {
                        isConsistent = false;
                        break;
                    }
                }

                if (isConsistent)
                    consistentStrings.Add(word);
            }

            return consistentStrings.Count;
        }

        #endregion

        #region [SumOfUnique From Leetcode]
        public static int SumOfUnique(int[] nums)
        {
            var frequency = new Dictionary<int, int>();

            foreach (int number in nums)
            {
                if (!frequency.ContainsKey(number))
                    frequency[number] = 1;
                else
                    frequency[number]++;
            }

            var sum = 0;
            foreach (var item in frequency)
            {
                if (item.Value == 1)
                    sum = sum + item.Key;
            }

            return sum;
        }
        #endregion
    }
}
