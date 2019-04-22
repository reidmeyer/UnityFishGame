using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boundary : MonoBehaviour
{

  public GameObject myobject;

  void OnTriggerEnter2D(Collider2D col)
  {
    //SceneManager.LoadScene("SampleScene");
    //check isTrigger in boundary objects if you want it to end scene
/*

    if (col.name=="Character" && (GameObject.Find("Character").transform.position.x<0))
    {
      GameObject.Find("Character").transform.position= new Vector3(-GameObject.Find("Character").transform.position.x-1, GameObject.Find("Character").transform.position.y, GameObject.Find("Character").transform.position.z);
    }
    else
    {
      GameObject.Find("Character").transform.position= new Vector3(-GameObject.Find("Character").transform.position.x+1, GameObject.Find("Character").transform.position.y, GameObject.Find("Character").transform.position.z);
    }*/

  }

}
