using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearingItems : MonoBehaviour
{

    private GameObject Item4, Item5, Item6, Item7, Item8, Item9;
    public GameObject Button4, Button5, Button6, Button7, Button8, Button9;
    // Start is called before the first frame update
    void Start()
    {
        Item4 = GameObject.FindGameObjectWithTag("Item4");
        Item5 = GameObject.FindGameObjectWithTag("Item5");
        Item6 = GameObject.FindGameObjectWithTag("Item6");
        Item7 = GameObject.FindGameObjectWithTag("Item7");
        Item8 = GameObject.FindGameObjectWithTag("Item8");
        Item9 = GameObject.FindGameObjectWithTag("Item9");

        Item4.SetActive(false);
        Item5.SetActive(false);
        Item6.SetActive(false);
        Item7.SetActive(false);
        Item8.SetActive(false);
        Item9.SetActive(false);

        Button4.SetActive(false);
        Button5.SetActive(false);
        Button6.SetActive(false);
        Button7.SetActive(false);
        Button8.SetActive(false);
        Button9.SetActive(false);

        StartCoroutine(AppearingItemss());
    }

    // Update is called once per frame
    IEnumerator AppearingItemss()
    {
        yield return new WaitForSeconds(Random.Range(0,30));
        Item4.SetActive(true);
        Button4.SetActive(true);

        yield return new WaitForSeconds(Random.Range(0, 30));
        Item5.SetActive(true);
        Button5.SetActive(true);

        yield return new WaitForSeconds(Random.Range(0, 30));
        Item6.SetActive(true);
        Button6.SetActive(true);

        yield return new WaitForSeconds(Random.Range(0, 30));
        Item7.SetActive(true);
        Button7.SetActive(true);

        yield return new WaitForSeconds(Random.Range(0, 30));
        Item8.SetActive(true);
        Button8.SetActive(true);

        yield return new WaitForSeconds(Random.Range(0, 30));
        Item9.SetActive(true);
        Button9.SetActive(true);
    }
}
