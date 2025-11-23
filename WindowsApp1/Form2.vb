Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeAppointmentsTable()
        DataGridView1.DataSource = AppointmentsTable
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Load fresh availability
        RefreshTimeSlotAvailability()
    End Sub


    ' ========================================================================
    '   TASK 1 – AUTO-REFRESH TIME SLOTS WHEN DATE CHANGES
    ' ========================================================================
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        RefreshTimeSlotAvailability()
        AutoCheckConflict()
    End Sub


    Private Sub RefreshTimeSlotAvailability()
        Dim selectedDate = DateTimePicker1.Value.Date.ToShortDateString()

        ' Reset visual states
        For i As Integer = 0 To ListBox2.Items.Count - 1
            ListBox2.SetSelected(i, False)
        Next

        ' Disable booked slots
        For i As Integer = 0 To ListBox2.Items.Count - 1
            Dim slot = ListBox2.Items(i).ToString()

            Dim booked = AppointmentsTable.AsEnumerable().Any(Function(r) _
                r.Field(Of String)("Date") = selectedDate AndAlso
                r.Field(Of String)("TimeSlot") = slot)

            If booked Then
                ' Grey-out booked slots visually
                ListBox2.Items(i) = slot & " (BOOKED)"
            Else
                ' Ensure clean reset if previously greyed
                If ListBox2.Items(i).ToString().Contains("(BOOKED)") Then
                    ListBox2.Items(i) = slot.Replace(" (BOOKED)", "")
                End If
            End If
        Next
    End Sub


    ' ========================================================================
    '  TASK 2 – AUTO-CHECK CONFLICTS WHEN TIME OR DATE IS SELECTED
    ' ========================================================================
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        AutoCheckConflict()
    End Sub

    Private Sub AutoCheckConflict()
        LabelError.Visible = False

        If ListBox2.SelectedItem Is Nothing Then Return

        Dim rawSlot = ListBox2.SelectedItem.ToString().Replace(" (BOOKED)", "")
        Dim selectedDate = DateTimePicker1.Value.Date.ToShortDateString()

        Dim conflict = AppointmentsTable.AsEnumerable().Any(Function(r) _
            r.Field(Of String)("Date") = selectedDate AndAlso
            r.Field(Of String)("TimeSlot") = rawSlot)

        If conflict Then
            LabelError.Text = $"{rawSlot} is already booked for {selectedDate}. Choose another date or time."
            LabelError.Visible = True
        End If
    End Sub



    ' ========================================================================
    '   BOOK NOW BUTTON
    ' ========================================================================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' BOOK NOW - collect values
        Dim full = TextBox1.Text.Trim()
        Dim phone = TextBox2.Text.Trim()
        Dim email = TextBox3.Text.Trim()
        Dim service = If(ListBox1.SelectedItem IsNot Nothing, ListBox1.SelectedItem.ToString(), String.Empty)

        Dim selectedRawSlot As String = ""
        If ListBox2.SelectedItem IsNot Nothing Then
            selectedRawSlot = ListBox2.SelectedItem.ToString().Replace(" (BOOKED)", "")
        End If

        Dim prefDate = DateTimePicker1.Value.Date


        ' Basic validation
        If String.IsNullOrWhiteSpace(full) Then
            LabelError.Text = "Please enter Full Name."
            LabelError.Visible = True
            TextBox1.Focus()
            Return
        End If

        ' Check for duplicate date and timeslot
        Dim alreadyBooked = AppointmentsTable.AsEnumerable().Any(Function(r) _
        r.Field(Of String)("Date") = prefDate.ToShortDateString() AndAlso
        r.Field(Of String)("TimeSlot") = selectedRawSlot)

        If alreadyBooked Then
            LabelError.Text = $"{selectedRawSlot} is already booked for {prefDate.ToShortDateString()}."
            LabelError.Visible = True
            Return
        End If

        ' Add row to the shared AppointmentsTable
        AppointmentsTable.Rows.Add(full, phone, email, service, selectedRawSlot, prefDate.ToShortDateString())

        ' Hide error label and clear inputs after booking
        LabelError.Visible = False
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ListBox1.ClearSelected()
        ListBox2.ClearSelected()
        DateTimePicker1.Value = DateTime.Now

        ' **Auto-refresh slots after booking**
        RefreshTimeSlotAvailability()
    End Sub


    ' Keep your other handlers the same
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 OrElse e.RowIndex >= DataGridView1.Rows.Count Then
            Return
        End If

        Dim row = DataGridView1.Rows(e.RowIndex)

        TextBox1.Text = row.Cells("FullName").Value.ToString()
        TextBox2.Text = row.Cells("Phone").Value.ToString()
        TextBox3.Text = row.Cells("Email").Value.ToString()

        Dim service = row.Cells("Service").Value.ToString()
        Dim idxService = ListBox1.Items.IndexOf(service)
        If idxService >= 0 Then ListBox1.SelectedIndex = idxService

        Dim timeslot = row.Cells("TimeSlot").Value.ToString()
        Dim idxTime = ListBox2.Items.IndexOf(timeslot)
        If idxTime >= 0 Then ListBox2.SelectedIndex = idxTime

        Dim dt As DateTime
        If DateTime.TryParse(row.Cells("Date").Value.ToString(), dt) Then
            DateTimePicker1.Value = dt
        End If

        RefreshTimeSlotAvailability()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub


    Public Sub ShowAppointmentsInForm5()
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
