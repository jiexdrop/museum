using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public Transform destination;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = destination.position;
        this.transform.parent = destination;
    }

    private void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<BoxCollider>().enabled = true;
        GetComponent<Rigidbody>().useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
