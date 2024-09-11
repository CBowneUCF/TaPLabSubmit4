using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Camera cam;
    static Plane XZPlane = new Plane(Vector3.up, Vector3.zero);

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    public float speed;

    // Update is called once per frame
    void Update()
    {
		//transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
		transform.position = Camera.main.ScreenToWorldPoint(new(Input.mousePosition.x, Input.mousePosition.y, 10));

		/*
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if(XZPlane.Raycast(ray, out float distance))
        {
            Vector3 hitPoint = ray.GetPoint(distance);
            transform.position = hitPoint;
        }
         */

	}
}
