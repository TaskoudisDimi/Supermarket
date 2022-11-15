using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using API.Models;

namespace API.Controllers
{
    public class ProductController : ApiController
    {
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/allproducts")]
        public HttpResponseMessage GetAllProducts()
        {
            string query = @"Select * From ProductTbl";
            Connect con = new Connect();
            con.retrieve_data(query);
            return Request.CreateResponse(HttpStatusCode.OK, con.table);
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/products")]
        public HttpResponseMessage PostProducts([FromBody] Product products)
        {
            string query = @"Insert Into ProductTbl values('" + products.ProdName + "'," + products.ProdQty + "," + products.ProdPrice + ",'" + products.ProdCat + "','" + products.Date +"')";
            Connect con = new Connect();
            con.commandExc(query);

            return Request.CreateResponse(HttpStatusCode.OK);
        }


    }
}