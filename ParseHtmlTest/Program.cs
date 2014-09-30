//------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Taeke van der Veen">
// Taeke van der Veen september 2014
// </copyright>
// Visual Studio Premiun 2013
// <summary>This is the Program class.</summary>
//------------------------------------------------------------------------------------------------
namespace ParseHtmlTest
{
    using System;
    using System.Linq;
    using HtmlAgilityPack;

    /// <summary>
    /// Startup class for the application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Starting point for the application.
        /// </summary>
        /// <param name="args"> The arguments passed in from the console. </param>
        public static void Main(string[] args)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.OptionFixNestedTags = true;
            htmlDoc.Load("ing.html");

            if (htmlDoc.ParseErrors != null && htmlDoc.ParseErrors.Count() > 0)
            {
                // Handle any parse errors as required
            }
            else
            {
                if (htmlDoc.DocumentNode != null)
                {
                    foreach (var cell in htmlDoc.DocumentNode.SelectNodes("//table[@class='ib-datatable transactions-table']//tr[@class='ib-datatable-contents ng-scope']/td"))
                    {
                        Console.WriteLine(cell.InnerHtml);
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine("We are done");
            Console.ReadKey();
        }
    }
}
