#define sensor_pin A0
#define threshold 700

int led = D6;




void setup() {

    pinMode(led, OUTPUT);
    

}

void loop() {
    
    
        int lightlevel = analogRead(sensor_pin);
    
    
        if(lightlevel > threshold)
        {
            digitalWrite(led, HIGH);
            delay(5000);
            //In real world application delay can be a higher number to prevent sending too many notifications
        
            Particle.publish("sunlight", "bright");
        
        
        }
    
    
        
        
        if(lightlevel<= threshold)
        {
            digitalWrite(led, LOW);
            delay(5000);
            //in real world application delay can be a higher number to prevent sending too many notifications
            
            Particle.publish("nosunlight", "dark");
            
            
        }
        
    
}
   


   
    
    
   
    
    
    
    
