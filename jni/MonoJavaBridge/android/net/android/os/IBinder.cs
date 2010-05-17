namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface IBinder 
	{ 
		void dump(java.io.FileDescriptor arg0, java.lang.String[] arg1); 
		java.lang.String getInterfaceDescriptor(); 
		bool pingBinder(); 
		bool isBinderAlive(); 
		android.os.IInterface queryLocalInterface(java.lang.String arg0); 
		bool transact(int arg0, android.os.Parcel arg1, android.os.Parcel arg2, int arg3); 
		void linkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1); 
		bool unlinkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1); 
	} 
} 
