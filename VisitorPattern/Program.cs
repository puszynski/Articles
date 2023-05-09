using VisitorPattern;

var invoice = new Invoice();
var receipt = new Receipt();

var visitor = new GanaratePDFVisitor();

invoice.Accept(visitor);
receipt.Accept(visitor);
