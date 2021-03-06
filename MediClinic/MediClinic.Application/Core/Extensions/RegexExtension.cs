using MediClinic.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MediClinic.Application.Core.Extensions
{
    static public partial class Extension
    {

        public static string PlainText(this string text)
        {
            return Regex.Replace(text, @"<[^>]*>", "");
        }

        public static bool? IsEmail(this string text)
        {
            return Regex.IsMatch(text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        private static readonly Regex sWhitespace = new Regex(@"\s+");
        public static string ReplaceWhitespace(string input, string replacement)
        {
            var a = sWhitespace.Replace(input, replacement);
            return a;
        }
    }


}