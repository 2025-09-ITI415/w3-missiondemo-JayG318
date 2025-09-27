using UnityEngine;

public class HazardZone : MonoBehaviour
{
    void OnCollisionEnter(Collision coll) {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.CompareTag("Player")) {
            Destroy(collidedWith);
        }
    }
}
