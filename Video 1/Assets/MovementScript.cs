using UnityEngine;
using UnityEngine.UIElements;

public class MovementScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
   {
        // Move Forward when Up Arrow is pressed
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward* Time.deltaTime;
        }
        // Move Backward when Down Arrow is pressed
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= Vector3.forward * Time.deltaTime;
        }

        // Move Left when Left Arrow is pressed
        if (Input.GetKey(KeyCode.LeftArrow))
        { 
            transform.position += Vector3.left * Time.deltaTime;
        }

        // Move Right when Right Arrow is pressed
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime;
        }
    }
}