Imports FirstApp.MessageSender

Public Class BulkMessagesClass

    Public Property MessagesToSend As New Dictionary(Of Integer, String)
    Public Property ImagePaths As New Dictionary(Of Integer, String)

    Public Property SentList As New List(Of String)
    Public Property FailedList As New List(Of String)
    Public Property UnRegisteredList As New List(Of String)
    Public Property RemovedList As New List(Of String)





#Region ""
    Public Function Greet()
        Dim hour As String = TimeOfDay.ToString("hh")
        If TimeOfDay.ToString("tt") = "AM" Then
            Return "Good Morning"
        ElseIf TimeOfDay.ToString("tt") = "PM" _
            And hour >= 5 _
            And hour <= 11 Then
            Return "Good Evening"
        Else
            Return "Good AfterNoon"
        End If
    End Function

    Public Function ReplaceTemplateWithDetails(_kitty As Kitty, _text As String) As String
        _kitty.Initialize(True)
        With _kitty
            _text = _text.Replace(Templates.Greeting, Greet())
            _text = _text.Replace(Templates.CoustName, .Owner.FullName())
            _text = _text.Replace(Templates.CoustPhNo, .Owner.PhNo(","))
            _text = _text.Replace(Templates.KittyType, .KittyType.ToCurrency(True))
            _text = _text.Replace(Templates.KittyNo, .KittyNo)
            _text = _text.Replace(Templates.InstalmentsCompleted, .GetInstalmentsCompleted)

            Dim FirstDate As Date = .Record.First.Key
            Dim InstComp As Integer = .GetInstalmentsCompleted
            Dim InstPending As Integer = .GetInstalmentsPending

            If InstComp = 1 Then
                _text = _text.Replace(Templates.PeriodIntalmentsCompleted, $"{ FirstDate:MMM}({ FirstDate:yyyy})")
            ElseIf InstComp = 2 Then
                _text = _text.Replace(Templates.PeriodIntalmentsCompleted, $"{ FirstDate:MMM}({ FirstDate:yyyy}),{ FirstDate.AddMonths(1):MMM}({ FirstDate.AddMonths(1):yyyy})")
            Else
                _text = _text.Replace(Templates.PeriodIntalmentsCompleted, $"{ FirstDate:MMM}({ FirstDate:yyyy})-{ FirstDate.AddMonths(InstComp - 1):MMM}({ FirstDate.AddMonths(InstComp - 1):yyyy})")
            End If

            _text = _text.Replace(Templates.GivenAmount, .GivenAmount.ToCurrency(True))
            _text = _text.Replace(Templates.InstalmentsPending, InstPending)

            If InstPending = 1 Then
                _text = _text.Replace(Templates.PeriodInstalmentsPending, $"{ FirstDate.AddMonths(InstComp):MMM}({ FirstDate.AddMonths(InstComp):yyyy})")
            ElseIf InstPending = 2 Then
                _text = _text.Replace(Templates.PeriodInstalmentsPending, $"{ FirstDate.AddMonths(InstComp):MMM}({ FirstDate.AddMonths(InstComp):yyyy}),{ FirstDate.AddMonths(InstComp + 1):MMM}({ FirstDate.AddMonths(InstComp + 1):yyyy})")
            Else
                _text = _text.Replace(Templates.PeriodInstalmentsPending, $"{ FirstDate.AddMonths(InstComp):MMM}({ FirstDate.AddMonths(InstComp):yyyy})-{ FirstDate.AddMonths(InstComp + InstPending - 1):MMM}({ FirstDate.AddMonths(InstComp + InstPending - 1):yyyy})")
            End If

            _text = _text.Replace(Templates.PendingAmount, Int(InstPending * .KittyType).ToCurrency(True))

        End With

        Return _text
    End Function
#End Region

End Class
