using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass : MonoBehaviour
{
    // From ApplePicker, destroys the wall the player touches
    void OnCollisionEnter(Collision coll) {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.CompareTag("Player")) {
            Destroy(this.gameObject);
        }
    }
}
