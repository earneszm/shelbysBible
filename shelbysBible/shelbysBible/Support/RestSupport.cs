using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using shelbysBible.Models;

namespace shelbysBible.Support
{
    public static class RestSupport
    {
        public static string RequestBook(string bookName, int chapterNumber)
        {
            var requestString = string.Format(string.Format("{0}", ConfigUtils.API_Url), bookName, chapterNumber);
            var client = new RestClient(requestString);
            var request = new RestRequest("", Method.GET);

            request.AddHeader("Authorization", string.Format("Basic {0}", ConfigUtils.API_Key));

            var response = client.Execute<Response>(request);

            return response.Content;
        }

        public static string RequestVerseOfTheDay()
        {
            var requestString = string.Format(string.Format("{0}", ConfigUtils.Verse_Of_The_Day_Url));
            var client = new RestClient(requestString);
            var request = new RestRequest("", Method.GET);

         //   request.AddHeader("Authorization", string.Format("Basic {0}", ConfigUtils.API_Key));

            var response = client.Execute(request);

            return response.Content;
        }
    }
}