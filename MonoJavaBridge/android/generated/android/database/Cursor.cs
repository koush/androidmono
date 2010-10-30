namespace android.database
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.database.Cursor_))]
	public partial interface Cursor  : global::MonoJavaBridge.IJavaObject 
	{
		short getShort(int arg0);
		int getInt(int arg0);
		long getLong(int arg0);
		float getFloat(int arg0);
		double getDouble(int arg0);
		void close();
		global::java.lang.String getString(int arg0);
		bool isFirst();
		bool isClosed();
		int getPosition();
		global::android.os.Bundle getExtras();
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
		global::java.lang.String getColumnName(int arg0);
		global::java.lang.String[] getColumnNames();
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
		global::android.os.Bundle respond(android.os.Bundle arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.Cursor))]
	internal sealed partial class Cursor_ : java.lang.Object, Cursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Cursor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getShort4476;
		short android.database.Cursor.getShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.database.Cursor_.staticClass, "getShort", "(I)S", ref global::android.database.Cursor_._getShort4476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt4477;
		int android.database.Cursor.getInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.Cursor_.staticClass, "getInt", "(I)I", ref global::android.database.Cursor_._getInt4477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong4478;
		long android.database.Cursor.getLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.Cursor_.staticClass, "getLong", "(I)J", ref global::android.database.Cursor_._getLong4478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat4479;
		float android.database.Cursor.getFloat(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.database.Cursor_.staticClass, "getFloat", "(I)F", ref global::android.database.Cursor_._getFloat4479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble4480;
		double android.database.Cursor.getDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.database.Cursor_.staticClass, "getDouble", "(I)D", ref global::android.database.Cursor_._getDouble4480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close4481;
		void android.database.Cursor.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Cursor_.staticClass, "close", "()V", ref global::android.database.Cursor_._close4481);
		}
		internal static global::MonoJavaBridge.MethodId _getString4482;
		global::java.lang.String android.database.Cursor.getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.Cursor_.staticClass, "getString", "(I)Ljava/lang/String;", ref global::android.database.Cursor_._getString4482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isFirst4483;
		bool android.database.Cursor.isFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "isFirst", "()Z", ref global::android.database.Cursor_._isFirst4483);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed4484;
		bool android.database.Cursor.isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "isClosed", "()Z", ref global::android.database.Cursor_._isClosed4484);
		}
		internal static global::MonoJavaBridge.MethodId _getPosition4485;
		int android.database.Cursor.getPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.Cursor_.staticClass, "getPosition", "()I", ref global::android.database.Cursor_._getPosition4485);
		}
		internal static global::MonoJavaBridge.MethodId _getExtras4486;
		global::android.os.Bundle android.database.Cursor.getExtras()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.database.Cursor_.staticClass, "getExtras", "()Landroid/os/Bundle;", ref global::android.database.Cursor_._getExtras4486) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver4487;
		void android.database.Cursor.registerContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Cursor_.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V", ref global::android.database.Cursor_._registerContentObserver4487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver4488;
		void android.database.Cursor.unregisterContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Cursor_.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V", ref global::android.database.Cursor_._unregisterContentObserver4488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCount4489;
		int android.database.Cursor.getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.Cursor_.staticClass, "getCount", "()I", ref global::android.database.Cursor_._getCount4489);
		}
		internal static global::MonoJavaBridge.MethodId _move4490;
		bool android.database.Cursor.move(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "move", "(I)Z", ref global::android.database.Cursor_._move4490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToPosition4491;
		bool android.database.Cursor.moveToPosition(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "moveToPosition", "(I)Z", ref global::android.database.Cursor_._moveToPosition4491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToFirst4492;
		bool android.database.Cursor.moveToFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "moveToFirst", "()Z", ref global::android.database.Cursor_._moveToFirst4492);
		}
		internal static global::MonoJavaBridge.MethodId _moveToLast4493;
		bool android.database.Cursor.moveToLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "moveToLast", "()Z", ref global::android.database.Cursor_._moveToLast4493);
		}
		internal static global::MonoJavaBridge.MethodId _moveToNext4494;
		bool android.database.Cursor.moveToNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "moveToNext", "()Z", ref global::android.database.Cursor_._moveToNext4494);
		}
		internal static global::MonoJavaBridge.MethodId _moveToPrevious4495;
		bool android.database.Cursor.moveToPrevious()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "moveToPrevious", "()Z", ref global::android.database.Cursor_._moveToPrevious4495);
		}
		internal static global::MonoJavaBridge.MethodId _isLast4496;
		bool android.database.Cursor.isLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "isLast", "()Z", ref global::android.database.Cursor_._isLast4496);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst4497;
		bool android.database.Cursor.isBeforeFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "isBeforeFirst", "()Z", ref global::android.database.Cursor_._isBeforeFirst4497);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast4498;
		bool android.database.Cursor.isAfterLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "isAfterLast", "()Z", ref global::android.database.Cursor_._isAfterLast4498);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndex4499;
		int android.database.Cursor.getColumnIndex(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.Cursor_.staticClass, "getColumnIndex", "(Ljava/lang/String;)I", ref global::android.database.Cursor_._getColumnIndex4499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndexOrThrow4500;
		int android.database.Cursor.getColumnIndexOrThrow(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.Cursor_.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I", ref global::android.database.Cursor_._getColumnIndexOrThrow4500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName4501;
		global::java.lang.String android.database.Cursor.getColumnName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.Cursor_.staticClass, "getColumnName", "(I)Ljava/lang/String;", ref global::android.database.Cursor_._getColumnName4501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames4502;
		global::java.lang.String[] android.database.Cursor.getColumnNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.database.Cursor_.staticClass, "getColumnNames", "()[Ljava/lang/String;", ref global::android.database.Cursor_._getColumnNames4502) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount4503;
		int android.database.Cursor.getColumnCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.Cursor_.staticClass, "getColumnCount", "()I", ref global::android.database.Cursor_._getColumnCount4503);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob4504;
		byte[] android.database.Cursor.getBlob(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.database.Cursor_.staticClass, "getBlob", "(I)[B", ref global::android.database.Cursor_._getBlob4504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer4505;
		void android.database.Cursor.copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Cursor_.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", ref global::android.database.Cursor_._copyStringToBuffer4505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNull4506;
		bool android.database.Cursor.isNull(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "isNull", "(I)Z", ref global::android.database.Cursor_._isNull4506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deactivate4507;
		void android.database.Cursor.deactivate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Cursor_.staticClass, "deactivate", "()V", ref global::android.database.Cursor_._deactivate4507);
		}
		internal static global::MonoJavaBridge.MethodId _requery4508;
		bool android.database.Cursor.requery()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "requery", "()Z", ref global::android.database.Cursor_._requery4508);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver4509;
		void android.database.Cursor.registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Cursor_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.database.Cursor_._registerDataSetObserver4509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver4510;
		void android.database.Cursor.unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Cursor_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.database.Cursor_._unregisterDataSetObserver4510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationUri4511;
		void android.database.Cursor.setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Cursor_.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", ref global::android.database.Cursor_._setNotificationUri4511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getWantsAllOnMoveCalls4512;
		bool android.database.Cursor.getWantsAllOnMoveCalls()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "getWantsAllOnMoveCalls", "()Z", ref global::android.database.Cursor_._getWantsAllOnMoveCalls4512);
		}
		internal static global::MonoJavaBridge.MethodId _respond4513;
		global::android.os.Bundle android.database.Cursor.respond(android.os.Bundle arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.database.Cursor_.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", ref global::android.database.Cursor_._respond4513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Bundle;
		}
		static Cursor_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.Cursor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/Cursor"));
		}
		internal static void InitJNI()
		{
		}
	}
}
