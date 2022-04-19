using UnityEngine.SceneManagement;
using UnityEngine;

public class Bird : MonoBehaviour
{

    private Vector3 _initialPosition;
    private bool _birdWasLaunched;
    private float _timeSittingAround;

    private void Awake()
    {
        _initialPosition = transform.position;
    }

    private void Update()
    {
        GetComponent<LineRenderer>().SetPosition(0, transform.position);
        GetComponent<LineRenderer>().SetPosition(1, _initialPosition);
       

        if(_birdWasLaunched && GetComponent<Rigidbody2D>().velocity.magnitude <= 0.1)
        {
            _timeSittingAround += Time.deltaTime;
        }


        if(transform.position.y> 20||
            transform.position.y<-20||
            transform.position.x>20||
            transform.position.x < -20||
            _timeSittingAround > 3)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
            _birdWasLaunched = true;
        }
    }
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;

        GetComponent<LineRenderer>().enabled = true;
    }
    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;

        Vector3 directionToInitialPosition = _initialPosition - transform.position;

        GetComponent<Rigidbody2D>().AddForce(directionToInitialPosition * 250);
        GetComponent<Rigidbody2D>().gravityScale = 1;

        GetComponent<LineRenderer>().enabled = false;
    }
   
    private void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x, newPosition.y);
    }
}
