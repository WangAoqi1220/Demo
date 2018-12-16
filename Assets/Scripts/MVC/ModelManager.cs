using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelManager {
    private Dictionary<string, UIModel> models;

    public void Init()
    {
        models["BagModel"] = new UIModel();
    }

    public T GetT<T>(string name)where T:UIModel
    {
        return (T)models[name];
    }

    private static ModelManager _instance;
    public static ModelManager Instance { get { return _instance; } }

    public UIView UIView;
    public UICtrl UICtrl;

    private bool isShow = false;
}
