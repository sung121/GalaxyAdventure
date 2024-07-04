using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    Player player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("PLAYER").GetComponent<Player>();
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject gameObject = other.transform.root.gameObject;
        
        if (gameObject.GetComponent<Unit>() != null)
        {
            Unit unit = gameObject.GetComponent<Unit>();
            unit.Hit(player.power * 5);
        }

        Destroy(this.gameObject, 4.0f);

    }
}
