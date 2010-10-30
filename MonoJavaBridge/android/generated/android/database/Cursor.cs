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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._getShort4476.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._getShort4476 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getShort", "(I)S");
			return @__env.CallShortMethod(this.JvmHandle, global::android.database.Cursor_._getShort4476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt4477;
		int android.database.Cursor.getInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._getInt4477.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._getInt4477 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getInt", "(I)I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.database.Cursor_._getInt4477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong4478;
		long android.database.Cursor.getLong(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._getLong4478.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._getLong4478 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getLong", "(I)J");
			return @__env.CallLongMethod(this.JvmHandle, global::android.database.Cursor_._getLong4478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat4479;
		float android.database.Cursor.getFloat(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._getFloat4479.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._getFloat4479 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getFloat", "(I)F");
			return @__env.CallFloatMethod(this.JvmHandle, global::android.database.Cursor_._getFloat4479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble4480;
		double android.database.Cursor.getDouble(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._getDouble4480.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._getDouble4480 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getDouble", "(I)D");
			return @__env.CallDoubleMethod(this.JvmHandle, global::android.database.Cursor_._getDouble4480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close4481;
		void android.database.Cursor.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._close4481.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._close4481 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "close", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._close4481);
		}
		internal static global::MonoJavaBridge.MethodId _getString4482;
		global::java.lang.String android.database.Cursor.getString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._getString4482.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._getString4482 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getString", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.Cursor_._getString4482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isFirst4483;
		bool android.database.Cursor.isFirst()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._isFirst4483.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._isFirst4483 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "isFirst", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._isFirst4483);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed4484;
		bool android.database.Cursor.isClosed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._isClosed4484.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._isClosed4484 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "isClosed", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._isClosed4484);
		}
		internal static global::MonoJavaBridge.MethodId _getPosition4485;
		int android.database.Cursor.getPosition()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._getPosition4485.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._getPosition4485 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getPosition", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.database.Cursor_._getPosition4485);
		}
		internal static global::MonoJavaBridge.MethodId _getExtras4486;
		global::android.os.Bundle android.database.Cursor.getExtras()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._getExtras4486.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._getExtras4486 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getExtras", "()Landroid/os/Bundle;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.Cursor_._getExtras4486)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver4487;
		void android.database.Cursor.registerContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._registerContentObserver4487.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._registerContentObserver4487 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._registerContentObserver4487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver4488;
		void android.database.Cursor.unregisterContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._unregisterContentObserver4488.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._unregisterContentObserver4488 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._unregisterContentObserver4488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCount4489;
		int android.database.Cursor.getCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._getCount4489.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._getCount4489 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getCount", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.database.Cursor_._getCount4489);
		}
		internal static global::MonoJavaBridge.MethodId _move4490;
		bool android.database.Cursor.move(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._move4490.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._move4490 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "move", "(I)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._move4490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToPosition4491;
		bool android.database.Cursor.moveToPosition(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._moveToPosition4491.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._moveToPosition4491 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "moveToPosition", "(I)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._moveToPosition4491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToFirst4492;
		bool android.database.Cursor.moveToFirst()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._moveToFirst4492.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._moveToFirst4492 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "moveToFirst", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._moveToFirst4492);
		}
		internal static global::MonoJavaBridge.MethodId _moveToLast4493;
		bool android.database.Cursor.moveToLast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._moveToLast4493.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._moveToLast4493 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "moveToLast", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._moveToLast4493);
		}
		internal static global::MonoJavaBridge.MethodId _moveToNext4494;
		bool android.database.Cursor.moveToNext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._moveToNext4494.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._moveToNext4494 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "moveToNext", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._moveToNext4494);
		}
		internal static global::MonoJavaBridge.MethodId _moveToPrevious4495;
		bool android.database.Cursor.moveToPrevious()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._moveToPrevious4495.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._moveToPrevious4495 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "moveToPrevious", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._moveToPrevious4495);
		}
		internal static global::MonoJavaBridge.MethodId _isLast4496;
		bool android.database.Cursor.isLast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._isLast4496.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._isLast4496 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "isLast", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._isLast4496);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst4497;
		bool android.database.Cursor.isBeforeFirst()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._isBeforeFirst4497.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._isBeforeFirst4497 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "isBeforeFirst", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._isBeforeFirst4497);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast4498;
		bool android.database.Cursor.isAfterLast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._isAfterLast4498.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._isAfterLast4498 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "isAfterLast", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._isAfterLast4498);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndex4499;
		int android.database.Cursor.getColumnIndex(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._getColumnIndex4499.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._getColumnIndex4499 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.database.Cursor_._getColumnIndex4499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndexOrThrow4500;
		int android.database.Cursor.getColumnIndexOrThrow(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._getColumnIndexOrThrow4500.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._getColumnIndexOrThrow4500 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.database.Cursor_._getColumnIndexOrThrow4500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName4501;
		global::java.lang.String android.database.Cursor.getColumnName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._getColumnName4501.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._getColumnName4501 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.Cursor_._getColumnName4501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames4502;
		global::java.lang.String[] android.database.Cursor.getColumnNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._getColumnNames4502.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._getColumnNames4502 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.Cursor_._getColumnNames4502)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount4503;
		int android.database.Cursor.getColumnCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._getColumnCount4503.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._getColumnCount4503 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getColumnCount", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.database.Cursor_._getColumnCount4503);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob4504;
		byte[] android.database.Cursor.getBlob(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._getBlob4504.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._getBlob4504 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getBlob", "(I)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.Cursor_._getBlob4504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer4505;
		void android.database.Cursor.copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._copyStringToBuffer4505.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._copyStringToBuffer4505 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._copyStringToBuffer4505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNull4506;
		bool android.database.Cursor.isNull(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._isNull4506.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._isNull4506 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "isNull", "(I)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._isNull4506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deactivate4507;
		void android.database.Cursor.deactivate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._deactivate4507.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._deactivate4507 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "deactivate", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._deactivate4507);
		}
		internal static global::MonoJavaBridge.MethodId _requery4508;
		bool android.database.Cursor.requery()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._requery4508.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._requery4508 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "requery", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._requery4508);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver4509;
		void android.database.Cursor.registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._registerDataSetObserver4509.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._registerDataSetObserver4509 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._registerDataSetObserver4509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver4510;
		void android.database.Cursor.unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._unregisterDataSetObserver4510.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._unregisterDataSetObserver4510 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._unregisterDataSetObserver4510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationUri4511;
		void android.database.Cursor.setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._setNotificationUri4511.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._setNotificationUri4511 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._setNotificationUri4511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getWantsAllOnMoveCalls4512;
		bool android.database.Cursor.getWantsAllOnMoveCalls()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._getWantsAllOnMoveCalls4512.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._getWantsAllOnMoveCalls4512 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getWantsAllOnMoveCalls", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._getWantsAllOnMoveCalls4512);
		}
		internal static global::MonoJavaBridge.MethodId _respond4513;
		global::android.os.Bundle android.database.Cursor.respond(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Cursor_._respond4513.native == global::System.IntPtr.Zero)
				global::android.database.Cursor_._respond4513 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.Cursor_._respond4513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
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
