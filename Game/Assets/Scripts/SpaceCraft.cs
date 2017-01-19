using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceCraft : MonoBehaviour {

    private Rigidbody2D rigidBody;
    private float acceleration = 100f;
    private Cannon cannon;
    private float health = 100f;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        cannon = GetComponentInChildren<Cannon>();
        rigidBody.drag = 1f;
    }

    public void Accelerate()
    {
        Debug.Log("Accelerate!");
        rigidBody.AddForce(transform.right * acceleration * Time.deltaTime, ForceMode2D.Force);
    }

    public void Shoot()
    {
        cannon.Shoot();
    }

    public void TakeDamage(float dmg)
    {
        health -= dmg;
        Debug.Log(health);
        if (health <= 0)
            Die();
    }

    public void Die()
    {
        Debug.Log("I'm dead!");
        Destroy(gameObject);
    }
}
