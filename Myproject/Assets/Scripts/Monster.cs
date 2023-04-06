using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Monster : MonoBehaviour
{
    [SerializeField] private float speed;
    public Transform[] monsters;

    private float StartpositionX;
    
    private float rightPosX = 0f;

    private GameObject WaitingLine;
    private float waitwaitingLineX;


    // Start is called before the first frame update
    void Start()
    {
        StartpositionX = GetComponent<Transform>().position.x;

        rightPosX = waitwaitingLineX + 24f;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < monsters.Length; i++)
        {
            monsters[i].position += new Vector3(-speed, 0, 0) * Time.deltaTime;

            if (monsters[i].position.x < waitwaitingLineX)
            {
                Vector3 nextPos = monsters[i].position;
                nextPos = new Vector3(nextPos.x + rightPosX, nextPos.y, nextPos.z);
                monsters[i].position = nextPos;
            }
        }
    }
}
