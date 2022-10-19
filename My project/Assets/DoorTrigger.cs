/*
Made by: Ava Fritts
Date Created: October 19th, 2022
Date Modified: ^^^
Description: Here's something to open the door
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{

    public GameObject doorPrefab;
    public string openParmName; //ref to the animator bool to open the door
    Animator animator;//REFERENCES THE ANIMATOR TREE

    // Start is called before the first frame update
    void Start()
    {
        animator = doorPrefab.GetComponent<Animator>();
        Debug.Log("Door Animator: " + animator.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            animator.SetBool(openParmName, true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool(openParmName, false);
        }
    }
}
