using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHazard : MonoBehaviour
{
    public int health = -2;

    private void OnTriggerStay2D(Collider2D other) {
        PlayerController player = other.GetComponent<PlayerController>();
        if(player != null){
            player.UpdateHealth(health);
        }
        Debug.Log("ouch you dingus!j");
    }
}
