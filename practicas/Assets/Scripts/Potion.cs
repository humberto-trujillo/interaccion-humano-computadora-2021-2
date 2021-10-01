using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

[CreateAssetMenu(fileName = "Potion", menuName = "Inventory/Potion")]
public class Potion : Item
{
    public float lifeGain;
    public float magicGain;

    [Range(0f, 10f)]
    public float speedGain = 5f;
    [Range(0f, 10f)]
    public float jumpHeightGain = 1f;

    private FirstPersonController _player;

    public override void Use()
    {
        base.Use();
        _player = FindObjectOfType<FirstPersonController>();
        _player.MoveSpeed += speedGain;
        _player.JumpHeight += jumpHeightGain;
        // respawn del objeto...
    }
}
