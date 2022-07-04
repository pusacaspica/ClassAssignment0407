using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    public float velocity = 5f;
    Rigidbody2D rigidbody;
    public float timer = 1;
    private int dir = 1;
    private float ogTimer;

    // Start is called before the first frame update
    void Start()
    {
        ogTimer = timer;
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = rigidbody.position;
        pos.x += dir * velocity * Time.deltaTime;
        rigidbody.MovePosition(pos);

        timer -= Time.deltaTime;
        if(timer < 0){
            dir *= -1;
            timer = ogTimer;
        }
        if(dir > 0){
            this.transform.localScale = new Vector3(5f, 5f, 0f);
        } else {
            this.transform.localScale = new Vector3(-5f, 5f, 0f);
        }
    }

    public void OnCollisionEnter2D(Collision2D other){
        Debug.Log("b'gawk!");
        PlayerController player = other.gameObject.GetComponent<PlayerController>();
        if(player != null){
            player.UpdateHealth(-1);
        }
    }
}
