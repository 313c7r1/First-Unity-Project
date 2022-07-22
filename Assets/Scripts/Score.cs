using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreBoard;

    // Update is called once per frame
    void Update()
    {
        scoreBoard.text = player.position.x.ToString("0");
        //Debug.Log(player.position.x);
    }
}
