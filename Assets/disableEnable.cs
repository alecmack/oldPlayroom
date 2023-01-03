using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class disableEnable : NetworkBehaviour
{
    public GameObject objectBeingActivated;
    private int soClose = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsHost && soClose == 0)
        {
            Debug.Log("setting camera 1 to false");

            objectBeingActivated.SetActive(false);
            soClose++;
        }

    }

    //public virtual void OnStartServer()
    //{
        
    //}

    //public virtual void OnNetworkSpawn()
    //{

    //}
}
