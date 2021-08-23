using UnityEngine;
using System.Collections;

// Place the script in the Camera-Control group in the component menu
[AddComponentMenu("Camera-Control/Smooth Follow CSharp")]

public class SmoothFollow : MonoBehaviour
{
    public Transform player;
    public float followSpeed = 5;
    public float rotateSpeed = 10;


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, followSpeed * Time.deltaTime);//move to the player
        transform.localRotation = player.transform.localRotation;
        //transform.RotateAround(player.position, Vector3.up, Input.GetAxis("Mouse X") * rotateSpeed);//rotate around
    }
}