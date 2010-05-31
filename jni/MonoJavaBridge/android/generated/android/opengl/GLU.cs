namespace android.opengl
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class GLU : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static GLU()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.opengl.GLU), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.opengl.GLU(@__env);
			}
		}
		protected GLU(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _gluErrorString5296;
		public static global::java.lang.String gluErrorString(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.opengl.GLU.staticClass, global::android.opengl.GLU._gluErrorString5296, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _gluLookAt5297;
		public static void gluLookAt(javax.microedition.khronos.opengles.GL10 arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7, float arg8, float arg9) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLU.staticClass, global::android.opengl.GLU._gluLookAt5297, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9));
		}
		internal static global::net.sf.jni4net.jni.MethodId _gluOrtho2D5298;
		public static void gluOrtho2D(javax.microedition.khronos.opengles.GL10 arg0, float arg1, float arg2, float arg3, float arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLU.staticClass, global::android.opengl.GLU._gluOrtho2D5298, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _gluPerspective5299;
		public static void gluPerspective(javax.microedition.khronos.opengles.GL10 arg0, float arg1, float arg2, float arg3, float arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLU.staticClass, global::android.opengl.GLU._gluPerspective5299, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _gluProject5300;
		public static int gluProject(float arg0, float arg1, float arg2, float[] arg3, int arg4, float[] arg5, int arg6, int[] arg7, int arg8, float[] arg9, int arg10) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLU.staticClass, global::android.opengl.GLU._gluProject5300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10));
		}
		internal static global::net.sf.jni4net.jni.MethodId _gluUnProject5301;
		public static int gluUnProject(float arg0, float arg1, float arg2, float[] arg3, int arg4, float[] arg5, int arg6, int[] arg7, int arg8, float[] arg9, int arg10) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLU.staticClass, global::android.opengl.GLU._gluUnProject5301, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GLU5302;
		public GLU()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.opengl.GLU.staticClass, global::android.opengl.GLU._GLU5302, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.opengl.GLU.staticClass = @__class;
			global::android.opengl.GLU._gluErrorString5296 = @__env.GetStaticMethodID(global::android.opengl.GLU.staticClass, "gluErrorString", "(I)Ljava/lang/String;");
			global::android.opengl.GLU._gluLookAt5297 = @__env.GetStaticMethodID(global::android.opengl.GLU.staticClass, "gluLookAt", "(Ljavax/microedition/khronos/opengles/GL10;FFFFFFFFF)V");
			global::android.opengl.GLU._gluOrtho2D5298 = @__env.GetStaticMethodID(global::android.opengl.GLU.staticClass, "gluOrtho2D", "(Ljavax/microedition/khronos/opengles/GL10;FFFF)V");
			global::android.opengl.GLU._gluPerspective5299 = @__env.GetStaticMethodID(global::android.opengl.GLU.staticClass, "gluPerspective", "(Ljavax/microedition/khronos/opengles/GL10;FFFF)V");
			global::android.opengl.GLU._gluProject5300 = @__env.GetStaticMethodID(global::android.opengl.GLU.staticClass, "gluProject", "(FFF[FI[FI[II[FI)I");
			global::android.opengl.GLU._gluUnProject5301 = @__env.GetStaticMethodID(global::android.opengl.GLU.staticClass, "gluUnProject", "(FFF[FI[FI[II[FI)I");
			global::android.opengl.GLU._GLU5302 = @__env.GetMethodID(global::android.opengl.GLU.staticClass, "<init>", "()V");
		}
	}
}
