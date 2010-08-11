//
// Author: Atsushi Enomoto <atsushi@ximian.com>
//
// Copyright (C) 2010 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Discovery;
using System.ServiceModel.Dispatcher;
using NUnit.Framework;

namespace MonoTests.System.ServiceModel.Discovery
{
	[TestFixture]
	public class DiscoveryEndpointTest
	{
		[Test]
		public void DefaultValues ()
		{
			var de = new DiscoveryEndpoint ();
			Assert.AreEqual (DiscoveryVersion.WSDiscovery11, de.DiscoveryVersion, "#1");
			Assert.AreEqual (ServiceDiscoveryMode.Managed, de.DiscoveryMode, "#2");
			Assert.AreEqual (TimeSpan.Zero, de.MaxResponseDelay, "#3");
			Assert.IsNotNull (de.Contract, "#11"); // some version-dependent internal type.
			Assert.AreEqual ("http://docs.oasis-open.org/ws-dd/ns/discovery/2009/01", de.Contract.Namespace, "#11-2");
			Assert.AreEqual ("DiscoveryProxy", de.Contract.Name, "#11-3");
			Assert.IsNull (de.Binding, "#12");
			Assert.IsNull (de.Address, "#13");
			Assert.IsNull (de.ListenUri, "#14");
		}
	}
}
