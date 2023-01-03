using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

// This is the client for testing purposes

public class CameraController : NetworkBehaviour
{
  //  public GameObject cameraHolder;

    [SerializeField] public GameObject iteractWith;



    SpriteRenderer button1Renderer;
    SpriteRenderer otherButton;


    public void Update()
    {
     

           
    }

    public void Start()
    { 

        button1Renderer = GetComponent<SpriteRenderer>();
        button1Renderer.color = Color.green;

    }
    private void OnMouseDown()
    {
        Debug.Log("Button 1 clicked!");

        otherButton = iteractWith.GetComponent<SpriteRenderer>();
        otherButton.color = Color.green;

        button1Renderer.color = Color.red;

        changeOtherColorServerRpc();


    }

    [ServerRpc(RequireOwnership = false)]
    private void changeOtherColorServerRpc()
    {
        Debug.Log("Are we reaching server from client?????");

        otherButton = iteractWith.GetComponent<SpriteRenderer>();
        otherButton.color = Color.green;

        button1Renderer.color = Color.red;

    }


}
