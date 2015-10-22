using System.Linq;
using CSharp.DesignPatterns.FactoryMethod.Impl;
using NUnit.Framework;

namespace CSharp.DesignPatterns.FactoryMethod.Test {
    [TestFixture]
    public class FactoryMethodTest {
        [Test]
        public void Resume_Document_Should_Have_Specific_Pages() {
            // arrange
            DocumentBase document = new ResumeDocument();

            // act
            var pages = document.Pages.Select(_ => _.ToString());

            // assert
            Assert.AreEqual(3, document.Pages.Count);

            CollectionAssert.AreEquivalent(new[] {
                "SkillsPage",
                "EducationPage",
                "ExperiencePage"
            }, pages);
        }

        [Test]
        public void Report_Document_Should_Have_Specific_Pages() {
            // arrange
            DocumentBase document = new ReportDocument();

            // act
            var pages = document.Pages.Select(_ => _.ToString());

            // assert
            Assert.AreEqual(5, document.Pages.Count);
            CollectionAssert.AreEqual(new[] {
                "IntroductionPage",
                "ResultsPage",
                "ConclusionPage",
                "SummaryPage",
                "BibliographyPage"
            }, pages);
        }
    }
}