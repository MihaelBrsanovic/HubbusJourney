using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Gegner", menuName = "Gegner", order = 52)]
public class GegnerSpawn : ScriptableObject  //Ist für das spawnen der Gegner zuständig
{
    public GameObject[] gegner;
    public Vector2[] moeglichePositionen = { new Vector2(6f, 0.5f), new Vector2(3.8f, -1.5f), new Vector2(6f, -3.5f) };
    public Transform[] gegnerPositionen = new Transform[3];
    public void SpawnStartEnemy()
    {
        string[] gegnerID = Lesen.lesen();
        for (int i = 0; i < 3; i++)
        {
            // gegnerPositionen[i] = Instantiate(gegner[int.Parse(gegnerID[i])], moeglichePositionen[i], Quaternion.identity, ResourceScript.enemyContainer).transform;
        }
    }
    public void SpawnEnemyAutomatic(int index)  //Default Positionen
    {
        int posIndex = FreiePosition();
        if (posIndex != -1 && index != 0) {
            // gegnerPositionen[posIndex] = Instantiate(gegner[index], moeglichePositionen[posIndex], Quaternion.identity, ResourceScript.enemyContainer).transform;
        }
        
    }
    public void SpawnEnemy(int index, Vector2 position)     //Prosciutto
    {
        int posIndex = FreiePosition();
        if (posIndex != -1)
        {
            // gegnerPositionen[posIndex] = Instantiate(gegner[index], position, Quaternion.identity, ResourceScript.enemyContainer).transform;
        }
    }
    public void SpawnEnemyRandom(Vector2 position)
    {
        // Instantiate(gegner[Random.Range(0, gegner.Length - 1)], position, Quaternion.identity, ResourceScript.enemyContainer);
    }
    private int FreiePosition()
    {
        for (int i = 0; i < gegnerPositionen.Length; i++)
        {
            if (gegnerPositionen[i] != null)
            {
                if (!gegnerPositionen[i].gameObject.activeSelf) return i;
            }
        }
        return -1;
    }
}



