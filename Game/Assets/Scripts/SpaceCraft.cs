using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceCraft : MonoBehaviour {

    public const float MAX_PLAYER_HEALTH = 100f;

    private Rigidbody2D rigidBody;
    private float acceleration = 100f;
    private Cannon cannon;

    public float Health { get { return health; } }
    private float health = 100f;

    public delegate void SpaceCraftEvent(SpaceCraft _spaceCraft);
    public static event SpaceCraftEvent OnDead;
    public static event SpaceCraftEvent OnHurt;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        cannon = GetComponentInChildren<Cannon>();
        rigidBody.drag = 1f;
    }

    public void Accelerate()
    {
        rigidBody.AddForce(transform.right * acceleration * Time.deltaTime, ForceMode2D.Force);
    }

    public void Shoot()
    {
        cannon.Shoot();
    }

    public void TakeDamage(float dmg)
    {
        health -= dmg;
        
        if (OnHurt != null)
            OnHurt(this);

        if (health <= 0)
            Die();
    }

    public void Die()
    {
        if (OnDead != null)
            OnDead(this);
        Destroy(gameObject);
    }
}
