namespace CSharp.DesignPatterns.FactoryMethod.Impl {
    public class ReportDocument : DocumentBase {
        #region Public Override Methods

        public override void CreatePages() {
            Pages.Clear();
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }

        #endregion
    }
}