using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PromoEngineLibrary.Entity;

namespace PromoEngineLibrary
{
    public class PromoEngineLibrary
    {
        public static int CheckOut(List<SKUInputClass> sKUInputClass)
        {
            int unitPrice = 0;
            PromoEngineLibrary promoEngineLibrary = new PromoEngineLibrary();

            Root root = promoEngineLibrary.LoadPromoData();//load the promotype config to root object

            unitPrice = promoEngineLibrary.GetUnitPrice(sKUInputClass, root);// calculate unit price based on input
            return unitPrice;
        }


        #region Private Methods

        private int GetUnitPrice(List<SKUInputClass> sKUInputClass,Root root)
        {
            int unitPrice = 0;
            //calculate Unit Price

            return unitPrice;
        }

        /// <summary>
        /// Get the PromoTypes Configuration from the Json file - real time it can be pulled from a database
        /// deserialize the Json data to corresponding entites
        /// </summary>
        /// <returns></returns>
        private Root LoadPromoData()
        {
            Root root = new Root();
            string dirPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string filePath = "Data//PromoTypes.json";

            string fullPath = Path.Combine(dirPath, filePath);

            using (StreamReader r = new StreamReader(fullPath))
            {
                string json = r.ReadToEnd();

                JObject jsonObj = JObject.Parse(json);
                root = JsonConvert.DeserializeObject<Root>(json);//deseriealize to class objects
            }
            return root;
        }

        #endregion
    }
}
