/********************************************************************************************************************
'
' Copyright (c) 2002, James Newkirk, Michael C. Two, Alexei Vorontsov, Philip Craig
'
' Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
' documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
' the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and
' to permit persons to whom the Software is furnished to do so, subject to the following conditions:
'
' The above copyright notice and this permission notice shall be included in all copies or substantial portions 
' of the Software.
'
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO
' THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
' AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
'
'*******************************************************************************************************************/
using System;

namespace NUnit.Core
{
	/// <summary>
	/// Summary description for WarningSuite.
	/// </summary>
	public class WarningSuite : TestSuite
	{
		public WarningSuite(string name) : base(name) 
		{
			ShouldRun=false;
		}

		public WarningSuite(string parentName, string name) : base(parentName,name) 
		{
			ShouldRun=false;
		}

		protected internal override void Add(Test test)
		{
			base.Add(test);
			test.ShouldRun = false;
			test.IgnoreReason = "Containing Suite cannot be run";
		}

		protected internal override TestSuite CreateNewSuite(Type type) 
		{
			return new WarningSuite(type.Namespace,type.Name);
		}
	}
}
