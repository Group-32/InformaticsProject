' *****************************************************************
' Team Number: 32
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
<Serializable()> Public Class UniversalPrimaryEducation
    Inherits MillieniumGoals

    'The Primary education attributes
    Private _Schoolfees As Double
    Private _Age As Integer
    Private _Enrolment As Double
    Private _ChildPop As Double
    'The constructor
    Public Sub New(nY As Integer)
        MyBase.New(nY)
    End Sub

    Public Property Schoolfees As Double
        Get
            Return _Schoolfees
        End Get
        Set(value As Double)
            _Schoolfees = ValidateDouble(value)
        End Set
    End Property

    Public Property Enrolment As Double
        Get
            Return _Enrolment
        End Get
        Set(value As Double)
            _Enrolment = ValidateDouble(value)
        End Set
    End Property

    Public Property ChildPop As Double
        Get
            Return _ChildPop
        End Get
        Set(value As Double)
            _ChildPop = ValidateDouble(value)
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
    'Checks whether the child population is more than the actual population
    Private Function CheckChildPop() As Boolean
        If Convert(_ChildPop) <= Population Then
            Return True
        Else
            Return False
        End If
    End Function
    'This is the enrollment rate being calculated
    Public Function EnrollmentRate() As Double
        If CheckChildPop() Then
            Return (Convert(_Enrolment) / Convert(_ChildPop)) * 100
        End If
    End Function
    'Finds non-school going children among the child population that should be at school
    Public Function FindNonSchoolGoingChild() As Double
        If CheckChildPop() Then
            Return Convert(_ChildPop - _Enrolment)
        End If
    End Function

    Public Overrides Function Display() As String
        Dim temp As String
        temp = MyBase.Display()
        temp &= "Country funding eligibility : " & FundingEligibility() & Environment.NewLine
        temp &= "Enrollment Rate: " & Format(EnrollmentRate(), "0.0") & "%" & Environment.NewLine
        temp &= "Number of children not at school: " & Format(FindNonSchoolGoingChild(), "0") & Environment.NewLine
        Return temp

    End Function


End Class
