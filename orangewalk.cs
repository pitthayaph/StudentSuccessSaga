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
                // เคลื่อนที่ GameObject ไปทางขวา
                transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
                distanceright += moveSpeed * Time.deltaTime;

                animator.SetBool("Isgoright", goright);

            // ถ้าเคลื่อนที่ไปได้ 50 เมตรแล้วให้หยุด
            if (distanceright >= 10f)
                {
                    goright = false;
                animator.SetBool("Isgoright", goright);     

            }


            }

            if (godown)
            {
                // เคลื่อนที่ GameObject ไปทางขวา
                transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
                distancedown += moveSpeed * Time.deltaTime;

                // ถ้าเคลื่อนที่ไปได้ 50 เมตรแล้วให้หยุด
                if (distancedown >= 5)
                {
                    godown = false;
                    goleft = true;

                }


            }

            if (goleft)
            {
                // เคลื่อนที่ GameObject ไปทางขวา
                transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
                distanceleft += moveSpeed * Time.deltaTime;
                animator.SetBool("Isgoleft", goleft);

            // ถ้าเคลื่อนที่ไปได้ 50 เมตรแล้วให้หยุด
            if (distanceleft >= 10f)
                {
                    goleft = false;
                    goup = true;
                animator.SetBool("Isgoleft", goleft);
            }


            }

            if (goup)
            {
                // เคลื่อนที่ GameObject ไปทางขวา
                transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
                distanceup += moveSpeed * Time.deltaTime;

                // ถ้าเคลื่อนที่ไปได้ 50 เมตรแล้วให้หยุด
                if (distanceup >= 5)
                {
                    goup = false;
                goright = true;

                }

                
            }


        
        
        
        
        
        
    }
}