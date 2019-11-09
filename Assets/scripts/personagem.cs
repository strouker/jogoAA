using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personagem : MonoBehaviour

    
{
    public float velocidade;
    public float forcaPulo;
    private Rigidbody2D rb2d;
    private SpriteRenderer spPersonagem; // pra fazer flip , se só usar transforme.euarleangles a camera gira junto
    private Animator animacao; // ainda nao vou usar

    //public GameObject person;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spPersonagem = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        velocidade = 2.0f;
        forcaPulo = 200.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right")){
            //transform.Translate(Vector2.right * velocidade * Time.deltaTime);
            rb2d.velocity = new Vector2(velocidade , rb2d.velocity.y);
            spPersonagem.flipX = false;
             
           
           
        }
        if (Input.GetKey("left"))
        {
            //transform.Translate(Vector2.left * velocidade * Time.deltaTime);
            rb2d.velocity = new Vector2(-velocidade , rb2d.velocity.y);
            spPersonagem.flipX = true;
            
            
        }
        if (Input.GetKeyDown("up"))
        {
            rb2d.AddForce(transform.up * forcaPulo);
        }

    }
}
