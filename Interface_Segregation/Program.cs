using Interface_Segregation_IdealCode;
//using Interface_Segregation_Principle_NotIdealCode;

#region Not Ideal Code
//SamsungPrinter printer = new();
//printer.PrintDuplex();
#endregion
#region Ideal Code
SamsungPrinter printer = new();
printer.Fax();
#endregion
