Imports System.Data.SqlClient

Public Class AccountsDashboard
    Public con As New SqlConnection("Data Source=RONALD\SQLEXPRESS;Initial Catalog=YSSEAN;Integrated Security=True")

    Dim TotalAccounts As Integer
    Dim ActiveAccounts As Integer
    Dim DisabledAccounts As Integer

    Private Sub LoadAccountStatistics()
        Try
            con.Open()

            Using cmdTotal As New SqlCommand("SELECT COUNT(*) FROM dbo.Accounts", con)
                TotalAccounts = Convert.ToInt32(cmdTotal.ExecuteScalar())
            End Using


            Using cmdActive As New SqlCommand("SELECT COUNT(*) FROM dbo.Accounts WHERE Status = 'Active'", con)
                ActiveAccounts = Convert.ToInt32(cmdActive.ExecuteScalar())
            End Using


            Using cmdDisabled As New SqlCommand("SELECT COUNT(*) FROM dbo.Accounts WHERE Status = 'Disabled'", con)
                DisabledAccounts = Convert.ToInt32(cmdDisabled.ExecuteScalar())
            End Using
        Finally
            con.Close()
        End Try
        con.Close()
    End Sub

    Private Sub DisplayAccountStatistics()

        txtTotalAccounts.Text = TotalAccounts.ToString()
        txtActiveAccounts.Text = ActiveAccounts.ToString()
        txtDisabledAccounts.Text = DisabledAccounts.ToString()


        Me.Chart.Series("TOTAL NUMBER").Points.AddXY("TOTAL ACCOUNTS", TotalAccounts)
        Me.Chart.Series("TOTAL NUMBER").Points.AddXY("ACTIVE ACCOUNTS", ActiveAccounts)
        Me.Chart.Series("TOTAL NUMBER").Points.AddXY("DISABLED ACCOUNTS", DisabledAccounts)
    End Sub

    Private Sub HideSensitiveColumns()

        RecentLoginsDataGrid.Columns("Password").Visible = False
        RecentLoginsDataGrid.Columns("Status").Visible = False
        RecentLoginsDataGrid.Columns("AccountID").Visible = False
    End Sub

    Private Sub data()
        Dim query As String = "SELECT * FROM dbo.Accounts WHERE LastLoginDateTime IS NOT NULL ORDER BY LastLoginDateTime DESC"
        cmd = New SqlCommand(query, con)
        sd = New SqlDataAdapter(cmd)
        dt = New DataTable()
        sd.Fill(dt)
        RecentLoginsDataGrid.DataSource = dt
    End Sub

    Private Sub ITDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAccountStatistics()
        DisplayAccountStatistics()
        data()
        HideSensitiveColumns()
        Chart.ChartAreas(0).AxisY.Interval = 1
        For Each col As DataGridViewColumn In RecentLoginsDataGrid.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Private Sub Chart_Click(sender As Object, e As EventArgs) Handles Chart.Click

    End Sub
End Class