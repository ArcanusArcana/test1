using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //print("algo paso");
        //x = 0;
        //Debug.LogWarning("Algo salio medio mal");
        // Debug.LogError("Algo salio muy mal");
    }

    // Update is called once per frame
    void Update()
    {
        // x = x + 1;
        // Debug.Log(x);
        Debug.LogError("Hola desde update");
    }

    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde FixedUpdate cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola desde LateUpdate");
    }

    private void OnEnable()
    {
        Debug.LogWarning("El objeto ha sido habilitado");
    }

    private void OnDisable()
    {
        Debug.Log("el objeto ha sido inhabilitado");
    }
}
