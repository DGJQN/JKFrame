using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using JKFrame;

public class Test : SerializedMonoBehaviour
{

    public Dictionary<string, string> dicTest = new Dictionary<string, string>();

    public List<GameObject> listGameObjects = new List<GameObject>();

    public GameObject Bullet;
    private void Start()
    {
        dicTest = new Dictionary<string, string>();
        dicTest.Add("Test", "AAAA");
        PoolSystem.InitGameObjectPool(Bullet, 50, 50);
    }


    public void JKFTest()
    {
        

    }
}
