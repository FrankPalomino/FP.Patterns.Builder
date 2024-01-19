namespace FP.Patterns.Builder.Exercice3
{
    public class SimpleDocumentBuilder : IDocumentBuilder
    {
        private readonly DocumentComponent _document;

        public SimpleDocumentBuilder()
        {
            _document = new DocumentComponent();
        }
        public void BuildHeading()
        {
            _document.Heading = "This is Heading";
        }

        public void BuildImage()
        {
            _document.ImgUrl = default;
        }

        public void BuildList()
        {
            _document.Items = default;
        }

        public void BuildParagraph()
        {
            _document.Paragraph = "This is the paragraph";
        }

        public DocumentComponent CreateDocument()
        {
            return _document;
        }
    }
}
