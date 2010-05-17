namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Cursor 
	{ 
		short getShort(int arg0); 
		int getInt(int arg0); 
		long getLong(int arg0); 
		float getFloat(int arg0); 
		double getDouble(int arg0); 
		void close(); 
		java.lang.String getString(int arg0); 
		bool isFirst(); 
		bool isClosed(); 
		int getPosition(); 
		android.os.Bundle getExtras(); 
		void registerContentObserver(android.database.ContentObserver arg0); 
		void unregisterContentObserver(android.database.ContentObserver arg0); 
		int getCount(); 
		bool move(int arg0); 
		bool moveToPosition(int arg0); 
		bool moveToFirst(); 
		bool moveToLast(); 
		bool moveToNext(); 
		bool moveToPrevious(); 
		bool isLast(); 
		bool isBeforeFirst(); 
		bool isAfterLast(); 
		int getColumnIndex(java.lang.String arg0); 
		int getColumnIndexOrThrow(java.lang.String arg0); 
		java.lang.String getColumnName(int arg0); 
		java.lang.String[] getColumnNames(); 
		int getColumnCount(); 
		byte[] getBlob(int arg0); 
		void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1); 
		bool isNull(int arg0); 
		void deactivate(); 
		bool requery(); 
		void registerDataSetObserver(android.database.DataSetObserver arg0); 
		void unregisterDataSetObserver(android.database.DataSetObserver arg0); 
		void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1); 
		bool getWantsAllOnMoveCalls(); 
		android.os.Bundle respond(android.os.Bundle arg0); 
	} 
} 
