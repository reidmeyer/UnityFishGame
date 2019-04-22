using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlasticBag : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other)
    {
    	if(other.gameObject.GetComponent<Character>())
    	{
    		//SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    	}
    }


    // Update is called once per frame
    void Update()
    {

		transform.position = new Vector2(transform.position.x, Mathf.Sin(GameController.instance.timeElapsed));

    }

}
