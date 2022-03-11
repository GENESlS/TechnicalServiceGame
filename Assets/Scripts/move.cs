using UnityEngine;

public class move : MonoBehaviour
{
    Animator a;
    public GameObject b, c, e;
    //private int BaseStateHash = Animator.StringToHash("Base Layer.base");
    private int IdleStateHash = Animator.StringToHash("Base Layer.idle");
    private int SitStateHash = Animator.StringToHash("Base Layer.sit_start");
    int flag = 0, flag2 = 0, flag3 = 0, flag4 = 0;
    Vector3 temp;
    //Vector3 v;
    //int aa = 0;

    void Start()
    {
        //v = new Vector3(b.transform.position.x, b.transform.position.y, b.transform.position.z - 1);
        a = GetComponent<Animator>();
        temp = new Vector3(c.transform.localPosition.x, c.transform.localPosition.y, c.transform.localPosition.z);
    }
    void Update()
    {
        AnimatorStateInfo stateInfo = a.GetCurrentAnimatorStateInfo(0);
        if (stateInfo.fullPathHash == SitStateHash && flag == 0)
        {
            c.SetActive(false);
            e.SetActive(true);
            a.speed = 0;
            b.transform.Rotate(0, -118, 0);
           // b.transform.position.z = 5;
            a.speed = 1;
            flag = 1;
            //this.enabled = false;
        }

        if (stateInfo.fullPathHash == IdleStateHash && flag2 == 0 & flag3 == 0)
        {
            //a.speed = 1;
            c.transform.localPosition = new Vector3(0/*-(950/1000)*/, 2/*(1845/1000)*/, 2/*(1800/1000)*/);
            c.transform.Rotate(0, 171, 0);
            flag2 = 1; flag3 = 1;
        }
        else if (stateInfo.fullPathHash != IdleStateHash && flag2 == 1 && flag4 == 0)
        {
            c.transform.localPosition = temp;
            c.transform.Rotate(0, -171, 0);
            flag2 = 0; flag4 = 1;
        }
    }
}
