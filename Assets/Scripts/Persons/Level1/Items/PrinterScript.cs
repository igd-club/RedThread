﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterScript : ItemScript
{
    private Level1Controller levelController;
    public GameObject soundEmitter;

    new void Start()
    {
        base.Start();
        levelController = FindObjectOfType<Level1Controller>();
    }
    public override void Act()
    {
        Debug.Log("PrinterScript");
        soundEmitter.SetActive(!soundEmitter.activeSelf);
        levelController.PaperInPrinter = false;
    }
}