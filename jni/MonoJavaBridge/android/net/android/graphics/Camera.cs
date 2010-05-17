namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Camera : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Camera() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Camera), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _save2592; 
		public virtual void save() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Camera)) 
				@__env.CallVoidMethod(this, _save2592); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Camera.staticClass, _save2592); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restore2593; 
		public virtual void restore() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Camera)) 
				@__env.CallVoidMethod(this, _restore2593); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Camera.staticClass, _restore2593); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _translate2594; 
		public virtual void translate(float arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Camera)) 
				@__env.CallVoidMethod(this, _translate2594, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Camera.staticClass, _translate2594, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMatrix2595; 
		public virtual void getMatrix(android.graphics.Matrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Camera)) 
				@__env.CallVoidMethod(this, _getMatrix2595, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Camera.staticClass, _getMatrix2595, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rotateX2596; 
		public virtual void rotateX(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Camera)) 
				@__env.CallVoidMethod(this, _rotateX2596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Camera.staticClass, _rotateX2596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rotateY2597; 
		public virtual void rotateY(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Camera)) 
				@__env.CallVoidMethod(this, _rotateY2597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Camera.staticClass, _rotateY2597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rotateZ2598; 
		public virtual void rotateZ(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Camera)) 
				@__env.CallVoidMethod(this, _rotateZ2598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Camera.staticClass, _rotateZ2598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _applyToCanvas2599; 
		public virtual void applyToCanvas(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Camera)) 
				@__env.CallVoidMethod(this, _applyToCanvas2599, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Camera.staticClass, _applyToCanvas2599, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dotWithNormal2600; 
		public virtual float dotWithNormal(float arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Camera)) 
				return @__env.CallFloatMethod(this, _dotWithNormal2600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.Camera.staticClass, _dotWithNormal2600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Camera2601; 
		public Camera()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Camera.staticClass, _Camera2601, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.Camera.staticClass = @__class; 
			global::android.graphics.Camera._save2592 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "save", "()V"); 
			global::android.graphics.Camera._restore2593 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "restore", "()V"); 
			global::android.graphics.Camera._translate2594 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "translate", "(FFF)V"); 
			global::android.graphics.Camera._getMatrix2595 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "getMatrix", "(Landroid/graphics/Matrix;)V"); 
			global::android.graphics.Camera._rotateX2596 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "rotateX", "(F)V"); 
			global::android.graphics.Camera._rotateY2597 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "rotateY", "(F)V"); 
			global::android.graphics.Camera._rotateZ2598 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "rotateZ", "(F)V"); 
			global::android.graphics.Camera._applyToCanvas2599 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "applyToCanvas", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.Camera._dotWithNormal2600 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "dotWithNormal", "(FFF)F"); 
			global::android.graphics.Camera._Camera2601 = @__env.GetMethodID(global::android.graphics.Camera.staticClass, "<init>", "()V"); 
		} 
	} 
} 
