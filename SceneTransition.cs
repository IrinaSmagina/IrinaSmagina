using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneName; // Имя сцены для перехода
    public Vector2 pushBackForce = new Vector2(2f, 0f); // Сила отталкивания игрока

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Rigidbody2D playerRb = collision.GetComponent<Rigidbody2D>();
            if (playerRb != null)
            {
                Vector2 pushDirection = (collision.transform.position - transform.position).normalized;
                playerRb.velocity = pushDirection * pushBackForce;
            }
            
            SceneManager.LoadScene(sceneName);
        }
    }
}