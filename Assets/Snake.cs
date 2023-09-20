using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Snake : MonoBehaviour
{
    private Vector2 _direction = Vector2.right;
    private List<Transform> _segments = new List<Transform>();

    public Transform segmentPrefab;
    public int initialSize = 4;

    public float score = 0;
    public TextMeshProUGUI scoreText;
    
    private bool canMoveLeft = false;
    private bool canMoveUp = true;

    public AudioSource audioPlayer;

    private void Start()
    {
        ResetState();
    }

    //movement keys
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && canMoveUp == true){
            _direction = Vector2.up;
            gameObject.transform.localRotation = new Quaternion (0, 0, 0, 0);
            gameObject.transform.localScale = new Vector3 (1, 1 ,1);
            canMoveUp = false;
            canMoveLeft = true;
        }else if(Input.GetKeyDown(KeyCode.S) && canMoveUp == true){
            _direction = Vector2.down;
            gameObject.transform.localRotation = new Quaternion (0, 0, 180, 0);    
            gameObject.transform.localScale = new Vector3 (1, 1 ,1);
            canMoveUp = false;
            canMoveLeft = true;
        }else if(Input.GetKeyDown(KeyCode.A) && canMoveLeft == true){
            _direction = Vector2.left;
            gameObject.transform.localRotation = new Quaternion (0, 0, 90, 90);
            gameObject.transform.localScale = new Vector3 (1, 1 ,1);
            canMoveUp = true;
            canMoveLeft = false;
        }else if(Input.GetKeyDown(KeyCode.D) && canMoveLeft == true){
            _direction = Vector2.right;
            gameObject.transform.localRotation = new Quaternion (0, 0, 90, 90);
            gameObject.transform.localScale = new Vector3 (1, -1 ,1);
            canMoveUp = true;
            canMoveLeft = false;
        }
    }

    //transform the snake when eating the food object
    private void FixedUpdate()
    {
         
        for(int i = _segments.Count - 1; i > 0; i--){
            _segments[i].position = _segments[i - 1].position;
        }
        
        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x) + _direction.x,
            Mathf.Round(this.transform.position.y) + _direction.y,
            0.0f
        );
        
    }

    private void Grow()
    {
        Transform segment = Instantiate(this.segmentPrefab);
        segment.position = _segments[_segments.Count - 1].position;

        _segments.Add(segment);

    }

    //reset the position of the snake if run into wall or itself(prefab for the other segments)
    private void ResetState(){
        for(int i = 1; i < _segments.Count; i++){
            Destroy(_segments[i].gameObject);
        }

        _segments.Clear();
        _segments.Add(this.transform);

        for(int i = 1; i < this.initialSize; i++){
            _segments.Add(Instantiate(this.segmentPrefab));
        }

        this.transform.position = Vector3.zero;
        _direction = Vector2.right;
        gameObject.transform.localRotation = new Quaternion (0, 0, 90, 90);
        gameObject.transform.localScale = new Vector3 (1, -1 ,1);
    }
    //if statments for collision of food object or obstacles being walls or segments
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Food"){
            score += 1;
            Grow();
        }else if(other.tag == "Obstacle"){
            scoreText.text = "";
            audioPlayer.Play();
            ResetState();
        }
    }

}
