Public Class Formulario
    Inherits Form

    Sub New()
        MsgBox("Usando DLL no .NET")
    End Sub

End Class


Module Aplicacao

    Private frmPrincipal As New Form

End Module

Public Class FormularioMDI
    Inherits Form

End Class

Partial Public Class servidor
    Property nome As String
End Class