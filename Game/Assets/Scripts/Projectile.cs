using UnityEngine;

public class Projectile : MonoBehaviour {

    public const float TIME_TO_DESTROY = 5f;
    public float speed = 10;
    public float damage = 5;
    private SpaceCraft owner;

    void Awake()
    {
        Destroy(gameObject, TIME_TO_DESTROY);
    }

    public void Init(SpaceCraft _owner)
    {
        owner = _owner;
    }

	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * Time.deltaTime * speed);		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        SpaceCraft spaceCraft = coll.gameObject.GetComponent<SpaceCraft>();
        if (spaceCraft != null && spaceCraft != owner)
        {
            spaceCraft.TakeDamage(damage);
            spaceCraft.GetComponent<Rigidbody2D>().AddForce(transform.up * 100f);
            Destroy(gameObject);
        }

    }
}
