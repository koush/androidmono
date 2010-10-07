namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Camera : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Camera()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Camera), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.Camera(@__env);
			}
		}
		protected Camera(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _save2989;
		public virtual void save() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Camera._save2989);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._save2989);
		}
		internal static global::net.sf.jni4net.jni.MethodId _restore2990;
		public virtual void restore() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Camera._restore2990);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._restore2990);
		}
		internal static global::net.sf.jni4net.jni.MethodId _translate2991;
		public virtual void translate(float arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Camera._translate2991, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._translate2991, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMatrix2992;
		public virtual void getMatrix(android.graphics.Matrix arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Camera._getMatrix2992, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._getMatrix2992, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _rotateX2993;
		public virtual void rotateX(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Camera._rotateX2993, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._rotateX2993, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _rotateY2994;
		public virtual void rotateY(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Camera._rotateY2994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._rotateY2994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _rotateZ2995;
		public virtual void rotateZ(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Camera._rotateZ2995, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._rotateZ2995, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _applyToCanvas2996;
		public virtual void applyToCanvas(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Camera._applyToCanvas2996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._applyToCanvas2996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dotWithNormal2997;
		public virtual float dotWithNormal(float arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.Camera._dotWithNormal2997, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Camera.staticClass, global::android.graphics.Camera._dotWithNormal2997, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Camera2998;
		public Camera()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Camera.staticClass, global::android.graphics.Camera._Camera2998, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.Camera.staticClass = @__class;
			global::android.graphics.Camera._save2989 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "save", "()V");
			global::android.graphics.Camera._restore2990 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "restore", "()V");
			global::android.graphics.Camera._translate2991 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "translate", "(FFF)V");
			global::android.graphics.Camera._getMatrix2992 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "getMatrix", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Camera._rotateX2993 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "rotateX", "(F)V");
			global::android.graphics.Camera._rotateY2994 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "rotateY", "(F)V");
			global::android.graphics.Camera._rotateZ2995 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "rotateZ", "(F)V");
			global::android.graphics.Camera._applyToCanvas2996 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "applyToCanvas", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.Camera._dotWithNormal2997 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "dotWithNormal", "(FFF)F");
			global::android.graphics.Camera._Camera2998 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "<init>", "()V");
		}
	}
}
