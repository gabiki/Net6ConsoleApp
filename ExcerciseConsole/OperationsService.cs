using ExcerciseConsole;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;

namespace ExcerciseConsole
{
    public class OperationsService
    {
        public void oldestUser(List<SingleUser> userparameterList)
        {
            int oldest = userparameterList.Max(u => u.age);
            Console.WriteLine("The youngest user is:" + oldest + ".");
        }
        public void youngestUser(List<SingleUser> userparameterList)
        {
            int youngest = userparameterList.Min(u => u.age);
            Console.WriteLine("The youngest user is:" + youngest + ".");
        }
        public void averageAge(List<SingleUser> userparameterList)
        {
            double averageofAge = userparameterList.Average(u => u.age); 
            Console.WriteLine("The average age os users is:" + averageofAge + ".");
        }
        public void longestName(List<SingleUser> userparameterList)
        {
            string[] nameList = userparameterList.Select(x => x.firstName).ToArray();
            string longestString = nameList.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
            Console.WriteLine("The longest user name is: " + longestString + ".");
        }
        public void shortestName(List<SingleUser> userparameterList)
        {
            List<string> nameList = userparameterList.Select(x => x.firstName).ToList();
            string shortestString = nameList.Aggregate((min, cur) => min.Length < cur.Length ? min : cur);
            Console.WriteLine("The shortest user name is: " + shortestString + ".");
        }
        public void mostVowels(List<SingleUser> userparameterList)
        {   
            List<char> vowelsList = new List<char>()
            {
                'a',
                'e',
                'i',
                'o',
                'u'
            };
            List<string> nameList = userparameterList.Select(x => x.firstName).ToList();
            int maxFreq = 0;
            List<NameAndVowel> nameVowels = new List<NameAndVowel>();
            for (int i = 0; i < nameList.Count; i++)
            {  
                NameAndVowel nameVowel = new NameAndVowel();
                int counter = 0;
                int maxNumber = 0;
                string singleName = nameList[i];
                for (int j = 0; j < vowelsList.Count; j++)
                {
                    char singleVowel = vowelsList[j];
                    int freq = singleName.Count(f => f == singleVowel);
                    counter += freq;
                    if (counter > maxNumber)
                    {
                        maxNumber = counter;
                    };
                };
                nameVowel.firstName = singleName;
                nameVowel.vowel = maxNumber;
                nameVowels.Add(nameVowel);
            };
            int maxfindVowel = nameVowels.Max(x => x.vowel);
            NameAndVowel objectMax = nameVowels.Find(x => x.vowel == maxfindVowel);
            Console.WriteLine(objectMax.firstName);
        }
        public void userInitials(List<SingleUser> userparameterList)
        {
           
            Console.WriteLine("Introduce user's first name to see the initals");
            string firstNameInitials = Console.ReadLine();
            var user = userparameterList.Find(u => u.firstName == firstNameInitials);
            string initialName = user.firstName.Substring(0, 1);
            string initialLastName = user.lastName.Substring(0, 1);
            Console.WriteLine(initialName + initialLastName);

        }
        public void mirrorName(List<SingleUser> userparameterList)
        {
            Console.WriteLine("Introduce user's first name to see the mirror name");
            string firstName = Console.ReadLine();
            var user = userparameterList.Find(u => u.firstName == firstName);
            string initialName = user.firstName;
            char[] array = initialName.ToCharArray(); 
            Array.Reverse(array);
            string reversedName = new String(array); 
            Console.WriteLine(reversedName);
        }
    }                                                              
}