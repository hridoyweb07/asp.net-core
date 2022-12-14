#pragma checksum "C:\Users\nahid\OneDrive\Desktop\All Evidence\Core\ASP.NET Core Crud\Evidence\Views\Contact\SPA.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74d01b3a476ca5a6fb5e591de4da7b5396a44bb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_SPA), @"mvc.1.0.view", @"/Views/Contact/SPA.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\nahid\OneDrive\Desktop\All Evidence\Core\ASP.NET Core Crud\Evidence\Views\_ViewImports.cshtml"
using Evidence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nahid\OneDrive\Desktop\All Evidence\Core\ASP.NET Core Crud\Evidence\Views\_ViewImports.cshtml"
using Evidence.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d01b3a476ca5a6fb5e591de4da7b5396a44bb2", @"/Views/Contact/SPA.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d6dd054d9b9b29d44f88c5e4ac946241bbd8f18", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_SPA : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div id=""list"">
    <h2>Contact Information</h2>
    <a href=""#"" onclick=""loadView('form')"">Create New</a>
    <div>
        <table>
            <thead>
                <tr>
                    <td>ID</td>
                    <td>Name</td>
                    <td>Gender</td>
                    <td>Age</td>
                    <td>Country Name</td>
                    <td>DOB</td>
                    <td>Photo</td>
                    <td>Edit</td>
                    <td>Delete</td>
                </tr>
            </thead>
            <tbody id=""tbody"">

            </tbody>
        </table>
    </div>
