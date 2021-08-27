<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128549191/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4728)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Index.cshtml](./CS/WebSite/Views/Home/Index.cshtml)**
<!-- default file list end -->
# How to determine if a any form editor has been modified by an end-user
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4728/)**
<!-- run online end -->


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


