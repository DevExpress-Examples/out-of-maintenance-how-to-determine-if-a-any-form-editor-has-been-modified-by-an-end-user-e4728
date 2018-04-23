@Html.DevExpress().Button( _
    Sub(settings)
    settings.Name = "btn"
    settings.Text = "<< Home"
    settings.RouteValues = New With { .Controller = "Home", .Action = "Index" }
End Sub).GetHtml()