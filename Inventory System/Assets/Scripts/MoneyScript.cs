using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyScript : MonoBehaviour
{
    public int Money = 100;

    public TextMeshProUGUI MoneyText;

    

    // Update is called once per frame
    private void Start()
    {
        MoneyManagerUpdate();
    }

  

    public void MoneyManagerUpdate()
    {
        MoneyText.text = Money + "$";
    }
}
