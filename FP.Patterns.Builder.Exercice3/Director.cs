namespace FP.Patterns.Builder.Exercice3
{
    public class Director
    {
        public void CreateDocument(IDocumentBuilder documentBuilder)
        {
            documentBuilder.BuildHeading();
            documentBuilder.BuildList();
            documentBuilder.BuildParagraph();
            documentBuilder.BuildImage();
        }
    }
}
