﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wedding.Models;
using System.Data.Entity;
using Newtonsoft.Json;//json解析用
using System.IO;
using System.Net;
using System.Text;


namespace Wedding.Controllers
{
    public class CheckOutController : Controller
    {
        FlowersEntity db = new FlowersEntity();
        const String KEY = "f8abfbc6cf7244d195a3e8891bb04837";
        // GET: CheckOut
        public ActionResult Servicer1(string input1)
        {
            string input = input1;
            string url = "http://www.tuling123.com/openapi/api?key=" + KEY + "&info=" + input;
            Encoding encoding = Encoding.GetEncoding("utf-8");
            String data = HttpGet(url, encoding);
            JsonReader reader = new JsonTextReader(new StringReader(data));
            while (reader.Read()){               
                if (reader.TokenType == JsonToken.PropertyName
                    && reader.ValueType == Type.GetType("System.String")
                    && Convert.ToString(reader.Value) == "code"){
                    reader.Read();
                    switch (Convert.ToInt32(reader.Value)){
                        case 100000:reader.Read(); reader.Read();input = (string)reader.Value;break;default:break;
                    }}}
            return Content(input);}
        public static string HttpGet(string url, Encoding encoding)
        {
            string data = "";
            try
            {
                WebRequest request; //使用url发出请求的类               
                request = WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;   //使用默认的身份验证                
                request.Timeout = 10000;    //设定超时               
                WebResponse response;   //提供响应的类                
                response = request.GetResponse();
                data = new StreamReader(response.GetResponseStream(), encoding).ReadToEnd();    //获取数据           
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return data;
        }
    }
}