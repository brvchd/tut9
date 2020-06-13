using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tut9.Exceptions
{
    public class NoStudentsToPromote : Exception
    {
        public NoStudentsToPromote(string message = "There are no student to promote") : base (message) { }
    }
}
