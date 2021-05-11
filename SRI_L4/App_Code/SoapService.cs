using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Opis podsumowujący dla SoapService
/// </summary>
//[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Aby zezwalać na wywoływanie tej usługi sieci Web ze skryptu za pomocą kodu ASP.NET AJAX, usuń znaczniki komentarza z następującego wiersza. 
// [System.Web.Script.Services.ScriptService]
public class SoapService : System.Web.Services.WebService
{

    public SoapService()
    {

        //Usuń znaczniki komentarza z następującego wiersza, jeśli używane są zaprojektowane składniki 
        //InitializeComponent(); 
    }

    [WebMethod]
    public List<Document> GetDocuments()
    {
        return DocumentService.documentList;
    }
    [WebMethod]
    public Document GetDocument(int id)
    {

        return DocumentService.documentList.FirstOrDefault(x => x.Id == id);
    }
    [WebMethod]
    public bool AddDocument(Document document)
    {
        try
        {
            DocumentService.documentList.Add(document);
        }
    catch(Exception e)
        {
            return false;
        }
        return true;
    }

}
