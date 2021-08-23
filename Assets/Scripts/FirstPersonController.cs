using UnityEngine;
using System.Collections;

[RequireComponent (typeof (GravityBody))]
public class FirstPersonController : MonoBehaviour {
	
	// public vars
	public float mouseSensitivityX = 250;
	public float mouseSensitivityY = 250;
	public float walkSpeed = 6;
	public float jumpForce = 220;
	public LayerMask groundedMask;
	Vector3 dir = Vector3.zero;
	// System vars
	bool grounded;
	Vector3 moveAmount;
	Vector3 smoothMoveVelocity;
	float verticalLookRotation;
	Transform cameraTransform;
	
	
	void Awake() {
		//Screen.lockCursor = true;
		cameraTransform = Camera.main.transform;
	}
	
	void Update() {
        dir.x = Input.acceleration.x;
		// Look rotation:
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * mouseSensitivityX * Time.deltaTime);
        transform.Rotate(Vector3.up * dir.x * mouseSensitivityX * Time.deltaTime);
		//verticalLookRotation += Input.GetAxis("Mouse Y") * mouseSensitivityY * Time.deltaTime;
		//verticalLookRotation = Mathf.Clamp(verticalLookRotation,-60,60);
		//cameraTransform.localEulerAngles = Vector3.left * verticalLookRotation;
		
		// Calculate movement:
		float inputX = 0;
        float inputY = 80;//Input.GetAxisRaw("Vertical");
		
		Vector3 moveDir = new Vector3(inputX,0, inputY).normalized;
		Vector3 targetMoveAmount = moveDir * walkSpeed;
		moveAmount = Vector3.SmoothDamp(moveAmount,targetMoveAmount,ref smoothMoveVelocity,.15f);
		
		// Jump
		if (Input.GetKeyDown(KeyCode.Space)) {
			//if (grounded) {
				GetComponent<Rigidbody>().AddForce(transform.up * jumpForce);
			//}
		}
		
		// Grounded check
		Ray ray = new Ray(transform.position, -transform.up);
		RaycastHit hit;
		
		if (Physics.Raycast(ray, out hit, 1 + .1f, groundedMask)) {
			grounded = true;
		}
		else {
			grounded = false;
		}
		
	}
	
	void FixedUpdate() {
		// Apply movement to rigidbody
		Vector3 localMove = transform.TransformDirection(moveAmount) * Time.fixedDeltaTime;
		GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + localMove);
	}
}
