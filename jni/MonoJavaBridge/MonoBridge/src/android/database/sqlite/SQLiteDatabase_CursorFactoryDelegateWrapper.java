package android.database.sqlite;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class SQLiteDatabase_CursorFactoryDelegateWrapper extends java.lang.Object implements MonoProxy, android.database.sqlite.SQLiteDatabase.CursorFactory
{
	static
	{
		MonoBridge.link(SQLiteDatabase_CursorFactoryDelegateWrapper.class, "newCursor", "(Landroid/database/sqlite/SQLiteDatabase;Landroid/database/sqlite/SQLiteCursorDriver;Ljava/lang/String;Landroid/database/sqlite/SQLiteQuery;)Landroid/database/Cursor;", "android.database.sqlite.SQLiteDatabase,android.database.sqlite.SQLiteCursorDriver,java.lang.String,android.database.sqlite.SQLiteQuery");

	}

	@Override
	public native android.database.Cursor newCursor(android.database.sqlite.SQLiteDatabase arg0,android.database.sqlite.SQLiteCursorDriver arg1,java.lang.String arg2,android.database.sqlite.SQLiteQuery arg3);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
