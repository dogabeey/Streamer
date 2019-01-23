using System.Collections;
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
        string[] directories = Directory.GetDirectories("Assets\\XML", typeof(T).ToString());
        if (directories.Length > 0)
        {
            string directory = directories[0];
            string[] files = Directory.GetFiles(directory, "*.xml");
            foreach (string file in files)
            {
                string fileContent = File.ReadAllText(file);
                T content = Deserialize<T>(fileContent);
                Debug.Log(content);
                retVal.Add(content);
            }
            return retVal;
        }
        else return new List<T>();
    }

    public static void ExportAll<T>(List<T> list)
    {
        foreach (T item in list)
        {
            if (Directory.GetDirectories("Assets/XML", typeof(T).ToString()).Length == 0)
            {
                Directory.CreateDirectory("Assets\\XML\\" + typeof(T).ToString());
            }
            string directory = Directory.GetDirectories("Assets/XML", typeof(T).ToString())[0];
            Debug.Log(directory);
            string xmlText = Serialize(item);
            Debug.Log(xmlText);
            File.Create(directory + "/" + typeof(T).ToString() + "_" + list.FindIndex(t => t.GetHashCode() == item.GetHashCode()) + ".xml").Dispose();
            File.WriteAllText(directory + "/" + typeof(T).ToString() + "_" + list.FindIndex(t => t.GetHashCode() == item.GetHashCode()) + ".xml", xmlText);
        }
    }
}
