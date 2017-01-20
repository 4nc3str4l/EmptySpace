using UnityEngine;

public class KeyboardInput : MonoBehaviour {

    private SpaceCraft spaceCraft;

	// Use this for initialization
	void Start () {
        spaceCraft = GetComponent<SpaceCraft>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            spaceCraft.Accelerate();
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1"))
            spaceCraft.Shoot();

        LookAtMouse();
    }

    void LookAtMouse()
    {
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
