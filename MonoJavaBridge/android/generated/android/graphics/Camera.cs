namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Camera : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Camera(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Camera.staticClass, "finalize", "()V", ref global::android.graphics.Camera._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void save()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Camera.staticClass, "save", "()V", ref global::android.graphics.Camera._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void restore()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Camera.staticClass, "restore", "()V", ref global::android.graphics.Camera._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void translate(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Camera.staticClass, "translate", "(FFF)V", ref global::android.graphics.Camera._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void getMatrix(android.graphics.Matrix arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Camera.staticClass, "getMatrix", "(Landroid/graphics/Matrix;)V", ref global::android.graphics.Camera._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void rotateX(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Camera.staticClass, "rotateX", "(F)V", ref global::android.graphics.Camera._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void rotateY(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Camera.staticClass, "rotateY", "(F)V", ref global::android.graphics.Camera._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void rotateZ(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Camera.staticClass, "rotateZ", "(F)V", ref global::android.graphics.Camera._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void applyToCanvas(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Camera.staticClass, "applyToCanvas", "(Landroid/graphics/Canvas;)V", ref global::android.graphics.Camera._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual float dotWithNormal(float arg0, float arg1, float arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Camera.staticClass, "dotWithNormal", "(FFF)F", ref global::android.graphics.Camera._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public Camera() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Camera._m10.native == global::System.IntPtr.Zero)
				global::android.graphics.Camera._m10 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Camera.staticClass, global::android.graphics.Camera._m10);
			Init(@__env, handle);
		}
		static Camera()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Camera.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Camera"));
		}
		internal static void InitJNI()
		{
		}
	}
}
