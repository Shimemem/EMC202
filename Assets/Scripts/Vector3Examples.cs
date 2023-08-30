using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Emovement
{
    Forward, 
    Backward,
    Left,
    Right
}

public class Vector3Examples : MonoBehaviour
{
    public float moveSpeed;
    public Emovement movementType;

    public Transform pointA, pointB;

    public float rangeValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //switch (movementType)
        //{
        //    case Emovement.Forward:
        //        MoveForward();
        //        break;
        //    case Emovement.Backward:
        //        MoveBackward();
        //        break;
        //    case Emovement.Left:
        //        MoveLeft();
        //        break;
        //    case Emovement.Right:
        //        MoveRight();
        //        break;
        //    default:
        //        break;
        //}
        //transform.position = Vector3.Lerp(transform.position, pointB.position, moveSpeed * Time.deltaTime);

        float dist = Vector3.Distance(transform.position, pointB.position);
        //Debug.Log(dist);

        if (dist < rangeValue)
        {
            Debug.Log("Point B has been detected!!!");
        }

    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, rangeValue);
    }

    // Time.time - consistent increment of time. Time passed since the beginning of the cycle.
    // Time.deltaTime - time passed from last frame | 0 -> 1 -> reset to 0
    public void MoveForward()
    {
        transform.position = Vector3.forward * moveSpeed * Time.time;
    }

    public void MoveBackward()
    {
        transform.position = Vector3.back * moveSpeed * Time.time;
    }

    public void MoveLeft()
    {
        transform.position = Vector3.left * moveSpeed * Time.time;
    }

    public void MoveRight()
    {
        transform.position = Vector3.right * moveSpeed * Time.time;
    }
}
