using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyScript : MonoBehaviour
{
    private Camera cam;
    public Rigidbody rb;
    public float lerpValue;
    public float minY, maxY;
    public float minX, maxX;
    public float speed;

    private bool IsGameEnded = false;
    public bool canMove=true;
    void Start()
    {
        cam = Camera.main;
        
    }

    
    void Update()
    {
        if (!IsGameEnded)
        {
            rb.velocity = Vector3.forward * speed * Time.deltaTime;
        }

        if (Input.GetButton("Fire1"))
        {
            ChangeScale();
        }
    }

    public void ChangeScale()
    {
        
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10;

            Vector3 moveVec = cam.ScreenToViewportPoint(mousePos);

            float x = transform.localScale.x;
            moveVec.z = transform.localScale.z;
            moveVec.y *= 2f;
            moveVec.y = Mathf.Clamp(moveVec.y, minY, maxY);

            x = maxY / moveVec.y;

            moveVec.x = Mathf.Clamp(x, minX, maxX);

            transform.localScale = moveVec;

            GhostJelly.Instance.ChangeScaleOfTheGhost(moveVec);
        
       
        
    }
}
