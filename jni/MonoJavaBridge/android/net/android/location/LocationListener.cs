namespace android.location 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface LocationListener 
	{ 
		void onStatusChanged(java.lang.String arg0, int arg1, android.os.Bundle arg2); 
		void onLocationChanged(android.location.Location arg0); 
		void onProviderEnabled(java.lang.String arg0); 
		void onProviderDisabled(java.lang.String arg0); 
	} 
} 
