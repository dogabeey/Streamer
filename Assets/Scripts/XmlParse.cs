﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;

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

    public static List<T> ImportAll<T>()
    {
        List<T> retVal = new List<T>();

        string directory = Directory.GetDirectories("Assets/XML",typeof(T).ToString())[0];
        Debug.Log(directory);
        string[] files = Directory.GetFiles(directory, "*.xml");
        foreach (string file in files)
        {
            Debug.Log(file);
            string fileContent = File.ReadAllText(file);
            retVal.Add(Deserialize<T>(fileContent));
        }
        return retVal;
    }
}