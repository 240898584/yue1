using UnityEditor;
using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class InscriptionConfigGenerator : EditorWindow
{
    [MenuItem("Editor/Generate Inscription Class")]
    static void GenerateClass()
    {
        // 读取CSV文件路径
        string csvPath = Application.dataPath + "/Resources/inscription_config.csv";
        if (!File.Exists(csvPath))
        {
            Debug.LogError("未找到铭文配置文件！");
            return;
        }
        // 读取CSV文件内容
        string[] lines = File.ReadAllLines(csvPath);
        if (lines.Length < 2)
        {
            Debug.LogError("CSV文件内容不足！");
            return;
        }
        // 解析表头
        string[] headers = lines[0].Split(',');
        // 生成类代码
        string className = "InscriptionConfig";
        string classCode = "public class " + className + "\n{\n";
        foreach (string header in headers)
        {
            string propertyName = char.ToUpper(header[0]) + header.Substring(1).Replace(" ", "");
            classCode += "    public string " + propertyName + " { get; set; }\n";
        }
        classCode += "}\n";
        // 生成列表类代码
        string listClassName = className + "List";
        string listClassCode = "public class " + listClassName + "\n{\n    public List<" + className + "> " + className + "s { get; set; }\n}\n";
        // 保存类代码到文件
        string classFilePath = Application.dataPath + "/Scripts/" + className + ".cs";
        File.WriteAllText(classFilePath, classCode);
        string listClassFilePath = Application.dataPath + "/Scripts/" + listClassName + ".cs";
        File.WriteAllText(listClassFilePath, listClassCode);
        AssetDatabase.Refresh();
        Debug.Log("类生成成功！");
    }
}