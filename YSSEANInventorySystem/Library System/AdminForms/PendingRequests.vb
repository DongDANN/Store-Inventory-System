Imports System.Data.SqlClient

Public Class PendingRequests
    Public con As New SqlConnection("Data Source=RONALD\SQLEXPRESS;Initial Catalog=YSSEAN;Integrated Security=True")

    Private Sub data()
        cmd = New SqlCommand("Select * from dbo.Pending_Approval", con)
        sd = New SqlDataAdapter(cmd)
        dt = New DataTable()
        sd.Fill(dt)
        PendingDatagrid.DataSource = dt
    End Sub

    Private Sub HideSensitiveColumns()

        PendingDatagrid.Columns("ProductID").Visible = False

    End Sub

    Private Sub PendingRequests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data()
        HideSensitiveColumns()

        For Each col As DataGridViewColumn In PendingDatagrid.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

    End Sub

    Private Sub PendingDatagridDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PendingDatagrid.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dt.Rows.Count Then
            productcode = dt.Rows(e.RowIndex)("ProductCode").ToString()
            txtProductCode.Text = productcode
        End If
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If PendingDatagrid.SelectedCells.Count > 0 Then
            Dim selectedCell As DataGridViewCell = PendingDatagrid.SelectedCells(0)
            Dim selectedRow As DataGridViewRow = PendingDatagrid.Rows(selectedCell.RowIndex)
            Dim productCode As String = selectedRow.Cells("ProductCode").Value.ToString()
            Dim productType As String = selectedRow.Cells("Request").Value.ToString()

            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to approve {productCode}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    con.Open()

                    If productType = "New" Then
                        ' Approve a new product
                        Dim archiveQuery As String = "INSERT INTO dbo.Products (ProductCode, ProductName, Price, Category) " &
                                 "SELECT ProductCode, ProductName, Price, Category FROM dbo.Pending_Approval WHERE ProductCode=@ProductCode"

                        cmd = New SqlCommand(archiveQuery, con)
                        cmd.Parameters.AddWithValue("@ProductCode", productCode)
                        cmd.ExecuteNonQuery()

                    ElseIf productType = "Edit" Then
                        Dim editQuery As String = "UPDATE dbo.Products SET ProductName=@ProductName, Category=@Category, Price=@Price WHERE ProductCode=@ProductCode"
                        cmd = New SqlCommand(editQuery, con)
                        cmd.Parameters.AddWithValue("@ProductCode", txtProductCode.Text)
                        cmd.Parameters.AddWithValue("@Category", txtCategory.Text)
                        cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
                        cmd.Parameters.AddWithValue("@ProductName", txtProdName.Text)

                        cmd.ExecuteNonQuery()

                    ElseIf productType = "Delete" Then
                        Dim archiveQuery As String = "INSERT INTO dbo.Products_Archive (ProductID, ProductCode, Category, ProductName, Price) " &
                                    "SELECT ProductID, ProductCode, Category, ProductName, Price FROM dbo.Products WHERE ProductCode=@ProductCode"
                        cmd = New SqlCommand(archiveQuery, con)
                        cmd.Parameters.AddWithValue("@ProductCode", productCode)
                        cmd.ExecuteNonQuery()

                        Dim deleteQuery As String = "DELETE FROM dbo.Products WHERE ProductID=@ProductID"
                        cmd = New SqlCommand(deleteQuery, con)
                        ' Use the values from the textboxes
                        cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text)
                        cmd.ExecuteNonQuery()

                    End If

                    Dim deletePendingQuery As String = "DELETE FROM dbo.Pending_Approval WHERE ProductCode=@ProductCode"
                    cmd = New SqlCommand(deletePendingQuery, con)
                    cmd.Parameters.AddWithValue("@ProductCode", productCode)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Approved.")
                    data()
                Finally
                    con.Close()
                End Try
            End If
        Else
            MessageBox.Show("Please select a cell in the table.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub




    Private Sub btnDecline_Click(sender As Object, e As EventArgs) Handles btnDecline.Click
        If PendingDatagrid.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = PendingDatagrid.SelectedRows(0)
            Dim productName As String = selectedRow.Cells("ProductName").Value.ToString()

            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to decline {productName}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    con.Open()

                    Dim deleteQuery As String = "DELETE FROM dbo.Pending_Approval WHERE ProductName=@ProductName"
                    cmd = New SqlCommand(deleteQuery, con)
                    cmd.Parameters.AddWithValue("@ProductName", productName)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Successfully Declined.")
                    data()
                Finally
                    con.Close()
                End Try
            End If
        Else
            MessageBox.Show("Please select a row in the table.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtProductCode_TextChanged(sender As Object, e As EventArgs) Handles txtProductCode.TextChanged
        Dim matchingRows() As DataRow = dt.Select("ProductCode = '" & txtProductCode.Text & "'")

        If matchingRows.Length > 0 Then
            Dim selectedRow As DataRow = matchingRows(0)
            txtProductID.Text = selectedRow("ProductID").ToString()
            txtProdName.Text = selectedRow("ProductName").ToString()
            txtCategory.Text = selectedRow("Category").ToString()
            txtPrice.Text = selectedRow("Price").ToString()
        Else
        End If
    End Sub

    Private Sub btnApproveAll_Click(sender As Object, e As EventArgs) Handles btnApproveAll.Click
        If PendingDatagrid.Rows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to approve all items?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    con.Open()

                    For Each row As DataGridViewRow In PendingDatagrid.Rows
                        Dim productCode As String = row.Cells("ProductCode").Value.ToString()
                        Dim productType As String = row.Cells("Request").Value.ToString()

                        ' Perform approval based on the product type
                        If productType = "New" Then
                            Dim archiveQuery As String = "INSERT INTO dbo.Products (ProductCode, ProductName, Price, Category) " &
                                    "SELECT ProductCode, ProductName, Price, Category FROM dbo.Pending_Approval WHERE ProductCode=@ProductCode"

                            cmd = New SqlCommand(archiveQuery, con)
                            cmd.Parameters.AddWithValue("@ProductCode", productCode)
                            cmd.ExecuteNonQuery()

                        ElseIf productType = "Edit" Then
                            Dim editQuery As String = "UPDATE dbo.Products SET ProductName=@ProductName, Category=@Category, Price=@Price WHERE ProductCode=@ProductCode"
                            cmd = New SqlCommand(editQuery, con)
                            cmd.Parameters.AddWithValue("@ProductCode", productCode)
                            cmd.Parameters.AddWithValue("@Category", row.Cells("Category").Value.ToString())
                            cmd.Parameters.AddWithValue("@Price", row.Cells("Price").Value.ToString())
                            cmd.Parameters.AddWithValue("@ProductName", row.Cells("ProductName").Value.ToString())

                            cmd.ExecuteNonQuery()

                        ElseIf productType = "Delete" Then
                            Dim archiveQuery As String = "INSERT INTO dbo.Products_Archive (ProductID, ProductCode, Category, ProductName, Price) " &
                                        "SELECT ProductID, ProductCode, Category, ProductName, Price FROM dbo.Products WHERE ProductCode=@ProductCode"
                            cmd = New SqlCommand(archiveQuery, con)
                            cmd.Parameters.AddWithValue("@ProductCode", productCode)
                            cmd.ExecuteNonQuery()

                            Dim deleteQuery As String = "DELETE FROM dbo.Products WHERE ProductID=@ProductID"
                            cmd = New SqlCommand(deleteQuery, con)
                            cmd.Parameters.AddWithValue("@ProductID", row.Cells("ProductID").Value.ToString())
                            cmd.ExecuteNonQuery()

                        End If

                        Dim deletePendingQuery As String = "DELETE FROM dbo.Pending_Approval WHERE ProductCode=@ProductCode"
                        cmd = New SqlCommand(deletePendingQuery, con)
                        cmd.Parameters.AddWithValue("@ProductCode", productCode)
                        cmd.ExecuteNonQuery()
                    Next

                    MessageBox.Show("All items approved.")
                    data()
                Finally
                    con.Close()
                End Try
            End If
        Else
            MessageBox.Show("No items to approve.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
