using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour
{
    [SerializeField]
    private GameObject Gravity; 


    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("string"))
        {
            Drawin();
        }
    }

    private void Drawin()
    {
        //if ()
        //{

        //}
    }
}
