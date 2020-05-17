using UnityEngine;

public class PatternManagerScript : MonoBehaviour
{

    public Transform reference;
    GameObject[] CurrentlyActive = new GameObject[5];
    int CurrentlyActiveIndex = 0;
    public GameObject[] Patterns;
    public int startingDistance = 100;
    int StartSpawn = -1;
    public int distanceBetween = 60;
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Spawn();
        }
    }
    public void PatternTrigger()
    {
        if (StartSpawn <= 0)
        {
            StartSpawn++;
        }
        else
        {
            DestroyPattern();
            Spawn();
        }
    }

    void Spawn()
    {
        CurrentlyActive[CurrentlyActiveIndex] = Instantiate(Patterns[Random.Range(0, Patterns.Length)], new Vector3(0, 1, startingDistance), reference.rotation);
        startingDistance += distanceBetween;
        CurrentlyActiveIndex++;
    }

    void DestroyPattern()
    {
        CurrentlyActiveIndex--;
        Destroy(CurrentlyActive[0]);
        for (int i = 0; i < 4; i++)
        {
            CurrentlyActive[i] = CurrentlyActive[i + 1];
        }
    }
}