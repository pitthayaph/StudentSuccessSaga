using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loopwalk : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float distanceright = 0f;
    //private float distancedown = 0f;
    //private float distanceleft = 0f;
    //private float distanceup = 0f;
    private bool goright = true;
    public bool goleft = false;
    public bool goup = false;
    public bool godorm = false;
    public bool godown = false;
    public int knowledge;
    public int totalknowledge ;



    private Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();
        PlayerPrefs.DeleteKey("hasmove");
    }
    void Update()
    {
        knowledge = PlayerPrefs.GetInt("PlayerKnowledge");


        if (godown)
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
            animator.SetBool("Isgodown", godown);

        }

        if (goleft)
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            animator.SetBool("Isgoleft", goleft);
        }

        if (goup)
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
            animator.SetBool("Isgoup", goup);


        }
        if (godorm)
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
            animator.SetBool("Isgoup", godorm);


        }
        if (goright)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            distanceright += moveSpeed * Time.deltaTime;

            animator.SetBool("Isgoright", goright);

            if (distanceright >= 9f)
            {
                goright = false;
                animator.SetBool("Isgoright", goright);
                goup= true;
                distanceright = 0;

            }


        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Building")
        {
            transform.position = new Vector2(-20f, 0f);
            
            
            StartCoroutine(inbuilding());

        }
    }

    IEnumerator inbuilding()
    {


        if (goleft)
        {
            PlayerPrefs.DeleteKey("Library");
            PlayerPrefs.SetInt("Library", 70);
            goleft = false;
            animator.SetBool("Isgoleft", goleft);

            yield return new WaitForSeconds(2f);
            transform.position = new Vector2(-4.5f, 0f);
            Debug.Log(knowledge);

            godorm = true;
        } else if(goup)
        {
            goup = false;
            animator.SetBool("Isgoup", goup);

            yield return new WaitForSeconds(2f);
            transform.position = new Vector2(4.3f, 1.93f);
            godown = true;
        }
        else if (godown)
        {
            totalknowledge = knowledge + 15;
            PlayerPrefs.DeleteKey("PienVichit");
            PlayerPrefs.SetInt("PienVichit", 70);

                
            godown = false;
            animator.SetBool("Isgodown", godown);

            yield return new WaitForSeconds(2f);
            transform.position = new Vector2(5.28f, -4.2f);
            PlayerPrefs.SetInt("PlayerKnowledge", totalknowledge);

            Debug.Log(knowledge);
            Debug.Log(totalknowledge);


            goleft = true;
        }
        else if (godorm)
        {
            PlayerPrefs.DeleteKey("PienVichit");
            PlayerPrefs.SetInt("PienVichit", 70);
            godorm = false;
            animator.SetBool("Isgoup", godorm);

            yield return new WaitForSeconds(2f);
            transform.position = new Vector2(-4.43f, 0.99f);
            goright = true;
        }






    }
}
