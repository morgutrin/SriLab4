using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Opis podsumowujący dla DocumentService
/// </summary>
public static class DocumentService
{
    public static List<Document> documentList = new List<Document> { new Document
    { Id=1,Description="Opis dokument 1",Name="Pismo1" },
        new Document{Id=2,Description="Opis dokument 2",Name="Pismo2"}
       
    };
}