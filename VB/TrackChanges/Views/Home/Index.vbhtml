<script type="text/javascript">
    var isChanged = false;
    function OnValueChanged(s, e) {
        isChanged = true;
        btn.SetEnabled(true);
    }
    function OnClick(s, e) {
        if (isChanged) {
            if (confirm("Some value has been changed. Continue anyway?")) {
                window.location.href = '@Url.Action("About")';
            }
        }
    }
</script>

@Html.DevExpress().TextBox( _
    Sub(settings)
            settings.Name = "txt1"
            settings.Properties.ClientSideEvents.ValueChanged = "OnValueChanged"
End Sub).GetHtml()

@Html.DevExpress().SpinEdit( _
    Sub(settings)
            settings.Name = "se1"
            settings.Properties.ClientSideEvents.ValueChanged = "OnValueChanged"
End Sub).GetHtml()

@Html.DevExpress().Button( _
    Sub(settings)
            settings.Name = "btn"
            settings.Text = "Go Away"
            settings.ClientSideEvents.Click = "OnClick"
            settings.ClientEnabled = False
End Sub).GetHtml()