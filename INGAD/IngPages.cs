//------------------------------------------------------------------------------------------------
// <copyright file="IngPages.cs" company="Taeke van der Veen">
// Taeke van der Veen september 2014
// </copyright>
// Visual Studio Premiun 2013
// <summary>This is the Program class.</summary>
//------------------------------------------------------------------------------------------------
namespace INGAD
{
    using System;
    using INGAD.Interfaces;
    using OpenQA.Selenium;

    /// <inheritDoc/>
    public class IngPages : IHtmlData
    {
        private IWebDriver webDriver;
        private IHtmlDataState htmlDataState;

        /// <summary>
        /// Initializes a new instance of the <see cref="IngPages"/> class.
        /// </summary>
        /// <param name="webDriver"> The <see cref="IWebDrive"/> instance. </param>
        /// <param name="htmlDataState"> The <see cref="IHtmlDataState"/> instance. </param>
        public IngPages(IWebDriver webDriver, IHtmlDataState htmlDataState)
        {
            this.webDriver = webDriver;
            this.htmlDataState = htmlDataState;
        }

        /// <inheritDoc/>
        public IHtmlDataState HtmlDataState
        {
            get { return this.htmlDataState; }
        }

        /// <inheritDoc/>
        public IPage GetNextPage()
        {
            switch (this.htmlDataState.PageLoadResult)
            {
                case INGAD.Enums.PageLoadResult.None:
                    return this.Login();
                case INGAD.Enums.PageLoadResult.LoginPageNotFound:
                    return null;
                case INGAD.Enums.PageLoadResult.CouldNotLogon:
                    return null;
                case INGAD.Enums.PageLoadResult.NewDataAvailable:
                    return null;
                case INGAD.Enums.PageLoadResult.NoNewDataAvailable:
                    return null;
                case INGAD.Enums.PageLoadResult.LoadFailed:
                    return null;
                default:
                    return null;
            }
        }

        private IPage Login()
        {
            this.webDriver.Navigate().GoToUrl("https://mijn.ing.nl/internetbankieren/SesamLoginServlet");
            return null;
        }
    }
}
