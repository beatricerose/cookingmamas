using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
	{
        
        if (!other.CompareTag("Bowl"))
        {
           Destroy(other.gameObject);
        }
	}
}
