using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableCollider : MonoBehaviour
{
    void onCollisionEnter(Collider other)
	{
        //if (!other.CompareTag("Bowl"))
		//{
			//Destroy(other.gameObject);
		//}
        if (other.CompareTag("Flour"))
        {
            Destroy(other.gameObject);
        }
	}
}
