using UnityEngine;

public class PlayerCollission : MonoBehaviour
{
    public PlayerScript movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Hit with " + collisionInfo.collider.name);
            GetComponent<PlayerScript>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
        
    }

}
