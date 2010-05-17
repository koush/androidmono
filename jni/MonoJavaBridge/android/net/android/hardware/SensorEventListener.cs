namespace android.hardware 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SensorEventListener 
	{ 
		void onSensorChanged(android.hardware.SensorEvent arg0); 
		void onAccuracyChanged(android.hardware.Sensor arg0, int arg1); 
	} 
} 
