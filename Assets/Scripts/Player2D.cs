using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2D : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    Vector2 velocity;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * 10;

        if (Input.GetKeyDown(KeyCode.Alpha1)) SceneManager.LoadScene(0);
        if (Input.GetKeyDown(KeyCode.Alpha2)) SceneManager.LoadScene(1);
        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit(); // press 2
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }
}
