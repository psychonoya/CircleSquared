using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;

    public Rigidbody2D rb;

    public string currentColor;

    public SpriteRenderer sr;

    public CameraController cameraController;

    public Color colorRed;
    public Color colorBlue;
    public Color colorYellow;
    public Color colorPurple;

    public bool needsToBePlayed;

    private void Start()
    {
        SetRandomColor();
    }

    void Update()
    {
        
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ColorChanger")
        {
            SetRandomColor();
            Destroy(collision.gameObject);
            return;
        }

        if (collision.tag == currentColor)
        {

        }
        else if(collision.tag != currentColor)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

    public void ObjectiveReached()
    {

    }

    public void SetRandomColor()
    {
        int index = Random.Range(0, 4);
        switch (index)
        {
            case 0:
                currentColor = "Red";
                sr.color = colorRed;
                ObjectiveReached();
                break;
            case 1:
                currentColor = "Blue";
                sr.color = colorBlue;
                ObjectiveReached();
                break;
            case 2:
                currentColor = "Yellow";
                sr.color = colorYellow;
                ObjectiveReached();
                break;
            case 3:
                currentColor = "Purple";
                sr.color = colorPurple;
                ObjectiveReached();
                break;
        }
    }

}
