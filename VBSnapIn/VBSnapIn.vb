Imports CommonSnappableTypes

<CompanyInfo(CompanyName:="Chucky's Software", CompanyUrl:="www.ChuckySoft.com")>
Public Class VBSnapIn
    Implements IAppFunctionality
    Public Sub Dolt() Implements IAppFunctionality.Dolt
        Console.WriteLine("You have just used the VB snap in!")
    End Sub
End Class