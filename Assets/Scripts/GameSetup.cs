﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameSetup : MonoBehaviour
{
    public static GameSetup gs;

    public Transform[] spawnPoints;


    void Start()
    {
        CreatePlayer();
    }

    private void CreatePlayer()
    {
        Debug.Log("Creating Player");
        PhotonNetwork.Instantiate("PhotonNetworkPlayer", Vector2.zero, Quaternion.identity);
        //PhotonNetwork.Instantiate("player", new Vector3(0, -1.23f, 1.12f), Quaternion.identity);
        //PhotonNetwork.Instantiate("Maze", new Vector3(0, -1.23f, 1.12f), Quaternion.identity);
    }


    private void OnEnable()
    {
        if (GameSetup.gs == null)
        {
            GameSetup.gs = this;
        }
    }

}
