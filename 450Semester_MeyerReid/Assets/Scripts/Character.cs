using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Character : MonoBehaviour
{
    public static Character instance;

    Rigidbody2D _rb;
    public float speed;
    public float rotationSpeed;
    public Image imageHealthBar;


    public float healthMax = 100f;
    public float health = 100f;
    public bool isPaused;
    public float isDead = 0f; //0 means alive 1 means dead
    SpriteRenderer sprite;
    public float timemultiplier = 1f;



    Animator animator;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

        _rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        animator.SetFloat("isDead", isDead);
    }

    void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        if(health<=0)
        {
            Die();
        }

        imageHealthBar.fillAmount = health / healthMax;
    }

    void Die()
    {
      //dieee
      //SceneManager.LoadScene("SampleScene");
      isDead=1f;



      //wait
      //then open death menu

        StartCoroutine(ExecuteAfterTime(2));

    }

    IEnumerator ExecuteAfterTime(float time)
 {
     yield return new WaitForSeconds(time);
 
        MenuController.instance.Death();
 }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlasticBag>())
        {
            TakeDamage(10f);
            SoundManager.instance.PlayHookSound();

        }

        if (collision.gameObject.GetComponent<Hook>())
        {
            TakeDamage(20f);
            SoundManager.instance.PlayHookSound();

        }


        if (collision.gameObject.GetComponent<fishingnet>())
        {
            TakeDamage(20f);
            SoundManager.instance.PlayHookSound();

        }

    }


    float elapsed = 0f;
   
    // Update is called once per frame
    void Update()
    {

        animator.SetFloat("isDead", isDead);


        if(isPaused)
        {
            return;
        }

        if(Input.GetKey(KeyCode.Escape))
        {
            MenuController.instance.Show();
        }



        elapsed += Time.deltaTime;        
        if(elapsed>=1f)
        {
            elapsed = elapsed % 1f;
            timemultiplier=elapsed*200f;
            TakeDamage(timemultiplier*2f);
        }




      if (transform.position.x < -50)
      {
        transform.position = new Vector3(50, transform.position.y, transform.position.z);
      }
      else if (transform.position.x > 50)
      {
        transform.position =new Vector3(-50, transform.position.y, transform.position.z);
      }





        _rb.angularVelocity = 0;



        if(Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A))
        {
           // _rb.AddTorque(rotationSpeed * Time.deltaTime);
            transform.Rotate(Vector3.forward * 5);

        }

        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
         //   _rb.AddTorque(-rotationSpeed * Time.deltaTime);
            transform.Rotate(Vector3.forward * -5 );

        }

        if(Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            _rb.AddRelativeForce(Vector2.right * 3f * speed * Time.deltaTime);
        }


        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _rb.AddRelativeForce(-Vector2.right * 3f *  speed * Time.deltaTime);
        }



    }

    public void add10Health()
    {
        if(health >= 0 && health < healthMax)
        {
            health = health+10;
            imageHealthBar.fillAmount = health / healthMax;
        }

        if(health>healthMax)
        {
            health=healthMax;
            imageHealthBar.fillAmount = health / healthMax;
        }
    }


}
