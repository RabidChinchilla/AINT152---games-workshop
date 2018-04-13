﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickUp : MonoBehaviour {

    public GameObject Barrier;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameObject.FindWithTag("Player"))
        {
            gameObject.SetActive(false);
            Destroy(Barrier);
        }
    }
}
