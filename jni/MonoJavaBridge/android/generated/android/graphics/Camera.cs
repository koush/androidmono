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
		internal static global::MonoJavaBridge.MethodId _finalize5082;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._finalize5082);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._finalize5082);
		}
		internal static global::MonoJavaBridge.MethodId _save5083;
		public virtual void save() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._save5083);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._save5083);
		}
		internal static global::MonoJavaBridge.MethodId _restore5084;
		public virtual void restore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._restore5084);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._restore5084);
		}
		internal static global::MonoJavaBridge.MethodId _translate5085;
		public virtual void translate(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._translate5085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._translate5085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getMatrix5086;
		public virtual void getMatrix(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._getMatrix5086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._getMatrix5086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateX5087;
		public virtual void rotateX(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._rotateX5087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._rotateX5087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateY5088;
		public virtual void rotateY(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._rotateY5088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._rotateY5088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateZ5089;
		public virtual void rotateZ(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._rotateZ5089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._rotateZ5089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _applyToCanvas5090;
		public virtual void applyToCanvas(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Camera._applyToCanvas5090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._applyToCanvas5090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dotWithNormal5091;
		public virtual float dotWithNormal(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Camera._dotWithNormal5091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._dotWithNormal5091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _Camera5092;
		public Camera()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Camera.staticClass, global::android.graphics.Camera._Camera5092);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Camera.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Camera"));
			global::android.graphics.Camera._finalize5082 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "finalize", "()V");
			global::android.graphics.Camera._save5083 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "save", "()V");
			global::android.graphics.Camera._restore5084 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "restore", "()V");
			global::android.graphics.Camera._translate5085 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "translate", "(FFF)V");
			global::android.graphics.Camera._getMatrix5086 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "getMatrix", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Camera._rotateX5087 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "rotateX", "(F)V");
			global::android.graphics.Camera._rotateY5088 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "rotateY", "(F)V");
			global::android.graphics.Camera._rotateZ5089 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "rotateZ", "(F)V");
			global::android.graphics.Camera._applyToCanvas5090 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "applyToCanvas", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.Camera._dotWithNormal5091 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "dotWithNormal", "(FFF)F");
			global::android.graphics.Camera._Camera5092 = @__env.GetMethodIDNoThrow(global::android.graphics.Camera.staticClass, "<init>", "()V");
		}
	}
}
