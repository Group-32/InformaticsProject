' *****************************************************************
' Team Number: assigned to team
' Team Member 1 Details: Ngomane, MJ (216077694)
' Team Member 2 Details:Menze ,M (220034828)
' Team Member 3 Details: Damoyi, T (220002492)
' Team Member 4 Details: Maholobela,ZA(220045302)
' Practical: Team Project
' Class name: ExtremeProverty_and_Hunger
' *****************************************************************

Option Infer Off
Option Strict On
Option Explicit On

Public Class frmMilliennium

    Private nC As Integer
    Private objMillienniumgoals() As MillieniumGoals
    Private objExtremePoverty As ExtremeProverty_and_Hunger
    Private objUniversal As UniversalPrimaryEducation

    Private Years As Integer
    Private Population As Integer
    Private CountryName As String

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Years = CInt(txtnYears.Text)
        nC = CInt(txtnCounrties.Text)
        ReDim objMillienniumgoals(nC)


        For i As Integer = 1 To nC
            Dim choice As Integer = CInt(InputBox("What goal is country " & CStr(i) & " trying to achieve (1-Poverty and hunger, 2-Education"))

            Select Case choice
                Case 1
                    objExtremePoverty = New ExtremeProverty_and_Hunger(Years, Population, CountryName)
                    objExtremePoverty.CountryName = InputBox("What is the Country name for Country " & CStr(i))

                    objExtremePoverty.Population = CInt(InputBox("Enter the initial poverty population for country " & CStr(i)))
                    objExtremePoverty.Salary = CDbl(InputBox("What is the average salary of " & objExtremePoverty.CountryName))
                    objMillienniumgoals(i) = objExtremePoverty
                Case 2
                    objUniversal = New UniversalPrimaryEducation(Years, Population, CountryName)
                    objUniversal.CountryName = InputBox("What is the Country name for Country " & CStr(i))
                    objUniversal.Population = CInt(InputBox("Enter the initial poverty population for country " & CStr(i)))
                    objMillienniumgoals(i) = objUniversal
            End Select

            txtDisplyExtr.Text &= objMillienniumgoals(i).Display
        Next

        'txtDisplyExtr.Text = objExtremePoverty.Display()
        'txtDisplyUniv.Text = objUniversal.Display()

    End Sub
End Class
