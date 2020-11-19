using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public BoxCollider2D box2D;

    public float speed;
    private float input;

    public GameObject textObj;
    public float textDelay = 500;
    private float timer;

    [SerializeField] textScript textScript;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        box2D.GetComponent<BoxCollider2D>();
        timer = textDelay;
    }

    void FixedUpdate()
    {
        input = Input.GetAxis("Horizontal");
        rb2D.velocity = new Vector2(input * speed, rb2D.velocity.y);

    }
    private void Update()
    {
        if(textA.isTyping == false)
        {
            timer -= Time.deltaTime;
            if(timer < 0)
            {
                timer = textDelay;
                textScript.value = 0;
            }
        }
    }
}
