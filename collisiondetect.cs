using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisiondetect : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Player")
        {
            Destroy(c.gameObject);
        }

       /* if(c.gameObject.tag =="Ground")
        {
            Destroy(obj);
        }*/
    }
}
