using UnityEngine;
using System.Collections;
using Uniduino;
 
public class Trigger : MonoBehaviour {
 
    public Arduino arduino;
	
	public int pin = 9;
	
 
    void Start( )
	{
        arduino = Arduino.global;
		arduino.Setup(ConfigurePins);
    }
	
	void ConfigurePins() {
		arduino.pinMode(9, PinMode.SERVO);
	}
		

	void OnTriggerEnter(Collider other) {
	    arduino.analogWrite(pin, 0);
    }
	
	void OnTriggerExit(Collider other) {
		arduino.analogWrite(pin, 180);
	}

}



