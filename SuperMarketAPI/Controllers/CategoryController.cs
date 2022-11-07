using SupermarketTuto.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SuperMarketAPI.Controllers
{
    public class CategoryController : ApiController
    {


        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/categories")]
        public HttpResponseMessage GetAllProducts()
        {
            string query = @"Select * From CategoryTbl";
            SqlConnect con = new SqlConnect();
            con.retrieveData(query);
            return Request.CreateResponse(HttpStatusCode.OK, con.table);
        }


        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/categories/{id}")]
        public HttpResponseMessage GetValueById(int Id)
        {
            string query = @"Select * From CategoriesTbl where Catid=" + Id + "";
            SqlConnect con = new SqlConnect();
            con.retrieveData(query);
            return Request.CreateResponse(HttpStatusCode.OK, con.table);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/categories/{name}")]
        public HttpResponseMessage GetValueByName(string CatName)
        {
            string query = @"Select * From CategoriesTbl where CatName=" + CatName + "";
            SqlConnect con = new SqlConnect();
            con.retrieveData(query);
            return Request.CreateResponse(HttpStatusCode.OK, con.table);
        }

    }
}