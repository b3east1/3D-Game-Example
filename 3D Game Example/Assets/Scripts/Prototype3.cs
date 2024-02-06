using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prototype3 : MonoBehaviour
{
    public float turnSpeed = 20f;
    public float moveSpeed = 10f;
    public float JumpForce = 10f;
    public float GravityModifer = 1f;
    public bool IsOnGround = true;
    private Rigidbody _playerRb;

    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= GravityModifer;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && IsOnGround)
        {
            _playerRb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            IsOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.CompareTag("Ground"))
        {
            IsOnGround = true;
        } 
}   }
