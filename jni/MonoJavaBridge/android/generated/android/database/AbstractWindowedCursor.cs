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
		internal static global::net.sf.jni4net.jni.MethodId _getShort2324;
		public override short getShort(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this, global::android.database.AbstractWindowedCursor._getShort2324, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getShort2324, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInt2325;
		public override int getInt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.AbstractWindowedCursor._getInt2325, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getInt2325, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLong2326;
		public override long getLong(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.database.AbstractWindowedCursor._getLong2326, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getLong2326, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2327;
		public override float getFloat(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.database.AbstractWindowedCursor._getFloat2327, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getFloat2327, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDouble2328;
		public override double getDouble(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::android.database.AbstractWindowedCursor._getDouble2328, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getDouble2328, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getString2329;
		public override global::java.lang.String getString(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.AbstractWindowedCursor._getString2329, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getString2329, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWindow2330;
		public override global::android.database.CursorWindow getWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorWindow>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.AbstractWindowedCursor._getWindow2330));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorWindow>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getWindow2330));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBlob2331;
		public override byte[] getBlob(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.database.AbstractWindowedCursor._getBlob2331, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._getBlob2331, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _copyStringToBuffer2332;
		public override void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.AbstractWindowedCursor._copyStringToBuffer2332, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._copyStringToBuffer2332, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isNull2333;
		public override bool isNull(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor._isNull2333, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isNull2333, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkPosition2334;
		protected override void checkPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.AbstractWindowedCursor._checkPosition2334);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._checkPosition2334);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isBlob2335;
		public virtual bool isBlob(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor._isBlob2335, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isBlob2335, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLong2336;
		public virtual bool isLong(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor._isLong2336, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isLong2336, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFloat2337;
		public virtual bool isFloat(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor._isFloat2337, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isFloat2337, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isString2338;
		public virtual bool isString(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor._isString2338, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._isString2338, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWindow2339;
		public virtual void setWindow(android.database.CursorWindow arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.AbstractWindowedCursor._setWindow2339, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._setWindow2339, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasWindow2340;
		public virtual bool hasWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractWindowedCursor._hasWindow2340);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._hasWindow2340);
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbstractWindowedCursor2341;
		public AbstractWindowedCursor()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.AbstractWindowedCursor.staticClass, global::android.database.AbstractWindowedCursor._AbstractWindowedCursor2341, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.AbstractWindowedCursor.staticClass = @__class;
			global::android.database.AbstractWindowedCursor._getShort2324 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getShort", "(I)S");
			global::android.database.AbstractWindowedCursor._getInt2325 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getInt", "(I)I");
			global::android.database.AbstractWindowedCursor._getLong2326 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getLong", "(I)J");
			global::android.database.AbstractWindowedCursor._getFloat2327 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getFloat", "(I)F");
			global::android.database.AbstractWindowedCursor._getDouble2328 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getDouble", "(I)D");
			global::android.database.AbstractWindowedCursor._getString2329 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.AbstractWindowedCursor._getWindow2330 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getWindow", "()Landroid/database/CursorWindow;");
			global::android.database.AbstractWindowedCursor._getBlob2331 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "getBlob", "(I)[B");
			global::android.database.AbstractWindowedCursor._copyStringToBuffer2332 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::android.database.AbstractWindowedCursor._isNull2333 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "isNull", "(I)Z");
			global::android.database.AbstractWindowedCursor._checkPosition2334 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "checkPosition", "()V");
			global::android.database.AbstractWindowedCursor._isBlob2335 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "isBlob", "(I)Z");
			global::android.database.AbstractWindowedCursor._isLong2336 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "isLong", "(I)Z");
			global::android.database.AbstractWindowedCursor._isFloat2337 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "isFloat", "(I)Z");
			global::android.database.AbstractWindowedCursor._isString2338 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "isString", "(I)Z");
			global::android.database.AbstractWindowedCursor._setWindow2339 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "setWindow", "(Landroid/database/CursorWindow;)V");
			global::android.database.AbstractWindowedCursor._hasWindow2340 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "hasWindow", "()Z");
			global::android.database.AbstractWindowedCursor._AbstractWindowedCursor2341 = @__env.GetMethodID(global::android.database.AbstractWindowedCursor.staticClass, "<init>", "()V");
		}
	}
}
