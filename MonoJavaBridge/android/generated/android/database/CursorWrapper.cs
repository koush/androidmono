namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CursorWrapper : java.lang.Object, Cursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CursorWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual short getShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.database.CursorWrapper.staticClass, "getShort", "(I)S", ref global::android.database.CursorWrapper._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWrapper.staticClass, "getInt", "(I)I", ref global::android.database.CursorWrapper._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual long getLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.CursorWrapper.staticClass, "getLong", "(I)J", ref global::android.database.CursorWrapper._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual float getFloat(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.database.CursorWrapper.staticClass, "getFloat", "(I)F", ref global::android.database.CursorWrapper._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual double getDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.database.CursorWrapper.staticClass, "getDouble", "(I)D", ref global::android.database.CursorWrapper._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWrapper.staticClass, "close", "()V", ref global::android.database.CursorWrapper._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.String getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.CursorWrapper.staticClass, "getString", "(I)Ljava/lang/String;", ref global::android.database.CursorWrapper._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool isFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, "isFirst", "()Z", ref global::android.database.CursorWrapper._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, "isClosed", "()Z", ref global::android.database.CursorWrapper._m8);
		}
		public new int Position
		{
			get
			{
				return getPosition();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWrapper.staticClass, "getPosition", "()I", ref global::android.database.CursorWrapper._m9);
		}
		public new global::android.os.Bundle Extras
		{
			get
			{
				return getExtras();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::android.os.Bundle getExtras()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.database.CursorWrapper.staticClass, "getExtras", "()Landroid/os/Bundle;", ref global::android.database.CursorWrapper._m10) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void registerContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWrapper.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V", ref global::android.database.CursorWrapper._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWrapper.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V", ref global::android.database.CursorWrapper._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWrapper.staticClass, "getCount", "()I", ref global::android.database.CursorWrapper._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool move(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, "move", "(I)Z", ref global::android.database.CursorWrapper._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool moveToPosition(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, "moveToPosition", "(I)Z", ref global::android.database.CursorWrapper._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool moveToFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, "moveToFirst", "()Z", ref global::android.database.CursorWrapper._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual bool moveToLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, "moveToLast", "()Z", ref global::android.database.CursorWrapper._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual bool moveToNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, "moveToNext", "()Z", ref global::android.database.CursorWrapper._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool moveToPrevious()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, "moveToPrevious", "()Z", ref global::android.database.CursorWrapper._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool isLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, "isLast", "()Z", ref global::android.database.CursorWrapper._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual bool isBeforeFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, "isBeforeFirst", "()Z", ref global::android.database.CursorWrapper._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool isAfterLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, "isAfterLast", "()Z", ref global::android.database.CursorWrapper._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual int getColumnIndex(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWrapper.staticClass, "getColumnIndex", "(Ljava/lang/String;)I", ref global::android.database.CursorWrapper._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual int getColumnIndexOrThrow(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWrapper.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I", ref global::android.database.CursorWrapper._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::java.lang.String getColumnName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.CursorWrapper.staticClass, "getColumnName", "(I)Ljava/lang/String;", ref global::android.database.CursorWrapper._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		public new global::java.lang.String[] ColumnNames
		{
			get
			{
				return getColumnNames();
			}
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual global::java.lang.String[] getColumnNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.database.CursorWrapper.staticClass, "getColumnNames", "()[Ljava/lang/String;", ref global::android.database.CursorWrapper._m26) as java.lang.String[];
		}
		public new int ColumnCount
		{
			get
			{
				return getColumnCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual int getColumnCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWrapper.staticClass, "getColumnCount", "()I", ref global::android.database.CursorWrapper._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual byte[] getBlob(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.database.CursorWrapper.staticClass, "getBlob", "(I)[B", ref global::android.database.CursorWrapper._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWrapper.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", ref global::android.database.CursorWrapper._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual bool isNull(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, "isNull", "(I)Z", ref global::android.database.CursorWrapper._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual void deactivate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWrapper.staticClass, "deactivate", "()V", ref global::android.database.CursorWrapper._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual bool requery()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, "requery", "()Z", ref global::android.database.CursorWrapper._m32);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWrapper.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.database.CursorWrapper._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWrapper.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.database.CursorWrapper._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWrapper.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", ref global::android.database.CursorWrapper._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool WantsAllOnMoveCalls
		{
			get
			{
				return getWantsAllOnMoveCalls();
			}
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual bool getWantsAllOnMoveCalls()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, "getWantsAllOnMoveCalls", "()Z", ref global::android.database.CursorWrapper._m36);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual global::android.os.Bundle respond(android.os.Bundle arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.database.CursorWrapper.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", ref global::android.database.CursorWrapper._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public CursorWrapper(android.database.Cursor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._m38.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._m38 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "<init>", "(Landroid/database/Cursor;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CursorWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.CursorWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CursorWrapper"));
		}
	}
}
