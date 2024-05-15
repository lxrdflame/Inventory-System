using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Parenting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ParentingObjects(transform);
    }

    // Update is called once per frame
    void ParentingObjects(Transform transform)
    {
        foreach (Transform child in transform)
        {
            ParentingObjects(child);
        }
    }
}
