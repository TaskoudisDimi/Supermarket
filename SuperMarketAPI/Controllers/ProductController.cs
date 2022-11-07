using SupermarketTuto.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using SupermarketTuto.DataAccess;
using SuperMarketAPI.Models;

namespace SuperMarketAPI.Controllers
{
    public class ProductController : ApiController
    {


        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/allproducts")]
        public HttpResponseMessage GetAllProducts()
        {
            string query = @"Select * From ProductTbl";
            SqlConnect con = new SqlConnect();
            con.retrieveData(query);
            return Request.CreateResponse(HttpStatusCode.OK, con.table);
        }


        //[System.Web.Http.HttpGet]
        //[System.Web.Http.Route("api/products/{id}")]
        //public HttpResponseMessage GetValueById(int Id)
        //{

        //    string query = @"Select * From ProductTbl where Prodid=" + Id + "";
        //    Connect con = new Connect();
        //    con.retrieve_data(query);
        //    return Request.CreateResponse(HttpStatusCode.OK, con.table);

        //}

        //[System.Web.Http.HttpGet]
        //[System.Web.Http.Route("api/products/{name}")]
        //public HttpResponseMessage GetValueByName(string ProdName)
        //{

        //    string query = @"Select * From ProductTbl where ProdName=" + ProdName + "";
        //    Connect con = new Connect();
        //    con.retrieve_data(query);
        //    return Request.CreateResponse(HttpStatusCode.OK, con.table);

        //}

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/products")]
        public HttpResponseMessage PostProducts([FromBody] Products products)
        {
            string query = @"Insert Into ProductTbl values(" + products.Prodid + ",'" + products.ProdName + "'," + products.ProdQty + "," + products.ProdPrice + ",'" + products.ProdCat + "')";
            SqlConnect con = new SqlConnect();
            con.commandExc(query);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [System.Web.Http.HttpDelete]
        [System.Web.Http.Route("api/delete/{Prodid}")]
        public HttpResponseMessage DeleteProducts([FromUri] int Prodid)
        {
            string query = @"Delete From ProductTbl where ProdId=" + Prodid;
            SqlConnect con = new SqlConnect();
            con.commandExc(query);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [System.Web.Http.HttpPut]
        [System.Web.Http.Route("api/put/{Prodid}")]
        public HttpResponseMessage PutProducts([FromUri] int Prodid, Products products)
        {
            string query = @"Update ProductTbl set ProdName='" + products.ProdName + "', ProdQty='" + products.ProdQty + "', ProdPrice='" + products.ProdPrice + "', ProdCat='" + products.ProdCat + "' Where Prodid = " + products.Prodid;
            SqlConnect con = new SqlConnect();
            con.commandExc(query);
            return Request.CreateResponse(HttpStatusCode.OK);
        }




    }
}