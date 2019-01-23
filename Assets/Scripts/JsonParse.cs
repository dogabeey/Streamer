using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonParse
{
    // Start is called before the first frame update
    public static void ExportAll<T>(List<T> list)
    {
        foreach (T item in list)
        {
            if (Directory.GetDirectories("Assets/JSON", typeof(T).ToString()).Length == 0)
            {
                Directory.CreateDirectory("Assets\\JSON\\" + typeof(T).ToString());
            }
            string directory = Directory.GetDirectories("Assets/JSON", typeof(T).ToString())[0];
            Debug.Log(directory);
            string json = JsonUtility.ToJson(item);
            Debug.Log(json);
            File.Create(directory + "/" + typeof(T).ToString() + "_" + list.FindIndex(t => t.GetHashCode() == item.GetHashCode()) + ".json").Dispose();
            File.WriteAllText(directory + "/" + typeof(T).ToString() + "_" + list.FindIndex(t => t.GetHashCode() == item.GetHashCode()) + ".json", json);
        }
    }

    // Update is called once per frame
    public static List<T> ImportAll<T>()
    {
        List<T> retVal = new List<T>();
        string[] directories = Directory.GetDirectories("Assets\\JSON", typeof(T).ToString());
        if (directories.Length > 0)
        {
            string directory = directories[0];
            string[] files = Directory.GetFiles(directory, "*.json");
            foreach (string file in files)
            {
                string fileContent = File.ReadAllText(file);
                T content = JsonUtility.FromJson<T>(fileContent);
                Debug.Log(content);
                retVal.Add(content);
            }
            return retVal;
        }
        else return new List<T>();
    }
}
