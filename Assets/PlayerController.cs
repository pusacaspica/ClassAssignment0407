using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    public float velocity = 1f;
    public int health = 5;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 position = transform.position;
        if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0){
            anim.SetBool("input", true);
        } else {
            anim.SetBool("input", false);
        }
        anim.SetFloat("yInput", Input.GetAxis("Vertical"));
        anim.SetFloat("xInput", Input.GetAxis("Horizontal"));
        if(Input.GetAxis("Horizontal") < 0 && Input.GetAxis("Vertical") == 0){
            this.transform.localScale = new Vector3(-5f, 5f, 0f);
        } else {
            this.transform.localScale = new Vector3(5f, 5f, 0f);
        }

        position.x += Input.GetAxis("Horizontal") * velocity * Time.deltaTime;
        position.y += Input.GetAxis("Vertical") * velocity * Time.deltaTime;

        transform.position = position;
    }

    public void UpdateHealth(int increment){
        health += increment;
    }

    public void Flip(){

    }
}
