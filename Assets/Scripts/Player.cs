using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    Vector3 velocity;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized * 10;

        if (Input.GetKeyDown(KeyCode.Alpha1)) SceneManager.LoadScene(0);
        if (Input.GetKeyDown(KeyCode.Alpha2)) SceneManager.LoadScene(1);
        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
    }


    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }
}
