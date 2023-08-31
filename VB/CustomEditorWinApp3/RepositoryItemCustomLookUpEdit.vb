Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo

Namespace CustomEditor

    Friend Class RepositoryItemCustomLookUpEdit
        Inherits RepositoryItemLookUpEdit

        Friend Const EditorName As String = "CustomLookUpEdit"

        Shared Sub New()
            Call Register()
        End Sub

        Public Sub New()
        End Sub

        Public Shared Sub Register()
            Call EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(CustomLookUpEdit), GetType(RepositoryItemCustomLookUpEdit), GetType(ButtonEditViewInfo), New ButtonEditPainter(), True))
        End Sub

        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return EditorName
            End Get
        End Property

        Protected Friend Overloads ReadOnly Property IsNullInputAllowed As Boolean
            Get
                Return MyBase.IsNullInputAllowed
            End Get
        End Property
    End Class
End Namespace
