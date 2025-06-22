using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class Single : MonoBehaviour
{
    public Text Tex2t;
    public void Cube()
    {
        StartCoroutine(TextShow("是你爹"));
    }

     IEnumerator TextShow(string v)
    {
     StringBuilder stringBuilder= new StringBuilder();
        for (int i = 0; i < v.Length; i++)
        {
            stringBuilder.Append(v);
            Tex2t.text = stringBuilder.ToString();
        }
        yield return new WaitForSeconds(0.2f);
    }
    public void Cube2()
    {
        StartCoroutine(TextShow2("是你妈"));
    }

    IEnumerator TextShow2(string v)
    {
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < v.Length; i++)
        {
            stringBuilder.Append(v);
            Tex2t.text = stringBuilder.ToString();
        }
        yield return new WaitForSeconds(0.2f);
    }
    public void Cube4()
    {
        StartCoroutine(TextShow4("是你奶"));
    }

    IEnumerator TextShow4(string v)
    {
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < v.Length; i++)
        {
            stringBuilder.Append(v);
            Tex2t.text = stringBuilder.ToString();
        }
        yield return new WaitForSeconds(0.2f);
    }
    public void Cube5()
    {
        StartCoroutine(TextShow5("是你奶"));
    }

    IEnumerator TextShow5(string v)
    {
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < v.Length; i++)
        {
            stringBuilder.Append(v);
            Tex2t.text = stringBuilder.ToString();
        }
        yield return new WaitForSeconds(0.2f);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
