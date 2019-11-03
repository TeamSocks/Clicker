using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellCookie : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton(){
        OutCat.Count -=1;
        OutCash.CashCount += 1;
    }
}
