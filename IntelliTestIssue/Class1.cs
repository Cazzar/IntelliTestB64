using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelliTestIssue
{
    class Class1
    {
        public string Bas64Encode(string input) => Convert.ToBase64String(Encoding.UTF8.GetBytes(input)); //This is fine
        public string Base64Decode(string input) => Encoding.UTF8.GetString(Convert.FromBase64String(input)); //I would expect more than one just to pass.
    }
}
