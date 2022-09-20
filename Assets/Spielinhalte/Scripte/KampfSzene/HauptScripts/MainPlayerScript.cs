using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using TMPro;

public class MainPlayerScript : MonoBehaviour //Bezieht sich auf das Verhalten des Spielers.Hier steht, wie sich der Spieler bewegt, Schaden bekommt, mit Objekten kollidiert,…
{
    private PlayerStats playerstats;
    private bool moveable;
    [SerializeField] private PlayerUIElement[] playerUIElements;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        playerstats = new PlayerStats();
        moveable = false;
    }

    // Update is called once per frame
    void Update()
    {
        Keyboard key = Keyboard.current;
        Vector3 moveForce = new Vector3(0, 0);
        if (key.wKey.isPressed) moveForce += new Vector3(0, 1);
        if (key.aKey.isPressed) moveForce += new Vector3(-1, 0);
        if (key.sKey.isPressed) moveForce += new Vector3(0, -1);
        if (key.dKey.isPressed) moveForce += new Vector3(1, 0, 0);

        if (moveForce.x != 0 && moveForce.y != 0) moveForce *= 0.7f;
        this.transform.position += moveForce * Time.deltaTime * 3.2f * playerstats.GetSpeedMult();
    }
    public void TakeDamage(int damage)
    {
        if(!playerstats.LowerHp(damage)) Die();
        UpdatePlayerUI();
    }
    private void UpdatePlayerUI()
    {
        playerstats.SetPlayerPosition(this.transform.position);
        /**
        foreach(PlayerUIElement element in playerUIElements)
        {
            element.UpdateUI(playerstats);
        }
        **/
    }
    public void Die()
    {
        // animator
        moveable = false;
    }
}

public class PlayerStats
{
    private int hp, maxHp;
    private float damageTakenMult, damageDealtMult, speedMult;
    private Vector3 position;

    public PlayerStats()
    {
        hp = 1000; maxHp = 1000;
        damageTakenMult = 1f; damageDealtMult = 1f; speedMult = 1f;
    }
    public void SetHp(int hp) => this.hp = hp;
    public void SetMaxHp(int maxHp) => this.maxHp = maxHp;
    public float GetSpeedMult() { return speedMult; }

    public void SetPlayerPosition(Vector3 position) => this.position = position;
    public bool LowerHp(int change)
    {
        if(hp - (change * damageTakenMult) <= 0)
        {
            hp = 0;
            return false;
        }
        hp -= (int)(change * damageTakenMult);
        return true;
    }
    public void IncreaseHp(int change)
    {
        if (hp + change > maxHp) hp = maxHp;
        else hp += change;
    }
}