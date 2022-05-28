using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider target)
    {
        //Destroy(this.gameObject); // <== Remove colliding object
        if(target.tag == "Ground") {
            this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}
