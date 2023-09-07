using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject PlayerGameObject;

    [SerializeField]
    private Rigidbody PlayerRd;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var VeloCity = PlayerRd.velocity;

        if (Input.GetKey(KeyCode.D))
        {
            VeloCity.x = 10; 
        }
        else if(Input.GetKey(KeyCode.A))
        {
            VeloCity.x = -10;
        }
        else
        {
            VeloCity = Vector3.zero;
        }
        PlayerRd.velocity = VeloCity;

    }
}
