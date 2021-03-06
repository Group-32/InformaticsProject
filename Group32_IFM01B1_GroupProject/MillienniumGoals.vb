﻿' *****************************************************************
' Team Number: 32
' Team Member 1 Details: Ngomane, MJ (216077694)
' Team Member 2 Details:Menze ,M (220034828)
' Team Member 3 Details: Damoyi, T (220002492)
' Team Member 4 Details: Maholobela,ZA(220045302)
' Practical: Team Project
' Class name: MillienniumGoals
' *****************************************************************

Option Infer Off
Option Strict On
Option Explicit On

<Serializable()> Public Class MillieniumGoals
    'The MilleniumGoals attributes
    Private _CountryName As String
    Private _Population As Double
    Private _Years As Integer
    Private _GDP As Double

    'The constructors
    Public Sub New(nY As Integer)
        _Years = nY
    End Sub
    'The property methods
    Public Property CountryName As String
        Get
            Return _CountryName
        End Get
        Set(value As String)
            _CountryName = value
        End Set
    End Property

    Public Property GDP As Double
        Get
            Return _GDP
        End Get
        Set(value As Double)
            _GDP = ValidateDouble(value)
        End Set
    End Property

    Public Property Population As Double
        Get
            Return _Population
        End Get
        Set(value As Double)
            _Population = ValidateDouble(value)
        End Set
    End Property
    Public Property Years As Integer
        Get
            Return _Years
        End Get
        Set(value As Integer)
            _Years = validateData(value)
        End Set
    End Property
    'converts any number to millions
    Public Function Convert(number As Double) As Double

        Return number * 1000000
    End Function
    'Checks if an integer number has any negative values, if so then the values are multiplied by -1
    Protected Function validateData(number As Integer) As Integer
        If (number < 0) Then
            Return number * -1
        Else
            Return number
        End If
    End Function
    Public Function FundingEligibility() As String
        If _GDP < 100000000000 Then
            Return "Eligible "
        Else
            Return "Not Eligible  "
        End If
    End Function
    'Checks if a double has any negative values, if so then the values are multiplied by -1
    Protected Function ValidateDouble(x As Double) As Double
        If (x < 0) Then
            Return x * -1
        Else
            Return x
        End If
    End Function
    'The rest of the function will be displayed using the diaplay function on the Education and PovertyAndHunger classes
    Public Overridable Function Display() As String
        Dim temp As String
        temp = "Country name : " & CountryName & Environment.NewLine
        temp &= "Initial Popolation : " & Population & Environment.NewLine
        Return temp
    End Function

End Class
