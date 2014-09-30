//------------------------------------------------------------------------------------------------
// <copyright file="IHtmlData.cs" company="Taeke van der Veen">
// Taeke van der Veen september 2014
// </copyright>
// Visual Studio Premiun 2013
// <summary>This is the Program class.</summary>
//------------------------------------------------------------------------------------------------
namespace INGAD.Interfaces
{
    /// <summary>
    /// For loading html pages with table data.
    /// </summary>
    public interface IHtmlData
    {
        /// <summary>
        /// Gets the state of the current page.
        /// </summary>
        IHtmlDataState HtmlDataState { get; }

        /// <summary>
        /// Gets the next page with table data. Will login to the site if necessary.
        /// </summary>
        /// <returns> True if the page could be loaded. </returns>
        IPage GetNextPage();
    }
}
