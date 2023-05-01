using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseConsole
{
    public class Service
    {
        public int choose(List<SingleUser> usersList)
        {
            OperationsService operations = new OperationsService();
            Console.WriteLine("Type in: create / show / remove / update / oldest / youngest / average / longest / shortest / vowels / initials / reverse. To close the programme type in: exit");
            string addSee = Console.ReadLine();
            switch (addSee)
            {
                case "create":
                    addSeeUser(usersList);
                    return 0;
                    break;

                case "show":
                    showUsers(usersList);
                    return 0;
                    break;

                case "remove":
                    removeUser(usersList);
                    return 0;
                    break;

                case "update":
                    updateUser(usersList);
                    return 0;
                    break;

                case "oldest":
                    operations.oldestUser(usersList);
                    return 0;
                    break;

                case "youngest":
                    operations.youngestUser(usersList);
                    return 0;
                    break;

                case "average":
                    operations.averageAge(usersList);
                    return 0;
                    break;

                case "longest":
                    operations.longestName(usersList);
                    return 0;
                    break;

                case "shortest":
                    operations.shortestName(usersList);
                    return 0;
                    break;

                case "vowels":
                    operations.mostVowels(usersList);
                    return 0;
                    break;

                case "initials":
                    operations.userInitials(usersList);
                    return 0;
                    break;

                case "reverse":
                    operations.mirrorName(usersList);
                    return 0;
                    break;

                case "exit":
                    Console.WriteLine("Closing programme...");
                    return 1;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("Incorrect word. Type in again.");
                    Console.ResetColor();
                    return 0;
                    break;
            }
        }

        private void addSeeUser(List<SingleUser> userparameterList)
        {
                SingleUser newUser = new SingleUser();
                Console.WriteLine("Introduce first name");
                string firstName = Console.ReadLine();
                Console.WriteLine("Introduce last name");
                string lastName = Console.ReadLine();
                Console.WriteLine("Introduce age");
                int age = Convert.ToInt32(Console.ReadLine());
                newUser.firstName = firstName;
                newUser.lastName = lastName;
                newUser.age = age;
                userparameterList.Add(newUser);
                Console.WriteLine("User saved!");
                Console.WriteLine("");
          
        }

        private void showUsers(List<SingleUser> userparameterList)
        {
            if (userparameterList.Count == 0)
            {
                Console.WriteLine("No users added");
                Console.WriteLine("");
                return;
            }
            else
            {
                userparameterList.ForEach(e => Console.WriteLine(e.firstName + " " + e.lastName + " " + e.age));
            }
        }
        private void removeUser(List<SingleUser> userparameterList)
        {
            Console.WriteLine("Type the name of the user you want to remove");
            Console.WriteLine("");
            string userToRemove = Console.ReadLine();
            for (int i = 0; i < userparameterList.Count; i++)
            {
                if (userparameterList[i].firstName == userToRemove)
                {
                    userparameterList.Remove(userparameterList[i]);
                    Console.WriteLine("User removed");
                    Console.WriteLine("");
                    return;
                }
                else if (userparameterList[i].firstName != userToRemove)
                {
                    Console.WriteLine("This user does not exist. Type name of an existing user");
                    Console.WriteLine("");
                    return;
                }
            }
        }
        private void updateUser(List<SingleUser> userparameterList)
        {
                Console.WriteLine("Type the name of the user you want to update");
                string userToUpdate = Console.ReadLine();
                for (int i = 0; i < userparameterList.Count; i++)
                {
                    if (userparameterList[i].firstName == userToUpdate)
                    {
                        Console.WriteLine("Change first name");
                        userparameterList[i].firstName = Console.ReadLine();
                        Console.WriteLine("Change last name");
                        userparameterList[i].lastName = Console.ReadLine();
                        Console.WriteLine("Change age");
                        userparameterList[i].age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("User updated!");
                        Console.WriteLine("");
                        return;
                    }
                    else if (userparameterList[i].firstName != userToUpdate)
                    {
                        Console.WriteLine("This user does not exist. Type name of an existing user");
                        Console.WriteLine("");
                        return;
                }
            }
        }
    }
}
