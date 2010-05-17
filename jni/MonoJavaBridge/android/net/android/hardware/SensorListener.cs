namespace android.hardware 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SensorListener 
	{ 
		void onSensorChanged(int arg0, float[] arg1); 
		void onAccuracyChanged(int arg0, int arg1); 
	} 
} 
