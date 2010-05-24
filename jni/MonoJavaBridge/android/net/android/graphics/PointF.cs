namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PointF : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static PointF() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.PointF), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.PointF(@__env); 
			} 
		} 
		protected PointF(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals3246; 
		public virtual bool equals(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.PointF)) 
				return @__env.CallBooleanMethod(this, _equals3246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.PointF.staticClass, _equals3246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offset3247; 
		public virtual void offset(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.PointF)) 
				@__env.CallVoidMethod(this, _offset3247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.PointF.staticClass, _offset3247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _length3248; 
		public static float length(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticFloatMethod(android.graphics.PointF.staticClass, _length3248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _length3249; 
		public virtual float length() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.PointF)) 
				return @__env.CallFloatMethod(this, _length3249); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.PointF.staticClass, _length3249); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set3250; 
		public virtual void set(android.graphics.PointF arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.PointF)) 
				@__env.CallVoidMethod(this, _set3250, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.PointF.staticClass, _set3250, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set3251; 
		public virtual void set(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.PointF)) 
				@__env.CallVoidMethod(this, _set3251, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.PointF.staticClass, _set3251, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _negate3252; 
		public virtual void negate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.PointF)) 
				@__env.CallVoidMethod(this, _negate3252); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.PointF.staticClass, _negate3252); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PointF3253; 
		public PointF(float arg0, float arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.PointF.staticClass, _PointF3253, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PointF3254; 
		public PointF(android.graphics.Point arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.PointF.staticClass, _PointF3254, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PointF3255; 
		public PointF()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.PointF.staticClass, _PointF3255, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _x3256; 
		public float x
		{ 
			get 
			{ 
				return default(float); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _y3257; 
		public float y
		{ 
			get 
			{ 
				return default(float); 
			} 
			set 
			{ 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.PointF.staticClass = @__class; 
			global::android.graphics.PointF._equals3246 = @__env.GetMethodID(global::android.graphics.PointF.staticClass, "equals", "(FF)Z"); 
			global::android.graphics.PointF._offset3247 = @__env.GetMethodID(global::android.graphics.PointF.staticClass, "offset", "(FF)V"); 
			global::android.graphics.PointF._length3248 = @__env.GetStaticMethodID(global::android.graphics.PointF.staticClass, "length", "(FF)F"); 
			global::android.graphics.PointF._length3249 = @__env.GetMethodID(global::android.graphics.PointF.staticClass, "length", "()F"); 
			global::android.graphics.PointF._set3250 = @__env.GetMethodID(global::android.graphics.PointF.staticClass, "set", "(Landroid/graphics/PointF;)V"); 
			global::android.graphics.PointF._set3251 = @__env.GetMethodID(global::android.graphics.PointF.staticClass, "set", "(FF)V"); 
			global::android.graphics.PointF._negate3252 = @__env.GetMethodID(global::android.graphics.PointF.staticClass, "negate", "()V"); 
			global::android.graphics.PointF._PointF3253 = @__env.GetMethodID(global::android.graphics.PointF.staticClass, "<init>", "(FF)V"); 
			global::android.graphics.PointF._PointF3254 = @__env.GetMethodID(global::android.graphics.PointF.staticClass, "<init>", "(Landroid/graphics/Point;)V"); 
			global::android.graphics.PointF._PointF3255 = @__env.GetMethodID(global::android.graphics.PointF.staticClass, "<init>", "()V"); 
		} 
	} 
} 
