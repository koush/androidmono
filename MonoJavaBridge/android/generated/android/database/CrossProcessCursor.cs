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
		private static global::MonoJavaBridge.MethodId _m0;
		global::android.database.CursorWindow android.database.CrossProcessCursor.getWindow()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getWindow", "()Landroid/database/CursorWindow;", ref global::android.database.CrossProcessCursor_._m0) as android.database.CursorWindow;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool android.database.CrossProcessCursor.onMove(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "onMove", "(II)Z", ref global::android.database.CrossProcessCursor_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void android.database.CrossProcessCursor.fillWindow(int arg0, android.database.CursorWindow arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CrossProcessCursor_.staticClass, "fillWindow", "(ILandroid/database/CursorWindow;)V", ref global::android.database.CrossProcessCursor_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		short android.database.Cursor.getShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getShort", "(I)S", ref global::android.database.CrossProcessCursor_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		int android.database.Cursor.getInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getInt", "(I)I", ref global::android.database.CrossProcessCursor_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		long android.database.Cursor.getLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getLong", "(I)J", ref global::android.database.CrossProcessCursor_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		float android.database.Cursor.getFloat(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getFloat", "(I)F", ref global::android.database.CrossProcessCursor_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		double android.database.Cursor.getDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getDouble", "(I)D", ref global::android.database.CrossProcessCursor_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void android.database.Cursor.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CrossProcessCursor_.staticClass, "close", "()V", ref global::android.database.CrossProcessCursor_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::java.lang.String android.database.Cursor.getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.CrossProcessCursor_.staticClass, "getString", "(I)Ljava/lang/String;", ref global::android.database.CrossProcessCursor_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		bool android.database.Cursor.isFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "isFirst", "()Z", ref global::android.database.CrossProcessCursor_._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		bool android.database.Cursor.isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "isClosed", "()Z", ref global::android.database.CrossProcessCursor_._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		int android.database.Cursor.getPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getPosition", "()I", ref global::android.database.CrossProcessCursor_._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		global::android.os.Bundle android.database.Cursor.getExtras()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.database.CrossProcessCursor_.staticClass, "getExtras", "()Landroid/os/Bundle;", ref global::android.database.CrossProcessCursor_._m13) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		void android.database.Cursor.registerContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CrossProcessCursor_.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V", ref global::android.database.CrossProcessCursor_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		void android.database.Cursor.unregisterContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CrossProcessCursor_.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V", ref global::android.database.CrossProcessCursor_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		int android.database.Cursor.getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getCount", "()I", ref global::android.database.CrossProcessCursor_._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		bool android.database.Cursor.move(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "move", "(I)Z", ref global::android.database.CrossProcessCursor_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		bool android.database.Cursor.moveToPosition(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "moveToPosition", "(I)Z", ref global::android.database.CrossProcessCursor_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		bool android.database.Cursor.moveToFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "moveToFirst", "()Z", ref global::android.database.CrossProcessCursor_._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		bool android.database.Cursor.moveToLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "moveToLast", "()Z", ref global::android.database.CrossProcessCursor_._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		bool android.database.Cursor.moveToNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "moveToNext", "()Z", ref global::android.database.CrossProcessCursor_._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		bool android.database.Cursor.moveToPrevious()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "moveToPrevious", "()Z", ref global::android.database.CrossProcessCursor_._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		bool android.database.Cursor.isLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "isLast", "()Z", ref global::android.database.CrossProcessCursor_._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		bool android.database.Cursor.isBeforeFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "isBeforeFirst", "()Z", ref global::android.database.CrossProcessCursor_._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		bool android.database.Cursor.isAfterLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "isAfterLast", "()Z", ref global::android.database.CrossProcessCursor_._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		int android.database.Cursor.getColumnIndex(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getColumnIndex", "(Ljava/lang/String;)I", ref global::android.database.CrossProcessCursor_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		int android.database.Cursor.getColumnIndexOrThrow(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I", ref global::android.database.CrossProcessCursor_._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		global::java.lang.String android.database.Cursor.getColumnName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.CrossProcessCursor_.staticClass, "getColumnName", "(I)Ljava/lang/String;", ref global::android.database.CrossProcessCursor_._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		global::java.lang.String[] android.database.Cursor.getColumnNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.database.CrossProcessCursor_.staticClass, "getColumnNames", "()[Ljava/lang/String;", ref global::android.database.CrossProcessCursor_._m29) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m30;
		int android.database.Cursor.getColumnCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getColumnCount", "()I", ref global::android.database.CrossProcessCursor_._m30);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		byte[] android.database.Cursor.getBlob(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.database.CrossProcessCursor_.staticClass, "getBlob", "(I)[B", ref global::android.database.CrossProcessCursor_._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m32;
		void android.database.Cursor.copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CrossProcessCursor_.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", ref global::android.database.CrossProcessCursor_._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		bool android.database.Cursor.isNull(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "isNull", "(I)Z", ref global::android.database.CrossProcessCursor_._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		void android.database.Cursor.deactivate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CrossProcessCursor_.staticClass, "deactivate", "()V", ref global::android.database.CrossProcessCursor_._m34);
		}
		private static global::MonoJavaBridge.MethodId _m35;
		bool android.database.Cursor.requery()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "requery", "()Z", ref global::android.database.CrossProcessCursor_._m35);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		void android.database.Cursor.registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CrossProcessCursor_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.database.CrossProcessCursor_._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		void android.database.Cursor.unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CrossProcessCursor_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.database.CrossProcessCursor_._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		void android.database.Cursor.setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CrossProcessCursor_.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", ref global::android.database.CrossProcessCursor_._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		bool android.database.Cursor.getWantsAllOnMoveCalls()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CrossProcessCursor_.staticClass, "getWantsAllOnMoveCalls", "()Z", ref global::android.database.CrossProcessCursor_._m39);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		global::android.os.Bundle android.database.Cursor.respond(android.os.Bundle arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.database.CrossProcessCursor_.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", ref global::android.database.CrossProcessCursor_._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Bundle;
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
