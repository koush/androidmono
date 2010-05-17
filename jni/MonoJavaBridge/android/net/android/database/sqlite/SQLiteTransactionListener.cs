namespace android.database.sqlite 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SQLiteTransactionListener 
	{ 
		void onBegin(); 
		void onCommit(); 
		void onRollback(); 
	} 
} 
