Imports System.ComponentModel
Imports DevExpress.XtraEditors

Namespace CustomEditor

    Friend Class CustomLookUpEdit
        Inherits LookUpEdit

        Shared Sub New()
            RepositoryItemCustomLookUpEdit.Register()
        End Sub

        Public Sub New()
            MyBase.New()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Overloads ReadOnly Property Properties As RepositoryItemCustomLookUpEdit
            Get
                Return TryCast(MyBase.Properties, RepositoryItemCustomLookUpEdit)
            End Get
        End Property

        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return RepositoryItemCustomLookUpEdit.EditorName
            End Get
        End Property

        Protected Overrides Function ProcessNewValueCore(ByVal partital As Boolean, ByVal text As String) As Boolean
            If Properties.IsNullInputAllowed AndAlso String.IsNullOrEmpty(text) Then
                EditValue = Nothing
                Return True
            End If

            Return MyBase.ProcessNewValueCore(partital, text)
        End Function
    End Class
End Namespace
