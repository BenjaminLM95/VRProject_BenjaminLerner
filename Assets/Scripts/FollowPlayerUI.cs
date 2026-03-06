using UnityEngine;

public class FollowPlayerUI : MonoBehaviour
{
    [SerializeField] private GameObject objToFollow;
    public Vector3 offSet; 



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(objToFollow == null) 
        {
            objToFollow = GameObject.Find("Camera Offset");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = objToFollow.transform.position + offSet; 
    }
}
