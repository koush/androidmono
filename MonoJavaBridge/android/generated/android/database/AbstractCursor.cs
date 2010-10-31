namespace android.database
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.AbstractCursor_))]
	public abstract partial class AbstractCursor : java.lang.Object, CrossProcessCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class SelfContentObserver : android.database.ContentObserver
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected SelfContentObserver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override bool deliverSelfNotifications()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.SelfContentObserver.staticClass, "deliverSelfNotifications", "()Z", ref global::android.database.AbstractCursor.SelfContentObserver._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override void onChange(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.SelfContentObserver.staticClass, "onChange", "(Z)V", ref global::android.database.AbstractCursor.SelfContentObserver._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public SelfContentObserver(android.database.AbstractCursor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.database.AbstractCursor.SelfContentObserver._m2.native == global::System.IntPtr.Zero)
					global::android.database.AbstractCursor.SelfContentObserver._m2 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.SelfContentObserver.staticClass, "<init>", "(Landroid/database/AbstractCursor;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.AbstractCursor.SelfContentObserver.staticClass, global::android.database.AbstractCursor.SelfContentObserver._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static SelfContentObserver()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.database.AbstractCursor.SelfContentObserver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractCursor$SelfContentObserver"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "finalize", "()V", ref global::android.database.AbstractCursor._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract short getShort(int arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract int getInt(int arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract long getLong(int arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract float getFloat(int arg0);
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract double getDouble(int arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "close", "()V", ref global::android.database.AbstractCursor._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract global::java.lang.String getString(int arg0);
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool isFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "isFirst", "()Z", ref global::android.database.AbstractCursor._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "isClosed", "()Z", ref global::android.database.AbstractCursor._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.AbstractCursor.staticClass, "getPosition", "()I", ref global::android.database.AbstractCursor._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::android.os.Bundle getExtras()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.database.AbstractCursor.staticClass, "getExtras", "()Landroid/os/Bundle;", ref global::android.database.AbstractCursor._m11) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void registerContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V", ref global::android.database.AbstractCursor._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V", ref global::android.database.AbstractCursor._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::android.database.CursorWindow getWindow()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.AbstractCursor.staticClass, "getWindow", "()Landroid/database/CursorWindow;", ref global::android.database.AbstractCursor._m14) as android.database.CursorWindow;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public abstract int getCount();
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool move(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "move", "(I)Z", ref global::android.database.AbstractCursor._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual bool moveToPosition(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "moveToPosition", "(I)Z", ref global::android.database.AbstractCursor._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual bool moveToFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "moveToFirst", "()Z", ref global::android.database.AbstractCursor._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool moveToLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "moveToLast", "()Z", ref global::android.database.AbstractCursor._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool moveToNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "moveToNext", "()Z", ref global::android.database.AbstractCursor._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual bool moveToPrevious()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "moveToPrevious", "()Z", ref global::android.database.AbstractCursor._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool isLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "isLast", "()Z", ref global::android.database.AbstractCursor._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool isBeforeFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "isBeforeFirst", "()Z", ref global::android.database.AbstractCursor._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual bool isAfterLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "isAfterLast", "()Z", ref global::android.database.AbstractCursor._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual int getColumnIndex(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.AbstractCursor.staticClass, "getColumnIndex", "(Ljava/lang/String;)I", ref global::android.database.AbstractCursor._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual int getColumnIndexOrThrow(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.AbstractCursor.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I", ref global::android.database.AbstractCursor._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::java.lang.String getColumnName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.AbstractCursor.staticClass, "getColumnName", "(I)Ljava/lang/String;", ref global::android.database.AbstractCursor._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public abstract global::java.lang.String[] getColumnNames();
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual int getColumnCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.AbstractCursor.staticClass, "getColumnCount", "()I", ref global::android.database.AbstractCursor._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual byte[] getBlob(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.database.AbstractCursor.staticClass, "getBlob", "(I)[B", ref global::android.database.AbstractCursor._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", ref global::android.database.AbstractCursor._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public abstract bool isNull(int arg0);
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void deactivate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "deactivate", "()V", ref global::android.database.AbstractCursor._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual bool requery()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "requery", "()Z", ref global::android.database.AbstractCursor._m34);
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.database.AbstractCursor._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.database.AbstractCursor._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", ref global::android.database.AbstractCursor._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual bool getWantsAllOnMoveCalls()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "getWantsAllOnMoveCalls", "()Z", ref global::android.database.AbstractCursor._m38);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual global::android.os.Bundle respond(android.os.Bundle arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.database.AbstractCursor.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", ref global::android.database.AbstractCursor._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m40;
		protected virtual void onChange(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "onChange", "(Z)V", ref global::android.database.AbstractCursor._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual bool onMove(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "onMove", "(II)Z", ref global::android.database.AbstractCursor._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual void fillWindow(int arg0, android.database.CursorWindow arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "fillWindow", "(ILandroid/database/CursorWindow;)V", ref global::android.database.AbstractCursor._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		protected virtual bool isFieldUpdated(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor.staticClass, "isFieldUpdated", "(I)Z", ref global::android.database.AbstractCursor._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		protected virtual global::java.lang.Object getUpdatedField(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.AbstractCursor.staticClass, "getUpdatedField", "(I)Ljava/lang/Object;", ref global::android.database.AbstractCursor._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m45;
		protected virtual void checkPosition()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractCursor.staticClass, "checkPosition", "()V", ref global::android.database.AbstractCursor._m45);
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public AbstractCursor() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.AbstractCursor._m46.native == global::System.IntPtr.Zero)
				global::android.database.AbstractCursor._m46 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._m46);
			Init(@__env, handle);
		}
		static AbstractCursor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.AbstractCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractCursor"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.AbstractCursor))]
	internal sealed partial class AbstractCursor_ : android.database.AbstractCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractCursor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override short getShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.database.AbstractCursor_.staticClass, "getShort", "(I)S", ref global::android.database.AbstractCursor_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int getInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.AbstractCursor_.staticClass, "getInt", "(I)I", ref global::android.database.AbstractCursor_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override long getLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.AbstractCursor_.staticClass, "getLong", "(I)J", ref global::android.database.AbstractCursor_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override float getFloat(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.database.AbstractCursor_.staticClass, "getFloat", "(I)F", ref global::android.database.AbstractCursor_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override double getDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.database.AbstractCursor_.staticClass, "getDouble", "(I)D", ref global::android.database.AbstractCursor_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.lang.String getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.AbstractCursor_.staticClass, "getString", "(I)Ljava/lang/String;", ref global::android.database.AbstractCursor_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.AbstractCursor_.staticClass, "getCount", "()I", ref global::android.database.AbstractCursor_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.lang.String[] getColumnNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.database.AbstractCursor_.staticClass, "getColumnNames", "()[Ljava/lang/String;", ref global::android.database.AbstractCursor_._m7) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override bool isNull(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractCursor_.staticClass, "isNull", "(I)Z", ref global::android.database.AbstractCursor_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static AbstractCursor_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.AbstractCursor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractCursor"));
		}
	}
}
