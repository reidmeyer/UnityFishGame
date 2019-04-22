using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowfish : MonoBehaviour
{

	public GameObject myobject;
	//public float var;


	void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name=="Character")
        {
        	GameObject.Find("Character").transform.localScale += new Vector3(0.1F, 0.1F, 0);
            if (GameObject.Find("Character").transform.localScale.x > 3f)
{
                GameObject.Find("Character").transform.localScale = new Vector3(3F, 3F, 0);

}

			GameController.instance.EarnPoints(10);
					//GameObject.Find("Character").add10Health();

			myobject.GetComponent<Character>().add10Health();

        }

        Respawn();

    }


    void Respawn()
    {
    		//var = transform.position.y;
			Instantiate(gameObject, new Vector3(Random.Range(-37.0f,37.0f),Random.Range(-2f,10.0f),0), Quaternion.identity);
			//Instantiate(gameObject, new Vector3(0f,var-1f,0f), Quaternion.identity);

			Destroy(gameObject);

    }

}
