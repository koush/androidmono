namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Camera : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Camera(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize5101;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Camera.staticClass, "finalize", "()V", ref global::android.graphics.Camera._finalize5101);
		}
		internal static global::MonoJavaBridge.MethodId _save5102;
		public virtual void save()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Camera.staticClass, "save", "()V", ref global::android.graphics.Camera._save5102);
		}
		internal static global::MonoJavaBridge.MethodId _restore5103;
		public virtual void restore()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Camera.staticClass, "restore", "()V", ref global::android.graphics.Camera._restore5103);
		}
		internal static global::MonoJavaBridge.MethodId _translate5104;
		public virtual void translate(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Camera.staticClass, "translate", "(FFF)V", ref global::android.graphics.Camera._translate5104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getMatrix5105;
		public virtual void getMatrix(android.graphics.Matrix arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Camera.staticClass, "getMatrix", "(Landroid/graphics/Matrix;)V", ref global::android.graphics.Camera._getMatrix5105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateX5106;
		public virtual void rotateX(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Camera.staticClass, "rotateX", "(F)V", ref global::android.graphics.Camera._rotateX5106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateY5107;
		public virtual void rotateY(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Camera.staticClass, "rotateY", "(F)V", ref global::android.graphics.Camera._rotateY5107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateZ5108;
		public virtual void rotateZ(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Camera.staticClass, "rotateZ", "(F)V", ref global::android.graphics.Camera._rotateZ5108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _applyToCanvas5109;
		public virtual void applyToCanvas(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Camera.staticClass, "applyToCanvas", "(Landroid/graphics/Canvas;)V", ref global::android.graphics.Camera._applyToCanvas5109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dotWithNormal5110;
		public virtual float dotWithNormal(float arg0, float arg1, float arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Camera.staticClass, "dotWithNormal", "(FFF)F", ref global::android.graphics.Camera._dotWithNormal5110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _Camera5111;
		public Camera() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Camera._Camera5111.native == global::System.IntPtr.Zero)
				global::android.graphics.Camera._Camera5111 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Camera.staticClass, global::android.graphics.Camera._Camera5111);
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
