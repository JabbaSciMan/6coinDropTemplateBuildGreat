using UnityEngine;

public class VerticalBoost : MonoBehaviour
{
    [SerializeField] private float verticalForce = 10f;
    [SerializeField] private string playerTag = "Player";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(playerTag))
        {
            Rigidbody2D playerRb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (playerRb != null)
            {
                playerRb.AddForce(Vector2.up * verticalForce, ForceMode2D.Impulse);
            }
        }
    }
}
