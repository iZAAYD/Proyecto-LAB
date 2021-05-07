using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogController


    {
        public string email, password, userID, userName;


        public LogController(string _pass, string _email, string _name, string _id)
        {
            this.email = _email;
            this.password = _pass;
            this.userID = _id;
            this.userName = _name;

        }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
