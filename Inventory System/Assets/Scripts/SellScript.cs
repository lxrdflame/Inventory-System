using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SellScript : MonoBehaviour
{

    public Transform SellSlot;

    public MoneyScript moneyScripts;

    public ButtonManager buttonManagerscript;

    public int Offset = 3;
    public LayerMask LayerMasks;

    // Start is called before the first frame update
 

    // Update is called once per frame
    public void Sell()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, Offset, LayerMasks);

        if (hit.collider != null )
        {
            GameObject Sold = hit.collider.gameObject;
            Destroy( Sold );

            if (Sold.name == "Item 1(Clone)")
            {
                moneyScripts.Money += buttonManagerscript.Item1price;
                moneyScripts.MoneyManagerUpdate();
            }

            if (Sold.name == "Item 2(Clone)")
            {
                moneyScripts.Money += buttonManagerscript.Item2price;
                moneyScripts.MoneyManagerUpdate();
            }

            if (Sold.name == "Item 3(Clone)")
            {
                moneyScripts.Money += buttonManagerscript.Item3price;
                moneyScripts.MoneyManagerUpdate();
            }

            if (Sold.name == "Item 4(Clone)")
            {
                moneyScripts.Money += buttonManagerscript.Item4price;
                moneyScripts.MoneyManagerUpdate();
            }

            if (Sold.name == "Item 5(Clone)")
            {
                moneyScripts.Money += buttonManagerscript.Item5price;
                moneyScripts.MoneyManagerUpdate();
            }

            if (Sold.name == "Item 6(Clone)")
            {
                moneyScripts.Money += buttonManagerscript.Item6price;
                moneyScripts.MoneyManagerUpdate();
            }

            if (Sold.name == "Item 7(Clone)")
            {
                moneyScripts.Money += buttonManagerscript.Item7price;
                moneyScripts.MoneyManagerUpdate();
            }

            if (Sold.name == "Item 8(Clone)")
            {
                moneyScripts.Money += buttonManagerscript.Item8price;
                moneyScripts.MoneyManagerUpdate();
            }

            if (Sold.name == "Item 9(Clone)")
            {
                moneyScripts.Money += buttonManagerscript.Item9price;
                moneyScripts.MoneyManagerUpdate();
            }
        }
        else
        {
            Debug.Log("nothing is here");
        }
        
    }
}
