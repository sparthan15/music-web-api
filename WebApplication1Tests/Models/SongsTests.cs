﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models.Tests
{
    [TestClass()]
    public class SongsTests
    {
        [TestMethod()]
        public void fooTest()
        {
            Assert.IsNotNull(new Song());
        }
    }
}