using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



    	
		transform.position = new Vector2(transform.position.x, 1+Mathf.Sin(GameController.instance.timeElapsed)*5f);

		


    	
    }
}
