Imports System
Imports Excel = Microsoft.Office.Interop.Excel

Class GuidList
    Private Sub New()
    End Sub

    Public Const guidVsGuidPkgString As String = "830a0549-78e8-4074-8927-9217eaea4393"
    Public Const guidVsGuidCmdSetString As String = "c656fdc3-34e3-4273-8688-91fbd75f3fba"

    Public Shared ReadOnly guidVsGuidCmdSet As New Guid(guidVsGuidCmdSetString)

End Class