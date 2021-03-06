// <copyright file="Class1Test.cs">Copyright ©  2015</copyright>
using System;
using IntelliTestIssue;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntelliTestIssue.Tests
{
    /// <summary>This class contains parameterized unit tests for Class1</summary>
    [PexClass(typeof(Class1))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class Class1Test
    {
        /// <summary>Test stub for Base64Decode(String)</summary>
        [PexMethod]
        internal string Base64DecodeTest([PexAssumeUnderTest]Class1 target, string input)
        {
            string result = target.Base64Decode(input);
            return result;
            // TODO: add assertions to method Class1Test.Base64DecodeTest(Class1, String)
        }
    }
}
