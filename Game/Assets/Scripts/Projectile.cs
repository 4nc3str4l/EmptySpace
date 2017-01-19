using UnityEngine;

public class Projectile : MonoBehaviour {

    public const float TIME_TO_DESTROY = 5f;
    public float speed = 10;
    public float damage = 5;

    void Awake()
    {
        Destroy(gameObject, TIME_TO_DESTROY);
    }

	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * Time.deltaTime * speed);		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        SpaceCraft spaceCraft = coll.gameObject.GetComponent<SpaceCraft>();
        if (spaceCraft != null)
        {
            spaceCraft.TakeDamage(damage);
            Destroy(gameObject);
        }

    }
}
