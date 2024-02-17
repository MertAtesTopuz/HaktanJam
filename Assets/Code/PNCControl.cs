using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNCControl : MonoBehaviour
{
    private Vector2 followSpot;
    [SerializeField] private float speed;
    //[SerializeField] private float perspectiveScale;
    //[SerializeField] private float scaleRatio;
    private Animator anim;
    private Vector2 stuckDistanceCheck;
    //public Rigidbody2D rb;
    private Vector3 previousPosition;
    bool isRight;
    public CameraFollow2D cameraFollow;

    void Start()
    {
        followSpot = transform.position;
        anim = GetComponent<Animator>();
        previousPosition = transform.position;
    }

    void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(1))
        {
            followSpot = new Vector2(mousePos.x, transform.position.y);
        }
        transform.position = Vector2.MoveTowards(transform.position, followSpot, speed * Time.deltaTime);


        if (transform.position.x > followSpot.x && !isRight)
        {
            Flip();
        }
        else if (transform.position.x < followSpot.x && isRight)
        {
            Flip();
        }



        if (transform.position.x == followSpot.x)
        {
            anim.SetBool("walk", false);
            print("walkF");
        }
        else
        {
            anim.SetBool("walk", true);
        }
        //UpdateAnimation();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        followSpot = transform.position;
    }

    private void UpdateAnimation()
    {
        float distance = Vector2.Distance(transform.position, followSpot);
        if (Vector2.Distance(stuckDistanceCheck, transform.position) == 0)
        {
            //anim.SetFloat("distance", 0f);
            return;
        }
       // anim.SetFloat("distance", distance);
        if (distance > 0.01)
        {
            Vector3 direction = transform.position - new Vector3(followSpot.x, followSpot.y, transform.position.z);
            float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
            //anim.SetFloat("angle", angle);
            stuckDistanceCheck = transform.position;
        }
    }


    void Flip()
    {
        isRight = !isRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
        cameraFollow.offset.x *= -1;
        cameraFollow.smoothSpeed = 0.01f;
    }
}
