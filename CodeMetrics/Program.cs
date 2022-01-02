﻿using System;
using System.IO;
using System.Text;
using CodeMetricsBadCode.SampleClasses;

namespace CodeMetricsBadCode
{
    internal class Program
    {
        private static void Main()
        {
            CyclomaticComplexitySample();
            SampleDepthOfInheritance();
            CodeWithNoTryCatch("a");
            CodeWithEmptyTryCatch("a");
            CodeWithCorrectTryCatch("a");
            CodeWithIncorrectFileStreamManagement();
            CorrectFileStreamManagementFirstOption();
            CorrectFileStreamManagementSecondOption();
            CorrectFileStreamManagementThirdOption();
        }

        /// <summary>
        /// This code is being used just for explaning the concept of cyclomatic complexity. 
        /// It makes no sense at all. Please Calculate Code Metrics for understanding 
        /// </summary>
        private static void CyclomaticComplexitySample()
        {
            var billingMode = GetBillingMode();
            var messageResponse = ProcessCreditCardMethod();
            switch (messageResponse)
            {
                case "A":
                    if (billingMode == "M1")
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                                          $"Message Response {messageResponse}");
                    else
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                                          $"Message Response {messageResponse}");
                    break;
                case "B":
                    if (billingMode == "M2")
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                                          $"Message Response {messageResponse}");
                    else
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                                          $"Message Response {messageResponse}");
                    break;
                case "C":
                    if (billingMode == "M3")
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                                          $"Message Response {messageResponse}");
                    else
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                                          $"Message Response {messageResponse}");
                    break;
                case "D":
                    if (billingMode == "M4")
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                                          $"Message Response {messageResponse}");
                    else
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                                          $"Message Response {messageResponse}");
                    break;
                case "E":
                    if (billingMode == "M5")
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                                          $"Message Response {messageResponse}");
                    else
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                                          $"Message Response {messageResponse}");
                    break;
                case "F":
                    if (billingMode == "M6")
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                                          $"Message Response {messageResponse}");
                    else
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                                          $"Message Response {messageResponse}");
                    break;
                case "G":
                    if (billingMode == "M7")
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                                          $"Message Response {messageResponse}");
                    else
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                                          $"Message Response {messageResponse}");
                    break;
                case "H":
                    if (billingMode == "M8")
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                                          $"Message Response {messageResponse}");
                    else
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                                          $"Message Response {messageResponse}");
                    break;
                default:
                    Console.WriteLine("The result of processing is unknown");
                    break;
            }
        }

        private static void CorrectFileStreamManagementFirstOption()
        {
            FileStream file = new("C:\\file.txt", FileMode.CreateNew);
            try
            {
                var data = GetFileData();
                file.Write(data, 0, data.Length);
            }
            finally
            {
                file.Dispose();
            }
        }

        private static void CorrectFileStreamManagementSecondOption()
        {
            using (FileStream file = new FileStream("C:\\file.txt", FileMode.CreateNew)
                   {
                       ReadTimeout = 0,
                       WriteTimeout = 0,
                       Position = 0
                   })
            {
                byte[] data = GetFileData();
                file.Write(data, 0, data.Length);
            }
        }

        private static void CorrectFileStreamManagementThirdOption()
        {
            using var file = new FileStream("C:\\file.txt", FileMode.CreateNew)
            {
                ReadTimeout = 0,
                WriteTimeout = 0,
                Position = 0
            };
            byte[] data = GetFileData();
            file.Write(data, 0, data.Length);
        }

        private static void CodeWithIncorrectFileStreamManagement()
        {
            var file = new FileStream("C:\\file.txt", FileMode.CreateNew)
            {
                ReadTimeout = 0,
                WriteTimeout = 0,
                Position = 0
            };
            byte[] data = GetFileData();
            file.Write(data, 0, data.Length);
        }

        private static byte[] GetFileData()
        {
            var text = "Sample text";
            return Encoding.GetEncoding("UTF-8").GetBytes(text);
        }

        private static int CodeWithCorrectTryCatch(string textToConvert)
        {
            try
            {
                return Convert.ToInt32(textToConvert);
            }
            catch (FormatException err)
            {
                Logger.GenerateLog(err);
                return 0;
            }
        }

        private static int CodeWithEmptyTryCatch(string textToConvert)
        {
            try
            {
                return Convert.ToInt32(textToConvert);
            }
            catch
            {
                return 0;
            }
        }

        private static int CodeWithNoTryCatch(string textToConvert)
        {
            return Convert.ToInt32(textToConvert);
        }

        private static void SampleDepthOfInheritance()
        {
            SampleClass01 class01 = new SampleClass01();
            class01.DoJob();

            SampleClass02 class02 = new SampleClass02();
            class01.DoJob();

            SampleClass03 class03 = new SampleClass03();
            class01.DoJob();

            SampleClass04 class04 = new SampleClass04();
            class01.DoJob();
        }


        /// <summary>
        /// This is just an example about how to answer the "billing mode" 
        /// </summary>
        /// <returns>A result for simulating the billing mode</returns>
        private static string GetBillingMode()
        {
            return "M1";
        }

        /// <summary>
        /// This is just an example about how to answer the "credit card processing" 
        /// </summary>
        /// <returns>A result for simulating the processing method</returns>
        private static string ProcessCreditCardMethod()
        {
            return "S";
        }
    }
}