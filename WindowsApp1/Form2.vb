Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeAppointmentsTable()
        DataGridView1.DataSource = AppointmentsTable
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' BOOK NOW - collect values
        Dim full = TextBox1.Text.Trim()
        Dim phone = TextBox2.Text.Trim()
        Dim email = TextBox3.Text.Trim()
        Dim service = If(ListBox1.SelectedItem IsNot Nothing, ListBox1.SelectedItem.ToString(), String.Empty)
        Dim timeslot = If(ListBox2.SelectedItem IsNot Nothing, ListBox2.SelectedItem.ToString(), String.Empty)
        Dim prefDate = DateTimePicker1.Value.Date

        ' Basic validation
        If String.IsNullOrWhiteSpace(full) Then
            MessageBox.Show("Please enter Full Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Focus()
            Return
        End If

        ' Add row to the shared AppointmentsTable
        AppointmentsTable.Rows.Add(full, phone, email, service, timeslot, prefDate.ToShortDateString())

        ' Optionally clear inputs after booking:
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ListBox1.ClearSelected()
        ListBox2.ClearSelected()
        DateTimePicker1.Value = DateTime.Now
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' When a grid cell (or the programmatic call) targets a row, populate the Appointment Details controls.
        If e.RowIndex < 0 OrElse e.RowIndex >= DataGridView1.Rows.Count Then
            Return
        End If

        Dim row = DataGridView1.Rows(e.RowIndex)

        ' Safely get each cell value and populate controls
        Dim full = If(row.Cells("FullName").Value, String.Empty).ToString()
        Dim phone = If(row.Cells("Phone").Value, String.Empty).ToString()
        Dim email = If(row.Cells("Email").Value, String.Empty).ToString()
        Dim service = If(row.Cells("Service").Value, String.Empty).ToString()
        Dim timeslot = If(row.Cells("TimeSlot").Value, String.Empty).ToString()
        Dim dateStr = If(row.Cells("PreferredDate").Value, String.Empty).ToString()

        TextBox1.Text = full
        TextBox2.Text = phone
        TextBox3.Text = email

        ' Select service in ListBox1 if present
        Dim idxService = ListBox1.Items.IndexOf(service)
        If idxService >= 0 Then
            ListBox1.SelectedIndex = idxService
        Else
            ListBox1.ClearSelected()
        End If

        ' Select time slot in ListBox2 if present
        Dim idxTime = ListBox2.Items.IndexOf(timeslot)
        If idxTime >= 0 Then
            ListBox2.SelectedIndex = idxTime
        Else
            ListBox2.ClearSelected()
        End If

        ' Try parse the date and set DateTimePicker
        Dim dt As DateTime
        If DateTime.TryParse(dateStr, dt) Then
            DateTimePicker1.Value = dt
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
    End Sub


    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
    End Sub
    ' Call this when you want to show Form5 and display the data
    Public Sub ShowAppointmentsInForm5()
        ' Ensure columns are set up
        Form5.DataGridView1.Rows.Clear()
        For Each row As DataGridViewRow In Me.DataGridView1.Rows
            If Not row.IsNewRow Then
                Form5.DataGridView1.Rows.Add(
                    row.Cells("FullName").Value,
                    row.Cells("Phone").Value,
                    row.Cells("Email").Value,
                    row.Cells("Service").Value,
                    row.Cells("TimeSlot").Value,
                    row.Cells("Date").Value
                )
            End If
        Next
        Form5.Show()
    End Sub
End Class