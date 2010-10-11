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
		internal static global::MonoJavaBridge.MethodId _finalize3163;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._finalize3163);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._finalize3163);
		}
		internal static global::MonoJavaBridge.MethodId _save3164;
		public virtual void save() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._save3164);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._save3164);
		}
		internal static global::MonoJavaBridge.MethodId _restore3165;
		public virtual void restore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._restore3165);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._restore3165);
		}
		internal static global::MonoJavaBridge.MethodId _translate3166;
		public virtual void translate(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._translate3166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._translate3166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getMatrix3167;
		public virtual void getMatrix(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._getMatrix3167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._getMatrix3167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateX3168;
		public virtual void rotateX(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._rotateX3168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._rotateX3168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateY3169;
		public virtual void rotateY(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._rotateY3169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._rotateY3169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateZ3170;
		public virtual void rotateZ(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._rotateZ3170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._rotateZ3170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _applyToCanvas3171;
		public virtual void applyToCanvas(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._applyToCanvas3171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._applyToCanvas3171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dotWithNormal3172;
		public virtual float dotWithNormal(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Camera._dotWithNormal3172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._dotWithNormal3172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _Camera3173;
		public Camera()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Camera.staticClass, global::android.graphics.Camera._Camera3173);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Camera.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Camera"));
			global::android.graphics.Camera._finalize3163 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "finalize", "()V");
			global::android.graphics.Camera._save3164 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "save", "()V");
			global::android.graphics.Camera._restore3165 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "restore", "()V");
			global::android.graphics.Camera._translate3166 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "translate", "(FFF)V");
			global::android.graphics.Camera._getMatrix3167 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "getMatrix", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Camera._rotateX3168 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "rotateX", "(F)V");
			global::android.graphics.Camera._rotateY3169 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "rotateY", "(F)V");
			global::android.graphics.Camera._rotateZ3170 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "rotateZ", "(F)V");
			global::android.graphics.Camera._applyToCanvas3171 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "applyToCanvas", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.Camera._dotWithNormal3172 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "dotWithNormal", "(FFF)F");
			global::android.graphics.Camera._Camera3173 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "<init>", "()V");
		}
	}
}
