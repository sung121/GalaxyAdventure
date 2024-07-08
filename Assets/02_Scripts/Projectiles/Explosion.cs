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
        UnitBase unit = gameObject.GetComponent<UnitBase>();

        if (unit == null)
        {
            return;
        }

        if (unit.teamType == TeamType.ALLY)
        {
            return;
        }

        unit.Hit(player.power * 20);

        Destroy(this.gameObject, 4.0f);

    }
}
