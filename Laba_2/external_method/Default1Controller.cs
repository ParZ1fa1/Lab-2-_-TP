using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Laba_2.external_method
{
    public static class Default1Controller 
    {
        public static MvcHtmlString ListArrayItems(this HtmlHelper html, List<Models.Person> Model)
        {
            TagBuilder block = new TagBuilder("div");
            foreach (var person in Model)
            {
                TagBuilder itemTag = new TagBuilder("tr");

                TagBuilder idTag = new TagBuilder("td");
                idTag.SetInnerText(Convert.ToString(person.PersonId));
                itemTag.InnerHtml += idTag.ToString();

                TagBuilder firstNameTag = new TagBuilder("td");
                firstNameTag.SetInnerText(Convert.ToString(person.FirstName));
                itemTag.InnerHtml += firstNameTag.ToString();

                TagBuilder lastNameTag = new TagBuilder("td");
                lastNameTag.SetInnerText(Convert.ToString(person.LastName));
                itemTag.InnerHtml += lastNameTag.ToString();

                TagBuilder ageTag = new TagBuilder("td");
                ageTag.SetInnerText(Convert.ToString(person.PersonAge));
                itemTag.InnerHtml += ageTag.ToString();

                TagBuilder phoneTag = new TagBuilder("td");
                phoneTag.SetInnerText(Convert.ToString(person.Phone));
                itemTag.InnerHtml += phoneTag.ToString();

                TagBuilder emailTag = new TagBuilder("td");
                emailTag.SetInnerText(Convert.ToString(person.Email));
                itemTag.InnerHtml += emailTag.ToString();

                TagBuilder premiumTag = new TagBuilder("td");
                premiumTag.SetInnerText(Convert.ToString(person.PremiumSub ? "Yes" : "No"));
                itemTag.InnerHtml += premiumTag.ToString();

                block.InnerHtml += itemTag.ToString();
            }
            return new MvcHtmlString(block.ToString());
        }

    }
}
