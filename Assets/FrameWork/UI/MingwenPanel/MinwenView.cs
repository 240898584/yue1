
using System;
using UnityEngine;
using UnityEngine.UI;
public class MinwenView : ViewBase
{
    public Transform ItemParent;
    public GameObject Item;
    public Button Button2;
    public override void Init(UIWindow uiBase)
    {
        base.Init(uiBase);
        ItemParent = uiBase.transform.Find("Scroll View/Viewport/Content");
        Item = ResourceMgr.Instance.ResLoadAsset<GameObject>("Item");
        Button2 = uiBase.transform.Find("Button").GetComponent<Button>();
        Button2.onClick.AddListener(() => OnButton2());
        // 读取 CSV 文件
        TextAsset csvFile = Resources.Load<TextAsset>("inscription_config");
        if (csvFile != null)
        {
            string[] lines = csvFile.text.Split(new[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
            // 跳过标题行
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                if (data.Length >= 3)
                {
                    InscriptionConfig config = new InscriptionConfig();
                    config.铭文ID = data[0];
                    config.铭文名称 = data[1];
                    config.铭文等级 = data[2];
                 

                    // 生成 Item 对
                    if (Item != null && ItemParent != null)
                    {
                        GameObject newItem = GameObject.Instantiate(Item, ItemParent);
                        newItem.transform.GetChild(0).GetComponent<Text>().text = config.铭文名称;
                        newItem.transform.GetChild(1).GetComponent<Text>().text = config.铭文等级;
                        // 传递 config 和 newItem 到 OnButton 方法
                        newItem.transform.GetChild(2).GetComponent<Button>().onClick.AddListener(() => OnButton(config, newItem));
                    }
                }
            }
        }
    }
    private void OnButton2()
    {
        ItemParent.gameObject.SetActive(false);
    }

    private void OnButton(InscriptionConfig config, GameObject item)
    {
        config.LevelUP();
        // 刷新 Item 显示的属性值
        item.transform.GetChild(0).GetComponent<Text>().text = config.铭文名称;
        item.transform.GetChild(1).GetComponent<Text>().text = config.铭文等级;
    }
}
