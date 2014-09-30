//------------------------------------------------------------------------------------------------
// <copyright file="IHtmlDataState.cs" company="Taeke van der Veen">
// Taeke van der Veen september 2014
// </copyright>
// Visual Studio Premiun 2013
// <summary>This is the Program class.</summary>
//------------------------------------------------------------------------------------------------

namespace INGAD.Interfaces
{
    using INGAD.Enums;

    /// <summary>
    /// Holds the current state for de IHtmlData instance.
    /// </summary>
    public interface IHtmlDataState
    {
        /// <summary>
        /// Gets or sets the result of the latest page we where trying to load.
        /// </summary>
        PageLoadResult PageLoadResult { get; set; }
    }
}
