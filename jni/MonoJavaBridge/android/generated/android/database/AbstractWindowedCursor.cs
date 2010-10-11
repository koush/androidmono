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
		internal static global::MonoJavaBridge.MethodId _getShort2488;
		public override short getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._getShort2488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getShort2488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt2489;
		public override int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._getInt2489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getInt2489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong2490;
		public override long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._getLong2490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getLong2490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat2491;
		public override float getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._getFloat2491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getFloat2491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble2492;
		public override double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._getDouble2492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getDouble2492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getString2493;
		public override global::java.lang.String getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._getString2493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getString2493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getWindow2494;
		public override global::android.database.CursorWindow getWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._getWindow2494)) as android.database.CursorWindow;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getWindow2494)) as android.database.CursorWindow;
		}
		internal static global::MonoJavaBridge.MethodId _getBlob2495;
		public override byte[] getBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._getBlob2495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getBlob2495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer2496;
		public override void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._copyStringToBuffer2496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._copyStringToBuffer2496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNull2497;
		public override bool isNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._isNull2497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isNull2497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkPosition2498;
		protected override void checkPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._checkPosition2498);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._checkPosition2498);
		}
		internal static global::MonoJavaBridge.MethodId _isBlob2499;
		public virtual bool isBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._isBlob2499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isBlob2499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLong2500;
		public virtual bool isLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._isLong2500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isLong2500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFloat2501;
		public virtual bool isFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._isFloat2501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isFloat2501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isString2502;
		public virtual bool isString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._isString2502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isString2502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWindow2503;
		public virtual void setWindow(android.database.CursorWindow arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._setWindow2503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._setWindow2503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasWindow2504;
		public virtual bool hasWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor._hasWindow2504);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._hasWindow2504);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractWindowedCursor2505;
		public AbstractWindowedCursor()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._AbstractWindowedCursor2505);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.AbstractWindowedCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractWindowedCursor"));
			global::android.database.AbstractWindowedCursor._getShort2488 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getShort", "(I)S");
			global::android.database.AbstractWindowedCursor._getInt2489 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getInt", "(I)I");
			global::android.database.AbstractWindowedCursor._getLong2490 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getLong", "(I)J");
			global::android.database.AbstractWindowedCursor._getFloat2491 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getFloat", "(I)F");
			global::android.database.AbstractWindowedCursor._getDouble2492 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getDouble", "(I)D");
			global::android.database.AbstractWindowedCursor._getString2493 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.AbstractWindowedCursor._getWindow2494 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getWindow", "()Landroid/database/CursorWindow;");
			global::android.database.AbstractWindowedCursor._getBlob2495 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "getBlob", "(I)[B");
			global::android.database.AbstractWindowedCursor._copyStringToBuffer2496 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::android.database.AbstractWindowedCursor._isNull2497 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "isNull", "(I)Z");
			global::android.database.AbstractWindowedCursor._checkPosition2498 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "checkPosition", "()V");
			global::android.database.AbstractWindowedCursor._isBlob2499 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "isBlob", "(I)Z");
			global::android.database.AbstractWindowedCursor._isLong2500 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "isLong", "(I)Z");
			global::android.database.AbstractWindowedCursor._isFloat2501 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "isFloat", "(I)Z");
			global::android.database.AbstractWindowedCursor._isString2502 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "isString", "(I)Z");
			global::android.database.AbstractWindowedCursor._setWindow2503 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "setWindow", "(Landroid/database/CursorWindow;)V");
			global::android.database.AbstractWindowedCursor._hasWindow2504 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "hasWindow", "()Z");
			global::android.database.AbstractWindowedCursor._AbstractWindowedCursor2505 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _getCount2506;
		public override int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor_._getCount2506);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor_.staticClass, global::android.database.AbstractWindowedCursor_._getCount2506);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames2507;
		public override global::java.lang.String[] getColumnNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor_._getColumnNames2507)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractWindowedCursor_.staticClass, global::android.database.AbstractWindowedCursor_._getColumnNames2507)) as java.lang.String[];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.AbstractWindowedCursor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractWindowedCursor"));
			global::android.database.AbstractWindowedCursor_._getCount2506 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor_.staticClass, "getCount", "()I");
			global::android.database.AbstractWindowedCursor_._getColumnNames2507 = @__env.GetMethodIDNoThrow(global::android.database.AbstractWindowedCursor_.staticClass, "getColumnNames", "()[Ljava/lang/String;");
		}
	}
}
