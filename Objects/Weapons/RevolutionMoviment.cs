using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolutionMoviment : MonoBehaviour
{
    public GameObject character; // Referência ao Transform do Sol
    public float orbitSpeed = -100f; // Velocidade de órbita (em graus por segundo)
    public float orbitRadius = 2f; // Raio da órbita
    private Vector3 orbitPosition; // Posição da órbita
    private float currentAngle = 0f; // Ângulo atual

    void Start()
    {
        character = GameObject.Find("!Character11_0 (1)");
        //character = this.transform.parent;
    }
    
    void Update()
    {
        // Atualiza o ângulo
        currentAngle += orbitSpeed * Time.deltaTime;

        // Calcula a nova posição orbital usando trigonometria
        float x = Mathf.Cos(currentAngle * Mathf.Deg2Rad) * orbitRadius;
        float y = Mathf.Sin(currentAngle * Mathf.Deg2Rad) * orbitRadius;
        orbitPosition = new Vector2(x, y);

        // Define a posição do planeta em relação à posição orbital e ao Sol
        transform.position = character.transform.position + orbitPosition;
    }
}
