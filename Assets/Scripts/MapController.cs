using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    //list of current rooms loaded, should only have 3 at a time
    public List<GameObject> loaded_rooms;
    //all rooms in the game
    public GameObject[] all_rooms;
    //next room to load
    public int room_index = 0;
    //relative spawn position of next room
    public Vector3 offset;
    //coords at which next room gets spawned, modified using offset
    private Vector3 position = new Vector3(0,0,0);

    private void Start()
    {
        Debug.Log(InitRooms());
    }

    public bool InitRooms()
    {
        bool flag = true;
        do
        {
            flag = SpawnRoom(room_index, position);
            room_index++;
            position = position + offset;
        } while (room_index != 2 && flag);

        return flag;
    }

    public bool UpdateRooms()
    {
        DespawnRoom();
        bool flag = SpawnRoom(room_index, position);
        room_index++;
        position += offset;
        return flag;
    }

    private bool SpawnRoom(int index, Vector3 pos)
    {
        if(index >= all_rooms.Length)
        {
            Debug.LogError("Index " + index + " not found in all_rooms");
            return false;
        }
        GameObject temp = Instantiate(all_rooms[index]);
        temp.transform.position = pos;
        loaded_rooms.Add(temp);
        return true;
    }

    private bool DespawnRoom()
    {
        //removes oldest room from list
        if(loaded_rooms.Count < 3)
        {
            Debug.Log("Could not despawn room; fewer than 3 loaded");
            return false;
        }
        Destroy(loaded_rooms[0]);
        loaded_rooms.RemoveAt(0);
        return true;
    }
}
