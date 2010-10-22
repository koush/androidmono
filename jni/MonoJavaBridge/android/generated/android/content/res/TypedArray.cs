namespace android.content.res
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TypedArray : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TypedArray()
		{
			InitJNI();
		}
		protected TypedArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString4239;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._toString4239)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._toString4239)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean4240;
		public virtual bool getBoolean(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.TypedArray._getBoolean4240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getBoolean4240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt4241;
		public virtual int getInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getInt4241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getInt4241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat4242;
		public virtual float getFloat(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.content.res.TypedArray._getFloat4242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getFloat4242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _length4243;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._length4243);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._length4243);
		}
		internal static global::MonoJavaBridge.MethodId _getValue4244;
		public virtual bool getValue(int arg0, android.util.TypedValue arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.TypedArray._getValue4244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getValue4244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.content.res.Resources Resources
		{
			get
			{
				return getResources();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResources4245;
		public virtual global::android.content.res.Resources getResources() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getResources4245)) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getResources4245)) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getInteger4246;
		public virtual int getInteger(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getInteger4246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getInteger4246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getString4247;
		public virtual global::java.lang.String getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getString4247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getString4247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getIndex4248;
		public virtual int getIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getIndex4248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getIndex4248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getText4249;
		public virtual global::java.lang.CharSequence getText(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getText4249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getText4249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _recycle4250;
		public virtual void recycle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.TypedArray._recycle4250);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._recycle4250);
		}
		internal static global::MonoJavaBridge.MethodId _getTextArray4251;
		public virtual global::java.lang.CharSequence[] getTextArray(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getTextArray4251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getTextArray4251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence[];
		}
		internal static global::MonoJavaBridge.MethodId _getDimension4252;
		public virtual float getDimension(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.content.res.TypedArray._getDimension4252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getDimension4252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDimensionPixelOffset4253;
		public virtual int getDimensionPixelOffset(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getDimensionPixelOffset4253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getDimensionPixelOffset4253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDimensionPixelSize4254;
		public virtual int getDimensionPixelSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getDimensionPixelSize4254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getDimensionPixelSize4254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFraction4255;
		public virtual float getFraction(int arg0, int arg1, int arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.content.res.TypedArray._getFraction4255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getFraction4255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable4256;
		public virtual global::android.graphics.drawable.Drawable getDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getDrawable4256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getDrawable4256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getColor4257;
		public virtual int getColor(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getColor4257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getColor4257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getColorStateList4258;
		public virtual global::android.content.res.ColorStateList getColorStateList(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getColorStateList4258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getColorStateList4258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
		}
		public new global::java.lang.String PositionDescription
		{
			get
			{
				return getPositionDescription();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPositionDescription4259;
		public virtual global::java.lang.String getPositionDescription() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getPositionDescription4259)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getPositionDescription4259)) as java.lang.String;
		}
		public new int IndexCount
		{
			get
			{
				return getIndexCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndexCount4260;
		public virtual int getIndexCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getIndexCount4260);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getIndexCount4260);
		}
		internal static global::MonoJavaBridge.MethodId _getNonResourceString4261;
		public virtual global::java.lang.String getNonResourceString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getNonResourceString4261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getNonResourceString4261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutDimension4262;
		public virtual int getLayoutDimension(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getLayoutDimension4262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getLayoutDimension4262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutDimension4263;
		public virtual int getLayoutDimension(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getLayoutDimension4263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getLayoutDimension4263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getResourceId4264;
		public virtual int getResourceId(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getResourceId4264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getResourceId4264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasValue4265;
		public virtual bool hasValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.TypedArray._hasValue4265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._hasValue4265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _peekValue4266;
		public virtual global::android.util.TypedValue peekValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._peekValue4266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.TypedValue;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._peekValue4266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.TypedValue;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.TypedArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/TypedArray"));
			global::android.content.res.TypedArray._toString4239 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.res.TypedArray._getBoolean4240 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getBoolean", "(IZ)Z");
			global::android.content.res.TypedArray._getInt4241 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getInt", "(II)I");
			global::android.content.res.TypedArray._getFloat4242 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getFloat", "(IF)F");
			global::android.content.res.TypedArray._length4243 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "length", "()I");
			global::android.content.res.TypedArray._getValue4244 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getValue", "(ILandroid/util/TypedValue;)Z");
			global::android.content.res.TypedArray._getResources4245 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getResources", "()Landroid/content/res/Resources;");
			global::android.content.res.TypedArray._getInteger4246 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getInteger", "(II)I");
			global::android.content.res.TypedArray._getString4247 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.content.res.TypedArray._getIndex4248 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getIndex", "(I)I");
			global::android.content.res.TypedArray._getText4249 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getText", "(I)Ljava/lang/CharSequence;");
			global::android.content.res.TypedArray._recycle4250 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "recycle", "()V");
			global::android.content.res.TypedArray._getTextArray4251 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getTextArray", "(I)[Ljava/lang/CharSequence;");
			global::android.content.res.TypedArray._getDimension4252 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getDimension", "(IF)F");
			global::android.content.res.TypedArray._getDimensionPixelOffset4253 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getDimensionPixelOffset", "(II)I");
			global::android.content.res.TypedArray._getDimensionPixelSize4254 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getDimensionPixelSize", "(II)I");
			global::android.content.res.TypedArray._getFraction4255 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getFraction", "(IIIF)F");
			global::android.content.res.TypedArray._getDrawable4256 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;");
			global::android.content.res.TypedArray._getColor4257 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getColor", "(II)I");
			global::android.content.res.TypedArray._getColorStateList4258 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getColorStateList", "(I)Landroid/content/res/ColorStateList;");
			global::android.content.res.TypedArray._getPositionDescription4259 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getPositionDescription", "()Ljava/lang/String;");
			global::android.content.res.TypedArray._getIndexCount4260 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getIndexCount", "()I");
			global::android.content.res.TypedArray._getNonResourceString4261 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getNonResourceString", "(I)Ljava/lang/String;");
			global::android.content.res.TypedArray._getLayoutDimension4262 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getLayoutDimension", "(II)I");
			global::android.content.res.TypedArray._getLayoutDimension4263 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getLayoutDimension", "(ILjava/lang/String;)I");
			global::android.content.res.TypedArray._getResourceId4264 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getResourceId", "(II)I");
			global::android.content.res.TypedArray._hasValue4265 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "hasValue", "(I)Z");
			global::android.content.res.TypedArray._peekValue4266 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "peekValue", "(I)Landroid/util/TypedValue;");
		}
	}
}
