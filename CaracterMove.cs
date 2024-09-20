using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CaracterMove : MonoBehaviour
{
    CharacterController controller;
    private Animator anim;
    
    private Vector3 _direction;
    private float _currentVelocity;

    [SerializeField] private float smoothTime = 0.05f;
    [SerializeField] private Transform cam;
    
    Vector2 movement;
    public float moveSpeed;
    public float sprintSpeed;
    float trueSpeed;

    void Start(){
        trueSpeed = moveSpeed;
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    void Update(){

        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (movement.sqrMagnitude == 0) {
            anim.SetFloat("Walk", 0f);
            return;
        }

        Vector3 direction = new Vector3(movement.x, 0, movement.y).normalized;

        if (direction.magnitude >= 0.1f) {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref _currentVelocity, smoothTime);
            transform.rotation = Quaternion.Euler(0.0f, angle, 0.0f);

            Vector3 moveDir = Quaternion.Euler(0.0f, targetAngle, 0.0f) * Vector3.forward;
            controller.Move(moveDir.normalized * trueSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift)){
            trueSpeed = sprintSpeed;
        } else if (Input.GetKeyUp(KeyCode.LeftShift)){
            trueSpeed = moveSpeed;
        }

        if (Input.GetKey(KeyCode.LeftShift)){
            anim.SetFloat("Walk", 1f);
        } else {
            anim.SetFloat("Walk", 0.5f);
        }
    }
}
