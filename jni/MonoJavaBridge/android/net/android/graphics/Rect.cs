namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Rect : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Rect() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Rect), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _equals3082; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallBooleanMethod(this, _equals3082, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Rect.staticClass, _equals3082, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString3083; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString3083)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Rect.staticClass, _toString3083)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offset3084; 
		public void offset(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, _offset3084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Rect.staticClass, _offset3084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty3085; 
		public bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallBooleanMethod(this, _isEmpty3085); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Rect.staticClass, _isEmpty3085); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _contains3086; 
		public bool contains(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallBooleanMethod(this, _contains3086, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Rect.staticClass, _contains3086, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _contains3087; 
		public bool contains(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallBooleanMethod(this, _contains3087, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Rect.staticClass, _contains3087, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _contains3088; 
		public bool contains(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallBooleanMethod(this, _contains3088, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Rect.staticClass, _contains3088, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set3089; 
		public void set(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, _set3089, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Rect.staticClass, _set3089, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set3090; 
		public void set(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, _set3090, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Rect.staticClass, _set3090, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sort3091; 
		public void sort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, _sort3091); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Rect.staticClass, _sort3091); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intersects3092; 
		public static bool intersects(android.graphics.Rect arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.graphics.Rect.staticClass, _intersects3092, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intersects3093; 
		public bool intersects(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallBooleanMethod(this, _intersects3093, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Rect.staticClass, _intersects3093, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _union3094; 
		public void union(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, _union3094, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Rect.staticClass, _union3094, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _union3095; 
		public void union(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, _union3095, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Rect.staticClass, _union3095, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _union3096; 
		public void union(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, _union3096, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Rect.staticClass, _union3096, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _centerX3097; 
		public int centerX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallIntMethod(this, _centerX3097); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Rect.staticClass, _centerX3097); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _centerY3098; 
		public int centerY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallIntMethod(this, _centerY3098); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Rect.staticClass, _centerY3098); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _height3099; 
		public int height() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallIntMethod(this, _height3099); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Rect.staticClass, _height3099); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _width3100; 
		public int width() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallIntMethod(this, _width3100); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Rect.staticClass, _width3100); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel3101; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, _writeToParcel3101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Rect.staticClass, _writeToParcel3101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents3102; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallIntMethod(this, _describeContents3102); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Rect.staticClass, _describeContents3102); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readFromParcel3103; 
		public void readFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, _readFromParcel3103, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Rect.staticClass, _readFromParcel3103, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flattenToString3104; 
		public java.lang.String flattenToString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _flattenToString3104)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Rect.staticClass, _flattenToString3104)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unflattenFromString3105; 
		public static android.graphics.Rect unflattenFromString(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Rect.staticClass, _unflattenFromString3105, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toShortString3106; 
		public java.lang.String toShortString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toShortString3106)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Rect.staticClass, _toShortString3106)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEmpty3107; 
		public void setEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, _setEmpty3107); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Rect.staticClass, _setEmpty3107); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _exactCenterX3108; 
		public float exactCenterX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallFloatMethod(this, _exactCenterX3108); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.Rect.staticClass, _exactCenterX3108); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _exactCenterY3109; 
		public float exactCenterY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallFloatMethod(this, _exactCenterY3109); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.Rect.staticClass, _exactCenterY3109); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offsetTo3110; 
		public void offsetTo(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, _offsetTo3110, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Rect.staticClass, _offsetTo3110, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inset3111; 
		public void inset(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				@__env.CallVoidMethod(this, _inset3111, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Rect.staticClass, _inset3111, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intersect3112; 
		public bool intersect(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallBooleanMethod(this, _intersect3112, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Rect.staticClass, _intersect3112, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intersect3113; 
		public bool intersect(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallBooleanMethod(this, _intersect3113, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Rect.staticClass, _intersect3113, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIntersect3114; 
		public bool setIntersect(android.graphics.Rect arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Rect)) 
				return @__env.CallBooleanMethod(this, _setIntersect3114, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Rect.staticClass, _setIntersect3114, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Rect3115; 
		public Rect()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Rect.staticClass, _Rect3115, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Rect3116; 
		public Rect(int arg0, int arg1, int arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Rect.staticClass, _Rect3116, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Rect3117; 
		public Rect(android.graphics.Rect arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Rect.staticClass, _Rect3117, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _left3118; 
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
		internal static global::net.sf.jni4net.jni.FieldId _top3119; 
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
		internal static global::net.sf.jni4net.jni.FieldId _right3120; 
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
		internal static global::net.sf.jni4net.jni.FieldId _bottom3121; 
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR3122; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.Rect.staticClass = @__class; 
			global::android.graphics.Rect._equals3082 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.graphics.Rect._toString3083 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.graphics.Rect._offset3084 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "offset", "(II)V"); 
			global::android.graphics.Rect._isEmpty3085 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "isEmpty", "()Z"); 
			global::android.graphics.Rect._contains3086 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "contains", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.Rect._contains3087 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "contains", "(IIII)Z"); 
			global::android.graphics.Rect._contains3088 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "contains", "(II)Z"); 
			global::android.graphics.Rect._set3089 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "set", "(IIII)V"); 
			global::android.graphics.Rect._set3090 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "set", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.Rect._sort3091 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "sort", "()V"); 
			global::android.graphics.Rect._intersects3092 = @__env.GetStaticMethodID(global::android.graphics.Rect.staticClass, "intersects", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z"); 
			global::android.graphics.Rect._intersects3093 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "intersects", "(IIII)Z"); 
			global::android.graphics.Rect._union3094 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "union", "(II)V"); 
			global::android.graphics.Rect._union3095 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "union", "(IIII)V"); 
			global::android.graphics.Rect._union3096 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "union", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.Rect._centerX3097 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "centerX", "()I"); 
			global::android.graphics.Rect._centerY3098 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "centerY", "()I"); 
			global::android.graphics.Rect._height3099 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "height", "()I"); 
			global::android.graphics.Rect._width3100 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "width", "()I"); 
			global::android.graphics.Rect._writeToParcel3101 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.graphics.Rect._describeContents3102 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "describeContents", "()I"); 
			global::android.graphics.Rect._readFromParcel3103 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V"); 
			global::android.graphics.Rect._flattenToString3104 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "flattenToString", "()Ljava/lang/String;"); 
			global::android.graphics.Rect._unflattenFromString3105 = @__env.GetStaticMethodID(global::android.graphics.Rect.staticClass, "unflattenFromString", "(Ljava/lang/String;)Landroid/graphics/Rect;"); 
			global::android.graphics.Rect._toShortString3106 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "toShortString", "()Ljava/lang/String;"); 
			global::android.graphics.Rect._setEmpty3107 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "setEmpty", "()V"); 
			global::android.graphics.Rect._exactCenterX3108 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "exactCenterX", "()F"); 
			global::android.graphics.Rect._exactCenterY3109 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "exactCenterY", "()F"); 
			global::android.graphics.Rect._offsetTo3110 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "offsetTo", "(II)V"); 
			global::android.graphics.Rect._inset3111 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "inset", "(II)V"); 
			global::android.graphics.Rect._intersect3112 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "intersect", "(IIII)Z"); 
			global::android.graphics.Rect._intersect3113 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "intersect", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.Rect._setIntersect3114 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "setIntersect", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z"); 
			global::android.graphics.Rect._Rect3115 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "<init>", "()V"); 
			global::android.graphics.Rect._Rect3116 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "<init>", "(IIII)V"); 
			global::android.graphics.Rect._Rect3117 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "<init>", "(Landroid/graphics/Rect;)V"); 
		} 
	} 
} 
