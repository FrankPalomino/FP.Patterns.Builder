using FP.Patterns.Builder.Exercice3;

Director director = new Director();
AdvancedDocumentBuilder advancedDocumentBuilder = new AdvancedDocumentBuilder();
SimpleDocumentBuilder simpleDocumentBuilder = new SimpleDocumentBuilder();

director.CreateDocument(simpleDocumentBuilder);
DocumentComponent simpleDocument = simpleDocumentBuilder.CreateDocument();

director.CreateDocument(advancedDocumentBuilder);
DocumentComponent advancedDocument = advancedDocumentBuilder.CreateDocument();

Console.WriteLine(advancedDocument.Paragraph);

Console.WriteLine(simpleDocument.Paragraph);
