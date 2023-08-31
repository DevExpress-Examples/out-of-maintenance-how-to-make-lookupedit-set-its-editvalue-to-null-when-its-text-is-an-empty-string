Imports System.Windows.Forms

Namespace CustomEditor

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs)
            categoriesTableAdapter.Fill(nwindDataSet.Categories)
            productsTableAdapter.Fill(nwindDataSet.Products)
        End Sub
    End Class
End Namespace
