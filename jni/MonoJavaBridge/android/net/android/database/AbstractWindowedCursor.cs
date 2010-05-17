namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbstractWindowedCursor : android.database.AbstractCursor
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AbstractWindowedCursor() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.AbstractWindowedCursor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbstractWindowedCursor(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShort2038; 
		public override short getShort(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractWindowedCursor)) 
				return @__env.CallShortMethod(this, _getShort2038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualShortMethod(this, android.database.AbstractWindowedCursor.staticClass, _getShort2038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInt2039; 
		public override int getInt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractWindowedCursor)) 
				return @__env.CallIntMethod(this, _getInt2039, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.AbstractWindowedCursor.staticClass, _getInt2039, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLong2040; 
		public override long getLong(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractWindowedCursor)) 
				return @__env.CallLongMethod(this, _getLong2040, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.database.AbstractWindowedCursor.staticClass, _getLong2040, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2041; 
		public override float getFloat(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractWindowedCursor)) 
				return @__env.CallFloatMethod(this, _getFloat2041, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.database.AbstractWindowedCursor.staticClass, _getFloat2041, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDouble2042; 
		public override double getDouble(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractWindowedCursor)) 
				return @__env.CallDoubleMethod(this, _getDouble2042, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, android.database.AbstractWindowedCursor.staticClass, _getDouble2042, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getString2043; 
		public override java.lang.String getString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractWindowedCursor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getString2043, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.AbstractWindowedCursor.staticClass, _getString2043, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindow2044; 
		public override android.database.CursorWindow getWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractWindowedCursor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorWindow>(@__env, @__env.CallObjectMethodPtr(this, _getWindow2044)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorWindow>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.AbstractWindowedCursor.staticClass, _getWindow2044)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBlob2045; 
		public override byte[] getBlob(int arg0) 
		{ 
			if (GetType() == typeof(android.database.AbstractWindowedCursor)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getBlob2045, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.AbstractWindowedCursor.staticClass, _getBlob2045, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyStringToBuffer2046; 
		public override void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractWindowedCursor)) 
				@__env.CallVoidMethod(this, _copyStringToBuffer2046, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractWindowedCursor.staticClass, _copyStringToBuffer2046, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNull2047; 
		public override bool isNull(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractWindowedCursor)) 
				return @__env.CallBooleanMethod(this, _isNull2047, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractWindowedCursor.staticClass, _isNull2047, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkPosition2048; 
		protected override void checkPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractWindowedCursor)) 
				@__env.CallVoidMethod(this, _checkPosition2048); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractWindowedCursor.staticClass, _checkPosition2048); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBlob2049; 
		public virtual bool isBlob(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractWindowedCursor)) 
				return @__env.CallBooleanMethod(this, _isBlob2049, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractWindowedCursor.staticClass, _isBlob2049, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLong2050; 
		public virtual bool isLong(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractWindowedCursor)) 
				return @__env.CallBooleanMethod(this, _isLong2050, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractWindowedCursor.staticClass, _isLong2050, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFloat2051; 
		public virtual bool isFloat(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractWindowedCursor)) 
				return @__env.CallBooleanMethod(this, _isFloat2051, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractWindowedCursor.staticClass, _isFloat2051, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isString2052; 
		public virtual bool isString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractWindowedCursor)) 
				return @__env.CallBooleanMethod(this, _isString2052, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractWindowedCursor.staticClass, _isString2052, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWindow2053; 
		public virtual void setWindow(android.database.CursorWindow arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractWindowedCursor)) 
				@__env.CallVoidMethod(this, _setWindow2053, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractWindowedCursor.staticClass, _setWindow2053, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasWindow2054; 
		public virtual bool hasWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractWindowedCursor)) 
				return @__env.CallBooleanMethod(this, _hasWindow2054); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractWindowedCursor.staticClass, _hasWindow2054); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractWindowedCursor2055; 
		public AbstractWindowedCursor()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.AbstractWindowedCursor.staticClass, _AbstractWindowedCursor2055, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.AbstractWindowedCursor.staticClass = @__class; 
			global::android.database.AbstractWindowedCursor._getShort2038 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getShort", "(I)S"); 
			global::android.database.AbstractWindowedCursor._getInt2039 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getInt", "(I)I"); 
			global::android.database.AbstractWindowedCursor._getLong2040 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getLong", "(I)J"); 
			global::android.database.AbstractWindowedCursor._getFloat2041 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getFloat", "(I)F"); 
			global::android.database.AbstractWindowedCursor._getDouble2042 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getDouble", "(I)D"); 
			global::android.database.AbstractWindowedCursor._getString2043 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getString", "(I)Ljava/lang/String;"); 
			global::android.database.AbstractWindowedCursor._getWindow2044 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getWindow", "()Landroid/database/CursorWindow;"); 
			global::android.database.AbstractWindowedCursor._getBlob2045 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getBlob", "(I)[B"); 
			global::android.database.AbstractWindowedCursor._copyStringToBuffer2046 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V"); 
			global::android.database.AbstractWindowedCursor._isNull2047 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "isNull", "(I)Z"); 
			global::android.database.AbstractWindowedCursor._checkPosition2048 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "checkPosition", "()V"); 
			global::android.database.AbstractWindowedCursor._isBlob2049 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "isBlob", "(I)Z"); 
			global::android.database.AbstractWindowedCursor._isLong2050 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "isLong", "(I)Z"); 
			global::android.database.AbstractWindowedCursor._isFloat2051 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "isFloat", "(I)Z"); 
			global::android.database.AbstractWindowedCursor._isString2052 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "isString", "(I)Z"); 
			global::android.database.AbstractWindowedCursor._setWindow2053 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "setWindow", "(Landroid/database/CursorWindow;)V"); 
			global::android.database.AbstractWindowedCursor._hasWindow2054 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "hasWindow", "()Z"); 
			global::android.database.AbstractWindowedCursor._AbstractWindowedCursor2055 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "<init>", "()V"); 
		} 
	} 
} 
