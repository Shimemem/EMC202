using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Behaviour : MonoBehaviour
{

    public List<Color> color;
    public MeshRenderer meshRenderer;
    public float delayTime;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        //for (int i = 0; i < color.Count; i++)
        //{
        //    meshRenderer.material.color = color[Random.Range(0, color.Count)];
        //}        
    }

    public void ChangeColor()
    {
        for (int i = 0; i < color.Count; i++)
        {
            meshRenderer.material.color = color[Random.Range(0, color.Count)];
        }
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    private void OnMouseDown()
    {
        //Invoke("ChangeColor", delayTime);
        InvokeRepeating("ChangeColor", delayTime, 5); 
        //CancelInvoke();
    }

    private void OnMouseUpAsButton()
    {
        
    }

    private void OnMouseEnter()
    {
        
    }


    private void OnMouseExit()
    {
        
    }

    private void OnMouseOver()
    {
        
    }

    private void OnMouseDrag()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // Fixed Update is Called 50 calls per second, For Physics
    void FixedUpdate()
    {
        
    }

    // Last Update to be called
    void LateUpdate()
    {
        
    }
}
