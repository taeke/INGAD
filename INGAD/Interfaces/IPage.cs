//------------------------------------------------------------------------------------------------
// <copyright file="IPage.cs" company="Taeke van der Veen">
// Taeke van der Veen september 2014
// </copyright>
// Visual Studio Premiun 2013
// <summary>This is the Program class.</summary>
//------------------------------------------------------------------------------------------------
namespace INGAD.Interfaces
{
    /// <summary>
    /// Information about and the content of a html page with table data.
    /// </summary>
    public interface IPage
    {
        /// <summary>
        /// Gets or sets the content of the page.
        /// </summary>
        string Html { get; set; }

        /// <summary>
        /// Gets or sets the number of the page. 
        /// </summary>
        int PageNumber { get; set; }
    }
}
