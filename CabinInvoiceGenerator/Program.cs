// See https://aka.ms/new-console-template for more information
using CabinInvoiceGenerator;

Console.WriteLine("Welcome to Cab Invoice Generator");



InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
double Fare = invoiceGenerator.TotalFare(10, 5);
Console.WriteLine("Total Fare for Journey = " + Fare);
