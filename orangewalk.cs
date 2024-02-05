using UnityEngine;

public class OrangeWalk : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float distanceright = 0f;
    private float distancedown = 0f;
    private float distanceleft = 0f;
    private float distanceup = 0f;
    private bool goright = false;
    private bool goleft = false;
    private bool goup = false;
    private bool godown = true;

    

    private Animator animator;
    

    private void Start()
    {
        animator = GetComponent<Animator>();
        PlayerPrefs.DeleteKey("hasmove");


    }
    void Update()
    {
        

        
            if (goright)
            {
                // ����͹��� GameObject 价ҧ���
                transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
                distanceright += moveSpeed * Time.deltaTime;

                animator.SetBool("Isgoright", goright);

            // �������͹������ 50 �������������ش
            if (distanceright >= 10f)
                {
                    goright = false;
                animator.SetBool("Isgoright", goright);     

            }


            }

            if (godown)
            {
                // ����͹��� GameObject 价ҧ���
                transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
                distancedown += moveSpeed * Time.deltaTime;

                // �������͹������ 50 �������������ش
                if (distancedown >= 5)
                {
                    godown = false;
                    goleft = true;

                }


            }

            if (goleft)
            {
                // ����͹��� GameObject 价ҧ���
                transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
                distanceleft += moveSpeed * Time.deltaTime;
                animator.SetBool("Isgoleft", goleft);

            // �������͹������ 50 �������������ش
            if (distanceleft >= 10f)
                {
                    goleft = false;
                    goup = true;
                animator.SetBool("Isgoleft", goleft);
            }


            }

            if (goup)
            {
                // ����͹��� GameObject 价ҧ���
                transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
                distanceup += moveSpeed * Time.deltaTime;

                // �������͹������ 50 �������������ش
                if (distanceup >= 5)
                {
                    goup = false;
                goright = true;

                }

                
            }


        
        
        
        
        
        
    }
}