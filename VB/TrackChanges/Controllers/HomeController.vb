Imports Microsoft.VisualBasic
Imports System.Web.Mvc

Namespace TrackChanges.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function
		Public Function About() As ActionResult
			Return View()
		End Function
	End Class
End Namespace