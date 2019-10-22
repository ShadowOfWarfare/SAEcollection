using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager2 : MonoBehaviour
{
    //alternative camera code done by Rohith Maddali
    private Vector3 startingPos;
    private Vector3 newPos;
    public float maxHeight;
    private float distBetweenPlayers;
    public float panSpeed;

    private GameObject player1;
    private GameObject player2;



    // Start is called before the first frame update
    void Start()
    {
        //store initial position of the camera.
        startingPos = transform.position;
        newPos = startingPos;
        newPos.y = maxHeight;
        player1 = GameObject.FindGameObjectWithTag("Player 1");
        player2 = GameObject.FindGameObjectWithTag("Player 2");
        distBetweenPlayers = Vector3.Distance(player1.transform.position, player2.transform.position);
        newPos.y = maxHeight;
        transform.position = Vector3.Lerp(startingPos, newPos, (distBetweenPlayers / maxHeight) * panSpeed);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
