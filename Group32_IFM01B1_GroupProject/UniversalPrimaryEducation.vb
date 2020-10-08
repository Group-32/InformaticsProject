' *****************************************************************
' Team Number: assigned to team
' Team Member 1 Details: Ngomane, MJ (216077694)
' Team Member 2 Details:Menze ,M (220034828)
' Team Member 3 Details: Damoyi, T (220002492)
' Team Member 4 Details: Maholobela,ZA(220045302)
' Practical: Team Project
' Class name: UniversalPrimaryEducation
' *****************************************************************

Option Infer Off
Option Strict On
Option Explicit On
Public Class UniversalPrimaryEducation
    Inherits MillieniumGoals


    Private _Schoolfees As Double
    Private _Age As Integer
    Private _Enrolment As Integer

    Public Sub New(nY As Integer, population As Integer, CountryName As String)
        MyBase.New(nY, population, CountryName)
    End Sub

    Public Property Schoolfees As Double
        Get
            Return _Schoolfees
        End Get
        Set(value As Double)
            If (value < 0) Then
                _Schoolfees = value * -1
            Else
                _Schoolfees = value
            End If
        End Set
    End Property

    Public Property Enrolment As Integer
        Get
            Return _Enrolment
        End Get
        Set(value As Integer)
            _Enrolment = validateData(value)
        End Set
    End Property


    Public Property Age As Integer
        Get
            Return _Age
        End Get
        Set(value As Integer)
            _Age = validateData(value)
        End Set
    End Property

    Public Overrides Function Display() As String
        Dim temp As String
        temp = "Country name : " & CountryName & Environment.NewLine
        temp &= "Initial Popolation : " & Population & Environment.NewLine
        ' temp &= "Country funding eligibility : " & FundingEligibility() & Environment.NewLin
        Return temp

    End Function

End Class
