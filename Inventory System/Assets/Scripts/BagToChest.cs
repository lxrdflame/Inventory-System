using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class BagToChest : MonoBehaviour
{
    public Transform[] AvailableChestSlots;
    public Transform[] BaughtChestSlots;

    public float snapDistance = 1f;
    public bool isDragging = false;

    private Vector3 offset;

    public ButtonManager ButtonManagerScript;

    public GameObject BaughtSlots;
    public GameObject UpgradeButton;

    public BackPack SpacesScript;
    public GameObject SpaceCover;

    public MoneyScript moneyScript;
    private int UpgradePrice = 30;




    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            child.gameObject.AddComponent<BagToChest>();
        }

       
    }

    public void BuySlots()
    {
        Debug.Log(BaughtSlots.transform.position);

        BaughtSlots.transform.position = new Vector3(3.68f, 1.21f, 89.99f);
        SpaceCover.SetActive(false);
        moneyScript.Money -= UpgradePrice;
        moneyScript.MoneyManagerUpdate();


        UpgradeButton.SetActive(false);

    }
    void Update()
    {
        if (isDragging)
        {
            Vector3 mousePosition = GetMouseWorldPosition() + offset;
            transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
        }

        



    }
    void OnMouseDown()
    {
        isDragging = true;
        offset = gameObject.transform.position - GetMouseWorldPosition();
    }

    void OnMouseUp()
    {
        isDragging = false;
         
        foreach (Transform spots in transform.parent.GetComponent<BagToChest>().AvailableChestSlots)
        {
            
            // Check if the object is close enough to the target spot to snap it into place
            float distance = Vector3.Distance(transform.position, spots.position);
            if (distance <= snapDistance)
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(spots.position, snapDistance);

                foreach (Collider2D collider in colliders)
                {
                    if(collider.gameObject != gameObject)
                    {

                        // transform.position = OriginalPosition;
                        return;
                    }
                }
                transform.position = spots.position;
                break;
            }
            else
            {
               // transform.position = OriginalPosition;
            }
        }

        foreach (Transform spots in transform.parent.GetComponent<BagToChest>().BaughtChestSlots)
        {

            // Check if the object is close enough to the target spot to snap it into place
            float distance = Vector3.Distance(transform.position, spots.position);
            if (distance <= snapDistance)
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(spots.position, snapDistance);

                foreach (Collider2D collider in colliders)
                {
                    if (collider.gameObject != gameObject)
                    {

                        // transform.position = OriginalPosition;
                        return;
                    }
                }
                transform.position = spots.position;
                break;
            }
            else
            {
                // transform.position = OriginalPosition;
            }
        }






        foreach (Transform spots in transform.parent.GetComponent<BagToChest>().SpacesScript.BigSpaces)
        {

            // Check if the object is close enough to the target spot to snap it into place
            float distance = Vector3.Distance(transform.position, spots.position);
            if (distance <= snapDistance)
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(spots.position, snapDistance);

                foreach (Collider2D collider in colliders)
                {
                    if (collider.gameObject != gameObject)
                    {

                        // transform.position = OriginalPosition;
                        return;
                    }
                }
                transform.position = spots.position;
                break;
            }
            else
            {
                // transform.position = OriginalPosition;
            }
        }

        
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(mousePosition);
    }


}
        
