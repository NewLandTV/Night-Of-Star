using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField]
    private float amount;
    private float time;

    private Vector3 initialPosition;

    private void Awake()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        if (time <= 0f)
        {
            return;
        }

        if (time > 0)
        {
            transform.position = Random.insideUnitSphere * amount + initialPosition;
            time -= Time.deltaTime;

            return;
        }

        transform.position = initialPosition;
        time = 0f;
    }

    public void Shake(float time)
    {
        this.time = time;
    }
}
