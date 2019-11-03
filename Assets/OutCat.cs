using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutCat : MonoBehaviour
{
    public static int Count;

    public GameObject CatDisplay;
    public int InternalCat;

    // Update is called once per frame
    void Update()
    {
        InternalCat = Count;
        CatDisplay.GetComponent<Text>().text = "Cat:" + InternalCat;

    }
}
