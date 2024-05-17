using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    //These variables tell  us  how fast we want the  player to  move forwrad and backwards and  how fast  we want the player to rotate left and right.
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;
    private float _vInput;
    private float _hInput;

    //This private variable references the Player's "Rigidbody" component.
    private Rigidbody _rb;

    //Time to add jumping!!
    //The first variable added here hold the amount of the jump force we want and the boolean is used to check if our Player should even be jumping.
    public float JumpVelocity = 5f;
    private bool _isJumping;

    //This is to check the distance between the player "Capsule Collider" and any object that has the "Ground Layer"
    public float DistanceToGround = 0.1f;

    //This variable is used for collider detection.
    public LayerMask GroundLayer;

    //This is where we store the Player's Capsule Collider component.
    private CapsuleCollider _col;

    void Start()
    {
        //This method checks if the Rigidbody component exists on our GameObject(capsule) this script is attached to andd returns it.
        _rb = GetComponent<Rigidbody>();

        //This is used to find andd return the Capsule Collider component.
        _col = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        _isJumping |= Input.GetKeyDown(KeyCode.Space);

        //This input detects when the up/down arrow keys and when the "W" and "S" keys  get pressed and multiplies the value by MoveSpeed.
        _vInput = Input.GetAxis("Vertical") * MoveSpeed;

        //This input detects when the left/right arrow keys and when the "A" and "D" keys  get pressed and multiplies the value by RotateSpeed.
        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;

        //This is where we utilize the "Translate" method, which takes the parameter of Vector3, in order to movve the Player's, or the capsule's, transform component.
        this.transform.Translate(Vector3.forward * _vInput * Time.deltaTime);

        //This is where we use the "Rotate" method to rotate  the Player's "Transform" component relative to Vector3.
        this.transform.Rotate(Vector3.up * _hInput * Time.deltaTime);

    }

    void FixedUpdate()
    {
        //This "if" statement is used to check IF "IsGrounded" comes out true and the spacebar(jump key) is presed before executing the code.
        if(IsGrounded() && _isJumping)
        {
            _rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);
        }

        _isJumping = false;
    }

    //IsGrounded() method is declared by the following  bool return type.
    private bool IsGrounded()
    {
        //This stores the position at the bottom of the Player's Capsule Collider. This will in turn be used to check for collisions with objects that contain the "Ground" layer.
        Vector3 capsuleBottom = new Vector3(_col.bounds.center.x, _col.bounds.min.y, _col.bounds.center.z);

        //This stores the result of the CheckCapsule() method. 
        bool grounded = Physics.CheckCapsule(_col.bounds.center,  capsuleBottom, DistanceToGround, GroundLayer, QueryTriggerInteraction.Ignore);

        //This simply returns the value stores in "grounded"att  the end of calculation.
        return grounded;
    }
    
}

