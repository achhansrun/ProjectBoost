using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("This is friendly");
                break;
            case "fuel":
                Debug.Log("You picked up fuel");
            break;
            case "Finish":
                Debug.Log("You're done");
                break;
            default:
                Debug.Log("Kaboom!");
            break;
        }
    }
}
