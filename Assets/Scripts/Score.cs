using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Need to put PlayerCube object into Transform box in Unity
    // Transform has data of PlayerCube position
    public Transform player;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
