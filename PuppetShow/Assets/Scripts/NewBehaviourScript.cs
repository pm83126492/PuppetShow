using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject finger;
    public GameObject hand;
    public GameObject finger2;
    public GameObject hand2;
    public GameObject neck;
    public GameObject indexfinger;
    public GameObject RightArm02;
    public GameObject MidTip02;
    public GameObject LeftArm02;
    public GameObject ThumbTip02;

    Quaternion quaternion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        finger= GameObject.Find("Hand_ThumbTip");
        finger2= GameObject.Find("Hand_MiddleTip");
        indexfinger = GameObject.Find("Hand_IndexTip");
        //MidTip02= GameObject.Find("Hand_Middle2");
        //ThumbTip02 = GameObject.Find("Hand_Thumb2");

        Vector3 rotationVector3 = new Vector3(finger.transform.rotation.eulerAngles.x, finger.transform.rotation.eulerAngles.y, finger.transform.rotation.eulerAngles.z+180);
        Vector3 rotationVector4 = new Vector3(indexfinger.transform.rotation.eulerAngles.x, indexfinger.transform.rotation.eulerAngles.y, indexfinger.transform.rotation.eulerAngles.z+180);
        Vector3 rotationVector5 = new Vector3(finger2.transform.rotation.eulerAngles.x, finger2.transform.rotation.eulerAngles.y, finger2.transform.rotation.eulerAngles.z + 180);
        //Vector3 rotationVector6 = new Vector3(MidTip02.transform.rotation.eulerAngles.x, MidTip02.transform.rotation.eulerAngles.y, MidTip02.transform.rotation.eulerAngles.z*-1);
       // Vector3 rotationVector7 = new Vector3(ThumbTip02.transform.rotation.eulerAngles.x, ThumbTip02.transform.rotation.eulerAngles.y, ThumbTip02.transform.rotation.eulerAngles.z*-1);
        Quaternion rotation = Quaternion.Euler(rotationVector3);
        Quaternion rotation2 = Quaternion.Euler(rotationVector4);
        Quaternion rotation3 = Quaternion.Euler(rotationVector5);
       // Quaternion rotation4 = Quaternion.Euler(rotationVector6);
       // Quaternion rotation5 = Quaternion.Euler(rotationVector7);
        hand.transform.rotation = rotation;
        hand2.transform.rotation = rotation3;
        neck.transform.rotation = rotation2;
        //RightArm02.transform.rotation = rotation;
       // LeftArm02.transform.rotation = rotation3;
    }
}
