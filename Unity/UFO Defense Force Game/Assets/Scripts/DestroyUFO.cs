using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyUFO : MonoBehaviour
{
private void OnTriggerEnter(Collider collision)
{
    if (collision.tag == "Bullet")
    {
        Destroy(gameObject);
    }
}


}
