namespace CSharp.DesignPatterns.FactoryMethod.Impl {
    public class ResumeDocument : DocumentBase {
        #region Public Override Methods

        public override void CreatePages() {
            Pages.Clear();
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }

        #endregion
    }
}