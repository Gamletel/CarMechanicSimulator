using UnityEngine;

    public class GlobalVars : MonoBehaviour
    {
        public GameObject car;
        public GameObject[] detailInCar;
        private void Start()
        {
            car = GameObject.FindGameObjectWithTag("Car");
        }
    }
