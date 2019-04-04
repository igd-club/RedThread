﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarnizScript : ItemScript
{
    private Level1Controller levelController;
    public GameObject shelves;

    new void Start()
    {
        base.Start();
        levelController = FindObjectOfType<Level1Controller>();
    }

    public override void Act()
    {
        Debug.Log("KarnizScript");
        FMODUnity.RuntimeManager.PlayOneShot("event:/GlassBreak", GetComponent<Transform>().position);
        if (levelController.MusorInInvertory)
        {
            levelController.MusorOnBossKarniz = true;
            levelController.MusorInInvertory = false;
            shelves.SetActive(true);
            levelController.PigeonsInBossRoom = true;
            //levelController.generatePigeonsInBossRoom();
        }
    }
}
