﻿//-----------------------------------------------------------------------
// <copyright file="TypeExtensionsTests.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//     Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using Akka.TestKit;
using Akka.Util;
using Xunit;

namespace Akka.Tests.Util
{
    
    public class TypeExtensionsTests
    {
        [Fact]
        public void TestGenericImplements()
        {
            typeof(object[]).Implements<IEnumerable>().ShouldBe(true);
            typeof(object[]).Implements<string>().ShouldBe(false);
            typeof(List<string>).Implements<IEnumerable<string>>().ShouldBe(true);
            typeof(List<string>).Implements<IEnumerable<int>>().ShouldBe(false);
        }

        [Fact]
        public void TestNongenericImplements()
        {
            typeof(object[]).Implements(typeof(IEnumerable)).ShouldBe(true);
            typeof(object[]).Implements(typeof(string)).ShouldBe(false);
            typeof(List<string>).Implements(typeof(IEnumerable<string>)).ShouldBe(true);
            typeof(List<string>).Implements(typeof(IEnumerable<int>)).ShouldBe(false);
        }
    }
}

