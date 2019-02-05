using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallOff : MonoBehaviour
{

    public Transform player;
    public float height;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        height = player.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.position.y < height - 5f)
        {
            text.text = "Loser!";
        }
        if(player.position.z > 300)
        {
            text.text = "Winner!";
        }
    }
}
