﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "Player")
        {
            other.gameObject.GetComponent<PlayerController>().Heal();
            Destroy(gameObject);
        }
    }

   
}