</div>
<!--<div id=""form"">
    <h2>Add Contact</h2>
    <a href=""#"" onclick=""loadView('list')"">List of Contact</a>
    <div>
        <input type=""hidden"" id=""contactID"" />
        <div> Name <input type=""text"" id=""contactName"" /> </div>
        <div>
            Gender
            <input type=""radio"" name=""gender"" id=""male"" /> Male
            <input type=""radio"" name=""gend");
            WriteLiteral(@"er"" id=""female"" /> Female
        </div>
        <div> Age <input type=""number"" id=""age"" /> </div>
        <div> Country Name <select id=""countryName""></select> </div>
        <div> DOB <input type=""date"" id=""dob"" /> </div>
        <div> Photo <input type=""file"" id=""photo"" /> </div>
        <div>
            <input type=""submit"" id=""insert"" value=""SAVE"" onclick=""insert()"" />
            <input type=""submit"" id=""update"" value=""UPDATE"" onclick=""update()"" />
            <!--<button type=""button"" onclick=""insert();"" id=""insert"">Save</button>
            <button type=""button"" onclick=""update();"" id=""update"">Update</button>
        </div>
    </div>
</div>-->

<div id=""form"">
    <h3>Create Contact</h3>
    <a href=""#"" onclick=""loadView('list');"">List of Contact</a>
    <div>
        <div>
            <input type=""hidden"" id=""contactID"" />
            Name: <input type=""text"" id=""contactName"" />
        </div>
        <div>
            Country:
            <select id=""countryName""></select>");
            WriteLiteral(@"
        </div>
        <div>
            Date of Birth: <input type=""date"" id=""dob"" />
        </div>
        <div>
            Gender:
            <input type=""radio"" id=""male"" name=""gender"" value=""Male"" /> Male
            <input type=""radio"" id=""female"" name=""gender"" value=""Female"" /> Female
        </div>
        <div>
            Pic:
            <input type=""file"" id=""photo"" name=""photo"" />
        </div>
        <div>
            <button type=""button"" onclick=""insert();"" id=""insert"">Save</button>
            <button type=""button"" onclick=""update();"" id=""update"">Update</button>
        </div>
    </div>
</div>

<script>
    function loadView(view) {
        if (view == ""list"") {
            document.getElementById(""list"").style.display = '';
            document.getElementById(""form"").style.display = 'none';
        }
        else {
            document.getElementById(""list"").style.display = 'none';
            document.getElementById(""form"").style.display = '';
          ");
            WriteLiteral(@"  document.getElementById(""update"").style.display = 'none';
            this.getCountry();
        }
    }
    this.loadView('list');
    this.getContact();
    var contact = {
        'contactID': '',
        'contactName': '',
        'gender': '',
        'age': '',
        'dob': '',
        'photo': '',
        'countryID': '',
        'countryName': '',
    }

    function getCountry() {
        var xhr = new XMLHttpRequest();
        xhr.open('GET', '/Contact/GetCountry', true);
        xhr.onload = function () {
            var listCountry = JSON.parse(this.responseText);
            var options = '';
            for (var i = 0; i < listCountry.length; i++) {
                var option = '<option value=""' + listCountry[i].countryId + '"">' + listCountry[i].countryName + '</option>';
                options += option;
            }
            document.getElementById('countryName').innerHTML = options;
        };
        xhr.send();
    }

    function getContact() {
   ");
            WriteLiteral(@"     var xhr = new XMLHttpRequest();
        xhr.open('GET', '/Contact/GetContact', true);
        xhr.onload = function () {
            var listContact = JSON.parse(this.responseText);
            var contact = '';
            for (var i = 0; i < listContact.length; i++) {
                var tr = '<tr>'
                    + '<td>' + listContact[i].contactID + '</td>'
                    + '<td>' + listContact[i].contactName + '</td>'
                    + '<td>' + listContact[i].gender + '</td>'
                    + '<td>' + listContact[i].age + '</td>'
                    + '<td>' + listContact[i].countryName + '</td>'
                    + '<td>' + listContact[i].dob + '</td>'
                    + '<td> <img src=""/photo/' + listContact[i].photo + '"" style=""width:100px"" /> </td>'

                    + '<td><a href=""#"" onclick=""edit(' + listContact[i].contactID + ')"">Edit</a></td>'
                    + '<td><a href=""#"" onclick=""remove(' + listContact[i].contactID + ')"">Delete</a></td>'");
            WriteLiteral(@"
                    + '</tr>';
                contact += tr;
            }
            document.getElementById('tbody').innerHTML = contact;
        }
        xhr.send();
    }

    //function insert() {
    //    this.contact.contactID = 0;
    //    this.contact.contactName = document.getElementById('contactName').value;
    //    this.contact.gender = document.getElementById(""male"").checked === true ? 'Male' : 'Female';
    //    this.contact.age = document.getElementById('age').value;
    //    this.contact.countryID = document.getElementById('countryName').value;
    //    this.contact.dob = document.getElementById('dob').value;

    //    var files = document.getElementById('photo').files;
    //    this.contact.photo = files.length > 0 ? files[0] : null;
    //    var strInsert = JSON.stringify(this.contact);

    //    var formData = new FormData();
    //    formData.append(""contactID"", this.contact.contactID);
    //    formData.append(""contactName"", this.contact.contactName");
            WriteLiteral(@");
    //    formData.append(""gender"", this.contact.gender);
    //    formData.append(""age"", this.contact.age);
    //    formData.append(""countryID"", this.contact.countryID);
    //    formData.append(""dob"", this.contact.dob);
    //    formData.append(""photo"", this.contact.photo);

    //    var xhr = new XMLHttpRequest();
    //    xhr.open('GET', '/Contact/Insert', true);
    //    xhr.onreadystatechange = function () {
    //        if (xhr.readyState == 4 && xhr.status == 200) {
    //            if (xhr.responseText != null) {
    //                var res = JSON.parse(xhr.responseText);
    //                if (res != null) {
    //                    if (res.resstate == true) {
    //                        alert('Save Successfully !');
    //                        loadView('list');
    //                    }
    //                }
    //            }
    //        }
    //    }
    //    xhr.send(formData);
    //}

    function insert() {
        this.contact.contactI");
            WriteLiteral(@"d = 0;
        this.contact.contactName = document.getElementById('contactName').value;
        this.contact.gender = document.getElementById(""Male"").checked === true ? 'Male' : 'Female';
        this.contact.age = document.getElementById('age').value;
        this.contact.countryId = document.getElementById('countryName').value;
        this.contact.dob = document.getElementById('dob').value;
        var strJson = JSON.stringify(this.contact);

        var files = document.getElementById('photo').files;
        var file = files.length > 0 ? files[0] : null;
        var formData = new FormData();
        formData.append(""contactID"", this.contact.contactID);
        formData.append(""contactName"", this.contact.contactName);
        formData.append(""gender"", this.contact.gender);
        formData.append(""age"", this.contact.age);
        formData.append(""countryID"", this.contact.countryID);
        formData.append(""dob"", this.contact.dob);
        formData.append(""photo"", file);

        var ht");
            WriteLiteral(@"tp = new XMLHttpRequest();
        var url = '/Contact/Insert';
        http.open('POST', url, true);
        //http.setRequestHeader('Content-type', 'multipart/form-data');
        http.onreadystatechange = function () {
            if (http.readyState == 4 && http.status == 200) {
                if (http.responseText != null) {
                    var res = JSON.parse(http.responseText);
                    if (res != null) {
                        if (res.resstate == true) {
                            alert('Save successfully.');
                            loadView('list');
                        }
                    }
                }
            }
        }
        //http.send(strJson);
        http.send(formData);
    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
