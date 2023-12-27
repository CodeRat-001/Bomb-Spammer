using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class bomb : MonoBehaviour
{
   public GameObject[] bom;
    int random=0;
    int random1 = 0;
  // public  Collider boom;
   public float wait = 0.0f;
    void Start()
    {
        StartCoroutine(spawn());
      // boom = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("Collision Detected with Player");
            Destroy(collision.gameObject);
        }
    }


    IEnumerator spawn()
    {
        random = Random.Range(0, bom.Length);
        random1 = Random.Range(0, 180);

        while(true)
        {
            yield return new WaitForSeconds(wait);
            Instantiate(bom[random], transform.position, Quaternion.Euler(0, 0, random1));
        }
        
    }


}
