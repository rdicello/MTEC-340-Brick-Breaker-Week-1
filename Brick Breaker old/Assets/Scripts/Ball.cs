
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed = 5f;

    public Vector2 direction;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    void Start()
    {

        direction = new Vector2(
            Random.Range(-1.0f, 1.0f),
            Random.Range(-1.0f, 1.0f)
        ).normalized;

    }

    void Update() 
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }


}
