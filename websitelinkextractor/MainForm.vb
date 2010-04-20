Public Class MainForm


    Private Sub cmdExtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExtract.Click
        Me.wb.Navigate(Me.txtUrl.Text)
    End Sub

    Private Sub wb_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles wb.DocumentCompleted
        Dim d = From x As HtmlElement In Me.wb.Document.Links _
                Select New Data With {.Text = x.InnerText, .URL = x.DomElement.href}
    End Sub
End Class
Public Structure Data
    Private mURL As String
    Public Property URL() As String
        Get
            Return mURL
        End Get
        Set(ByVal value As String)
            mURL = value
        End Set
    End Property
    Private mText As String
    Public Property Text() As String
        Get
            Return mText
        End Get
        Set(ByVal value As String)
            mText = value
        End Set
    End Property
End Structure

