Public Class MainForm
    Private Sub cmdExtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExtract.Click
        Me.wb.Navigate(Me.txtUrl.Text)
    End Sub

    Private Sub wb_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles wb.DocumentCompleted
        Dim d = From x As HtmlElement In Me.wb.Document.Links _
                Select New Data With {.Text = x.InnerText, .URL = x.DomElement.href}
        Me.GridView.DataSource = d.ToList
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Initialize the DataGridView.
        GridView.AutoGenerateColumns = False
        GridView.AutoSize = True


        ' Initialize and add a text box column.
        Dim column As DataGridViewColumn = _
            New DataGridViewTextBoxColumn()
        column.DataPropertyName = "Text"
        column.Name = "Text"
        GridView.Columns.Add(column)

        ' Initialize and add a check box column.
        column = New DataGridViewTextBoxColumn()
        column.DataPropertyName = "URL"
        column.Name = "URL"
        column.Width = Me.GridView.Width - GridView.Columns(0).Width - 100
        GridView.Columns.Add(column)

    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click, cmdExcel.Click
        Dim sb As New System.Text.StringBuilder
        For Each row As DataGridViewRow In GridView.Rows
            sb.AppendLine("""" & row.Cells(0).Value & """,""" & row.Cells(1).Value & """")
        Next

        Dim file As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, Now.Ticks & ".csv")
        

        If sender.Equals(Me.cmdExport) Then
            Dim fs As New SaveFileDialog
            fs.Filter = "CSV files (*.csv)|*.csv"
            fs.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If (fs.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                My.Computer.FileSystem.WriteAllText(fs.FileName, sb.ToString, False)
            End If
        ElseIf sender.Equals(Me.cmdExcel) Then
            My.Computer.FileSystem.WriteAllText(file, sb.ToString, False)
            System.Diagnostics.Process.Start(file)
        End If


    End Sub

    Private Sub MainForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.GridView.Columns.Count >= 2 Then
            Try
                GridView.Columns(1).Width = Me.GridView.Width - GridView.Columns(0).Width - 100
            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim sInfo As New ProcessStartInfo("http://www.thetechhub.com/")
        Process.Start(sInfo)
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

