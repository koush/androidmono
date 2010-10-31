namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PointF : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PointF(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool equals(float arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.PointF.staticClass, "equals", "(FF)Z", ref global::android.graphics.PointF._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void offset(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.PointF.staticClass, "offset", "(FF)V", ref global::android.graphics.PointF._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static float length(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PointF._m2.native == global::System.IntPtr.Zero)
				global::android.graphics.PointF._m2 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.PointF.staticClass, "length", "(FF)F");
			return @__env.CallStaticFloatMethod(android.graphics.PointF.staticClass, global::android.graphics.PointF._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual float length()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.PointF.staticClass, "length", "()F", ref global::android.graphics.PointF._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void set(android.graphics.PointF arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.PointF.staticClass, "set", "(Landroid/graphics/PointF;)V", ref global::android.graphics.PointF._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void set(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.PointF.staticClass, "set", "(FF)V", ref global::android.graphics.PointF._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void negate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.PointF.staticClass, "negate", "()V", ref global::android.graphics.PointF._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public PointF(float arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PointF._m7.native == global::System.IntPtr.Zero)
				global::android.graphics.PointF._m7 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "<init>", "(FF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PointF.staticClass, global::android.graphics.PointF._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public PointF(android.graphics.Point arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PointF._m8.native == global::System.IntPtr.Zero)
				global::android.graphics.PointF._m8 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "<init>", "(Landroid/graphics/Point;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PointF.staticClass, global::android.graphics.PointF._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public PointF() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PointF._m9.native == global::System.IntPtr.Zero)
				global::android.graphics.PointF._m9 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PointF.staticClass, global::android.graphics.PointF._m9);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _x2373;
		public float x
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _x2373);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _y2374;
		public float y
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _y2374);
			}
			set
			{
			}
		}
		static PointF()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PointF.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PointF"));
			global::android.graphics.PointF._x2373 = @__env.GetFieldIDNoThrow(global::android.graphics.PointF.staticClass, "x", "F");
			global::android.graphics.PointF._y2374 = @__env.GetFieldIDNoThrow(global::android.graphics.PointF.staticClass, "y", "F");
		}
	}
}
