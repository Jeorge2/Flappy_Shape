using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_generator_script : MonoBehaviour
{
    public float time_until_next_pipe = 3;
    public float time_passed_since_last_pipe;
    public Transform pipe;
    float last_call;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pipe_spawn = new Vector3(10, Random.Range(3, -3), 0);
        float time = Time.time;
        time_passed_since_last_pipe = Mathf.RoundToInt(time%6000);
        
        bool no_spam = true;
        print(last_call);
        //Mathf.Approximately(time_passed_since_last_pipe, time_until_next_pipe)
        if (time_passed_since_last_pipe == last_call)
        {
                spawn_pipe(pipe, pipe_spawn);
                Vector3 secondSpawn = new Vector3(pipe_spawn.x + 10, Random.Range(3,-3), pipe_spawn.z);
                spawn_pipe(pipe, secondSpawn);
                last_call = time_passed_since_last_pipe + time_until_next_pipe;
        }
    }
    private Transform spawn_pipe(Transform level_part, Vector3 spawnPipePostion)
    {
        Transform levelPartTransform = Instantiate(level_part, spawnPipePostion, Quaternion.identity);
        return levelPartTransform;
    }
}
