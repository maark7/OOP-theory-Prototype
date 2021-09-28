using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour
{
    public GameObject car;
    public GameObject tank;
    public GameObject truck;
    public GameObject miniTruck;

    public Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CarCam()
    {
        int carPos = (int)car.transform.position.x; 
        offset = new Vector3( carPos, 4.5f, -6);
        transform.position = car.transform.position + offset;
    }

    public void TankCam()
    {
        int tankPos = (int)tank.transform.position.x - 20; 
        offset = new Vector3(tankPos, 4.5f, -6);
        transform.position = tank.transform.position + offset;
    }

    public void TruckkCam()
    {
        int truckkPos = (int)truck.transform.position.x - 40; 
        offset = new Vector3(truckkPos, 4.5f, -6);
        transform.position = truck.transform.position + offset;
    }

    public void M_TruckkCam()
    {
        int m_truckPos = (int)miniTruck.transform.position.x + 20; 
        offset = new Vector3(m_truckPos, 4.5f, -6);
        transform.position = miniTruck.transform.position + offset;
    }
}
