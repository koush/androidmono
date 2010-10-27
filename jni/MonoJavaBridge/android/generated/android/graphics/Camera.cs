namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Camera : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Camera()
		{
			InitJNI();
		}
		protected Camera(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize5101;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._finalize5101);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._finalize5101);
		}
		internal static global::MonoJavaBridge.MethodId _save5102;
		public virtual void save()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._save5102);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._save5102);
		}
		internal static global::MonoJavaBridge.MethodId _restore5103;
		public virtual void restore()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._restore5103);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._restore5103);
		}
		internal static global::MonoJavaBridge.MethodId _translate5104;
		public virtual void translate(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._translate5104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._translate5104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getMatrix5105;
		public virtual void getMatrix(android.graphics.Matrix arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._getMatrix5105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._getMatrix5105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateX5106;
		public virtual void rotateX(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._rotateX5106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._rotateX5106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateY5107;
		public virtual void rotateY(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._rotateY5107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._rotateY5107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateZ5108;
		public virtual void rotateZ(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._rotateZ5108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._rotateZ5108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _applyToCanvas5109;
		public virtual void applyToCanvas(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._applyToCanvas5109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._applyToCanvas5109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dotWithNormal5110;
		public virtual float dotWithNormal(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Camera._dotWithNormal5110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._dotWithNormal5110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _Camera5111;
		public Camera() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Camera.staticClass, global::android.graphics.Camera._Camera5111);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Camera.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Camera"));
			global::android.graphics.Camera._finalize5101 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "finalize", "()V");
			global::android.graphics.Camera._save5102 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "save", "()V");
			global::android.graphics.Camera._restore5103 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "restore", "()V");
			global::android.graphics.Camera._translate5104 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "translate", "(FFF)V");
			global::android.graphics.Camera._getMatrix5105 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "getMatrix", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Camera._rotateX5106 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "rotateX", "(F)V");
			global::android.graphics.Camera._rotateY5107 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "rotateY", "(F)V");
			global::android.graphics.Camera._rotateZ5108 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "rotateZ", "(F)V");
			global::android.graphics.Camera._applyToCanvas5109 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "applyToCanvas", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.Camera._dotWithNormal5110 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "dotWithNormal", "(FFF)F");
			global::android.graphics.Camera._Camera5111 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "<init>", "()V");
		}
	}
}
