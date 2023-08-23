using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bird : MonoBehaviour
{
    [SerializeField] float _launchPower;
    [SerializeField] GameObject loseMenu;
    [SerializeField] GameObject winMenu;

    Vector3 _initialPosition;
    Rigidbody2D rigidBody;
    SpriteRenderer sprite;
    LineRenderer line;
    bool _birdWasLaunched;
    float _timeSittingAround;
    

    void Awake()
    {
        _initialPosition = transform.position;
        rigidBody = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        line = GetComponent<LineRenderer>();
    }

    void Update()
    {
        line.SetPosition(1, _initialPosition);
        line.SetPosition(0, transform.position);
        if (_birdWasLaunched && rigidBody.velocity.magnitude <= 0.1)
        {
            _timeSittingAround += Time.deltaTime;
        }
        if (transform.position.y > 8 || transform.position.y < -8
        || transform.position.x < -20 || transform.position.x > 20
        || _timeSittingAround > 2)
        {
            if(GameObject.FindGameObjectsWithTag("Menu").Length==0)
            {
                Instantiate(loseMenu,Vector3.zero,Quaternion.identity);
                gameObject.SetActive(false);
            }
        }
        if (GameObject.FindGameObjectsWithTag("Pet").Length == 0)
        {
            if(GameObject.FindGameObjectsWithTag("Menu").Length==0) 
            {
                Instantiate(winMenu,Vector3.zero,Quaternion.identity);
                gameObject.SetActive(false);
            }
        }

    }

    void OnMouseDown()
    {
        sprite.color = new UnityEngine.Color(212f / 255f, 207f / 255f, 207f / 255f);
        line.enabled = true;
    }

    void OnMouseUp()
    {
        sprite.color = UnityEngine.Color.white;
        var directionToInitialPosition = _initialPosition - transform.position;
        rigidBody.AddForce(directionToInitialPosition * _launchPower);
        rigidBody.gravityScale = 1;
        _birdWasLaunched = true;
        line.enabled = false;
    }

    void OnMouseDrag()
    {
        var newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = 0f;
        transform.position = newPosition;
    }
}
