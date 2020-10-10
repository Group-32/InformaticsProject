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
<Serializable()> Public Class ExtremeProverty_and_Hunger
    Inherits MillieniumGoals

    Private _Salarylessthan2D As Double
    Private _PovertyRate As Integer


    Public Sub New(nY As Integer)
        MyBase.New(nY)
    End Sub

    Public Property Salary As Double
        Get
            Return _Salarylessthan2D
        End Get
        Set(value As Double)
            _Salarylessthan2D = ValidateDouble(value)
        End Set
    End Property

    Public Property PovertyRate As Integer
        Get
            Return _PovertyRate
        End Get
        Set(value As Integer)
            _PovertyRate = validateData(value)
        End Set
    End Property


    Public Function DetermineRate() As Double
        Select Case _Salarylessthan2D
            Case Is <= 10000000
                PovertyRate = 5
            Case Is > 20000000
                PovertyRate = 25
            Case Else
                PovertyRate = 10
        End Select

        Return PovertyRate / 100
    End Function
    Public Function Determinegrowth() As Double
        Return Convert(Population) * (2.71828) ^ (DetermineRate() * Years)
    End Function



    Public Function CalcFinalpopolation() As Double
        Return Determinegrowth() - Population
    End Function



    Public Function Analysis() As String
        If (Determinegrowth() > Population) Then
            Return "'s Poverty growth has Increased "
        ElseIf (Determinegrowth() = Population) Then
            Return "'s Poverty growth has not changed"
        ElseIf (Determinegrowth() < Population) Then
            Return "'s Poverty growth has Decreased "
        Else
            Return "Invalid input"
        End If
    End Function

    Public Overrides Function Display() As String
        Dim temp As String
        temp = MyBase.Display
        temp &= "Population Growth : " & Determinegrowth() & Environment.NewLine
        temp &= CountryName & Analysis() & Environment.NewLine
        temp &= "Country funding eligibility : " & FundingEligibility() & Environment.NewLine

        Return temp

    End Function
End Class
