using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{

    [SerializeField]
    float moveSpeed = 20f;
    public GameObject mainChar;
    public AudioSource walkSound;
    public bool makeSound = true;

    Vector3 forward, right;
    void Start()
    {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
    }

    void Update()
    {
        
        if(Input.anyKey)
        {
            Move();
            if(makeSound || !walkSound.isPlaying)
            {
                walkSound.Play();
                makeSound = false;
            }
            mainChar.GetComponent<Animation>().Play("Run");
        }
        else
        {
            mainChar.GetComponent<Animation>().Play("Idle");
                if(!makeSound)
            {
                walkSound.Stop();
                makeSound = true;
            }
        }
    }

    void Move()
    {
        Vector3 direction = new Vector3(Input.GetAxis("HorizontalKey"), 0, Input.GetAxis("VerticalKey"));
        Vector3 rightMovement = right * moveSpeed * Time.deltaTime * Input.GetAxis("HorizontalKey");
        Vector3 upMovement = forward * moveSpeed * Time.deltaTime * Input.GetAxis("VerticalKey");

        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);



        transform.forward = heading;
        transform.position += rightMovement;
        transform.position += upMovement;

            
    }
}
