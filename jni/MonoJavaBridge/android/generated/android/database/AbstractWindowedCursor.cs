namespace android.database
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.AbstractWindowedCursor_))]
	public abstract partial class AbstractWindowedCursor : android.database.AbstractCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractWindowedCursor()
		{
			InitJNI();
		}
		protected AbstractWindowedCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getShort4386;
		public override short getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._getShort4386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getShort4386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt4387;
		public override int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._getInt4387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getInt4387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong4388;
		public override long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._getLong4388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getLong4388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat4389;
		public override float getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._getFloat4389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getFloat4389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble4390;
		public override double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._getDouble4390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getDouble4390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getString4391;
		public override global::java.lang.String getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._getString4391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getString4391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getWindow4392;
		public override global::android.database.CursorWindow getWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._getWindow4392)) as android.database.CursorWindow;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getWindow4392)) as android.database.CursorWindow;
		}
		internal static global::MonoJavaBridge.MethodId _getBlob4393;
		public override byte[] getBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._getBlob4393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getBlob4393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer4394;
		public override void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._copyStringToBuffer4394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._copyStringToBuffer4394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNull4395;
		public override bool isNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._isNull4395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isNull4395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkPosition4396;
		protected override void checkPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._checkPosition4396);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._checkPosition4396);
		}
		internal static global::MonoJavaBridge.MethodId _isBlob4397;
		public virtual bool isBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._isBlob4397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isBlob4397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLong4398;
		public virtual bool isLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._isLong4398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isLong4398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFloat4399;
		public virtual bool isFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._isFloat4399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isFloat4399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isString4400;
		public virtual bool isString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._isString4400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isString4400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWindow4401;
		public virtual void setWindow(android.database.CursorWindow arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._setWindow4401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._setWindow4401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasWindow4402;
		public virtual bool hasWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._hasWindow4402);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._hasWindow4402);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractWindowedCursor4403;
		public AbstractWindowedCursor()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._AbstractWindowedCursor4403);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.AbstractWindowedCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractWindowedCursor"));
			global::android.database.AbstractWindowedCursor._getShort4386 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getShort", "(I)S");
			global::android.database.AbstractWindowedCursor._getInt4387 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getInt", "(I)I");
			global::android.database.AbstractWindowedCursor._getLong4388 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getLong", "(I)J");
			global::android.database.AbstractWindowedCursor._getFloat4389 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getFloat", "(I)F");
			global::android.database.AbstractWindowedCursor._getDouble4390 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getDouble", "(I)D");
			global::android.database.AbstractWindowedCursor._getString4391 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.AbstractWindowedCursor._getWindow4392 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getWindow", "()Landroid/database/CursorWindow;");
			global::android.database.AbstractWindowedCursor._getBlob4393 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getBlob", "(I)[B");
			global::android.database.AbstractWindowedCursor._copyStringToBuffer4394 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::android.database.AbstractWindowedCursor._isNull4395 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "isNull", "(I)Z");
			global::android.database.AbstractWindowedCursor._checkPosition4396 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "checkPosition", "()V");
			global::android.database.AbstractWindowedCursor._isBlob4397 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "isBlob", "(I)Z");
			global::android.database.AbstractWindowedCursor._isLong4398 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "isLong", "(I)Z");
			global::android.database.AbstractWindowedCursor._isFloat4399 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "isFloat", "(I)Z");
			global::android.database.AbstractWindowedCursor._isString4400 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "isString", "(I)Z");
			global::android.database.AbstractWindowedCursor._setWindow4401 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "setWindow", "(Landroid/database/CursorWindow;)V");
			global::android.database.AbstractWindowedCursor._hasWindow4402 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "hasWindow", "()Z");
			global::android.database.AbstractWindowedCursor._AbstractWindowedCursor4403 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.AbstractWindowedCursor))]
	public sealed partial class AbstractWindowedCursor_ : android.database.AbstractWindowedCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractWindowedCursor_()
		{
			InitJNI();
		}
		internal AbstractWindowedCursor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCount4404;
		public override int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor_._getCount4404);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor_.staticClass, global::android.database.AbstractWindowedCursor_._getCount4404);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames4405;
		public override global::java.lang.String[] getColumnNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor_._getColumnNames4405)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor_.staticClass, global::android.database.AbstractWindowedCursor_._getColumnNames4405)) as java.lang.String[];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.AbstractWindowedCursor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractWindowedCursor"));
			global::android.database.AbstractWindowedCursor_._getCount4404 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor_.staticClass, "getCount", "()I");
			global::android.database.AbstractWindowedCursor_._getColumnNames4405 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor_.staticClass, "getColumnNames", "()[Ljava/lang/String;");
		}
	}
}
