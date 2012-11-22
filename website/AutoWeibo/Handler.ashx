<%@ WebHandler Language="C#" Class="Handler" %>
using System;
using System.Web;
using Newtonsoft.Json;
using Shop.DataAccess;
using System.Collections;
using System.Data;

public class Handler : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";

        weibo.DataAccess.tb_sianweibo sina = new weibo.DataAccess.tb_sianweibo();

        DataTable dt = sina.GetList("1=1").Tables[0];
        ArrayList al = new ArrayList();
        
        foreach (DataRow dr in dt.Rows)
        {
            weibo.DataAccess.mirmsg mm = new weibo.DataAccess.mirmsg();
            mm.CreatedAt = Convert.ToDateTime(dr["CreatedAt"].ToString());
            //mm.CreateOn = Convert.ToDateTime(dr["CreateOn"].ToString());
            mm.ID = Convert.ToDouble(dr["ID"].ToString());
            mm.MiddleSizePictureUrl = dr["MiddleSizePictureUrl"].ToString();
            mm.Note = dr["Note"].ToString();
            mm.OriginalPictureUrl = dr["OriginalPictureUrl"].ToString();
            mm.Source = dr["Source"].ToString();
            mm.Text = dr["Text"].ToString();
            mm.ThumbnailPictureUrl = dr["ThumbnailPictureUrl"].ToString();
           
                
            al.Add(mm);
        }
        

        string output = JavaScriptConvert.SerializeObject(al);


       
        
        context.Response.Write(output);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}