using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;

public static class XmlParse
{
    public static string Serialize<T>(T dataToSerialize)
    {
        try
        {
            var stringwriter = new System.IO.StringWriter();
            var serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(stringwriter, dataToSerialize);
            return stringwriter.ToString();
        }
        catch
        {   
            throw;
        }
    }

    public static T Deserialize<T>(string xmlText)
    {
        try
        {
            var stringReader = new System.IO.StringReader(xmlText);
            var serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(stringReader);
        }
        catch
        {
            throw;
        }
    }

}
