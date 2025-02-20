using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    private Vector2 _startPos;

    void Start()
    {
        _startPos = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            transform.position = _startPos;
        }
        
    }
}
