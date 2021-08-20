using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes  
{

    int _health;
    int _power;
    string _name;

    public Classes(int health, int power, string name)
    {
        _health = health;
        _power = power;
        _name = name;

    }  
        public void Info()
        {
            Debug.Log(_health);
            Debug.Log(_power);
            Debug.Log(_name);

        }

    }

/*
     Classes Helloworld;
    private void Start()
    {
        Helloworld = new Classes(1, 2, "Hello world");

        Helloworld.Info();
    
    }
    
 
 
 */
//classes
