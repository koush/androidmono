namespace android.database.sqlite 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SQLiteCursorDriver 
	{ 
		android.database.Cursor query(android.database.sqlite.SQLiteDatabase.CursorFactory arg0, java.lang.String[] arg1); 
		void cursorDeactivated(); 
		void cursorRequeried(android.database.Cursor arg0); 
		void cursorClosed(); 
		void setBindArguments(java.lang.String[] arg0); 
	} 
} 
