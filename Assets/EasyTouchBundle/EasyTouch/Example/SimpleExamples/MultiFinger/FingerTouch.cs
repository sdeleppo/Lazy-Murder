using UnityEngine;
using System.Collections;

public class FingerTouch : MonoBehaviour {

	private TextMesh textMesh;
	public Vector3 deltaPosition = Vector2.zero;
	public int fingerId=-1;
    AttackEnemy human;
    AttackEnemy human1;
    AttackEnemy human2;
    AttackEnemy human3;
    AttackEnemy human4;
    AttackEnemy human5;
    AttackEnemy human6;
    AttackEnemy human7;
    AttackEnemy human8;
    AttackEnemy human9;
    float timer = 0.3f;
    int damage = 1;
    void Update ()
    {

       /* human2 = GameObject.FindGameObjectWithTag("Human2");
        human3 = GameObject.FindGameObjectWithTag("Human3");
        human4 = GameObject.FindGameObjectWithTag("Human4");
        human5 = GameObject.FindGameObjectWithTag("Human5");
        human6 = GameObject.FindGameObjectWithTag("Human6");
        human7 = GameObject.FindGameObjectWithTag("Human7");
        human8 = GameObject.FindGameObjectWithTag("Human8");
        human9 = GameObject.FindGameObjectWithTag("Human9");*/

    }
	void OnEnable(){
		EasyTouch.On_TouchStart += On_TouchStart;
		EasyTouch.On_TouchUp += On_TouchUp;
		EasyTouch.On_Swipe += On_Swipe;
		EasyTouch.On_Drag += On_Drag;
		EasyTouch.On_DoubleTap += On_DoubleTap;
		textMesh =(TextMesh) GetComponentInChildren<TextMesh>();
	}

	void OnDestroy(){
		EasyTouch.On_TouchStart -= On_TouchStart;
		EasyTouch.On_TouchUp -= On_TouchUp;
		EasyTouch.On_Swipe -= On_Swipe;
		EasyTouch.On_Drag -= On_Drag;
		EasyTouch.On_DoubleTap -= On_DoubleTap;
	}
	

	void On_Drag (Gesture gesture)
	{
		if ( gesture.pickedObject.transform.IsChildOf(gameObject.transform) && fingerId == gesture.fingerIndex){
			Vector3 position = gesture.GetTouchToWorldPoint(gesture.pickedObject.transform.position);
			transform.position = position - deltaPosition;
		}
	}

