using System;
using UnityEngine;

public class Cannon : MonoBehaviour {

    public GameObject projectile;
    public SpaceCraft owner;

	// Use this for initialization
	void Start () {
        owner = GetComponentInParent<SpaceCraft>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    internal void Shoot()
    {
        GameObject laser = GameObject.Instantiate(projectile, transform.position, transform.rotation);
        laser.GetComponent<Projectile>().Init(owner);

    }
}
