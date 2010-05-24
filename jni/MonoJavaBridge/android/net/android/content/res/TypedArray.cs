namespace android.content.res 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TypedArray : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static TypedArray() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.res.TypedArray), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getBoolean2006; 
		public virtual bool getBoolean(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallBooleanMethod(this, _getBoolean2006, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.res.TypedArray.staticClass, _getBoolean2006, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInt2007; 
		public virtual int getInt(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getInt2007, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getInt2007, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2008; 
		public virtual float getFloat(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallFloatMethod(this, _getFloat2008, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.content.res.TypedArray.staticClass, _getFloat2008, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString2009; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString2009)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _toString2009)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _length2010; 
		public virtual int length() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _length2010); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _length2010); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValue2011; 
		public virtual bool getValue(int arg0, android.util.TypedValue arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallBooleanMethod(this, _getValue2011, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.res.TypedArray.staticClass, _getValue2011, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResources2012; 
		public virtual android.content.res.Resources getResources() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallObjectMethodPtr(this, _getResources2012)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _getResources2012)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInteger2013; 
		public virtual int getInteger(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getInteger2013, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getInteger2013, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getString2014; 
		public virtual java.lang.String getString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getString2014, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _getString2014, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIndex2015; 
		public virtual int getIndex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getIndex2015, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getIndex2015, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText2016; 
		public virtual java.lang.CharSequence getText(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getText2016, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _getText2016, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _recycle2017; 
		public virtual void recycle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				@__env.CallVoidMethod(this, _recycle2017); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.TypedArray.staticClass, _recycle2017); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextArray2018; 
		public virtual java.lang.CharSequence[] getTextArray(int arg0) 
		{ 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getTextArray2018, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _getTextArray2018, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDimension2019; 
		public virtual float getDimension(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallFloatMethod(this, _getDimension2019, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.content.res.TypedArray.staticClass, _getDimension2019, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDimensionPixelOffset2020; 
		public virtual int getDimensionPixelOffset(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getDimensionPixelOffset2020, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getDimensionPixelOffset2020, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDimensionPixelSize2021; 
		public virtual int getDimensionPixelSize(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getDimensionPixelSize2021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getDimensionPixelSize2021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFraction2022; 
		public virtual float getFraction(int arg0, int arg1, int arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallFloatMethod(this, _getFraction2022, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.content.res.TypedArray.staticClass, _getFraction2022, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable2023; 
		public virtual android.graphics.drawable.Drawable getDrawable(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getDrawable2023, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _getDrawable2023, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColor2024; 
		public virtual int getColor(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getColor2024, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getColor2024, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColorStateList2025; 
		public virtual android.content.res.ColorStateList getColorStateList(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, _getColorStateList2025, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _getColorStateList2025, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPositionDescription2026; 
		public virtual java.lang.String getPositionDescription() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPositionDescription2026)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _getPositionDescription2026)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIndexCount2027; 
		public virtual int getIndexCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getIndexCount2027); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getIndexCount2027); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNonResourceString2028; 
		public virtual java.lang.String getNonResourceString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getNonResourceString2028, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _getNonResourceString2028, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutDimension2029; 
		public virtual int getLayoutDimension(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getLayoutDimension2029, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getLayoutDimension2029, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutDimension2030; 
		public virtual int getLayoutDimension(int arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getLayoutDimension2030, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getLayoutDimension2030, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResourceId2031; 
		public virtual int getResourceId(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getResourceId2031, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getResourceId2031, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasValue2032; 
		public virtual bool hasValue(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallBooleanMethod(this, _hasValue2032, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.res.TypedArray.staticClass, _hasValue2032, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _peekValue2033; 
		public virtual android.util.TypedValue peekValue(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.TypedValue>(@__env, @__env.CallObjectMethodPtr(this, _peekValue2033, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.TypedValue>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _peekValue2033, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.res.TypedArray.staticClass = @__class; 
			global::android.content.res.TypedArray._getBoolean2006 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getBoolean", "(IZ)Z"); 
			global::android.content.res.TypedArray._getInt2007 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getInt", "(II)I"); 
			global::android.content.res.TypedArray._getFloat2008 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getFloat", "(IF)F"); 
			global::android.content.res.TypedArray._toString2009 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.res.TypedArray._length2010 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "length", "()I"); 
			global::android.content.res.TypedArray._getValue2011 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getValue", "(ILandroid/util/TypedValue;)Z"); 
			global::android.content.res.TypedArray._getResources2012 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getResources", "()Landroid/content/res/Resources;"); 
			global::android.content.res.TypedArray._getInteger2013 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getInteger", "(II)I"); 
			global::android.content.res.TypedArray._getString2014 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getString", "(I)Ljava/lang/String;"); 
			global::android.content.res.TypedArray._getIndex2015 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getIndex", "(I)I"); 
			global::android.content.res.TypedArray._getText2016 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getText", "(I)Ljava/lang/CharSequence;"); 
			global::android.content.res.TypedArray._recycle2017 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "recycle", "()V"); 
			global::android.content.res.TypedArray._getTextArray2018 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getTextArray", "(I)[Ljava/lang/CharSequence;"); 
			global::android.content.res.TypedArray._getDimension2019 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getDimension", "(IF)F"); 
			global::android.content.res.TypedArray._getDimensionPixelOffset2020 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getDimensionPixelOffset", "(II)I"); 
			global::android.content.res.TypedArray._getDimensionPixelSize2021 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getDimensionPixelSize", "(II)I"); 
			global::android.content.res.TypedArray._getFraction2022 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getFraction", "(IIIF)F"); 
			global::android.content.res.TypedArray._getDrawable2023 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;"); 
			global::android.content.res.TypedArray._getColor2024 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getColor", "(II)I"); 
			global::android.content.res.TypedArray._getColorStateList2025 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getColorStateList", "(I)Landroid/content/res/ColorStateList;"); 
			global::android.content.res.TypedArray._getPositionDescription2026 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getPositionDescription", "()Ljava/lang/String;"); 
			global::android.content.res.TypedArray._getIndexCount2027 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getIndexCount", "()I"); 
			global::android.content.res.TypedArray._getNonResourceString2028 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getNonResourceString", "(I)Ljava/lang/String;"); 
			global::android.content.res.TypedArray._getLayoutDimension2029 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getLayoutDimension", "(II)I"); 
			global::android.content.res.TypedArray._getLayoutDimension2030 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getLayoutDimension", "(ILjava/lang/String;)I"); 
			global::android.content.res.TypedArray._getResourceId2031 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getResourceId", "(II)I"); 
			global::android.content.res.TypedArray._hasValue2032 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "hasValue", "(I)Z"); 
			global::android.content.res.TypedArray._peekValue2033 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "peekValue", "(I)Landroid/util/TypedValue;"); 
		} 
	} 
} 