	void On_Swipe (Gesture gesture)
	{
		if (fingerId == gesture.fingerIndex){
			Vector3 position = gesture.GetTouchToWorldPoint(transform.position);
			transform.position = position - deltaPosition;
            if (GameObject.FindGameObjectsWithTag("Human").Length != 0)
                
                human = GameObject.FindGameObjectWithTag("Human").GetComponent<AttackEnemy>();
            if (GameObject.FindGameObjectsWithTag("Human1").Length != 0)
                
                human1 = GameObject.FindGameObjectWithTag("Human1").GetComponent<AttackEnemy>();

            if (GameObject.FindGameObjectsWithTag("Human2").Length != 0)

                human2 = GameObject.FindGameObjectWithTag("Human2").GetComponent<AttackEnemy>();

            if (GameObject.FindGameObjectsWithTag("Human3").Length != 0)

                human3 = GameObject.FindGameObjectWithTag("Human3").GetComponent<AttackEnemy>();
            if (GameObject.FindGameObjectsWithTag("Human4").Length != 0)

                human4 = GameObject.FindGameObjectWithTag("Human4").GetComponent<AttackEnemy>();
            if (GameObject.FindGameObjectsWithTag("Human5").Length != 0)

                human5 = GameObject.FindGameObjectWithTag("Human5").GetComponent<AttackEnemy>();
            if (GameObject.FindGameObjectsWithTag("Human6").Length != 0)

                human6 = GameObject.FindGameObjectWithTag("Human6").GetComponent<AttackEnemy>();
            if (GameObject.FindGameObjectsWithTag("Human7").Length != 0)

                human7 = GameObject.FindGameObjectWithTag("Human7").GetComponent<AttackEnemy>();
            if (GameObject.FindGameObjectsWithTag("Human8").Length != 0)

                human8 = GameObject.FindGameObjectWithTag("Human8").GetComponent<AttackEnemy>();
            if (GameObject.FindGameObjectsWithTag("Human9").Length != 0)

                human9 = GameObject.FindGameObjectWithTag("Human9").GetComponent<AttackEnemy>();
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                if (GameObject.FindGameObjectsWithTag("Human").Length != 0)
                {
                    if (human.enabled == true)
                    {
                        GameObject.FindGameObjectWithTag("Spawn").GetComponent<CameraSwitch>().claw.SetActive(true);
                        human.gameObject.SendMessage("OnDamage", damage);
                    }
                }
                if (GameObject.FindGameObjectsWithTag("Human1").Length != 0)
                {
                    if (human1.enabled == true)
                    {
                        human1.gameObject.SendMessage("OnDamage1", damage);
                        GameObject.FindGameObjectWithTag("Spawn").GetComponent<CameraSwitch>().claw1.SetActive(true);
                    }
                }
                if (GameObject.FindGameObjectsWithTag("Human2").Length != 0)
                {
                    if (human2.enabled == true){
                        human2.gameObject.SendMessage("OnDamage2", damage);
                    GameObject.FindGameObjectWithTag("Spawn").GetComponent<CameraSwitch>().claw2.SetActive(true);
                    }
                }
                if (GameObject.FindGameObjectsWithTag("Human3").Length != 0)
                {
                    if (human3.enabled == true) { 
                        human3.gameObject.SendMessage("OnDamage3", damage);
                        GameObject.FindGameObjectWithTag("Spawn").GetComponent<CameraSwitch>().claw3.SetActive(true);
                    }
                }
                if (GameObject.FindGameObjectsWithTag("Human4").Length != 0)
                {
                    if (human4.enabled == true) { 
                        human4.gameObject.SendMessage("OnDamage4", damage);
                        GameObject.FindGameObjectWithTag("Spawn").GetComponent<CameraSwitch>().claw4.SetActive(true);
                    }
                }
                if (GameObject.FindGameObjectsWithTag("Human5").Length != 0)
                {
                    if (human5.enabled == true) { 
                        human5.gameObject.SendMessage("OnDamage5", damage);
                        GameObject.FindGameObjectWithTag("Spawn").GetComponent<CameraSwitch>().claw5.SetActive(true);
                    }
                }
                if (GameObject.FindGameObjectsWithTag("Human6").Length != 0)
                {
                    if (human6.enabled == true) { 
                        human6.gameObject.SendMessage("OnDamage6", damage);
                        GameObject.FindGameObjectWithTag("Spawn").GetComponent<CameraSwitch>().claw6.SetActive(true);
                    }
                }
                if (GameObject.FindGameObjectsWithTag("Human7").Length != 0)
                {
                    if (human7.enabled == true) { 
                        human7.gameObject.SendMessage("OnDamage7", damage);
                        GameObject.FindGameObjectWithTag("Spawn").GetComponent<CameraSwitch>().claw7.SetActive(true);
                    }
                }
                if (GameObject.FindGameObjectsWithTag("Human8").Length != 0)
                {
                    if (human8.enabled == true) { 
                        human8.gameObject.SendMessage("OnDamage8", damage);
                        GameObject.FindGameObjectWithTag("Spawn").GetComponent<CameraSwitch>().claw8.SetActive(true);
                    }
                }
                if (GameObject.FindGameObjectsWithTag("Human9").Length != 0)
                {
                    if (human9.enabled == true) { 
                        human9.gameObject.SendMessage("OnDamage9", damage);
                        GameObject.FindGameObjectWithTag("Spawn").GetComponent<CameraSwitch>().claw9.SetActive(true);
                    }
                }
                timer +=0.3f;
            }

		}
	}

	void On_TouchStart (Gesture gesture)
	{
		if (gesture.pickedObject!=null && gesture.pickedObject.transform.IsChildOf(gameObject.transform)){
			fingerId = gesture.fingerIndex;
			textMesh.text = fingerId.ToString();

			Vector3 position = gesture.GetTouchToWorldPoint(gesture.pickedObject.transform.position);
			deltaPosition = position - transform.position;
            //if (human.GetComponent<AttackEnemy>() == true)
            //    human.GetComponent<AttackEnemy>().gameObject.SendMessage("OnDamage", damage);
            //else if (human1.GetComponent<AttackEnemy>() == true)
            //    human1.gameObject.SendMessage("OnDamage", damage);
            //else if (human2.GetComponent<AttackEnemy>() == true)
            //    human2.gameObject.SendMessage("OnDamage", damage);
            //else if (human3.GetComponent<AttackEnemy>() == true)
            //    human3.gameObject.SendMessage("OnDamage", damage);
            //else if (human4.GetComponent<AttackEnemy>() == true)
            //    human4.gameObject.SendMessage("OnDamage", damage);
            //else if (human5.GetComponent<AttackEnemy>() == true)
            //    human5.gameObject.SendMessage("OnDamage", damage);
            //else if (human6.GetComponent<AttackEnemy>() == true)
            //    human6.gameObject.SendMessage("OnDamage", damage);
            //else if (human7.GetComponent<AttackEnemy>() == true)
            //    human7.gameObject.SendMessage("OnDamage", damage);
            //else if (human8.GetComponent<AttackEnemy>() == true)
            //    human8.gameObject.SendMessage("OnDamage", damage);
            //else if (human9.GetComponent<AttackEnemy>() == true)
            //    human9.gameObject.SendMessage("OnDamage", damage);
		}
	}
	
	void On_TouchUp (Gesture gesture)
	{

		if (gesture.fingerIndex == fingerId){
			fingerId = -1;
			//textMesh.text="";
		}
	}

	public void InitTouch(int ind){
		fingerId = ind;
		//textMesh.text = fingerId.ToString();
	}

	void On_DoubleTap (Gesture gesture)
	{
		if (gesture.pickedObject!=null && gesture.pickedObject.transform.IsChildOf(gameObject.transform)){
			DestroyImmediate( transform.gameObject );
		}
	}

}
