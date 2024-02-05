using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class McWalk : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Animator animator;
    public bool goleft = true;

    // Start is called before the first frame update
    void Start()
        
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (goleft)
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            animator.SetBool("Isgoleft", goleft);
        }
    }
}
