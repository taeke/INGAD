//------------------------------------------------------------------------------------------------
// <copyright file="IngPagesTests.cs" company="Taeke van der Veen">
// Taeke van der Veen september 2014
// </copyright>
// Visual Studio Premiun 2013
// <summary>This is the Program class.</summary>
//------------------------------------------------------------------------------------------------
namespace INGAD.Tests
{
    using INGAD.Enums;
    using INGAD.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using OpenQA.Selenium;

    /// <summary>
    /// Tests for the IngPages class.
    /// </summary>
    [TestClass]
    public class IngPagesTests
    {
        /// <summary>
        /// Gets or sets the object under test.
        /// </summary>
        protected IngPages ingPages;

        /// <summary>
        /// Mock for the IWebDriver.
        /// </summary>
        protected Mock<IWebDriver> webDriverMock = new Mock<IWebDriver>(MockBehavior.Strict);

        /// <summary>
        /// Mock for the INavigation.
        /// </summary>
        protected Mock<INavigation> navigationMock = new Mock<INavigation>(MockBehavior.Strict);

        /// <summary>
        /// Mock for htmlDataState.
        /// </summary>
        protected Mock<IHtmlDataState> htmlDataStateMock = new Mock<IHtmlDataState>(MockBehavior.Strict);

        protected PageLoadResult pageLoadResults = PageLoadResult.None;

        /// <summary>
        /// Initializing for every test.
        /// </summary>
        [TestInitialize]
        public void IngPagesInitialize()
        {
            this.navigationMock.Setup(x => x.GoToUrl(It.IsAny<string>())).Verifiable();
            this.webDriverMock.Setup(x => x.Navigate()).Returns(this.navigationMock.Object);
            this.htmlDataStateMock.Setup(x => x.PageLoadResult).Returns(this.pageLoadResults);
            this.ingPages = new IngPages(this.webDriverMock.Object, this.htmlDataStateMock.Object);
        }

        /// <summary>
        /// Tests for the GetNextPage method.
        /// </summary>
        [TestClass]
        public class TheGetNextPageMethod : IngPagesTests
        {
            /// <summary>
            /// Testing should.
            /// </summary>
            [TestMethod]
            public void ShouldCallNavigateToLoginPageOnWebDriver()
            {
                // Arrange

                // Act
                this.ingPages.GetNextPage();

                // Assert
                this.webDriverMock.Verify(x => x.Navigate());
            }
        }
    }
}
