using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pretzel.Logic.Extensibility;

namespace Pretzel.PrettyDateTime
{
    public class PrettyDateFilter : IFilter
    {
        public string Name
        {
            get { return "PrettyDate"; }
        }

        public static string PrettyDate(DateTime input)
        {
            return input.ToString("d MMMM, yyyy");
        }
    }
}