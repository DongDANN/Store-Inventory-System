Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Module GlobalVariablesAndFunctions
    Public loggedInUsername As String
    Public AccountTypeLoggedIn As String
    Public productcode As String

    Public con As New SqlConnection("Data Source=RONALD\SQLEXPRESS;Initial Catalog=YSSEAN;Integrated Security=True")
    Public cmd As New SqlCommand
    Public sd As New SqlDataAdapter
    Public dt As New DataTable

    Public cmd1 As New SqlCommand
    Public sd1 As New SqlDataAdapter
    Public dt1 As New DataTable

End Module