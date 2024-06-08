using UnityEngine;

public class Sky : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed;

    private Material skybox;

    private void Awake()
    {
        skybox = RenderSettings.skybox;

        skybox.SetFloat("_Rotation", 0f);
    }

    private void Update()
    {
        skybox.SetFloat("_Rotation", Time.time * rotationSpeed);
    }
}
