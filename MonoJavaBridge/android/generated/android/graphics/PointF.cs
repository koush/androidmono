namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PointF : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PointF(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals5631;
		public virtual bool equals(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PointF._equals5631.native == global::System.IntPtr.Zero)
				global::android.graphics.PointF._equals5631 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "equals", "(FF)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._equals5631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _offset5632;
		public virtual void offset(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PointF._offset5632.native == global::System.IntPtr.Zero)
				global::android.graphics.PointF._offset5632 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "offset", "(FF)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._offset5632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _length5633;
		public static float length(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PointF._length5633.native == global::System.IntPtr.Zero)
				global::android.graphics.PointF._length5633 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.PointF.staticClass, "length", "(FF)F");
			return @__env.CallStaticFloatMethod(android.graphics.PointF.staticClass, global::android.graphics.PointF._length5633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _length5634;
		public virtual float length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PointF._length5634.native == global::System.IntPtr.Zero)
				global::android.graphics.PointF._length5634 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "length", "()F");
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._length5634);
		}
		internal static global::MonoJavaBridge.MethodId _set5635;
		public virtual void set(android.graphics.PointF arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PointF._set5635.native == global::System.IntPtr.Zero)
				global::android.graphics.PointF._set5635 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "set", "(Landroid/graphics/PointF;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._set5635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set5636;
		public virtual void set(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PointF._set5636.native == global::System.IntPtr.Zero)
				global::android.graphics.PointF._set5636 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "set", "(FF)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._set5636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _negate5637;
		public virtual void negate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PointF._negate5637.native == global::System.IntPtr.Zero)
				global::android.graphics.PointF._negate5637 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "negate", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._negate5637);
		}
		internal static global::MonoJavaBridge.MethodId _PointF5638;
		public PointF(float arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PointF._PointF5638.native == global::System.IntPtr.Zero)
				global::android.graphics.PointF._PointF5638 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "<init>", "(FF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PointF.staticClass, global::android.graphics.PointF._PointF5638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PointF5639;
		public PointF(android.graphics.Point arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PointF._PointF5639.native == global::System.IntPtr.Zero)
				global::android.graphics.PointF._PointF5639 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "<init>", "(Landroid/graphics/Point;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PointF.staticClass, global::android.graphics.PointF._PointF5639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PointF5640;
		public PointF() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PointF._PointF5640.native == global::System.IntPtr.Zero)
				global::android.graphics.PointF._PointF5640 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PointF.staticClass, global::android.graphics.PointF._PointF5640);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _x5641;
		public float x
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _x5641);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _y5642;
		public float y
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _y5642);
			}
			set
			{
			}
		}
		static PointF()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PointF.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PointF"));
			global::android.graphics.PointF._x5641 = @__env.GetFieldIDNoThrow(global::android.graphics.PointF.staticClass, "x", "F");
			global::android.graphics.PointF._y5642 = @__env.GetFieldIDNoThrow(global::android.graphics.PointF.staticClass, "y", "F");
		}
		internal static void InitJNI()
		{
		}
	}
}
