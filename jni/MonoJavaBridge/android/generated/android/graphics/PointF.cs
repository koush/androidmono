namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PointF : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PointF()
		{
			InitJNI();
		}
		protected PointF(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals3631;
		public virtual bool equals(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.PointF._equals3631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._equals3631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _offset3632;
		public virtual void offset(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.PointF._offset3632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._offset3632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _length3633;
		public static float length(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.graphics.PointF.staticClass, global::android.graphics.PointF._length3633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _length3634;
		public virtual float length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.PointF._length3634);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._length3634);
		}
		internal static global::MonoJavaBridge.MethodId _set3635;
		public virtual void set(android.graphics.PointF arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.PointF._set3635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._set3635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set3636;
		public virtual void set(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.PointF._set3636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._set3636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _negate3637;
		public virtual void negate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.PointF._negate3637);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._negate3637);
		}
		internal static global::MonoJavaBridge.MethodId _PointF3638;
		public PointF(float arg0, float arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PointF.staticClass, global::android.graphics.PointF._PointF3638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PointF3639;
		public PointF(android.graphics.Point arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PointF.staticClass, global::android.graphics.PointF._PointF3639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PointF3640;
		public PointF()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PointF.staticClass, global::android.graphics.PointF._PointF3640);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _x3641;
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
		internal static global::MonoJavaBridge.FieldId _y3642;
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PointF.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PointF"));
			global::android.graphics.PointF._equals3631 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "equals", "(FF)Z");
			global::android.graphics.PointF._offset3632 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "offset", "(FF)V");
			global::android.graphics.PointF._length3633 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.PointF.staticClass, "length", "(FF)F");
			global::android.graphics.PointF._length3634 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "length", "()F");
			global::android.graphics.PointF._set3635 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "set", "(Landroid/graphics/PointF;)V");
			global::android.graphics.PointF._set3636 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "set", "(FF)V");
			global::android.graphics.PointF._negate3637 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "negate", "()V");
			global::android.graphics.PointF._PointF3638 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "<init>", "(FF)V");
			global::android.graphics.PointF._PointF3639 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "<init>", "(Landroid/graphics/Point;)V");
			global::android.graphics.PointF._PointF3640 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "<init>", "()V");
		}
	}
}
