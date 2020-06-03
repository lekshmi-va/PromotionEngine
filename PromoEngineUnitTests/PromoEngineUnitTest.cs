using System;
using System.Collections.Generic;
using NUnit.Framework;
using PromoEngineLibrary.Entity;
using PromoEngineLibrary;
namespace PromoEngineUnitTests
{
    [TestFixture]
    public class PromoEngineUnitTest
    {

        [Test]//ScenarioA - A*5, B*5, C*1 - return 100
        public void SKU_One_Each_ScenarioA()
        {
            //Assign
            List<SKUInputClass> lstSKUClass = new List<SKUInputClass>();
            SKUInputClass sKUClass = new SKUInputClass();

            sKUClass = new SKUInputClass()
            {
                Id = "A",
                Count = 1
            };
            lstSKUClass.Add(sKUClass);

            sKUClass = new SKUInputClass()
            {
                Id = "B",
                Count = 1
            };
            lstSKUClass.Add(sKUClass);

            sKUClass = new SKUInputClass()
            {
                Id = "C",
                Count = 1
            };
            lstSKUClass.Add(sKUClass);
            //Act
            int output = PromoEngineLibrary.PromoEngineLibrary.CheckOut(lstSKUClass);

            //Assert
            Assert.AreEqual(100, output);

        }

        [Test]//ScenarioB A*5, B*5, C*1 - return - 370
        public void SKU_Offer_ScenarioB()
        {
            //Assign
            List<SKUInputClass> lstSKUClass = new List<SKUInputClass>();
            SKUInputClass sKUClass = new SKUInputClass();

            sKUClass = new SKUInputClass()
            {
                Id = "A",
                Count = 5
            };
            lstSKUClass.Add(sKUClass);

            sKUClass = new SKUInputClass()
            {
                Id = "B",
                Count = 5
            };
            lstSKUClass.Add(sKUClass);

            sKUClass = new SKUInputClass()
            {
                Id = "C",
                Count = 1
            };
            lstSKUClass.Add(sKUClass);

            //Act
            int output = PromoEngineLibrary.PromoEngineLibrary.CheckOut(lstSKUClass);

            //Assert
            Assert.AreEqual(370, output);

        }

        [Test]//ScenarioC A*3, B*5, C*1, D*1 - return - 280
        public void SKU_Offer_ScenarioC()
        {
            //Assign
            List<SKUInputClass> lstSKUClass = new List<SKUInputClass>();
            SKUInputClass sKUClass = new SKUInputClass();

            sKUClass = new SKUInputClass()
            {
                Id = "A",
                Count = 5
            };
            lstSKUClass.Add(sKUClass);

            sKUClass = new SKUInputClass()
            {
                Id = "B",
                Count = 5
            };
            lstSKUClass.Add(sKUClass);

            sKUClass = new SKUInputClass()
            {
                Id = "C",
                Count = 1
            };
            lstSKUClass.Add(sKUClass);

            sKUClass = new SKUInputClass()
            {
                Id = "D",
                Count = 1
            };
            lstSKUClass.Add(sKUClass);

            //Act
            int output = PromoEngineLibrary.PromoEngineLibrary.CheckOut(lstSKUClass);

            //Assert
            Assert.AreEqual(280, output);

        }
    }
}
