Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Core

Namespace CustomExpandButton
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			ThemeManager.ApplicationTheme = Theme.DeepBlue
		End Sub
	End Class
	Public Class SimpleData
		Private privateColumn1 As String
		Public Property Column1() As String
			Get
				Return privateColumn1
			End Get
			Set(ByVal value As String)
				privateColumn1 = value
			End Set
		End Property
		Private privateColumn2 As Integer
		Public Property Column2() As Integer
			Get
				Return privateColumn2
			End Get
			Set(ByVal value As Integer)
				privateColumn2 = value
			End Set
		End Property

		Private privateId As Integer
		Public Property Id() As Integer
			Get
				Return privateId
			End Get
			Set(ByVal value As Integer)
				privateId = value
			End Set
		End Property
		Private privateParentId As Integer
		Public Property ParentId() As Integer
			Get
				Return privateParentId
			End Get
			Set(ByVal value As Integer)
				privateParentId = value
			End Set
		End Property

		Public Sub New()
		End Sub

		Public Sub New(ByVal str1 As String, ByVal int2 As Integer)
			Column1 = str1
			Column2 = int2
		End Sub
	End Class
End Namespace