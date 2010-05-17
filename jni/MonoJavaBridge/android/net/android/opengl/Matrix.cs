namespace android.opengl 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Matrix : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Matrix() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.opengl.Matrix), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.opengl.Matrix(@__env); 
			} 
		} 
		protected Matrix(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _length5052; 
		public static float length(float arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticFloatMethod(android.opengl.Matrix.staticClass, _length5052, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _multiplyMM5053; 
		public static void multiplyMM(float[] arg0, int arg1, float[] arg2, int arg3, float[] arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, _multiplyMM5053, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _multiplyMV5054; 
		public static void multiplyMV(float[] arg0, int arg1, float[] arg2, int arg3, float[] arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, _multiplyMV5054, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _transposeM5055; 
		public static void transposeM(float[] arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, _transposeM5055, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invertM5056; 
		public static bool invertM(float[] arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.opengl.Matrix.staticClass, _invertM5056, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _orthoM5057; 
		public static void orthoM(float[] arg0, int arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, _orthoM5057, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _frustumM5058; 
		public static void frustumM(float[] arg0, int arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, _frustumM5058, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIdentityM5059; 
		public static void setIdentityM(float[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, _setIdentityM5059, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scaleM5060; 
		public static void scaleM(float[] arg0, int arg1, float[] arg2, int arg3, float arg4, float arg5, float arg6) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, _scaleM5060, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scaleM5061; 
		public static void scaleM(float[] arg0, int arg1, float arg2, float arg3, float arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, _scaleM5061, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _translateM5062; 
		public static void translateM(float[] arg0, int arg1, float[] arg2, int arg3, float arg4, float arg5, float arg6) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, _translateM5062, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _translateM5063; 
		public static void translateM(float[] arg0, int arg1, float arg2, float arg3, float arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, _translateM5063, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rotateM5064; 
		public static void rotateM(float[] arg0, int arg1, float[] arg2, int arg3, float arg4, float arg5, float arg6, float arg7) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, _rotateM5064, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rotateM5065; 
		public static void rotateM(float[] arg0, int arg1, float arg2, float arg3, float arg4, float arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, _rotateM5065, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRotateM5066; 
		public static void setRotateM(float[] arg0, int arg1, float arg2, float arg3, float arg4, float arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, _setRotateM5066, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRotateEulerM5067; 
		public static void setRotateEulerM(float[] arg0, int arg1, float arg2, float arg3, float arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, _setRotateEulerM5067, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Matrix5068; 
		public Matrix()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.opengl.Matrix.staticClass, _Matrix5068, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.opengl.Matrix.staticClass = @__class; 
			global::android.opengl.Matrix._length5052 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "length", "(FFF)F"); 
			global::android.opengl.Matrix._multiplyMM5053 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "multiplyMM", "([FI[FI[FI)V"); 
			global::android.opengl.Matrix._multiplyMV5054 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "multiplyMV", "([FI[FI[FI)V"); 
			global::android.opengl.Matrix._transposeM5055 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "transposeM", "([FI[FI)V"); 
			global::android.opengl.Matrix._invertM5056 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "invertM", "([FI[FI)Z"); 
			global::android.opengl.Matrix._orthoM5057 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "orthoM", "([FIFFFFFF)V"); 
			global::android.opengl.Matrix._frustumM5058 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "frustumM", "([FIFFFFFF)V"); 
			global::android.opengl.Matrix._setIdentityM5059 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "setIdentityM", "([FI)V"); 
			global::android.opengl.Matrix._scaleM5060 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "scaleM", "([FI[FIFFF)V"); 
			global::android.opengl.Matrix._scaleM5061 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "scaleM", "([FIFFF)V"); 
			global::android.opengl.Matrix._translateM5062 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "translateM", "([FI[FIFFF)V"); 
			global::android.opengl.Matrix._translateM5063 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "translateM", "([FIFFF)V"); 
			global::android.opengl.Matrix._rotateM5064 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "rotateM", "([FI[FIFFFF)V"); 
			global::android.opengl.Matrix._rotateM5065 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "rotateM", "([FIFFFF)V"); 
			global::android.opengl.Matrix._setRotateM5066 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "setRotateM", "([FIFFFF)V"); 
			global::android.opengl.Matrix._setRotateEulerM5067 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "setRotateEulerM", "([FIFFF)V"); 
			global::android.opengl.Matrix._Matrix5068 = @__env.GetMethodID(global::android.opengl.Matrix.staticClass, "<init>", "()V"); 
		} 
	} 
} 
