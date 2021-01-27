using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Discardedfile: MonoBehaviour
{
    public GameObject Maincamera;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("MainCamera"); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.transform.position.z > gameObject.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}
