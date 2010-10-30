namespace android.database
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.database.CrossProcessCursor_))]
	public partial interface CrossProcessCursor : Cursor
	{
		global::android.database.CursorWindow getWindow();
		bool onMove(int arg0, int arg1);
		void fillWindow(int arg0, android.database.CursorWindow arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.CrossProcessCursor))]
	internal sealed partial class CrossProcessCursor_ : java.lang.Object, CrossProcessCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CrossProcessCursor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getWindow4435;
		global::android.database.CursorWindow android.database.CrossProcessCursor.getWindow()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getWindow", "()Landroid/database/CursorWindow;", ref global::android.database.CrossProcessCursor_._getWindow4435) as android.database.CursorWindow;
		}
		internal static global::MonoJavaBridge.MethodId _onMove4436;
		bool android.database.CrossProcessCursor.onMove(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "onMove", "(II)Z", ref global::android.database.CrossProcessCursor_._onMove4436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fillWindow4437;
		void android.database.CrossProcessCursor.fillWindow(int arg0, android.database.CursorWindow arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CrossProcessCursor_.staticClass, "fillWindow", "(ILandroid/database/CursorWindow;)V", ref global::android.database.CrossProcessCursor_._fillWindow4437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getShort4438;
		short android.database.Cursor.getShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getShort", "(I)S", ref global::android.database.CrossProcessCursor_._getShort4438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt4439;
		int android.database.Cursor.getInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getInt", "(I)I", ref global::android.database.CrossProcessCursor_._getInt4439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong4440;
		long android.database.Cursor.getLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getLong", "(I)J", ref global::android.database.CrossProcessCursor_._getLong4440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat4441;
		float android.database.Cursor.getFloat(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getFloat", "(I)F", ref global::android.database.CrossProcessCursor_._getFloat4441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble4442;
		double android.database.Cursor.getDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getDouble", "(I)D", ref global::android.database.CrossProcessCursor_._getDouble4442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close4443;
		void android.database.Cursor.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CrossProcessCursor_.staticClass, "close", "()V", ref global::android.database.CrossProcessCursor_._close4443);
		}
		internal static global::MonoJavaBridge.MethodId _getString4444;
		global::java.lang.String android.database.Cursor.getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.CrossProcessCursor_.staticClass, "getString", "(I)Ljava/lang/String;", ref global::android.database.CrossProcessCursor_._getString4444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isFirst4445;
		bool android.database.Cursor.isFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "isFirst", "()Z", ref global::android.database.CrossProcessCursor_._isFirst4445);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed4446;
		bool android.database.Cursor.isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "isClosed", "()Z", ref global::android.database.CrossProcessCursor_._isClosed4446);
		}
		internal static global::MonoJavaBridge.MethodId _getPosition4447;
		int android.database.Cursor.getPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getPosition", "()I", ref global::android.database.CrossProcessCursor_._getPosition4447);
		}
		internal static global::MonoJavaBridge.MethodId _getExtras4448;
		global::android.os.Bundle android.database.Cursor.getExtras()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.database.CrossProcessCursor_.staticClass, "getExtras", "()Landroid/os/Bundle;", ref global::android.database.CrossProcessCursor_._getExtras4448) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver4449;
		void android.database.Cursor.registerContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CrossProcessCursor_.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V", ref global::android.database.CrossProcessCursor_._registerContentObserver4449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver4450;
		void android.database.Cursor.unregisterContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CrossProcessCursor_.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V", ref global::android.database.CrossProcessCursor_._unregisterContentObserver4450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCount4451;
		int android.database.Cursor.getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getCount", "()I", ref global::android.database.CrossProcessCursor_._getCount4451);
		}
		internal static global::MonoJavaBridge.MethodId _move4452;
		bool android.database.Cursor.move(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "move", "(I)Z", ref global::android.database.CrossProcessCursor_._move4452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToPosition4453;
		bool android.database.Cursor.moveToPosition(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "moveToPosition", "(I)Z", ref global::android.database.CrossProcessCursor_._moveToPosition4453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToFirst4454;
		bool android.database.Cursor.moveToFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "moveToFirst", "()Z", ref global::android.database.CrossProcessCursor_._moveToFirst4454);
		}
		internal static global::MonoJavaBridge.MethodId _moveToLast4455;
		bool android.database.Cursor.moveToLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "moveToLast", "()Z", ref global::android.database.CrossProcessCursor_._moveToLast4455);
		}
		internal static global::MonoJavaBridge.MethodId _moveToNext4456;
		bool android.database.Cursor.moveToNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "moveToNext", "()Z", ref global::android.database.CrossProcessCursor_._moveToNext4456);
		}
		internal static global::MonoJavaBridge.MethodId _moveToPrevious4457;
		bool android.database.Cursor.moveToPrevious()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "moveToPrevious", "()Z", ref global::android.database.CrossProcessCursor_._moveToPrevious4457);
		}
		internal static global::MonoJavaBridge.MethodId _isLast4458;
		bool android.database.Cursor.isLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "isLast", "()Z", ref global::android.database.CrossProcessCursor_._isLast4458);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst4459;
		bool android.database.Cursor.isBeforeFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "isBeforeFirst", "()Z", ref global::android.database.CrossProcessCursor_._isBeforeFirst4459);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast4460;
		bool android.database.Cursor.isAfterLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "isAfterLast", "()Z", ref global::android.database.CrossProcessCursor_._isAfterLast4460);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndex4461;
		int android.database.Cursor.getColumnIndex(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getColumnIndex", "(Ljava/lang/String;)I", ref global::android.database.CrossProcessCursor_._getColumnIndex4461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndexOrThrow4462;
		int android.database.Cursor.getColumnIndexOrThrow(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I", ref global::android.database.CrossProcessCursor_._getColumnIndexOrThrow4462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName4463;
		global::java.lang.String android.database.Cursor.getColumnName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.CrossProcessCursor_.staticClass, "getColumnName", "(I)Ljava/lang/String;", ref global::android.database.CrossProcessCursor_._getColumnName4463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames4464;
		global::java.lang.String[] android.database.Cursor.getColumnNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.database.CrossProcessCursor_.staticClass, "getColumnNames", "()[Ljava/lang/String;", ref global::android.database.CrossProcessCursor_._getColumnNames4464) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount4465;
		int android.database.Cursor.getColumnCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getColumnCount", "()I", ref global::android.database.CrossProcessCursor_._getColumnCount4465);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob4466;
		byte[] android.database.Cursor.getBlob(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.database.CrossProcessCursor_.staticClass, "getBlob", "(I)[B", ref global::android.database.CrossProcessCursor_._getBlob4466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer4467;
		void android.database.Cursor.copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CrossProcessCursor_.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", ref global::android.database.CrossProcessCursor_._copyStringToBuffer4467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNull4468;
		bool android.database.Cursor.isNull(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "isNull", "(I)Z", ref global::android.database.CrossProcessCursor_._isNull4468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deactivate4469;
		void android.database.Cursor.deactivate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CrossProcessCursor_.staticClass, "deactivate", "()V", ref global::android.database.CrossProcessCursor_._deactivate4469);
		}
		internal static global::MonoJavaBridge.MethodId _requery4470;
		bool android.database.Cursor.requery()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "requery", "()Z", ref global::android.database.CrossProcessCursor_._requery4470);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver4471;
		void android.database.Cursor.registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CrossProcessCursor_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.database.CrossProcessCursor_._registerDataSetObserver4471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver4472;
		void android.database.Cursor.unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CrossProcessCursor_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.database.CrossProcessCursor_._unregisterDataSetObserver4472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationUri4473;
		void android.database.Cursor.setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CrossProcessCursor_.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", ref global::android.database.CrossProcessCursor_._setNotificationUri4473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getWantsAllOnMoveCalls4474;
		bool android.database.Cursor.getWantsAllOnMoveCalls()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getWantsAllOnMoveCalls", "()Z", ref global::android.database.CrossProcessCursor_._getWantsAllOnMoveCalls4474);
		}
		internal static global::MonoJavaBridge.MethodId _respond4475;
		global::android.os.Bundle android.database.Cursor.respond(android.os.Bundle arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.database.CrossProcessCursor_.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", ref global::android.database.CrossProcessCursor_._respond4475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Bundle;
		}
		static CrossProcessCursor_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.CrossProcessCursor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CrossProcessCursor"));
		}
		internal static void InitJNI()
		{
		}
	}
}
