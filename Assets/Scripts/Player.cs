using UnityEngine;

public class Player : MonoBehaviour {

    public float MovementSpeed = 0.03f;
    public float JumpForce = 150f;
    public int CurrentState = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A)) {
            // left
            transform.position -= new Vector3(MovementSpeed, 0, 0);
            CurrentState = 1;
        } else if (Input.GetKey(KeyCode.D)) {
            // right
            transform.position += new Vector3(MovementSpeed, 0, 0);
            CurrentState = 2;
        } else {
            CurrentState = 0;
        }

        if (Input.GetKeyDown(KeyCode.O)) {
            Debug.Log("Salto");
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, JumpForce));
        }

        GetComponentInChildren<Animator>().SetInteger("State", CurrentState);
	}
}
