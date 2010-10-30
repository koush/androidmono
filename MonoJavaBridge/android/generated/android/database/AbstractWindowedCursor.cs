namespace android.database
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.AbstractWindowedCursor_))]
	public abstract partial class AbstractWindowedCursor : android.database.AbstractCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractWindowedCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getShort4403;
		public override short getShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getShort4403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt4404;
		public override int getInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getInt4404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong4405;
		public override long getLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getLong4405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat4406;
		public override float getFloat(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getFloat4406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble4407;
		public override double getDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getDouble4407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getString4408;
		public override global::java.lang.String getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getString4408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getWindow4409;
		public override global::android.database.CursorWindow getWindow()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getWindow4409)) as android.database.CursorWindow;
		}
		internal static global::MonoJavaBridge.MethodId _getBlob4410;
		public override byte[] getBlob(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getBlob4410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer4411;
		public override void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._copyStringToBuffer4411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNull4412;
		public override bool isNull(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isNull4412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkPosition4413;
		protected override void checkPosition()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._checkPosition4413);
		}
		internal static global::MonoJavaBridge.MethodId _isBlob4414;
		public virtual bool isBlob(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isBlob4414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLong4415;
		public virtual bool isLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isLong4415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFloat4416;
		public virtual bool isFloat(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isFloat4416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isString4417;
		public virtual bool isString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isString4417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWindow4418;
		public virtual void setWindow(android.database.CursorWindow arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._setWindow4418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasWindow4419;
		public virtual bool hasWindow()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._hasWindow4419);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractWindowedCursor4420;
		public AbstractWindowedCursor() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._AbstractWindowedCursor4420);
			Init(@__env, handle);
		}
		static AbstractWindowedCursor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.AbstractWindowedCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractWindowedCursor"));
			global::android.database.AbstractWindowedCursor._getShort4403 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getShort", "(I)S");
			global::android.database.AbstractWindowedCursor._getInt4404 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getInt", "(I)I");
			global::android.database.AbstractWindowedCursor._getLong4405 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getLong", "(I)J");
			global::android.database.AbstractWindowedCursor._getFloat4406 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getFloat", "(I)F");
			global::android.database.AbstractWindowedCursor._getDouble4407 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getDouble", "(I)D");
			global::android.database.AbstractWindowedCursor._getString4408 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.AbstractWindowedCursor._getWindow4409 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getWindow", "()Landroid/database/CursorWindow;");
			global::android.database.AbstractWindowedCursor._getBlob4410 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getBlob", "(I)[B");
			global::android.database.AbstractWindowedCursor._copyStringToBuffer4411 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::android.database.AbstractWindowedCursor._isNull4412 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "isNull", "(I)Z");
			global::android.database.AbstractWindowedCursor._checkPosition4413 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "checkPosition", "()V");
			global::android.database.AbstractWindowedCursor._isBlob4414 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "isBlob", "(I)Z");
			global::android.database.AbstractWindowedCursor._isLong4415 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "isLong", "(I)Z");
			global::android.database.AbstractWindowedCursor._isFloat4416 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "isFloat", "(I)Z");
			global::android.database.AbstractWindowedCursor._isString4417 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "isString", "(I)Z");
			global::android.database.AbstractWindowedCursor._setWindow4418 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "setWindow", "(Landroid/database/CursorWindow;)V");
			global::android.database.AbstractWindowedCursor._hasWindow4419 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "hasWindow", "()Z");
			global::android.database.AbstractWindowedCursor._AbstractWindowedCursor4420 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.AbstractWindowedCursor))]
	internal sealed partial class AbstractWindowedCursor_ : android.database.AbstractWindowedCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractWindowedCursor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCount4421;
		public override int getCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor_._getCount4421);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames4422;
		public override global::java.lang.String[] getColumnNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor_._getColumnNames4422)) as java.lang.String[];
		}
		static AbstractWindowedCursor_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.AbstractWindowedCursor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractWindowedCursor"));
			global::android.database.AbstractWindowedCursor_._getCount4421 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor_.staticClass, "getCount", "()I");
			global::android.database.AbstractWindowedCursor_._getColumnNames4422 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor_.staticClass, "getColumnNames", "()[Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}
