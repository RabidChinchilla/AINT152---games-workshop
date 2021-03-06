﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    public class WeaponsManager : MonoBehaviour
    {
        public string targetTag = "Player";
        public GameObject newPlayer;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == targetTag)
            {
                //when player collides with object create the new game object
                Instantiate(newPlayer, transform.position, transform.rotation);

                if (GetComponent<AudioSource>() != null)
                {
                    GetComponent<AudioSource>().Play();
                }
            }
        }
    }
}
