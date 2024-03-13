using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    [SerializeField] AsteroidData data;

    float moveSpeed;
    float radius;

    private void OnEnable()
    {
        moveSpeed = Random.Range(data.MoveSpeedRange.x, data.MoveSpeedRange.y);

        radius = Random.Range(data.RadiusRange.x, data.RadiusRange.y);
        transform.localScale = new Vector2(radius, radius);
    }

    // Update is called once per frame
    void Update()
        => transform.position += new Vector3(0.0f, moveSpeed * Time.deltaTime, 0.0f);


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ClearBox"))
            gameObject.SetActive(false); // TODO - Call back to Pool to return
    }
}
