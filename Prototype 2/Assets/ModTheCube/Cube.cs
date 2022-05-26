using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        int randomInt = Random.Range(0, 6);
        float randomFloat = Random.Range(0.0f, 1.0f);

        transform.position = new Vector3(randomInt, randomInt, randomInt);
        transform.localScale = Vector3.one * randomInt;
        
        Material material = Renderer.material;
        
        material.color = new Color(randomFloat, randomFloat, randomFloat, randomFloat);
    }
    
    void Update()
    {
        float _randomFloat = Random.Range(0.0f, 5.0f);
        float deltaFloat = _randomFloat * Time.deltaTime;

        //rotation
        transform.Rotate(deltaFloat, deltaFloat, deltaFloat);

        //color
        Material material = Renderer.material;
        material.color = new Color(deltaFloat, deltaFloat, deltaFloat, deltaFloat);
    }
}
