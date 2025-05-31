using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public GameObject explosionPrefab;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            if (explosionPrefab)
            {
                // Instantiate an explosion effect at the gameObjects position and rotation
                Instantiate(explosionPrefab, transform.position, transform.rotation);
            }

            // destroy the projectile
            Destroy(collision.gameObject);

            // destroy self
            Destroy(gameObject);
        }
    }
}
