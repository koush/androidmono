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
		internal static global::MonoJavaBridge.MethodId _toString2341;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._toString2341)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._toString2341)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean2342;
		public virtual bool getBoolean(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.TypedArray._getBoolean2342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getBoolean2342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt2343;
		public virtual int getInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getInt2343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getInt2343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat2344;
		public virtual float getFloat(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.content.res.TypedArray._getFloat2344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getFloat2344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _length2345;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._length2345);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._length2345);
		}
		internal static global::MonoJavaBridge.MethodId _getValue2346;
		public virtual bool getValue(int arg0, android.util.TypedValue arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.TypedArray._getValue2346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getValue2346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getResources2347;
		public virtual global::android.content.res.Resources getResources() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getResources2347)) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getResources2347)) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getInteger2348;
		public virtual int getInteger(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getInteger2348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getInteger2348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getString2349;
		public virtual global::java.lang.String getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getString2349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getString2349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getIndex2350;
		public virtual int getIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getIndex2350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getIndex2350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getText2351;
		public virtual global::java.lang.CharSequence getText(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getText2351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getText2351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _recycle2352;
		public virtual void recycle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.TypedArray._recycle2352);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._recycle2352);
		}
		internal static global::MonoJavaBridge.MethodId _getTextArray2353;
		public virtual global::java.lang.CharSequence[] getTextArray(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getTextArray2353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getTextArray2353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence[];
		}
		internal static global::MonoJavaBridge.MethodId _getDimension2354;
		public virtual float getDimension(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.content.res.TypedArray._getDimension2354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getDimension2354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDimensionPixelOffset2355;
		public virtual int getDimensionPixelOffset(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getDimensionPixelOffset2355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getDimensionPixelOffset2355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDimensionPixelSize2356;
		public virtual int getDimensionPixelSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getDimensionPixelSize2356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getDimensionPixelSize2356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFraction2357;
		public virtual float getFraction(int arg0, int arg1, int arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.content.res.TypedArray._getFraction2357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getFraction2357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable2358;
		public virtual global::android.graphics.drawable.Drawable getDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getDrawable2358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getDrawable2358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getColor2359;
		public virtual int getColor(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getColor2359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getColor2359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getColorStateList2360;
		public virtual global::android.content.res.ColorStateList getColorStateList(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getColorStateList2360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getColorStateList2360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _getPositionDescription2361;
		public virtual global::java.lang.String getPositionDescription() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getPositionDescription2361)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getPositionDescription2361)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getIndexCount2362;
		public virtual int getIndexCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getIndexCount2362);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getIndexCount2362);
		}
		internal static global::MonoJavaBridge.MethodId _getNonResourceString2363;
		public virtual global::java.lang.String getNonResourceString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getNonResourceString2363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getNonResourceString2363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutDimension2364;
		public virtual int getLayoutDimension(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getLayoutDimension2364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getLayoutDimension2364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutDimension2365;
		public virtual int getLayoutDimension(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getLayoutDimension2365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getLayoutDimension2365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getResourceId2366;
		public virtual int getResourceId(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getResourceId2366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getResourceId2366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasValue2367;
		public virtual bool hasValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.TypedArray._hasValue2367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._hasValue2367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _peekValue2368;
		public virtual global::android.util.TypedValue peekValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._peekValue2368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.TypedValue;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._peekValue2368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.TypedValue;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.TypedArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/TypedArray"));
			global::android.content.res.TypedArray._toString2341 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.res.TypedArray._getBoolean2342 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getBoolean", "(IZ)Z");
			global::android.content.res.TypedArray._getInt2343 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getInt", "(II)I");
			global::android.content.res.TypedArray._getFloat2344 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getFloat", "(IF)F");
			global::android.content.res.TypedArray._length2345 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "length", "()I");
			global::android.content.res.TypedArray._getValue2346 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getValue", "(ILandroid/util/TypedValue;)Z");
			global::android.content.res.TypedArray._getResources2347 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getResources", "()Landroid/content/res/Resources;");
			global::android.content.res.TypedArray._getInteger2348 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getInteger", "(II)I");
			global::android.content.res.TypedArray._getString2349 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.content.res.TypedArray._getIndex2350 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getIndex", "(I)I");
			global::android.content.res.TypedArray._getText2351 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getText", "(I)Ljava/lang/CharSequence;");
			global::android.content.res.TypedArray._recycle2352 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "recycle", "()V");
			global::android.content.res.TypedArray._getTextArray2353 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getTextArray", "(I)[Ljava/lang/CharSequence;");
			global::android.content.res.TypedArray._getDimension2354 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getDimension", "(IF)F");
			global::android.content.res.TypedArray._getDimensionPixelOffset2355 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getDimensionPixelOffset", "(II)I");
			global::android.content.res.TypedArray._getDimensionPixelSize2356 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getDimensionPixelSize", "(II)I");
			global::android.content.res.TypedArray._getFraction2357 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getFraction", "(IIIF)F");
			global::android.content.res.TypedArray._getDrawable2358 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;");
			global::android.content.res.TypedArray._getColor2359 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getColor", "(II)I");
			global::android.content.res.TypedArray._getColorStateList2360 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getColorStateList", "(I)Landroid/content/res/ColorStateList;");
			global::android.content.res.TypedArray._getPositionDescription2361 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getPositionDescription", "()Ljava/lang/String;");
			global::android.content.res.TypedArray._getIndexCount2362 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getIndexCount", "()I");
			global::android.content.res.TypedArray._getNonResourceString2363 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getNonResourceString", "(I)Ljava/lang/String;");
			global::android.content.res.TypedArray._getLayoutDimension2364 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getLayoutDimension", "(II)I");
			global::android.content.res.TypedArray._getLayoutDimension2365 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getLayoutDimension", "(ILjava/lang/String;)I");
			global::android.content.res.TypedArray._getResourceId2366 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getResourceId", "(II)I");
			global::android.content.res.TypedArray._hasValue2367 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "hasValue", "(I)Z");
			global::android.content.res.TypedArray._peekValue2368 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "peekValue", "(I)Landroid/util/TypedValue;");
		}
	}
}
