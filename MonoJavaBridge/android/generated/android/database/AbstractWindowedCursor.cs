namespace android.database
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.AbstractWindowedCursor_))]
	public abstract partial class AbstractWindowedCursor : android.database.AbstractCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractWindowedCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override short getShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.database.AbstractWindowedCursor.staticClass, "getShort", "(I)S", ref global::android.database.AbstractWindowedCursor._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int getInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.AbstractWindowedCursor.staticClass, "getInt", "(I)I", ref global::android.database.AbstractWindowedCursor._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override long getLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.AbstractWindowedCursor.staticClass, "getLong", "(I)J", ref global::android.database.AbstractWindowedCursor._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override float getFloat(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.database.AbstractWindowedCursor.staticClass, "getFloat", "(I)F", ref global::android.database.AbstractWindowedCursor._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override double getDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.database.AbstractWindowedCursor.staticClass, "getDouble", "(I)D", ref global::android.database.AbstractWindowedCursor._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.lang.String getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.AbstractWindowedCursor.staticClass, "getString", "(I)Ljava/lang/String;", ref global::android.database.AbstractWindowedCursor._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::android.database.CursorWindow getWindow()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.AbstractWindowedCursor.staticClass, "getWindow", "()Landroid/database/CursorWindow;", ref global::android.database.AbstractWindowedCursor._m6) as android.database.CursorWindow;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override byte[] getBlob(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.database.AbstractWindowedCursor.staticClass, "getBlob", "(I)[B", ref global::android.database.AbstractWindowedCursor._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractWindowedCursor.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", ref global::android.database.AbstractWindowedCursor._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override bool isNull(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, "isNull", "(I)Z", ref global::android.database.AbstractWindowedCursor._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected override void checkPosition()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractWindowedCursor.staticClass, "checkPosition", "()V", ref global::android.database.AbstractWindowedCursor._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool isBlob(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, "isBlob", "(I)Z", ref global::android.database.AbstractWindowedCursor._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool isLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, "isLong", "(I)Z", ref global::android.database.AbstractWindowedCursor._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool isFloat(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, "isFloat", "(I)Z", ref global::android.database.AbstractWindowedCursor._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool isString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, "isString", "(I)Z", ref global::android.database.AbstractWindowedCursor._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setWindow(android.database.CursorWindow arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractWindowedCursor.staticClass, "setWindow", "(Landroid/database/CursorWindow;)V", ref global::android.database.AbstractWindowedCursor._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool hasWindow()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, "hasWindow", "()Z", ref global::android.database.AbstractWindowedCursor._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public AbstractWindowedCursor() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.AbstractWindowedCursor._m17.native == global::System.IntPtr.Zero)
				global::android.database.AbstractWindowedCursor._m17 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._m17);
			Init(@__env, handle);
		}
		static AbstractWindowedCursor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.AbstractWindowedCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractWindowedCursor"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.AbstractWindowedCursor))]
	internal sealed partial class AbstractWindowedCursor_ : android.database.AbstractWindowedCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractWindowedCursor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.AbstractWindowedCursor_.staticClass, "getCount", "()I", ref global::android.database.AbstractWindowedCursor_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String[] getColumnNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.database.AbstractWindowedCursor_.staticClass, "getColumnNames", "()[Ljava/lang/String;", ref global::android.database.AbstractWindowedCursor_._m1) as java.lang.String[];
		}
		static AbstractWindowedCursor_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.AbstractWindowedCursor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractWindowedCursor"));
		}
	}
}
