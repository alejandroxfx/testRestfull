#pragma checksum "C:\Users\Alex\source\repos\Restfull\Restfull\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f8022c1237e1dc940eaefe0cfe579d2e08e2b56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Alex\source\repos\Restfull\Restfull\Views\_ViewImports.cshtml"
using Restfull;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\source\repos\Restfull\Restfull\Views\_ViewImports.cshtml"
using Restfull.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f8022c1237e1dc940eaefe0cfe579d2e08e2b56", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b204e3209f1bd3e7bc15f926c59e3f1d2882221c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Alex\source\repos\Restfull\Restfull\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://cdn.jsdelivr.net/npm/vue@2.6.10/dist/vue.js""></script>
<script src=""https://unpkg.com/axios/dist/axios.min.js""></script>
<script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>

<div id=""restApp"">
    <div class=""text-center"">
        <h1 class=""display-4"">Welcome</h1>
        <p>Do you want to see a random dog? <img src=""https://i.pinimg.com/originals/9f/8a/16/9f8a16e38df86be51951fa374fb9b351.png"" width=""50"" height=""50"" /></p>
        <button v-on:click=""dontSeeDog"" class=""btn btn-light"">Nop</button><button v-on:click=""seeDog"" class=""btn btn-success"">{{RandomDog.btnYes}}</button>
        <div v-if=""RandomDog.showDog"">
            <p>You have been seen {{RandomDog.counter}} dog's</p>
            <img v-bind:src=""RandomDog.url"" />
        </div>
        <div v-if=""LoadingRandomDog""><p class=""alert alert-warning"">Taking a look around the world...</p></div>
        <hr />
        <div class=""row"">
            <div class=""col-md-3""></div>
            <div ");
            WriteLiteral(@"class=""col-md-6"">
                <p>What's your favorite hobbie?</p>
                <input class=""form-control"" placeholder=""(e.g. music, reading, television, shopping...)"" v-model=""Hobbie.Name"" />
                <button v-on:click=""findHobbie()"" class=""btn btn-primary"">Find!</button>
            </div>
            <div class=""col-md-3""></div>

            <div v-if=""IsHobbieFound"" class=""col-md-8 offset-2"">
                <br />
                <div class=""card"">
                    <div class=""card-body"">
                        <blockquote class=""blockquote blockquote-custom bg-white px-3 pt-4"">
                            <div class=""blockquote-custom-icon bg-info shadow-1-strong"">
                                <i class=""fa fa-quote-left text-white""></i>
                            </div>
                            <p class=""mb-0 mt-2 font-italic"">
                                Do you know that this hobbie is #{{Hobbie.Place}} on the world?
                            </p>
     ");
            WriteLiteral(@"                       <footer class=""blockquote-footer pt-4 mt-4 border-top"">
                                <cite title=""Source Title"">{{Hobbie.Description}}</cite>
                            </footer>
                        </blockquote>
                    </div>
                </div>


            </div>
        </div>

        <hr />
        <div class=""row"">
            <div class=""col-md-12""><h5>Add new hobbie to the list</h5></div>
            <div class=""col-md-4""></div>
            <div class=""col-md-4""><input v-model=""NewHobbie.Name"" placeholder=""Name"" class=""form-control""/></div>
            <div class=""col-md-4""></div>

            <div class=""col-md-4""></div>
            <div class=""col-md-4"">
                <textarea v-model=""NewHobbie.Description"" placeholder=""Description"" class=""form-control""></textarea>
                <button v-on:click=""addNewHobbie()"" class=""btn btn-success"">Add</button>
            </div>
            <div class=""col-md-4""></div>

          ");
            WriteLiteral(@"  <div v-if=""AddingNewHobbie""><p class=""alert alert-warning"">Adding new hobbie ...</p></div>
        </div>

    </div>
</div>

<script>
    var restApp = new Vue({
        el: '#restApp',
        data: {
            Hobbie: { Name: '', Place: 0, Description: '' },
            NewHobbie: { Name: '', Place: 0, Description: '' },
            HobbieMessage : '',
            RandomDog: { showDog: false, url: '', btnYes : 'Yes', counter : 0 },
            LoadingRandomDog: false,
            IsHobbieFound: false,
            ShowHobbieMessage: false,
            AddingNewHobbie: false
        },
        methods: {
            seeDog: function () {
                var self = this;
                self.RandomDog.showDog = false;
                self.LoadingRandomDog = true;

                axios.get(""https://dog.ceo/api/breeds/image/random"", { mode: 'cors' })
                    .then(response => {
                        console.log(response)
                        console.log(response");
            WriteLiteral(@".data.message)
                        if (response.data.status === ""success"") {
                            self.RandomDog.url = response.data.message;
                            self.RandomDog.showDog = true;
                            self.RandomDog.btnYes = self.getRandomeTitleForYesButton();
                            self.RandomDog.counter += 1;
                        }
                        self.LoadingRandomDog = false;
                    })
                    .catch(e => {
                        self.RandomDog.showDog = false;
                    });
            },
            getRandomeTitleForYesButton: function () {
                var options = [""Lol, one more!"",""Next xD!"",""Whos next?"",""Great!"",""Click"",""Hehe"",""Amazing!"",""That's so funny, 1 more"", ""Hahahaha, next!"", ""sure, next!""];
                return options[Math.floor(Math.random() * options.length)];
            },
            dontSeeDog: function () {
                var self = this;
                swal({
     ");
            WriteLiteral(@"               title: ""Come on!"",
                    text: ""Are you sure that you don't want to see a dog?"",
                    buttons: [""Nop, I don't want"", ""Ok let's try""],
                }).then(function (isConfirm) {
                    if (isConfirm) {
                        self.seeDog();
                    }
                });
            },
            findHobbie: function () {
                var self = this;
                self.IsHobbieFound = false;

                if (self.Hobbie.Name == '' || self.Hobbie.Name.length < 3) {
                    swal(""Warning"", ""Please introduce a hobbie with at least 3 letters"", ""warning"");
                    return false;
                }              

                axios({
                    method: 'post',
                    url: 'Home/FindHobbie',
                    data: self.Hobbie
                    }).then(response => {
                        if (response.data.success && response.data.hobbie != null) {
            ");
            WriteLiteral(@"                self.Hobbie.Place = response.data.hobbie.place;
                            self.Hobbie.Description = response.data.hobbie.description;
                            self.IsHobbieFound = true;
                        } else {
                            swal({
                                title: ""Oops..."",
                                text: ""Seems that we couldn't find your hobbie, please try again!"",
                                type: ""warning"",
                                showConfirmButton: true
                            })
                        }
                    })
                    .catch(e => {
                       //show regarding error message or workflow to handle this
                    });
            }, 
            addNewHobbie: function () {
                var self = this;
                self.AddingNewHobbie = false;

                if (self.NewHobbie.Name == '' || self.NewHobbie.Name.length < 3) {
                    swal(""Warning"",");
            WriteLiteral(@" ""Please introduce a hobbie with at least 3 letters"", ""warning"");
                    return false;
                }

                if (self.NewHobbie.Description == '' || self.NewHobbie.Name.Description < 5) {
                    swal(""Warning"", ""Please introduce a description with at least 5 letters"", ""warning"");
                    return false;
                }              

                self.AddingNewHobbie = true;
                axios({
                    method: 'post',
                    url: 'Home/AddHobbie',
                    data: self.NewHobbie
                    }).then(response => {
                        if (response.data.success) {
                            swal({
                                title: ""Ok"",
                                text: self.NewHobbie.Name+"" has been added!"",
                                type: ""success"",
                                showConfirmButton: true
                            })
                            self.NewH");
            WriteLiteral(@"obbie.Name = '';
                            self.NewHobbie.Description = '';
                           
                        } else {
                            swal({
                                title: ""Oops..."",
                                text: ""Seems that we couldn't add your hobbie, please try again!"",
                                type: ""warning"",
                                showConfirmButton: true
                            })
                        }
                        self.AddingNewHobbie = false;
                    })
                    .catch(e => {
                       //show regarding error message or workflow to handle this
                    });
            }
        },
    });
</script>


");
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
