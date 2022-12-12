using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers.Tests
{
    [TestClass()]
    public class SongControllerTests
    {
        private Songs2Controller _controller = new Songs2Controller();

        [TestMethod]
        public void GetTest()
        {
            List<Song> response = (List<Song>)_controller.Get();
            Assert.IsNotNull(response);
            Assert.AreEqual(2, response.Count);
        }

        [TestMethod]
        public void PostTest()
        {
            _controller.Post(new Song() { Id = 1, Title = "New guachu guey", Language = "Inglish" });
            Assert.AreEqual(_controller.Get().Count(), 3);
        }
        [TestMethod]
        public void PutTest()
        {
            _controller.Put(0, new Song() { Id = 0, Title = "New guachu guey", Language = "Inglisheee" });
            Assert.AreEqual("Inglisheee", _controller.Get().ElementAt(0).Language);
        }
    }
}