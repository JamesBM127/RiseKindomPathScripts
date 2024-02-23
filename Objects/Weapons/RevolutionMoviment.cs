using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolutionMoviment : MonoBehaviour
{
    public GameObject character; // Refer�ncia ao Transform do Sol
    public float orbitSpeed = -100f; // Velocidade de �rbita (em graus por segundo)
    public float orbitRadius = 2f; // Raio da �rbita
    private Vector3 orbitPosition; // Posi��o da �rbita
    private float currentAngle = 0f; // �ngulo atual

    void Start()
    {
        character = GameObject.Find("!Character11_0 (1)");
        //character = this.transform.parent;
    }
    
    void Update()
    {
        // Atualiza o �ngulo
        currentAngle += orbitSpeed * Time.deltaTime;

        // Calcula a nova posi��o orbital usando trigonometria
        float x = Mathf.Cos(currentAngle * Mathf.Deg2Rad) * orbitRadius;
        float y = Mathf.Sin(currentAngle * Mathf.Deg2Rad) * orbitRadius;
        orbitPosition = new Vector2(x, y);

        // Define a posi��o do planeta em rela��o � posi��o orbital e ao Sol
        transform.position = character.transform.position + orbitPosition;
    }
}
