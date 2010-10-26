namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GLU : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GLU()
		{
			InitJNI();
		}
		protected GLU(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _gluErrorString9458;
		public static global::java.lang.String gluErrorString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.opengl.GLU.staticClass, global::android.opengl.GLU._gluErrorString9458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _gluLookAt9459;
		public static void gluLookAt(javax.microedition.khronos.opengles.GL10 arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7, float arg8, float arg9) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLU.staticClass, global::android.opengl.GLU._gluLookAt9459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9));
		}
		internal static global::MonoJavaBridge.MethodId _gluOrtho2D9460;
		public static void gluOrtho2D(javax.microedition.khronos.opengles.GL10 arg0, float arg1, float arg2, float arg3, float arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLU.staticClass, global::android.opengl.GLU._gluOrtho2D9460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _gluPerspective9461;
		public static void gluPerspective(javax.microedition.khronos.opengles.GL10 arg0, float arg1, float arg2, float arg3, float arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLU.staticClass, global::android.opengl.GLU._gluPerspective9461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _gluProject9462;
		public static int gluProject(float arg0, float arg1, float arg2, float[] arg3, int arg4, float[] arg5, int arg6, int[] arg7, int arg8, float[] arg9, int arg10) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLU.staticClass, global::android.opengl.GLU._gluProject9462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
		}
		internal static global::MonoJavaBridge.MethodId _gluUnProject9463;
		public static int gluUnProject(float arg0, float arg1, float arg2, float[] arg3, int arg4, float[] arg5, int arg6, int[] arg7, int arg8, float[] arg9, int arg10) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLU.staticClass, global::android.opengl.GLU._gluUnProject9463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
		}
		internal static global::MonoJavaBridge.MethodId _GLU9464;
		public GLU()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLU.staticClass, global::android.opengl.GLU._GLU9464);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLU.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLU"));
			global::android.opengl.GLU._gluErrorString9458 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLU.staticClass, "gluErrorString", "(I)Ljava/lang/String;");
			global::android.opengl.GLU._gluLookAt9459 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLU.staticClass, "gluLookAt", "(Ljavax/microedition/khronos/opengles/GL10;FFFFFFFFF)V");
			global::android.opengl.GLU._gluOrtho2D9460 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLU.staticClass, "gluOrtho2D", "(Ljavax/microedition/khronos/opengles/GL10;FFFF)V");
			global::android.opengl.GLU._gluPerspective9461 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLU.staticClass, "gluPerspective", "(Ljavax/microedition/khronos/opengles/GL10;FFFF)V");
			global::android.opengl.GLU._gluProject9462 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLU.staticClass, "gluProject", "(FFF[FI[FI[II[FI)I");
			global::android.opengl.GLU._gluUnProject9463 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLU.staticClass, "gluUnProject", "(FFF[FI[FI[II[FI)I");
			global::android.opengl.GLU._GLU9464 = @__env.GetMethodIDNoThrow(global::android.opengl.GLU.staticClass, "<init>", "()V");
		}
	}
}
