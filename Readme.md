# How to determine if a any form editor has been modified by an end-user


<p>This example illustrates how to determine if a any form editor has been modified by an end-user:<br />
- Handle the client-side ValueChanged event of all editors;<br />
- If any event has been raised once, mark the form's state "modified".</p>

```js
var isChanged = false;
function OnValueChanged(s, e) {
    isChanged = true;
}
```

<p> </p>

```cs
@Html.DevExpress().TextBox(settings => {
    settings.Name = "txt1";
    settings.Properties.ClientSideEvents.ValueChanged = "OnValueChanged";
}).GetHtml()
```

<p> </p>

```cs
@Html.DevExpress().SpinEdit(settings => {
    settings.Name = "se1";
    settings.Properties.ClientSideEvents.ValueChanged = "OnValueChanged";
}).GetHtml()
```

<p> </p>

<br/>


