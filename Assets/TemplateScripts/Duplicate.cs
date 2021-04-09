using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicate : MonoBehaviour
{
    public GameObject objectOriginal;
    public GameObject objectContainer;

    void Start()
    {
        DuplicateObject(1);
    }

    public void DuplicateObject(int objectNum)
    {
        for (int i = 0; i < objectNum; i++)
        {
            GameObject objectClone = Instantiate(objectOriginal, new Vector3(i * 0.6f, objectOriginal.transform.position.y, i * 0.75f), objectOriginal.transform.rotation);
            objectClone.transform.parent = objectContainer.transform;
            objectClone.name = "objectClone" + (i + 1);
        }
    }

}


