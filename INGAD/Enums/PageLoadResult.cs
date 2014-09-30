//------------------------------------------------------------------------------------------------
// <copyright file="PageLoadResult.cs" company="Taeke van der Veen">
// Taeke van der Veen september 2014
// </copyright>
// Visual Studio Premiun 2013
// <summary>This is the Program class.</summary>
//------------------------------------------------------------------------------------------------
namespace INGAD.Enums
{
    /// <summary>
    /// Trying to load a html page can have different results.
    /// </summary>
    public enum PageLoadResult
    {
        /// <summary>
        /// We didn't load a page yet.
        /// </summary>
        None,

        /// <summary>
        /// We first need to logon but the login page could not be found.
        /// </summary>
        LoginPageNotFound,

        /// <summary>
        /// We could not logon.
        /// </summary>
        CouldNotLogon,

        /// <summary>
        /// We have new data available.
        /// </summary>
        NewDataAvailable,

        /// <summary>
        /// There is no (more) data available.
        /// </summary>
        NoNewDataAvailable,

        /// <summary>
        /// We are logged in but we got a failure loading (more) data.
        /// </summary>
        LoadFailed
    }
}
