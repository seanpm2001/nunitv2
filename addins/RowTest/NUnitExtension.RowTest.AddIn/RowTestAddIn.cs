// *********************************************************************
// Copyright 2007, Andreas Schlapsi
// This is free software licensed under the MIT license. 
// *********************************************************************
using System;
using System.Reflection;
using NUnit.Core;
using NUnit.Core.Extensibility;

namespace NUnitExtension.RowTest.AddIn
{
	[NUnitAddin(Name = "Row Test Extension")]
	public class RowTestAddIn : IAddin, ITestCaseBuilder
	{
		private RowTestFactory _testFactory;
		
		public RowTestAddIn()
		{
			_testFactory = new RowTestFactory();
		}
		
		public bool Install(IExtensionHost host)
		{
			if (host == null)
				throw new ArgumentNullException("host");
			
			IExtensionPoint testCaseBuilders = host.GetExtensionPoint("TestCaseBuilders");
			if (testCaseBuilders == null)
				return false;
			
			testCaseBuilders.Install(this);
			return true;
		}

        public bool CanBuildFrom(MethodInfo method)
        {
            return CanBuildFrom(method, null);
        }

	    public bool CanBuildFrom(MethodInfo method, Test suite)
        {
			return RowTestFramework.IsRowTest(method);
		}

        public Test BuildFrom(MethodInfo method)
        {
            return BuildFrom(method, null);
        }

	    public Test BuildFrom(MethodInfo method, Test suite)
        {
			if (method == null)
				throw new ArgumentNullException("method");
			
			RowTestSuite methods = _testFactory.CreateRowTestSuite(method);
			Attribute[] rows = RowTestFramework.GetRowAttributes(method);

			foreach (Attribute row in rows)
				methods.Add(_testFactory.CreateRowTestCase(row, method));
			
			return methods;
		}
	}
}
