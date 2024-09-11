using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform player;
    public float maxSpeed;
    public float minSpeed;

    private void Update()
    {

        Vector2 direction = player.transform.position - transform.position;

        float targetDistance = Vector2.Distance(player.transform.position, transform.position);
        float f = Mathf.InverseLerp(0.5f, 20f, targetDistance);

        transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);
        transform.position += transform.right * Time.deltaTime * Mathf.Lerp(maxSpeed, minSpeed, f);
    }

}
