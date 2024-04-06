using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public float speedup = 0.05f;
    public float jumpForce = 10f;
    private bool isGrounded;
    private Rigidbody rb;
    public Animator Ap;
    public float Hp = 7f;
    // Start is called before the first frame update

    public void GetDmg(float a)
    {
        Hp += a;
    }


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = transform.position + Vector3.forward * speed * Time.deltaTime;
        //transform.position = Vector3.MoveTowards(transform.position, Positions[point].position, speed * Time.deltaTime);
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            //rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            rb.AddForce(0f, jumpForce, 0f, ForceMode.Impulse);
            isGrounded = false;
            //Ap.SetBool("jump", true);
            //StartCoroutine(J());
            Ap.SetTrigger("jump");
        }else if (Input.GetKeyDown(KeyCode.S))
        {
            Ap.SetBool("down", true);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            Ap.SetBool("down", false);
        }
        else
        {
            //Ap.SetBool("jump", false);
        }


        speed += speedup * Time.deltaTime;
    }

    private IEnumerator J()
    {
        Ap.SetBool("jump", true);
        Ap.SetBool("jump", false);
        yield return new WaitForSeconds(0.01f);
        Ap.SetBool("jump", false);
        //gameObject.GetComponent<CapsuleCollider>().
    }



    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }






}
