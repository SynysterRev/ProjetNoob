﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SpawnInteractionManager : NetworkBehaviour
{
    [SerializeField] GameObject prefab;



    [Command]
    void CmdSpawn(GameObject _gameObject)
    {
        NetworkServer.Spawn(_gameObject);
    }

    // Use this for initialization
    void Start()
    {
        if (isServer && InteractionManager.GetInteractionManager == null)
        {
            //NetworkServer.Spawn(Instantiate(prefab));
            CmdSpawn(Instantiate(prefab));
        }
        Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
