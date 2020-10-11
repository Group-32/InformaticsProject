' *****************************************************************
' Team Number: 32
' Team Member 1 Details: Ngomane, MJ (216077694)
' Team Member 2 Details:Menze ,M (220034828)
' Team Member 3 Details: Damoyi, T (220002492)
' Team Member 4 Details: Maholobela,ZA(220045302)
' Practical: Team Project
' Class name: frmMillennium
' *****************************************************************

Option Infer Off
Option Strict On
Option Explicit On
'Importing file management systems
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class frmMilliennium
    'The variable declarations
    Private nC As Integer
    Private objMillienniumgoals() As MillieniumGoals
    Private objExtremePoverty As ExtremeProverty_and_Hunger
    Private objUniversal As UniversalPrimaryEducation

    Private Years As Integer
    Private FileS As FileStream
    Private BinF As BinaryFormatter

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'The initial input from the text boxes
        Years = CInt(txtnYears.Text)
        nC = CInt(txtnCounrties.Text)
        ReDim objMillienniumgoals(nC)
        For i As Integer = 1 To nC
            'Allowing the user to select what goal each country is trying to achieve
            Dim choice As Integer = CInt(InputBox("What goal is country " & CStr(i) & " trying to achieve (1-Poverty and hunger, 2-Education"))
            'Option 1 represents the pverty and hunger object and option 2 represents the education object
            Select Case choice
                Case 1
                    objExtremePoverty = New ExtremeProverty_and_Hunger(Years)
                    objExtremePoverty.CountryName = InputBox("What is the Country name for Country " & CStr(i))
                    objExtremePoverty.GDP = CDbl(InputBox("What is the GDP of country " & CStr(i)))
                    objExtremePoverty.Population = CInt(InputBox("Enter the initial population for country " & CStr(i)))
                    objExtremePoverty.Salary = CDbl(InputBox("What is the average salary of " & objExtremePoverty.CountryName))
                    objMillienniumgoals(i) = objExtremePoverty
                Case 2
                    objUniversal = New UniversalPrimaryEducation(Years)
                    objUniversal.CountryName = InputBox("What is the Country name for Country " & CStr(i))
                    objUniversal.Population = CInt(InputBox("Enter the initial population for country " & CStr(i)))
                    objUniversal.GDP = CDbl(InputBox("What is the GDP of country " & CStr(i)))
                    objUniversal.Age = CInt(InputBox("What is the maximum level/grade for primary school education in country " & CStr(i)))
                    objUniversal.Enrolment = CDbl(InputBox("How many children (in millions) have reached the highest level/grade in primary education in country " & CStr(i)))
                    objUniversal.ChildPop = CDbl(InputBox("What is the total child population (in millions) in country " & CStr(i)))
                    objUniversal.Schoolfees = CDbl(InputBox("What is the average cost of school fees in country " & CStr(i)))
                    objMillienniumgoals(i) = objUniversal
            End Select
        Next i
        'Message box informs the user that data has been captured
        MsgBox("All data has been captured")
    End Sub
    'The list of eligible countries will be displayed
    Private Sub BtnDisplayList_Click(sender As Object, e As EventArgs) Handles BtnDisplayList.Click
        txtDisplyData.Clear()
        txtDisplyData.Text = "List of eligible countries: " & Environment.NewLine
        'Checks if each country is eligible for funding before displaying the list
        For i As Integer = 1 To nC
            If objMillienniumgoals(i).FundingEligibility = "Eligible " Then
                txtDisplyData.Text &= objMillienniumgoals(i).CountryName & Environment.NewLine
            End If
        Next i
    End Sub

    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click
        txtDisplyData.Clear()
        'Tries to display data onto txtDisplayData otherwise it throws up a null reference
        For i As Integer = 1 To nC
            Try
                txtDisplyData.Text &= objMillienniumgoals(i).Display
            Catch ex As NullReferenceException
                MsgBox("Some of the data may have been incorrectly entered")
                Exit Try
            End Try
        Next i
    End Sub

    Private Sub BtnSaveInfo_Click(sender As Object, e As EventArgs) Handles BtnSaveInfo.Click
        'FileS will open the file if it exists or create one if it doesen't
        FileS = New FileStream("EligibleCountryInfo.txt", FileMode.OpenOrCreate, FileAccess.Write)
        BinF = New BinaryFormatter()
        'Writes data on each eligible country and their millienium goals to EligibleCountryInfo.txt
        For i As Integer = 1 To nC
            If objMillienniumgoals(i).FundingEligibility = "Eligible " Then
                BinF.Serialize(FileS, objMillienniumgoals(i))
            End If
        Next i
        FileS.Close()
        MsgBox("Data on the eligible countries have been saved.")
    End Sub

    Private Sub BtnSummary_Click(sender As Object, e As EventArgs) Handles BtnSummary.Click
        'The file is opened again, this time it is for reading
        FileS = New FileStream("EligibleCountryInfo.txt", FileMode.Open, FileAccess.Read)
        BinF = New BinaryFormatter()
        Dim total As Double = 0
        Dim count As Integer = 0
        Dim EligCountry As String = ""
        While FileS.Position < FileS.Length
            'Reads data from EligibleCountryInfo.txt into tempMillenium, a tempory Millienum goal object
            Dim tempMillenium As MillieniumGoals
            tempMillenium = DirectCast(BinF.Deserialize(FileS), MillieniumGoals)
            'Reads the GDP and country name of each elighble country 
            total += tempMillenium.GDP
            EligCountry &= tempMillenium.CountryName & ", "
            count += 1
        End While
        FileS.Close()
        'Displays the number of eligible countries along with the recreated list and the average GDP
        txtDisplyUniv.Text &= "Number of countries eligible for funding: " & CStr(count) & Environment.NewLine
        txtDisplyUniv.Text &= "List of those countries: " & EligCountry & Environment.NewLine
        txtDisplyUniv.Text &= "Average GDP of these countries: $" & Format((total / count), "0.00")
    End Sub
End Class

