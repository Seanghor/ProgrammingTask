using System;

namespace NotificationChanelsParser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input string:
            Console.Write("Input: "); string input = Console.ReadLine();

            // Handle input null or space:
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Output: No input provided!!");
            }
            else
            {
                ParseNotificationChannels(input);
            }
        }

        static void ParseNotificationChannels(string input)
        {
            // Valid channels :
            string[] validChannels = { "BE", "FE", "QA", "Urgent" };

            // Result :
            string resChanels = "Receive channels: ";

            // default:
            bool hasValidChannels = false;

            // Loop to find if input value matches valid channels :
            foreach (var channel in validChannels)
            {
                if (input.Contains($"[{channel}]"))
                {
                    resChanels += channel + ", ";
                    hasValidChannels = true;
                }
            }

            // --- check if the input is matches then remove comman and space otherwise print Message
            if (hasValidChannels)
            {
                // Remove comma and space
                resChanels = resChanels.TrimEnd(',', ' ');
                Console.WriteLine("Output: " + resChanels);
            }
            else
            {
                Console.WriteLine("Output: No valid channels found.");
            }
        }
    }
}
