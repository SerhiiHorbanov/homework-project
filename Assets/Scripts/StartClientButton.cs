using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class StartClientButton : MonoBehaviour
{
    public void StartClient()
    {
        NetworkManager.Singleton.StartClient();
        Debug.Log("starting client");
    }
}
