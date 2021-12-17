using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] private float fireRate = 0.5f;
    [SerializeField] private float bulletSpeed = 20f;
    
    private float lastTime;

    void Update()
    {
        if (Time.time - lastTime > fireRate)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ObjectPoolSpawn();
                FindObjectOfType<AudioManager>().Play("Shoot");
            }
        }
    }

    private void ObjectPoolSpawn()
    {
        lastTime = Time.time;

        Vector2 position = transform.position;

        var bullet = BasicPool.Instance.GetFromPool();
        bullet.transform.position = position;

        Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
        rigidbody.velocity = transform.up * bulletSpeed * Time.deltaTime;
    }
}
