﻿using Xunit;
using System;
using System.IO;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;

namespace GildedRose
{
    [UseReporter(typeof(DiffReporter))]
    public class ApprovalTest
    {
        [Trait("Category", "Approval")]
        [Fact(Skip="Not working currently.")]
        public void ThirtyDays()
        {
            var fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            var output = fakeoutput.ToString();

            Approvals.Verify(output);
        }
    }
}
