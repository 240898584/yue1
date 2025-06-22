using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginView : ViewBase
{
    Button Button2;
    public override void Init(UIWindow uiBase)
    {
        base.Init(uiBase);
        Button2 = uiBase.transform.Find("Button"). GetComponent<Button>();
        Button2.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
      GameScenesManager.Instance.LoadSceneAsync("Game", "PlayerPanel");
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
