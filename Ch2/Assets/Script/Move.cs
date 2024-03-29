using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 goal;
    float speed = 1.0f; 
    float accuracy = 1.0f;

    void Start()
    {
        goal = this.transform.position;
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit) && Input.GetMouseButtonDown(0))
        {
            goal = new Vector3(hit. point.x, this.transform.position.y, hit. point.z);
        }
        this.transform.LookAt(goal);
        if(Vector3.Distance(transform.position,goal)>accuracy)
        {
            this.transform.Translate(0,0, speed*Time.deltaTime);
        }
    }

    /*private void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit) && Input.GetMouseButtonDown(0))
        {
            Vector3 newPosition = new Vector3(hit. point.x, this.transform.position.y, hit. point.z);
            this.transform.position = newPosition;
            Debug.Log("Current position vector: " + newPosition.ToString());
        }
    }*/
}
