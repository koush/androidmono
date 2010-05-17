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
		internal static global::net.sf.jni4net.jni.MethodId _getBoolean1961; 
		public virtual bool getBoolean(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallBooleanMethod(this, _getBoolean1961, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.res.TypedArray.staticClass, _getBoolean1961, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInt1962; 
		public virtual int getInt(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getInt1962, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getInt1962, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFloat1963; 
		public virtual float getFloat(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallFloatMethod(this, _getFloat1963, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.content.res.TypedArray.staticClass, _getFloat1963, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString1964; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1964)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _toString1964)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _length1965; 
		public virtual int length() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _length1965); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _length1965); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValue1966; 
		public virtual bool getValue(int arg0, android.util.TypedValue arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallBooleanMethod(this, _getValue1966, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.res.TypedArray.staticClass, _getValue1966, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResources1967; 
		public virtual android.content.res.Resources getResources() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallObjectMethodPtr(this, _getResources1967)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _getResources1967)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInteger1968; 
		public virtual int getInteger(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getInteger1968, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getInteger1968, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getString1969; 
		public virtual java.lang.String getString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getString1969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _getString1969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIndex1970; 
		public virtual int getIndex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getIndex1970, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getIndex1970, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText1971; 
		public virtual java.lang.CharSequence getText(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getText1971, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _getText1971, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _recycle1972; 
		public virtual void recycle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				@__env.CallVoidMethod(this, _recycle1972); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.TypedArray.staticClass, _recycle1972); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextArray1973; 
		public virtual java.lang.CharSequence[] getTextArray(int arg0) 
		{ 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getTextArray1973, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _getTextArray1973, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDimension1974; 
		public virtual float getDimension(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallFloatMethod(this, _getDimension1974, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.content.res.TypedArray.staticClass, _getDimension1974, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDimensionPixelOffset1975; 
		public virtual int getDimensionPixelOffset(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getDimensionPixelOffset1975, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getDimensionPixelOffset1975, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDimensionPixelSize1976; 
		public virtual int getDimensionPixelSize(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getDimensionPixelSize1976, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getDimensionPixelSize1976, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFraction1977; 
		public virtual float getFraction(int arg0, int arg1, int arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallFloatMethod(this, _getFraction1977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.content.res.TypedArray.staticClass, _getFraction1977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable1978; 
		public virtual android.graphics.drawable.Drawable getDrawable(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getDrawable1978, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _getDrawable1978, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColor1979; 
		public virtual int getColor(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getColor1979, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getColor1979, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColorStateList1980; 
		public virtual android.content.res.ColorStateList getColorStateList(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, _getColorStateList1980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _getColorStateList1980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPositionDescription1981; 
		public virtual java.lang.String getPositionDescription() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPositionDescription1981)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _getPositionDescription1981)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIndexCount1982; 
		public virtual int getIndexCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getIndexCount1982); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getIndexCount1982); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNonResourceString1983; 
		public virtual java.lang.String getNonResourceString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getNonResourceString1983, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _getNonResourceString1983, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutDimension1984; 
		public virtual int getLayoutDimension(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getLayoutDimension1984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getLayoutDimension1984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutDimension1985; 
		public virtual int getLayoutDimension(int arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getLayoutDimension1985, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getLayoutDimension1985, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResourceId1986; 
		public virtual int getResourceId(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallIntMethod(this, _getResourceId1986, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.TypedArray.staticClass, _getResourceId1986, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasValue1987; 
		public virtual bool hasValue(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return @__env.CallBooleanMethod(this, _hasValue1987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.res.TypedArray.staticClass, _hasValue1987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _peekValue1988; 
		public virtual android.util.TypedValue peekValue(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.TypedArray)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.TypedValue>(@__env, @__env.CallObjectMethodPtr(this, _peekValue1988, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.TypedValue>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.TypedArray.staticClass, _peekValue1988, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.res.TypedArray.staticClass = @__class; 
			global::android.content.res.TypedArray._getBoolean1961 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getBoolean", "(IZ)Z"); 
			global::android.content.res.TypedArray._getInt1962 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getInt", "(II)I"); 
			global::android.content.res.TypedArray._getFloat1963 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getFloat", "(IF)F"); 
			global::android.content.res.TypedArray._toString1964 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.res.TypedArray._length1965 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "length", "()I"); 
			global::android.content.res.TypedArray._getValue1966 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getValue", "(ILandroid/util/TypedValue;)Z"); 
			global::android.content.res.TypedArray._getResources1967 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getResources", "()Landroid/content/res/Resources;"); 
			global::android.content.res.TypedArray._getInteger1968 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getInteger", "(II)I"); 
			global::android.content.res.TypedArray._getString1969 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getString", "(I)Ljava/lang/String;"); 
			global::android.content.res.TypedArray._getIndex1970 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getIndex", "(I)I"); 
			global::android.content.res.TypedArray._getText1971 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getText", "(I)Ljava/lang/CharSequence;"); 
			global::android.content.res.TypedArray._recycle1972 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "recycle", "()V"); 
			global::android.content.res.TypedArray._getTextArray1973 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getTextArray", "(I)[Ljava/lang/CharSequence;"); 
			global::android.content.res.TypedArray._getDimension1974 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getDimension", "(IF)F"); 
			global::android.content.res.TypedArray._getDimensionPixelOffset1975 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getDimensionPixelOffset", "(II)I"); 
			global::android.content.res.TypedArray._getDimensionPixelSize1976 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getDimensionPixelSize", "(II)I"); 
			global::android.content.res.TypedArray._getFraction1977 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getFraction", "(IIIF)F"); 
			global::android.content.res.TypedArray._getDrawable1978 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;"); 
			global::android.content.res.TypedArray._getColor1979 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getColor", "(II)I"); 
			global::android.content.res.TypedArray._getColorStateList1980 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getColorStateList", "(I)Landroid/content/res/ColorStateList;"); 
			global::android.content.res.TypedArray._getPositionDescription1981 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getPositionDescription", "()Ljava/lang/String;"); 
			global::android.content.res.TypedArray._getIndexCount1982 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getIndexCount", "()I"); 
			global::android.content.res.TypedArray._getNonResourceString1983 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getNonResourceString", "(I)Ljava/lang/String;"); 
			global::android.content.res.TypedArray._getLayoutDimension1984 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getLayoutDimension", "(II)I"); 
			global::android.content.res.TypedArray._getLayoutDimension1985 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getLayoutDimension", "(ILjava/lang/String;)I"); 
			global::android.content.res.TypedArray._getResourceId1986 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "getResourceId", "(II)I"); 
			global::android.content.res.TypedArray._hasValue1987 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "hasValue", "(I)Z"); 
			global::android.content.res.TypedArray._peekValue1988 = @__env.GetMethodID(global::android.content.res.TypedArray.staticClass, "peekValue", "(I)Landroid/util/TypedValue;"); 
		} 
	} 
} 
