using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimator : MonoBehaviour
{

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //anim.Play("rotate");
            //Debug.Log(anim.GetCurrentAnimatorClipInfo(0)[0].clip.name);
            if (anim.GetBool("to_move"))
            {
                anim.SetBool("to_move", false);
                anim.SetBool("to_rot", true);
            }
            else
            {
                anim.SetBool("to_move", true);
                anim.SetBool("to_rot", false);
            }
        }
}
}
