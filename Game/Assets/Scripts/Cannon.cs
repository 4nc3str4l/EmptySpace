using System;
using UnityEngine;

public class Cannon : MonoBehaviour {

    public GameObject projectile;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    internal void Shoot()
    {
        GameObject.Instantiate(projectile, transform.position, transform.rotation);
    }
}
