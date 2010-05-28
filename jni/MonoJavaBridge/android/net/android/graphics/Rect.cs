namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Rect : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Rect() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Rect), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.Rect(@__env); 
			} 
		} 
		internal Rect(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals3282; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Rect._equals3282, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._equals3282, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString3283; 
		public sealed override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Rect._toString3283)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._toString3283)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offset3284; 
		public void offset(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, global::android.graphics.Rect._offset3284, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._offset3284, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty3285; 
		public bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Rect._isEmpty3285); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._isEmpty3285); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _contains3286; 
		public bool contains(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Rect._contains3286, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._contains3286, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _contains3287; 
		public bool contains(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Rect._contains3287, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._contains3287, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _contains3288; 
		public bool contains(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Rect._contains3288, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._contains3288, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set3289; 
		public void set(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, global::android.graphics.Rect._set3289, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._set3289, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set3290; 
		public void set(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, global::android.graphics.Rect._set3290, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._set3290, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sort3291; 
		public void sort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, global::android.graphics.Rect._sort3291); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._sort3291); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intersects3292; 
		public static bool intersects(android.graphics.Rect arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.graphics.Rect.staticClass, global::android.graphics.Rect._intersects3292, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intersects3293; 
		public bool intersects(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Rect._intersects3293, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._intersects3293, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _union3294; 
		public void union(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, global::android.graphics.Rect._union3294, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._union3294, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _union3295; 
		public void union(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, global::android.graphics.Rect._union3295, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._union3295, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _union3296; 
		public void union(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, global::android.graphics.Rect._union3296, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._union3296, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _centerX3297; 
		public int centerX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallIntMethod(this, global::android.graphics.Rect._centerX3297); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._centerX3297); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _centerY3298; 
		public int centerY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallIntMethod(this, global::android.graphics.Rect._centerY3298); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._centerY3298); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _height3299; 
		public int height() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallIntMethod(this, global::android.graphics.Rect._height3299); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._height3299); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _width3300; 
		public int width() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallIntMethod(this, global::android.graphics.Rect._width3300); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._width3300); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel3301; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, global::android.graphics.Rect._writeToParcel3301, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._writeToParcel3301, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents3302; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallIntMethod(this, global::android.graphics.Rect._describeContents3302); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._describeContents3302); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readFromParcel3303; 
		public void readFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, global::android.graphics.Rect._readFromParcel3303, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._readFromParcel3303, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flattenToString3304; 
		public global::java.lang.String flattenToString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Rect._flattenToString3304)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._flattenToString3304)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unflattenFromString3305; 
		public static global::android.graphics.Rect unflattenFromString(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Rect.staticClass, global::android.graphics.Rect._unflattenFromString3305, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toShortString3306; 
		public global::java.lang.String toShortString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Rect._toShortString3306)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._toShortString3306)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEmpty3307; 
		public void setEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, global::android.graphics.Rect._setEmpty3307); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._setEmpty3307); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _exactCenterX3308; 
		public float exactCenterX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallFloatMethod(this, global::android.graphics.Rect._exactCenterX3308); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._exactCenterX3308); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _exactCenterY3309; 
		public float exactCenterY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallFloatMethod(this, global::android.graphics.Rect._exactCenterY3309); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._exactCenterY3309); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offsetTo3310; 
		public void offsetTo(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, global::android.graphics.Rect._offsetTo3310, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._offsetTo3310, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inset3311; 
		public void inset(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, global::android.graphics.Rect._inset3311, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._inset3311, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intersect3312; 
		public bool intersect(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Rect._intersect3312, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._intersect3312, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intersect3313; 
		public bool intersect(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Rect._intersect3313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._intersect3313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIntersect3314; 
		public bool setIntersect(android.graphics.Rect arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Rect._setIntersect3314, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._setIntersect3314, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Rect3315; 
		public Rect()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._Rect3315, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Rect3316; 
		public Rect(int arg0, int arg1, int arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._Rect3316, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Rect3317; 
		public Rect(android.graphics.Rect arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._Rect3317, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _left3318; 
		public int left
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _top3319; 
		public int top
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _right3320; 
		public int right
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _bottom3321; 
		public int bottom
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR3322; 
		public static global::android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(global::android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.Rect.staticClass = @__class; 
			global::android.graphics.Rect._equals3282 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.graphics.Rect._toString3283 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.graphics.Rect._offset3284 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "offset", "(II)V"); 
			global::android.graphics.Rect._isEmpty3285 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "isEmpty", "()Z"); 
			global::android.graphics.Rect._contains3286 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "contains", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.Rect._contains3287 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "contains", "(IIII)Z"); 
			global::android.graphics.Rect._contains3288 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "contains", "(II)Z"); 
			global::android.graphics.Rect._set3289 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "set", "(IIII)V"); 
			global::android.graphics.Rect._set3290 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "set", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.Rect._sort3291 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "sort", "()V"); 
			global::android.graphics.Rect._intersects3292 = @__env.GetStaticMethodID(global::android.graphics.Rect.staticClass, "intersects", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z"); 
			global::android.graphics.Rect._intersects3293 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "intersects", "(IIII)Z"); 
			global::android.graphics.Rect._union3294 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "union", "(II)V"); 
			global::android.graphics.Rect._union3295 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "union", "(IIII)V"); 
			global::android.graphics.Rect._union3296 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "union", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.Rect._centerX3297 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "centerX", "()I"); 
			global::android.graphics.Rect._centerY3298 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "centerY", "()I"); 
			global::android.graphics.Rect._height3299 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "height", "()I"); 
			global::android.graphics.Rect._width3300 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "width", "()I"); 
			global::android.graphics.Rect._writeToParcel3301 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.graphics.Rect._describeContents3302 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "describeContents", "()I"); 
			global::android.graphics.Rect._readFromParcel3303 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V"); 
			global::android.graphics.Rect._flattenToString3304 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "flattenToString", "()Ljava/lang/String;"); 
			global::android.graphics.Rect._unflattenFromString3305 = @__env.GetStaticMethodID(global::android.graphics.Rect.staticClass, "unflattenFromString", "(Ljava/lang/String;)Landroid/graphics/Rect;"); 
			global::android.graphics.Rect._toShortString3306 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "toShortString", "()Ljava/lang/String;"); 
			global::android.graphics.Rect._setEmpty3307 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "setEmpty", "()V"); 
			global::android.graphics.Rect._exactCenterX3308 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "exactCenterX", "()F"); 
			global::android.graphics.Rect._exactCenterY3309 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "exactCenterY", "()F"); 
			global::android.graphics.Rect._offsetTo3310 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "offsetTo", "(II)V"); 
			global::android.graphics.Rect._inset3311 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "inset", "(II)V"); 
			global::android.graphics.Rect._intersect3312 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "intersect", "(IIII)Z"); 
			global::android.graphics.Rect._intersect3313 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "intersect", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.Rect._setIntersect3314 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "setIntersect", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z"); 
			global::android.graphics.Rect._Rect3315 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "<init>", "()V"); 
			global::android.graphics.Rect._Rect3316 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "<init>", "(IIII)V"); 
			global::android.graphics.Rect._Rect3317 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "<init>", "(Landroid/graphics/Rect;)V"); 
		} 
	} 
} 
