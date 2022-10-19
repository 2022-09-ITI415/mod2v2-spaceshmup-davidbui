using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePhaser : MonoBehaviour
{
    public float ProjectileSpawnTime;
    public float speed;
    public float x0;
    public float waveFrequency;
    public float waveWidth;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        ProjectileSpawnTime = Time.time;
        x0 = this.transform.position.x;
        waveFrequency = 3;
        waveWidth = 6;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 tempPos = this.transform.position;
        
        float age = Time.time - ProjectileSpawnTime;
        float theta = Mathf.PI * 2 * age / waveFrequency;
        float sin = Mathf.Sin(theta);
        tempPos.x = x0 + waveWidth * sin;
        tempPos.y += Time.deltaTime * speed;
        this.transform.position = tempPos;
    }
}
