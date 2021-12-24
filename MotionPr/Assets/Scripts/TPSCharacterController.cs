using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSCharacterController : MonoBehaviour
{
    // 3인칭 캐릭터 컨트롤러 만들기
    [SerializeField]
    private Transform characterBody;
    [SerializeField]
    private Transform cameraArm;

    private Animator animator;

    private void Start()
    {
        animator = characterBody.GetComponent<Animator>();
    }

    void Update()
    {
        LookAround();
        Move();
    }

    private void Move()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        bool isMove = moveInput.magnitude != 0;
        animator.SetBool("isMove", isMove); // animator 스크립트가 안들어가있음 빨랑 블렌드 만들자 
        if (isMove)
        {
            Vector3 lookForward = new Vector3(cameraArm.forward.x, 0f, cameraArm.forward.z).normalized;
            Vector3 lookRight = new Vector3(cameraArm.right.x, 0f, cameraArm.right.z).normalized;
            Vector3 moveDir = lookForward * moveInput.y + lookRight * moveInput.x;

            characterBody.forward = lookForward;
            transform.position += moveDir * Time.deltaTime * 5f;
        }

        // Debug.DrawRay(cameraArm.position, new Vector3(cameraArm.forward.x,0f,cameraArm.forward.z).normalized, Color.red);
    }


    // 문제 없음
    private void LookAround()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        Vector3 camAngle = cameraArm.rotation.eulerAngles;
        float x = camAngle.x - mouseDelta.y;

        if (x<180f)
        {
            x=Mathf.Clamp(x, -1f,70f);
        }
        else
        {
            x = Mathf.Clamp(x, 335f, 361f);
        }

        cameraArm.rotation = Quaternion.Euler(x, camAngle.y + mouseDelta.x, camAngle.z);
    }
}