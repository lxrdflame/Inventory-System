using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject Chestbutton;
    public GameObject ShopButton;

    public GameObject PanelDrag;

    public Animation test;
    public BackPack SpacesScript;
    public MoneyScript MoneyScript;

    public Animator animator;

    public int Item1price = 2;
    public int Item2price = 9;
    public int Item3price = 6;
    public int Item4price = 10;
    public int Item5price = 6;
    public int Item6price = 8;
    public int Item7price = 7;
    public int Item8price = 6;
    public int Item9price = 7;

    private GameObject Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9;
    private Vector3 size = new Vector3(19f, 19f, 0);

    private int LastPoitnt = -1;
    public Transform StorageSlot;

    public GameObject SellButton;




    



    // Start is called before the first frame update
    void Start()
    {
        ShopButton.SetActive(false);
        PanelDrag = GameObject.FindGameObjectWithTag("PanelDrag");

       foreach (Transform space in SpacesScript.BigSpaces )
        {
            space.SetParent(PanelDrag.transform);
        }

      




        Vector3 position = PanelDrag.transform.position;
        Debug.Log(position);

        Item1 = GameObject.FindGameObjectWithTag("Item1");
        Item2 = GameObject.FindGameObjectWithTag("Item2");
        Item3 = GameObject.FindGameObjectWithTag("Item3");
        Item4 = GameObject.FindGameObjectWithTag("Item4");
        Item5 = GameObject.FindGameObjectWithTag("Item5");
        Item6 = GameObject.FindGameObjectWithTag("Item6");
        Item7 = GameObject.FindGameObjectWithTag("Item7");
        Item8 = GameObject.FindGameObjectWithTag("Item8");
        Item9 = GameObject.FindGameObjectWithTag("Item9");

    }

    // Update is called once per frame
    public void ShopButtonClick()
    {
        foreach (Transform child in PanelDrag.transform)
        {
            //  animator.SetBool("moveleft", false);
            ShopButton.SetActive(false);
        PanelDrag.transform.position = new Vector3(4.89f, -0.31f, 90);
        Chestbutton.SetActive(true);
        Debug.Log(PanelDrag.transform.position);
        Debug.Log("rea");
            SellButton.SetActive(true);



        }
    }

   public void ChestButtonClick()
    {
        
        Chestbutton.SetActive(false);
        ShopButton.SetActive(true);
        Debug.Log("tile");
        PanelDrag.transform.position = new Vector3(-4.25f, -0.31f, 90);
        Debug.Log(PanelDrag.transform.position);
        SellButton.SetActive(false);


        // animator.SetBool("moveleft", true);

    }



    public void Buy1()
    {
        if (MoneyScript.Money >= Item1price)
        {
           

            int startIndex = LastPoitnt + 1;

            if (startIndex >= SpacesScript.BigSpaces.Length) //rechecks all the spaces all over after the last spot
            {
                startIndex = 0;
            }
            for (int i = startIndex; i < SpacesScript.BigSpaces.Length; i++)
            {
                Transform space = SpacesScript.BigSpaces[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject ClonedObject = Instantiate(Item1, space.position, Quaternion.identity, StorageSlot);
                    ClonedObject.transform.localScale = size;
                    ClonedObject.AddComponent<BagToChest>();
                    LastPoitnt = i;
                    MoneyScript.Money -= Item1price;
                    MoneyScript.MoneyManagerUpdate();

                    return;
                }
                
            }

            for (int i = 0; i < startIndex; i++)
            {
                Transform space = SpacesScript.BigSpaces[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject ClonedObject = Instantiate(Item1, space.position, Quaternion.identity, StorageSlot);
                    ClonedObject.transform.localScale = size;
                    ClonedObject.AddComponent<BagToChest>();
                    LastPoitnt = i;
                    return;
                }
            }
        }

    }

    public void Buy2()
    {
        if (MoneyScript.Money >= Item2price)
        {

            int startIndex = LastPoitnt + 1;

            if (startIndex >= SpacesScript.BigSpaces.Length) //rechecks all the spaces all over after the last spot
            {
                startIndex = 0;
            }
            for (int i = startIndex; i < SpacesScript.BigSpaces.Length; i++)
            {
                Transform space = SpacesScript.BigSpaces[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject ClonedObject = Instantiate(Item2, space.position, Quaternion.identity, StorageSlot);
                    ClonedObject.transform.localScale = size;
                    ClonedObject.AddComponent<BagToChest>();
                    LastPoitnt = i;
                    MoneyScript.Money -= Item2price;
                    MoneyScript.MoneyManagerUpdate();
                return;
                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                Transform space = SpacesScript.BigSpaces[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject ClonedObject = Instantiate(Item2, space.position, Quaternion.identity, StorageSlot);
                    ClonedObject.transform.localScale = size;
                    ClonedObject.AddComponent<BagToChest>();
                    LastPoitnt = i;
                    return;
                }
            }
        }


    }

    public void Buy3()
    {
        if (MoneyScript.Money >= Item3price)
        {
            int startIndex = LastPoitnt + 1;

            if (startIndex >= SpacesScript.BigSpaces.Length) //rechecks all the spaces all over after the last spot
            {
                startIndex = 0;
            }
            for (int i = startIndex; i < SpacesScript.BigSpaces.Length; i++)
            {
                Transform space = SpacesScript.BigSpaces[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject ClonedObject = Instantiate(Item3, space.position, Quaternion.identity, StorageSlot);
                    ClonedObject.transform.localScale = size;
                    ClonedObject.AddComponent<BagToChest>();
                    LastPoitnt = i;
                    MoneyScript.Money -= Item3price;
                    MoneyScript.MoneyManagerUpdate();
                return;
                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                Transform space = SpacesScript.BigSpaces[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject ClonedObject = Instantiate(Item3, space.position, Quaternion.identity, StorageSlot);
                    ClonedObject.transform.localScale = size;
                    ClonedObject.AddComponent<BagToChest>();
                    LastPoitnt = i;
                    return;
                }
            }
        }
    }

    public void Buy4()
    {
        if (MoneyScript.Money >= Item4price)
        {
            int startIndex = LastPoitnt + 1;

            if (startIndex >= SpacesScript.BigSpaces.Length) //rechecks all the spaces all over after the last spot
            {
                startIndex = 0;
            }
            for (int i = startIndex; i < SpacesScript.BigSpaces.Length; i++)
            {
                Transform space = SpacesScript.BigSpaces[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject ClonedObject = Instantiate(Item4, space.position, Quaternion.identity, StorageSlot);
                    ClonedObject.transform.localScale = size;
                    ClonedObject.AddComponent<BagToChest>();
                    LastPoitnt = i;
                    MoneyScript.Money -= Item4price;
                    MoneyScript.MoneyManagerUpdate();
                return;
                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                Transform space = SpacesScript.BigSpaces[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject ClonedObject = Instantiate(Item4, space.position, Quaternion.identity, StorageSlot);
                    ClonedObject.transform.localScale = size;
                    ClonedObject.AddComponent<BagToChest>();
                    LastPoitnt = i;
                    return;
                }
            }
        }
    }

    public void Buy5()
    {
        

        if (MoneyScript.Money >= Item5price)
        {
            int startIndex = LastPoitnt + 1;

            if (startIndex >= SpacesScript.BigSpaces.Length) //rechecks all the spaces all over after the last spot
            {
                startIndex = 0;
            }
            for (int i = startIndex; i < SpacesScript.BigSpaces.Length; i++)
            {
                Transform space = SpacesScript.BigSpaces[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject ClonedObject = Instantiate(Item5, space.position, Quaternion.identity, StorageSlot);
                    ClonedObject.transform.localScale = size;
                    ClonedObject.AddComponent<BagToChest>();
                    LastPoitnt = i;
                    MoneyScript.Money -= Item5price;
                    MoneyScript.MoneyManagerUpdate();
                return;
                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                Transform space = SpacesScript.BigSpaces[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject ClonedObject = Instantiate(Item5, space.position, Quaternion.identity, StorageSlot);
                    ClonedObject.transform.localScale = size;
                    ClonedObject.AddComponent<BagToChest>();
                    LastPoitnt = i;
                    return;
                }
            }
        }
        
    }

    public void Buy6()
    {
        if (MoneyScript.Money >= Item6price)
        {
            int startIndex = LastPoitnt + 1;

            if (startIndex >= SpacesScript.BigSpaces.Length) //rechecks all the spaces all over after the last spot
            {
                startIndex = 0;
            }
            for (int i = startIndex; i < SpacesScript.BigSpaces.Length; i++)
            {
                Transform space = SpacesScript.BigSpaces[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject ClonedObject = Instantiate(Item6, space.position, Quaternion.identity, StorageSlot);
                    ClonedObject.transform.localScale = size;
                    ClonedObject.AddComponent<BagToChest>();
                    LastPoitnt = i;
                    MoneyScript.Money -= Item6price;
                    MoneyScript.MoneyManagerUpdate();
                return;
                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                Transform space = SpacesScript.BigSpaces[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject ClonedObject = Instantiate(Item6, space.position, Quaternion.identity, StorageSlot);
                    ClonedObject.transform.localScale = size;
                    ClonedObject.AddComponent<BagToChest>();
                    LastPoitnt = i;
                    return;
                }
            }
        }

    }

    public void Buy7()
    {
        if (MoneyScript.Money >= Item7price)
        {
            int startIndex = LastPoitnt + 1;

            if (startIndex >= SpacesScript.BigSpaces.Length) //rechecks all the spaces all over after the last spot
            {
                startIndex = 0;
            }
            for (int i = startIndex; i < SpacesScript.BigSpaces.Length; i++)
            {
                Transform space = SpacesScript.BigSpaces[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject ClonedObject = Instantiate(Item7, space.position, Quaternion.identity, StorageSlot);
                    ClonedObject.transform.localScale = size;
                    ClonedObject.AddComponent<BagToChest>();
                    LastPoitnt = i;
                    MoneyScript.Money -= Item7price;
                    MoneyScript.MoneyManagerUpdate();
                return;
                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                Transform space = SpacesScript.BigSpaces[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject ClonedObject = Instantiate(Item7, space.position, Quaternion.identity, StorageSlot);
                    ClonedObject.transform.localScale = size;
                    ClonedObject.AddComponent<BagToChest>();
                    LastPoitnt = i;
                    return;
                }
            }
        }

    }

    public void Buy8()
    {
        if (MoneyScript.Money >= Item8price)
        {
            int startIndex = LastPoitnt + 1;

            if (startIndex >= SpacesScript.BigSpaces.Length) //rechecks all the spaces all over after the last spot
            {
                startIndex = 0;
            }
            for (int i = startIndex; i < SpacesScript.BigSpaces.Length; i++)
            {
                Transform space = SpacesScript.BigSpaces[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject ClonedObject = Instantiate(Item8, space.position, Quaternion.identity, StorageSlot);
                    ClonedObject.transform.localScale = size;
                    ClonedObject.AddComponent<BagToChest>();
                    LastPoitnt = i;
                    MoneyScript.Money -= Item8price;
                    MoneyScript.MoneyManagerUpdate();
                return;
                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                Transform space = SpacesScript.BigSpaces[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject ClonedObject = Instantiate(Item8, space.position, Quaternion.identity, StorageSlot);
                    ClonedObject.transform.localScale = size;
                    ClonedObject.AddComponent<BagToChest>();
                    LastPoitnt = i;
                    return;
                }
            }
        }

    }

    public void Buy9()
    {
        if (MoneyScript.Money >= Item9price)
        {
            int startIndex = LastPoitnt + 1;

            if (startIndex >= SpacesScript.BigSpaces.Length) //rechecks all the spaces all over after the last spot
            {
                startIndex = 0;
            }
            for (int i = startIndex; i < SpacesScript.BigSpaces.Length; i++)
            {
                Transform space = SpacesScript.BigSpaces[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject ClonedObject = Instantiate(Item9, space.position, Quaternion.identity, StorageSlot);
                    ClonedObject.transform.localScale = size;
                    ClonedObject.AddComponent<BagToChest>();
                    LastPoitnt = i;
                    MoneyScript.Money -= Item9price;
                    MoneyScript.MoneyManagerUpdate();
                return;
                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                Transform space = SpacesScript.BigSpaces[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject ClonedObject = Instantiate(Item9, space.position, Quaternion.identity, StorageSlot);
                    ClonedObject.transform.localScale = size;
                    ClonedObject.AddComponent<BagToChest>();
                    LastPoitnt = i;
                    return;
                }
            }
        }

    }
}
