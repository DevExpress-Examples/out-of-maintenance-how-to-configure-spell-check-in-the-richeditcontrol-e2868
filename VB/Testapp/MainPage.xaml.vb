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
Imports DevExpress.XtraSpellChecker
Imports System.Reflection
Imports System.IO
Imports System.Globalization
Imports DevExpress.Xpf.SpellChecker
Imports Testapp.SpellChecker

Namespace Testapp
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub richEdit_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim spellChecker As DevExpress.Xpf.SpellChecker.SpellChecker = SpellCheckerHelper.SpellChecker
			spellChecker.SpellCheckMode = SpellCheckMode.AsYouType
			Me.richEdit.SpellChecker = spellChecker
		End Sub
	End Class
End Namespace
