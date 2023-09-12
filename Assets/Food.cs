using UnityEngine;
using TMPro;

public class Food : MonoBehaviour
{
    public BoxCollider2D gridArea;

    public float score;
    public TextMeshProUGUI scoreText;

    public AudioSource audioPlayer;

    private void Start()
    {
        RandomizePosition();
    }

    private void Update(){
        scoreText.text = "" + score;
    }

    //Randomize the food location on startup or when touched by the player
    private void RandomizePosition()
    {
        Bounds bounds = this.gridArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    //If the player(the snake) touches the food, the food will randomize position and reappears. Add 1 to score.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player"){
            RandomizePosition();
            score += 1;
            audioPlayer.Play();
        }
    }
}
