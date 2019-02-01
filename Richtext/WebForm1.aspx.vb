Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports ADODB
Imports System.Windows
Public Class WebForm1
    Inherits System.Web.UI.Page
    Public CMD As New SqlCommand
    Public conn8, conn, conn1, conn2, conn4, cn1 As New ADODB.Connection
    Public rs, rs2 As New ADODB.Recordset
    Public dsPerson As New DataSet()
    Public data As DataTable
    Dim dataAdap As SqlDataAdapter
    Dim cmdBuild As SqlCommandBuilder
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        opendb1()
    End Sub
    Public Function opendb1()

        If conn.State = 1 Then conn.Close()
        'conn.Open("Provider=SQLOLEDB.1;Persist Security Info=True;Initial Catalog=Dacdata;Data Source=localhost;")
        conn4.Open("Provider=SQLOLEDB.1;Data source=DESKTOP-MFTEVGT;Initial catalog=NDA_DATABASECBT;Integrated Security=SSPI")
        Return 0
    End Function
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Try
        '    Con.ConnectionString = "Data Source=DESKTOP-MFTEVGT;Initial Catalog=NDA_DATABASECBT;Integrated Security=SSPI;"
        '    Con.Open()
        '    CMD.Connection = Con
        '    CMD.CommandText = "INSERT INTO table_2() VALUES(@text)"
        '    CMD.ExecuteNonQuery()

        'Catch ex As Exception
        '    MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        'Finally
        '    Con.Close()
        'End Try

        ''Dim bvalue() As Byte
        ''bvalue = System.Text.ASCIIEncoding.ASCII.GetBytes(Control.RTF)
        ''If Con.State = ConnectionState.Closed Then
        ''OpenCon()
        ''End If
        ''CMD.Connection = Con

        ''Dim ndaqst As String = "INSERT INTO arms (qst) values (@rtf) "
        '' CMD.Parameters.Add("@rtf", Control.rtf, System.Data.SqlTypes.text)
        ''CMD.CommandText = ("INSERT INTO arms (qst) VALUES ('" & Me.text.Text & "'")
        ''CMD.ExecuteNonQuery()
        ' ''Dim recordsEffected As Object
        ' ''Dim strSQL As String = "INSERT INTO table_1(data1)" & _
        ' ''   "VALUES ('" & text.Text & "')"
        ' ''conn4.Execute(strSQL)
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Trying to retrieve the record into the textbox from the database
        Using conn4 As New SqlConnection("connstr")
            conn4.Open()
            Dim cmd As New SqlCommand("", conn4)
            Dim txtName As String
            cmd.CommandText = "SELECT data1 FROM table_1"
            txtName = IIf(IsDBNull(cmd.ExecuteScalar), "", cmd.ExecuteScalar)
            If txtName <> "" Then
                MsgBox("Record Found!", MsgBoxStyle.Information, "Update")
                text.Text = ""
                text.Text = txtName
            Else
                MsgBox("No Record Found!", MsgBoxStyle.Information, "INFO.")
            End If
        End Using
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ' Insert Record direclty to the system direcl
        Dim recordsEffected As Object
        Dim strSQL As String = "INSERT INTO table_1(data1)" & _
           "VALUES ('" & text.Text & "')"
        conn4.Execute(strSQL)

    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'conn8.Open("Provider=SQLOLEDB.1;Data source=localhost;Initial catalog=TESTING;Integrated Security=SSPI")
        ''Dim strSQL3 As String = "SELECT * From Outpatient" nasara
        'rs2.ActiveConnection = conn8
        'Dim strSQL1 As String = "SELECT  * FROM  table_1 " + "WHERE id = 1 "
        'If rs2.State = 1 Then

        '    rs2.Close()
        'End If
        'rs2.Open(strSQL1, conn8)
        'If rs2.BOF = False And rs2.EOF = False Then


        '    text.Text = Convert.ToString(rs2.Fields("data1").Value)
        '    'txtgsm.Text = Convert.ToString(rs2.Fields["phone"].Value);
        '    'txtcontact.Text = Convert.ToString(rs2.Fields["contact"].Value);
        'End If
        'rs2.Close()
    End Sub

    Private Function MessageBox() As Object
        Throw New NotImplementedException
    End Function

End Class