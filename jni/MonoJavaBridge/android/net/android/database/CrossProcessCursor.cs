namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface CrossProcessCursor : Cursor
	{ 
		android.database.CursorWindow getWindow(); 
		bool onMove(int arg0, int arg1); 
		void fillWindow(int arg0, android.database.CursorWindow arg1); 
	} 
} 
