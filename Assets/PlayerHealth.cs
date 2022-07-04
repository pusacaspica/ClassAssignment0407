using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 5;

    private void OnTriggerEnter2D(Collider2D other) {
        PlayerController player = other.GetComponent<PlayerController>();
        if(player != null){
            player.UpdateHealth(health);
            Destroy(this.gameObject);
        }
        Debug.Log("got a pickup!");
    }
}
