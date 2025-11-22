Module Module1
    Public AppointmentsTable As New DataTable()

    Sub InitializeAppointmentsTable()
        If AppointmentsTable.Columns.Count = 0 Then
            AppointmentsTable.Columns.Add("FullName")
            AppointmentsTable.Columns.Add("Phone")
            AppointmentsTable.Columns.Add("Email")
            AppointmentsTable.Columns.Add("Service")
            AppointmentsTable.Columns.Add("TimeSlot")
            AppointmentsTable.Columns.Add("Date")
        End If
    End Sub
End Module
