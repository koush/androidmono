namespace android.content.res
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class TypedArray : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static TypedArray()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.res.TypedArray), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.res.TypedArray(@__env);
			}
		}
		protected TypedArray(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString2187;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.TypedArray._toString2187));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._toString2187));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBoolean2188;
		public virtual bool getBoolean(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.res.TypedArray._getBoolean2188, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getBoolean2188, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInt2189;
		public virtual int getInt(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.TypedArray._getInt2189, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getInt2189, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2190;
		public virtual float getFloat(int arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.content.res.TypedArray._getFloat2190, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getFloat2190, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _length2191;
		public virtual int length() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.TypedArray._length2191);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._length2191);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getValue2192;
		public virtual bool getValue(int arg0, android.util.TypedValue arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.res.TypedArray._getValue2192, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getValue2192, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResources2193;
		public virtual global::android.content.res.Resources getResources() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.TypedArray._getResources2193));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getResources2193));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInteger2194;
		public virtual int getInteger(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.TypedArray._getInteger2194, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getInteger2194, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getString2195;
		public virtual global::java.lang.String getString(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.TypedArray._getString2195, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getString2195, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIndex2196;
		public virtual int getIndex(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.TypedArray._getIndex2196, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getIndex2196, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getText2197;
		public virtual global::java.lang.CharSequence getText(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.TypedArray._getText2197, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getText2197, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _recycle2198;
		public virtual void recycle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.TypedArray._recycle2198);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._recycle2198);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextArray2199;
		public virtual global::java.lang.CharSequence[] getTextArray(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.TypedArray._getTextArray2199, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getTextArray2199, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDimension2200;
		public virtual float getDimension(int arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.content.res.TypedArray._getDimension2200, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getDimension2200, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDimensionPixelOffset2201;
		public virtual int getDimensionPixelOffset(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.TypedArray._getDimensionPixelOffset2201, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getDimensionPixelOffset2201, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDimensionPixelSize2202;
		public virtual int getDimensionPixelSize(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.TypedArray._getDimensionPixelSize2202, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getDimensionPixelSize2202, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFraction2203;
		public virtual float getFraction(int arg0, int arg1, int arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.content.res.TypedArray._getFraction2203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getFraction2203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable2204;
		public virtual global::android.graphics.drawable.Drawable getDrawable(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.TypedArray._getDrawable2204, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getDrawable2204, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColor2205;
		public virtual int getColor(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.TypedArray._getColor2205, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getColor2205, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColorStateList2206;
		public virtual global::android.content.res.ColorStateList getColorStateList(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.TypedArray._getColorStateList2206, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getColorStateList2206, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPositionDescription2207;
		public virtual global::java.lang.String getPositionDescription() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.TypedArray._getPositionDescription2207));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getPositionDescription2207));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIndexCount2208;
		public virtual int getIndexCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.TypedArray._getIndexCount2208);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getIndexCount2208);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNonResourceString2209;
		public virtual global::java.lang.String getNonResourceString(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.TypedArray._getNonResourceString2209, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getNonResourceString2209, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutDimension2210;
		public virtual int getLayoutDimension(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.TypedArray._getLayoutDimension2210, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getLayoutDimension2210, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutDimension2211;
		public virtual int getLayoutDimension(int arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.TypedArray._getLayoutDimension2211, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getLayoutDimension2211, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResourceId2212;
		public virtual int getResourceId(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.TypedArray._getResourceId2212, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getResourceId2212, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasValue2213;
		public virtual bool hasValue(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.res.TypedArray._hasValue2213, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._hasValue2213, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _peekValue2214;
		public virtual global::android.util.TypedValue peekValue(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.TypedValue>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.TypedArray._peekValue2214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.TypedValue>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._peekValue2214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.res.TypedArray.staticClass = @__class;
			global::android.content.res.TypedArray._toString2187 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.res.TypedArray._getBoolean2188 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getBoolean", "(IZ)Z");
			global::android.content.res.TypedArray._getInt2189 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getInt", "(II)I");
			global::android.content.res.TypedArray._getFloat2190 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getFloat", "(IF)F");
			global::android.content.res.TypedArray._length2191 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "length", "()I");
			global::android.content.res.TypedArray._getValue2192 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getValue", "(ILandroid/util/TypedValue;)Z");
			global::android.content.res.TypedArray._getResources2193 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getResources", "()Landroid/content/res/Resources;");
			global::android.content.res.TypedArray._getInteger2194 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getInteger", "(II)I");
			global::android.content.res.TypedArray._getString2195 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.content.res.TypedArray._getIndex2196 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getIndex", "(I)I");
			global::android.content.res.TypedArray._getText2197 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getText", "(I)Ljava/lang/CharSequence;");
			global::android.content.res.TypedArray._recycle2198 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "recycle", "()V");
			global::android.content.res.TypedArray._getTextArray2199 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getTextArray", "(I)[Ljava/lang/CharSequence;");
			global::android.content.res.TypedArray._getDimension2200 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getDimension", "(IF)F");
			global::android.content.res.TypedArray._getDimensionPixelOffset2201 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getDimensionPixelOffset", "(II)I");
			global::android.content.res.TypedArray._getDimensionPixelSize2202 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getDimensionPixelSize", "(II)I");
			global::android.content.res.TypedArray._getFraction2203 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getFraction", "(IIIF)F");
			global::android.content.res.TypedArray._getDrawable2204 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;");
			global::android.content.res.TypedArray._getColor2205 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getColor", "(II)I");
			global::android.content.res.TypedArray._getColorStateList2206 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getColorStateList", "(I)Landroid/content/res/ColorStateList;");
			global::android.content.res.TypedArray._getPositionDescription2207 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getPositionDescription", "()Ljava/lang/String;");
			global::android.content.res.TypedArray._getIndexCount2208 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getIndexCount", "()I");
			global::android.content.res.TypedArray._getNonResourceString2209 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getNonResourceString", "(I)Ljava/lang/String;");
			global::android.content.res.TypedArray._getLayoutDimension2210 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getLayoutDimension", "(II)I");
			global::android.content.res.TypedArray._getLayoutDimension2211 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getLayoutDimension", "(ILjava/lang/String;)I");
			global::android.content.res.TypedArray._getResourceId2212 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getResourceId", "(II)I");
			global::android.content.res.TypedArray._hasValue2213 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "hasValue", "(I)Z");
			global::android.content.res.TypedArray._peekValue2214 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "peekValue", "(I)Landroid/util/TypedValue;");
		}
	}
}
