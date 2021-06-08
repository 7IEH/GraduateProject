﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterLock : MonoBehaviour
{
    public GameManager manager;

    void OnTriggerEnter(Collider other)
    {
        int gate = 1;
        if (other.gameObject.tag == "Player")
            manager.StageStart(gate);
    }
}
