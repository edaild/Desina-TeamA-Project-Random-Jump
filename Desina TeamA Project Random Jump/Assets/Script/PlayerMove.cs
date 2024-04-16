using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    float hAxis;
    float vAxis;
    bool jump;

//    bool isJump;

    Vector3 moveVec;

    Rigidbody rb; // 케릭터를 움직이기 위해 선언
  //  Animator anim;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
      //  anim = GetComponentInChildren<Animator>();

    }
    void Update()
    {
        GetInput();
        Move();
        Turn();
        Jump();
    }


    void GetInput()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
        jump = Input.GetButtonDown("Jump");
    }

    void Move()
    {
        moveVec = new Vector3(hAxis, 0, vAxis).normalized;

        transform.position += moveVec * speed * Time.deltaTime;

   //     anim.SetBool("isRun", moveVec != Vector3.zero);
    }

    void Turn()
    {
        transform.LookAt(transform.position + moveVec);
    }

    void Jump() // 점프
    {
        if (jump) // ! 부정문 bool 값만 가능
        {
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
          //  anim.SetBool("triggerJump", true);
          //  isJump = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Game field")
        {
         //   anim.SetBool("triggerJump", false);
         //   isJump = false;
        }

        if (collision.gameObject.tag == "Finish Box")
        {
            gameObject.SetActive(false);
            print("스테이지 클리어");
        }
        if (collision.gameObject.tag == "Plane")
        {
            gameObject.SetActive(false);
            print("Game Over");
        }
    }
}
