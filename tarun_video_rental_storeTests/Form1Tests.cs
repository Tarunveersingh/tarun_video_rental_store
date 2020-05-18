using Microsoft.VisualStudio.TestTools.UnitTesting;
using tarun_video_rental_store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarun_video_rental_store.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            MovieBooking obj = new MovieBooking(1);
            int copies=obj.VideoCopies(1);
            if (copies > 0)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod()]
        public void Form2Test()
        {
            Movie obj = new Movie();
            int copies = obj.checkCost(2014);
            if (copies ==2)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }


    }
}