namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RectF : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static RectF() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.RectF), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.RectF(@__env); 
			} 
		} 
		protected RectF(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString3123; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString3123)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.RectF.staticClass, _toString3123)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offset3124; 
		public virtual void offset(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				@__env.CallVoidMethod(this, _offset3124, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.RectF.staticClass, _offset3124, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty3125; 
		public virtual bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				return @__env.CallBooleanMethod(this, _isEmpty3125); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.RectF.staticClass, _isEmpty3125); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _contains3126; 
		public virtual bool contains(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				return @__env.CallBooleanMethod(this, _contains3126, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.RectF.staticClass, _contains3126, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _contains3127; 
		public virtual bool contains(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				return @__env.CallBooleanMethod(this, _contains3127, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.RectF.staticClass, _contains3127, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _contains3128; 
		public virtual bool contains(android.graphics.RectF arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				return @__env.CallBooleanMethod(this, _contains3128, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.RectF.staticClass, _contains3128, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set3129; 
		public virtual void set(android.graphics.RectF arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				@__env.CallVoidMethod(this, _set3129, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.RectF.staticClass, _set3129, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set3130; 
		public virtual void set(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				@__env.CallVoidMethod(this, _set3130, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.RectF.staticClass, _set3130, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set3131; 
		public virtual void set(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				@__env.CallVoidMethod(this, _set3131, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.RectF.staticClass, _set3131, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sort3132; 
		public virtual void sort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				@__env.CallVoidMethod(this, _sort3132); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.RectF.staticClass, _sort3132); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _round3133; 
		public virtual void round(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				@__env.CallVoidMethod(this, _round3133, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.RectF.staticClass, _round3133, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intersects3134; 
		public static bool intersects(android.graphics.RectF arg0, android.graphics.RectF arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.graphics.RectF.staticClass, _intersects3134, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intersects3135; 
		public virtual bool intersects(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				return @__env.CallBooleanMethod(this, _intersects3135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.RectF.staticClass, _intersects3135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _union3136; 
		public virtual void union(android.graphics.RectF arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				@__env.CallVoidMethod(this, _union3136, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.RectF.staticClass, _union3136, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _union3137; 
		public virtual void union(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				@__env.CallVoidMethod(this, _union3137, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.RectF.staticClass, _union3137, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _union3138; 
		public virtual void union(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				@__env.CallVoidMethod(this, _union3138, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.RectF.staticClass, _union3138, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _centerX3139; 
		public virtual float centerX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				return @__env.CallFloatMethod(this, _centerX3139); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.RectF.staticClass, _centerX3139); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _centerY3140; 
		public virtual float centerY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				return @__env.CallFloatMethod(this, _centerY3140); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.RectF.staticClass, _centerY3140); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _height3141; 
		public virtual float height() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				return @__env.CallFloatMethod(this, _height3141); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.RectF.staticClass, _height3141); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _width3142; 
		public virtual float width() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				return @__env.CallFloatMethod(this, _width3142); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.RectF.staticClass, _width3142); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel3143; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				@__env.CallVoidMethod(this, _writeToParcel3143, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.RectF.staticClass, _writeToParcel3143, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents3144; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				return @__env.CallIntMethod(this, _describeContents3144); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.RectF.staticClass, _describeContents3144); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readFromParcel3145; 
		public virtual void readFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				@__env.CallVoidMethod(this, _readFromParcel3145, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.RectF.staticClass, _readFromParcel3145, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEmpty3146; 
		public virtual void setEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				@__env.CallVoidMethod(this, _setEmpty3146); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.RectF.staticClass, _setEmpty3146); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offsetTo3147; 
		public virtual void offsetTo(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				@__env.CallVoidMethod(this, _offsetTo3147, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.RectF.staticClass, _offsetTo3147, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inset3148; 
		public virtual void inset(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				@__env.CallVoidMethod(this, _inset3148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.RectF.staticClass, _inset3148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intersect3149; 
		public virtual bool intersect(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				return @__env.CallBooleanMethod(this, _intersect3149, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.RectF.staticClass, _intersect3149, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intersect3150; 
		public virtual bool intersect(android.graphics.RectF arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				return @__env.CallBooleanMethod(this, _intersect3150, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.RectF.staticClass, _intersect3150, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIntersect3151; 
		public virtual bool setIntersect(android.graphics.RectF arg0, android.graphics.RectF arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				return @__env.CallBooleanMethod(this, _setIntersect3151, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.RectF.staticClass, _setIntersect3151, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _roundOut3152; 
		public virtual void roundOut(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RectF)) 
				@__env.CallVoidMethod(this, _roundOut3152, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.RectF.staticClass, _roundOut3152, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RectF3153; 
		public RectF()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.RectF.staticClass, _RectF3153, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RectF3154; 
		public RectF(float arg0, float arg1, float arg2, float arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.RectF.staticClass, _RectF3154, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RectF3155; 
		public RectF(android.graphics.RectF arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.RectF.staticClass, _RectF3155, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RectF3156; 
		public RectF(android.graphics.Rect arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.RectF.staticClass, _RectF3156, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _left3157; 
		public float left
		{ 
			get 
			{ 
				return default(float); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _top3158; 
		public float top
		{ 
			get 
			{ 
				return default(float); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _right3159; 
		public float right
		{ 
			get 
			{ 
				return default(float); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _bottom3160; 
		public float bottom
		{ 
			get 
			{ 
				return default(float); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR3161; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.RectF.staticClass = @__class; 
			global::android.graphics.RectF._toString3123 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.graphics.RectF._offset3124 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "offset", "(FF)V"); 
			global::android.graphics.RectF._isEmpty3125 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "isEmpty", "()Z"); 
			global::android.graphics.RectF._contains3126 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "contains", "(FFFF)Z"); 
			global::android.graphics.RectF._contains3127 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "contains", "(FF)Z"); 
			global::android.graphics.RectF._contains3128 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "contains", "(Landroid/graphics/RectF;)Z"); 
			global::android.graphics.RectF._set3129 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "set", "(Landroid/graphics/RectF;)V"); 
			global::android.graphics.RectF._set3130 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "set", "(FFFF)V"); 
			global::android.graphics.RectF._set3131 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "set", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.RectF._sort3132 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "sort", "()V"); 
			global::android.graphics.RectF._round3133 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "round", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.RectF._intersects3134 = @__env.GetStaticMethodID(global::android.graphics.RectF.staticClass, "intersects", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z"); 
			global::android.graphics.RectF._intersects3135 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "intersects", "(FFFF)Z"); 
			global::android.graphics.RectF._union3136 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "union", "(Landroid/graphics/RectF;)V"); 
			global::android.graphics.RectF._union3137 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "union", "(FFFF)V"); 
			global::android.graphics.RectF._union3138 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "union", "(FF)V"); 
			global::android.graphics.RectF._centerX3139 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "centerX", "()F"); 
			global::android.graphics.RectF._centerY3140 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "centerY", "()F"); 
			global::android.graphics.RectF._height3141 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "height", "()F"); 
			global::android.graphics.RectF._width3142 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "width", "()F"); 
			global::android.graphics.RectF._writeToParcel3143 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.graphics.RectF._describeContents3144 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "describeContents", "()I"); 
			global::android.graphics.RectF._readFromParcel3145 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V"); 
			global::android.graphics.RectF._setEmpty3146 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "setEmpty", "()V"); 
			global::android.graphics.RectF._offsetTo3147 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "offsetTo", "(FF)V"); 
			global::android.graphics.RectF._inset3148 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "inset", "(FF)V"); 
			global::android.graphics.RectF._intersect3149 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "intersect", "(FFFF)Z"); 
			global::android.graphics.RectF._intersect3150 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "intersect", "(Landroid/graphics/RectF;)Z"); 
			global::android.graphics.RectF._setIntersect3151 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "setIntersect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z"); 
			global::android.graphics.RectF._roundOut3152 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "roundOut", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.RectF._RectF3153 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "<init>", "()V"); 
			global::android.graphics.RectF._RectF3154 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "<init>", "(FFFF)V"); 
			global::android.graphics.RectF._RectF3155 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "<init>", "(Landroid/graphics/RectF;)V"); 
			global::android.graphics.RectF._RectF3156 = @__env.GetMethodID(global::android.graphics.RectF.staticClass, "<init>", "(Landroid/graphics/Rect;)V"); 
		} 
	} 
} 
