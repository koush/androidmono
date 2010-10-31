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
		private static global::MonoJavaBridge.MethodId _m0;
		short android.database.Cursor.getShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.database.Cursor_.staticClass, "getShort", "(I)S", ref global::android.database.Cursor_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		int android.database.Cursor.getInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.Cursor_.staticClass, "getInt", "(I)I", ref global::android.database.Cursor_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		long android.database.Cursor.getLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.Cursor_.staticClass, "getLong", "(I)J", ref global::android.database.Cursor_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		float android.database.Cursor.getFloat(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.database.Cursor_.staticClass, "getFloat", "(I)F", ref global::android.database.Cursor_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		double android.database.Cursor.getDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.database.Cursor_.staticClass, "getDouble", "(I)D", ref global::android.database.Cursor_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void android.database.Cursor.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Cursor_.staticClass, "close", "()V", ref global::android.database.Cursor_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::java.lang.String android.database.Cursor.getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.Cursor_.staticClass, "getString", "(I)Ljava/lang/String;", ref global::android.database.Cursor_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		bool android.database.Cursor.isFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "isFirst", "()Z", ref global::android.database.Cursor_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		bool android.database.Cursor.isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "isClosed", "()Z", ref global::android.database.Cursor_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		int android.database.Cursor.getPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.Cursor_.staticClass, "getPosition", "()I", ref global::android.database.Cursor_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::android.os.Bundle android.database.Cursor.getExtras()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.database.Cursor_.staticClass, "getExtras", "()Landroid/os/Bundle;", ref global::android.database.Cursor_._m10) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void android.database.Cursor.registerContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Cursor_.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V", ref global::android.database.Cursor_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void android.database.Cursor.unregisterContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Cursor_.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V", ref global::android.database.Cursor_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		int android.database.Cursor.getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.Cursor_.staticClass, "getCount", "()I", ref global::android.database.Cursor_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		bool android.database.Cursor.move(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "move", "(I)Z", ref global::android.database.Cursor_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		bool android.database.Cursor.moveToPosition(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "moveToPosition", "(I)Z", ref global::android.database.Cursor_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		bool android.database.Cursor.moveToFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "moveToFirst", "()Z", ref global::android.database.Cursor_._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		bool android.database.Cursor.moveToLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "moveToLast", "()Z", ref global::android.database.Cursor_._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		bool android.database.Cursor.moveToNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "moveToNext", "()Z", ref global::android.database.Cursor_._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		bool android.database.Cursor.moveToPrevious()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "moveToPrevious", "()Z", ref global::android.database.Cursor_._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		bool android.database.Cursor.isLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "isLast", "()Z", ref global::android.database.Cursor_._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		bool android.database.Cursor.isBeforeFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "isBeforeFirst", "()Z", ref global::android.database.Cursor_._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		bool android.database.Cursor.isAfterLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "isAfterLast", "()Z", ref global::android.database.Cursor_._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		int android.database.Cursor.getColumnIndex(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.Cursor_.staticClass, "getColumnIndex", "(Ljava/lang/String;)I", ref global::android.database.Cursor_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		int android.database.Cursor.getColumnIndexOrThrow(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.Cursor_.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I", ref global::android.database.Cursor_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		global::java.lang.String android.database.Cursor.getColumnName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.Cursor_.staticClass, "getColumnName", "(I)Ljava/lang/String;", ref global::android.database.Cursor_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		global::java.lang.String[] android.database.Cursor.getColumnNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.database.Cursor_.staticClass, "getColumnNames", "()[Ljava/lang/String;", ref global::android.database.Cursor_._m26) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m27;
		int android.database.Cursor.getColumnCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.Cursor_.staticClass, "getColumnCount", "()I", ref global::android.database.Cursor_._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		byte[] android.database.Cursor.getBlob(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.database.Cursor_.staticClass, "getBlob", "(I)[B", ref global::android.database.Cursor_._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m29;
		void android.database.Cursor.copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Cursor_.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", ref global::android.database.Cursor_._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		bool android.database.Cursor.isNull(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "isNull", "(I)Z", ref global::android.database.Cursor_._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		void android.database.Cursor.deactivate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Cursor_.staticClass, "deactivate", "()V", ref global::android.database.Cursor_._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		bool android.database.Cursor.requery()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "requery", "()Z", ref global::android.database.Cursor_._m32);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		void android.database.Cursor.registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Cursor_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.database.Cursor_._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		void android.database.Cursor.unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Cursor_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.database.Cursor_._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		void android.database.Cursor.setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Cursor_.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", ref global::android.database.Cursor_._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		bool android.database.Cursor.getWantsAllOnMoveCalls()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.Cursor_.staticClass, "getWantsAllOnMoveCalls", "()Z", ref global::android.database.Cursor_._m36);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		global::android.os.Bundle android.database.Cursor.respond(android.os.Bundle arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.database.Cursor_.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", ref global::android.database.Cursor_._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Bundle;
		}
		static Cursor_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.Cursor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/Cursor"));
		}
	}
}
