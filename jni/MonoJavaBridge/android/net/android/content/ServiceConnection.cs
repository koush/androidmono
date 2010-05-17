namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface ServiceConnection 
	{ 
		void onServiceConnected(android.content.ComponentName arg0, android.os.IBinder arg1); 
		void onServiceDisconnected(android.content.ComponentName arg0); 
	} 
} 
