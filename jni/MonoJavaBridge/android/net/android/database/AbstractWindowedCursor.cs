namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbstractWindowedCursor : android.database.AbstractCursor
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AbstractWindowedCursor() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.AbstractWindowedCursor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbstractWindowedCursor(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShort2143; 
		public override short getShort(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallShortMethod(this, global::android.database.AbstractWindowedCursor._getShort2143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualShortMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getShort2143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInt2144; 
		public override int getInt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.database.AbstractWindowedCursor._getInt2144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getInt2144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLong2145; 
		public override long getLong(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::android.database.AbstractWindowedCursor._getLong2145, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getLong2145, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2146; 
		public override float getFloat(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.database.AbstractWindowedCursor._getFloat2146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getFloat2146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDouble2147; 
		public override double getDouble(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallDoubleMethod(this, global::android.database.AbstractWindowedCursor._getDouble2147, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getDouble2147, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getString2148; 
		public override global::java.lang.String getString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.AbstractWindowedCursor._getString2148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getString2148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindow2149; 
		public override global::android.database.CursorWindow getWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorWindow>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.AbstractWindowedCursor._getWindow2149)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorWindow>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getWindow2149)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBlob2150; 
		public override byte[] getBlob(int arg0) 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.database.AbstractWindowedCursor._getBlob2150, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getBlob2150, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyStringToBuffer2151; 
		public override void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.database.AbstractWindowedCursor._copyStringToBuffer2151, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._copyStringToBuffer2151, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNull2152; 
		public override bool isNull(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor._isNull2152, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isNull2152, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkPosition2153; 
		protected override void checkPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.database.AbstractWindowedCursor._checkPosition2153); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._checkPosition2153); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBlob2154; 
		public virtual bool isBlob(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor._isBlob2154, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isBlob2154, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLong2155; 
		public virtual bool isLong(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor._isLong2155, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isLong2155, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFloat2156; 
		public virtual bool isFloat(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor._isFloat2156, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isFloat2156, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isString2157; 
		public virtual bool isString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor._isString2157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isString2157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWindow2158; 
		public virtual void setWindow(android.database.CursorWindow arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.database.AbstractWindowedCursor._setWindow2158, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._setWindow2158, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasWindow2159; 
		public virtual bool hasWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor._hasWindow2159); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._hasWindow2159); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractWindowedCursor2160; 
		public AbstractWindowedCursor()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._AbstractWindowedCursor2160, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.AbstractWindowedCursor.staticClass = @__class; 
			global::android.database.AbstractWindowedCursor._getShort2143 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getShort", "(I)S"); 
			global::android.database.AbstractWindowedCursor._getInt2144 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getInt", "(I)I"); 
			global::android.database.AbstractWindowedCursor._getLong2145 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getLong", "(I)J"); 
			global::android.database.AbstractWindowedCursor._getFloat2146 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getFloat", "(I)F"); 
			global::android.database.AbstractWindowedCursor._getDouble2147 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getDouble", "(I)D"); 
			global::android.database.AbstractWindowedCursor._getString2148 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getString", "(I)Ljava/lang/String;"); 
			global::android.database.AbstractWindowedCursor._getWindow2149 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getWindow", "()Landroid/database/CursorWindow;"); 
			global::android.database.AbstractWindowedCursor._getBlob2150 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getBlob", "(I)[B"); 
			global::android.database.AbstractWindowedCursor._copyStringToBuffer2151 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V"); 
			global::android.database.AbstractWindowedCursor._isNull2152 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "isNull", "(I)Z"); 
			global::android.database.AbstractWindowedCursor._checkPosition2153 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "checkPosition", "()V"); 
			global::android.database.AbstractWindowedCursor._isBlob2154 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "isBlob", "(I)Z"); 
			global::android.database.AbstractWindowedCursor._isLong2155 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "isLong", "(I)Z"); 
			global::android.database.AbstractWindowedCursor._isFloat2156 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "isFloat", "(I)Z"); 
			global::android.database.AbstractWindowedCursor._isString2157 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "isString", "(I)Z"); 
			global::android.database.AbstractWindowedCursor._setWindow2158 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "setWindow", "(Landroid/database/CursorWindow;)V"); 
			global::android.database.AbstractWindowedCursor._hasWindow2159 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "hasWindow", "()Z"); 
			global::android.database.AbstractWindowedCursor._AbstractWindowedCursor2160 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "<init>", "()V"); 
		} 
	} 
} 
