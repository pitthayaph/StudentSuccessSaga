using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UpgradeItem : MonoBehaviour
{
    public GameObject obj1;
    void Start()
    {
        obj1.gameObject.SetActive(false);
    }

   
}
