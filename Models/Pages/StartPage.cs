using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace episerversite1.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "ebf68037-76bf-4afa-9546-8b499088ce14", Description = "")]
    public class StartPage : PageData
    {
        //[CultureSpecific]
        //[Display(
        //     Name = "Heading",
        //     Description = "The heading section of the page, using the textbox you can insert text.",
        //     GroupName = SystemTabNames.Content,
        //     Order = 1)]
        public virtual string Heading { get; set; }
        //[CultureSpecific]
        //[Display(
        //    Name = "Main body",
        //    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
        //    GroupName = SystemTabNames.Content,
        //    Order = 2)]
        public virtual XhtmlString MainBody { get; set; }

    }
}