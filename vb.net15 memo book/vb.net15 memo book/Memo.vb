Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class Memo
    Public path As String = "Data Source=.\sqlexpress;Initial Catalog=memo;Integrated Security=True"
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Public query As String

    Public da As New SqlDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet

    Public x As Boolean

    'contact feilds
    Dim sn As String
    Dim fullName As String
    Dim address As String
    Dim office As String
    Dim tel As String
    Dim mobile As String
    Dim dob As Date
    Dim gender As String

    'todo feilds
    Dim task As String
    Dim date_ As Date

    'for birthday
    Dim day As Integer
    Dim month As Integer
    Dim row As Integer
    Dim year As Integer



    'contact properties
    Public Property SN_ As String
        Set(value As String)
            sn = value
        End Set
        Get
            Return sn
        End Get
    End Property
    Public Property FullName_ As String
        Set(value As String)
            fullName = value
        End Set
        Get
            Return fullName
        End Get
    End Property
    Public Property Address_ As String
        Set(value As String)
            address = value
        End Set
        Get
            Return address
        End Get
    End Property
    Public Property Office_ As String
        Set(value As String)
            office = value
        End Set
        Get
            Return office
        End Get
    End Property
    Public Property Tel_ As String
        Set(value As String)
            tel = value
        End Set
        Get
            Return tel
        End Get
    End Property
    Public Property Mobile_ As String
        Set(value As String)
            mobile = value
        End Set
        Get
            Return mobile
        End Get
    End Property
    Public Property DOB_ As Date
        Set(value As Date)
            dob = value
        End Set
        Get
            Return dob
        End Get
    End Property
    Public Property Gender_ As String
        Set(value As String)
            gender = value
        End Set
        Get
            Return gender
        End Get
    End Property


    'todo properties
    Public Property Task_ As String
        Set(value As String)
            task = value
        End Set
        Get
            Return task
        End Get
    End Property
    Public Property Date1_ As Date
        Set(value As Date)
            date_ = value
        End Set
        Get
            Return date_
        End Get
    End Property


    'connect method
    Public Sub connect()
        con.ConnectionString = path
    End Sub

    'insert method
    Public Sub insert(ByVal query As String)
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        connect()
        con.Open()
        cmd = New SqlCommand(query, con)
        With cmd
            .ExecuteNonQuery()
        End With
        con.Close()

    End Sub


    'delete method
    Public Sub delete(ByVal query As String)
        connect()
        con.Open()
        cmd = New SqlCommand(query, con)
        With cmd
            .ExecuteNonQuery()
        End With
        con.Close()

    End Sub

    'update method
    Public Sub update(ByVal query As String)
        connect()
        con.Open()
        cmd = New SqlCommand(query, con)
        With cmd
            .ExecuteNonQuery()
        End With
        con.Close()
    End Sub

    'show method
    Public Sub showrecord(ByRef query As String, ByRef dgv As DataGridView)
        connect()
        con.Open()
        da = New SqlDataAdapter(query, con)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt

        con.Close()

    End Sub

    'sn generate method
    Public Function getSn(ByVal query As String, ByVal dbName As String)
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        connect()
        con.Open()
        da = New SqlDataAdapter(query, con)
        ds = New DataSet
        da.Fill(ds, dbName)
        Dim maxrow As Integer
        maxrow = ds.Tables(dbName).Rows.Count

        If maxrow = 0 Then
            Return 1

        Else
            Return Val(ds.Tables(dbName).Rows(0).Item("sn")) + 1

        End If

        con.Close()

    End Function


    'todo clear method
    Public Sub clear_todo(date_ As DateTimePicker, task As TextBox)
        date_.Value = Today
        task.Text = ""
    End Sub


    'contact clear method
    Public Sub clear_contact(fullname As TextBox, address As TextBox, office As TextBox, tel As TextBox, mobile As TextBox, dob As DateTimePicker, gender As ComboBox)
        fullname.Text = ""
        address.Text = ""
        office.Text = ""
        tel.Text = ""
        mobile.Text = ""
        dob.Value = Today
        gender.Text = ""
    End Sub

    'birthday notification method
    Public Sub showDOB(ByVal query As String, ByVal dbName As String, ByVal dgv As DataGridView, ByVal panel As Panel)
        connect()
        con.Open()
        da = New SqlDataAdapter(query, con)
        ds = New DataSet
        da.Fill(ds, dbName)
        Dim maxrow As Integer
        maxrow = ds.Tables(dbName).Rows.Count

        If maxrow > 0 Then
            For i = 0 To maxrow - 1
                dob = ds.Tables(dbName).Rows(i).Item("dob")
                day = dob.Day
                month = dob.Month
                If day = Today.Day And month = Today.Month Then
                    panel.Visible = True
                    row = dgv.Rows.Add()
                    dgv.Rows(row).Cells(0).Value = ds.Tables(dbName).Rows(i).Item("fullname")
                    dgv.Rows(row).Cells(1).Value = ds.Tables(dbName).Rows(i).Item("mob")
                    dgv.Rows(row).Cells(2).Value = ds.Tables(dbName).Rows(i).Item("gender")

                End If

            Next
        End If

        con.Close()

    End Sub


    'todo notification
    Public Sub showTodoNotification(ByVal query As String, ByVal dbName As String, ByVal dgv As DataGridView, ByVal panel As Panel)
        connect()
        con.Open()
        da = New SqlDataAdapter(query, con)
        ds = New DataSet
        da.Fill(ds, dbName)
        Dim maxrow As Integer
        maxrow = ds.Tables(dbName).Rows.Count

        If maxrow > 0 Then
            For i = 0 To maxrow - 1
                dob = ds.Tables(dbName).Rows(i).Item("date")
                day = dob.Day
                year = dob.Year
                month = dob.Month
                If day = Today.Day And month = Today.Month And year = Today.Year Then
                    panel.Visible = True
                    row = dgv.Rows.Add()
                    dgv.Rows(row).Cells(0).Value = ds.Tables(dbName).Rows(i).Item("date")
                    dgv.Rows(row).Cells(1).Value = ds.Tables(dbName).Rows(i).Item("task")

                End If
            Next

        End If
        con.Close()

    End Sub


    'update form fill method
    'Public Sub update_Form_fill(ByVal query As String, ByVal dbName As String, ByVal task As TextBox, ByVal date_ As DateTimePicker, ByVal sn As TextBox)
    '   connect()
    '    con.Open()
    '    da = New SqlDataAdapter(query, con)
    '    ds = New DataSet
    '    da.Fill(ds, dbName)
    '    Dim maxrow As Integer
    '    maxrow = ds.Tables(dbName).Rows.Count

    '    If maxrow > 0 Then
    '        For i = 0 To maxrow - 1
    '            sn.Text = ds.Tables(dbName).Rows(i).Item("sn")
    '            task.Text = ds.Tables(dbName).Rows(i).Item("task")
    '            date_.Value = ds.Tables(dbName).Rows(i).Item("date")
    '        Next

    '    End If

    '    con.Close()

    'End Sub


End Class



