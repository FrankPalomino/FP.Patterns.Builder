namespace FP.Patterns.Builder.Exercice3
{
    public class AdvancedDocumentBuilder : IDocumentBuilder
    {
        private readonly DocumentComponent _document;

        public AdvancedDocumentBuilder()
        {
            _document = new DocumentComponent();
        }
        public void BuildHeading()
        {
            _document.Heading = "This is a advanced heading";
        }

        public void BuildImage()
        {
            _document.ImgUrl = "www.image.com";
        }

        public void BuildList()
        {
            _document.Items = [];
        }

        public void BuildParagraph()
        {
            _document.Paragraph = "This is a advanced paragraph";
        }

        public DocumentComponent CreateDocument()
        {
            return _document;
        }
    }
}
