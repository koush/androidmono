namespace android.opengl
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class GLES11 : android.opengl.GLES10
	{
		internal new static global::java.lang.Class staticClass;
		static GLES11()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.opengl.GLES11), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.opengl.GLES11(@__env);
			}
		}
		protected GLES11(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _glColorPointer5073;
		public static void glColorPointer(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glColorPointer5073, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDrawElements5074;
		public static void glDrawElements(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glDrawElements5074, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glNormalPointer5075;
		public static void glNormalPointer(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glNormalPointer5075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexCoordPointer5076;
		public static void glTexCoordPointer(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexCoordPointer5076, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glVertexPointer5077;
		public static void glVertexPointer(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glVertexPointer5077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBindBuffer5078;
		public static void glBindBuffer(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glBindBuffer5078, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBufferData5079;
		public static void glBufferData(int arg0, int arg1, java.nio.Buffer arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glBufferData5079, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBufferSubData5080;
		public static void glBufferSubData(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glBufferSubData5080, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanef5081;
		public static void glClipPlanef(int arg0, float[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glClipPlanef5081, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanef5082;
		public static void glClipPlanef(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glClipPlanef5082, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanex5083;
		public static void glClipPlanex(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glClipPlanex5083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanex5084;
		public static void glClipPlanex(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glClipPlanex5084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glColor4ub5085;
		public static void glColor4ub(byte arg0, byte arg1, byte arg2, byte arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glColor4ub5085, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteBuffers5086;
		public static void glDeleteBuffers(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glDeleteBuffers5086, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteBuffers5087;
		public static void glDeleteBuffers(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glDeleteBuffers5087, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGenBuffers5088;
		public static void glGenBuffers(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGenBuffers5088, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGenBuffers5089;
		public static void glGenBuffers(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGenBuffers5089, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetBooleanv5090;
		public static void glGetBooleanv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetBooleanv5090, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetBooleanv5091;
		public static void glGetBooleanv(int arg0, bool[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetBooleanv5091, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetBufferParameteriv5092;
		public static void glGetBufferParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetBufferParameteriv5092, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetBufferParameteriv5093;
		public static void glGetBufferParameteriv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetBufferParameteriv5093, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanef5094;
		public static void glGetClipPlanef(int arg0, float[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetClipPlanef5094, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanef5095;
		public static void glGetClipPlanef(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetClipPlanef5095, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanex5096;
		public static void glGetClipPlanex(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetClipPlanex5096, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanex5097;
		public static void glGetClipPlanex(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetClipPlanex5097, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetFixedv5098;
		public static void glGetFixedv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetFixedv5098, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetFixedv5099;
		public static void glGetFixedv(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetFixedv5099, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetFloatv5100;
		public static void glGetFloatv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetFloatv5100, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetFloatv5101;
		public static void glGetFloatv(int arg0, float[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetFloatv5101, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetLightfv5102;
		public static void glGetLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetLightfv5102, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetLightfv5103;
		public static void glGetLightfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetLightfv5103, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetLightxv5104;
		public static void glGetLightxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetLightxv5104, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetLightxv5105;
		public static void glGetLightxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetLightxv5105, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetMaterialfv5106;
		public static void glGetMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetMaterialfv5106, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetMaterialfv5107;
		public static void glGetMaterialfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetMaterialfv5107, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetMaterialxv5108;
		public static void glGetMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetMaterialxv5108, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetMaterialxv5109;
		public static void glGetMaterialxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetMaterialxv5109, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexEnvfv5110;
		public static void glGetTexEnvfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexEnvfv5110, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexEnvfv5111;
		public static void glGetTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexEnvfv5111, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexEnviv5112;
		public static void glGetTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexEnviv5112, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexEnviv5113;
		public static void glGetTexEnviv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexEnviv5113, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexEnvxv5114;
		public static void glGetTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexEnvxv5114, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexEnvxv5115;
		public static void glGetTexEnvxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexEnvxv5115, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameterfv5116;
		public static void glGetTexParameterfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexParameterfv5116, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameterfv5117;
		public static void glGetTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexParameterfv5117, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameteriv5118;
		public static void glGetTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexParameteriv5118, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameteriv5119;
		public static void glGetTexParameteriv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexParameteriv5119, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameterxv5120;
		public static void glGetTexParameterxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexParameterxv5120, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameterxv5121;
		public static void glGetTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexParameterxv5121, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glIsBuffer5122;
		public static bool glIsBuffer(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glIsBuffer5122, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glIsEnabled5123;
		public static bool glIsEnabled(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glIsEnabled5123, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glIsTexture5124;
		public static bool glIsTexture(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glIsTexture5124, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterf5125;
		public static void glPointParameterf(int arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointParameterf5125, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterfv5126;
		public static void glPointParameterfv(int arg0, float[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointParameterfv5126, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterfv5127;
		public static void glPointParameterfv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointParameterfv5127, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterx5128;
		public static void glPointParameterx(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointParameterx5128, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterxv5129;
		public static void glPointParameterxv(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointParameterxv5129, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterxv5130;
		public static void glPointParameterxv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointParameterxv5130, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPointSizePointerOES5131;
		public static void glPointSizePointerOES(int arg0, int arg1, java.nio.Buffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointSizePointerOES5131, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvi5132;
		public static void glTexEnvi(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexEnvi5132, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnviv5133;
		public static void glTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexEnviv5133, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnviv5134;
		public static void glTexEnviv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexEnviv5134, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterfv5135;
		public static void glTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameterfv5135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterfv5136;
		public static void glTexParameterfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameterfv5136, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameteri5137;
		public static void glTexParameteri(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameteri5137, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameteriv5138;
		public static void glTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameteriv5138, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameteriv5139;
		public static void glTexParameteriv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameteriv5139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterxv5140;
		public static void glTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameterxv5140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterxv5141;
		public static void glTexParameterxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameterxv5141, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GLES115142;
		public GLES11()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._GLES115142, this);
		}
		public static int GL_ACTIVE_TEXTURE
		{
			get
			{
				return 34016;
			}
		}
		public static int GL_ADD_SIGNED
		{
			get
			{
				return 34164;
			}
		}
		public static int GL_ALPHA_SCALE
		{
			get
			{
				return 3356;
			}
		}
		public static int GL_ALPHA_TEST_FUNC
		{
			get
			{
				return 3009;
			}
		}
		public static int GL_ALPHA_TEST_REF
		{
			get
			{
				return 3010;
			}
		}
		public static int GL_ARRAY_BUFFER
		{
			get
			{
				return 34962;
			}
		}
		public static int GL_ARRAY_BUFFER_BINDING
		{
			get
			{
				return 34964;
			}
		}
		public static int GL_BLEND_DST
		{
			get
			{
				return 3040;
			}
		}
		public static int GL_BLEND_SRC
		{
			get
			{
				return 3041;
			}
		}
		public static int GL_BUFFER_ACCESS
		{
			get
			{
				return 35003;
			}
		}
		public static int GL_BUFFER_SIZE
		{
			get
			{
				return 34660;
			}
		}
		public static int GL_BUFFER_USAGE
		{
			get
			{
				return 34661;
			}
		}
		public static int GL_CLIENT_ACTIVE_TEXTURE
		{
			get
			{
				return 34017;
			}
		}
		public static int GL_CLIP_PLANE0
		{
			get
			{
				return 12288;
			}
		}
		public static int GL_CLIP_PLANE1
		{
			get
			{
				return 12289;
			}
		}
		public static int GL_CLIP_PLANE2
		{
			get
			{
				return 12290;
			}
		}
		public static int GL_CLIP_PLANE3
		{
			get
			{
				return 12291;
			}
		}
		public static int GL_CLIP_PLANE4
		{
			get
			{
				return 12292;
			}
		}
		public static int GL_CLIP_PLANE5
		{
			get
			{
				return 12293;
			}
		}
		public static int GL_COLOR_ARRAY_BUFFER_BINDING
		{
			get
			{
				return 34968;
			}
		}
		public static int GL_COLOR_ARRAY_POINTER
		{
			get
			{
				return 32912;
			}
		}
		public static int GL_COLOR_ARRAY_SIZE
		{
			get
			{
				return 32897;
			}
		}
		public static int GL_COLOR_ARRAY_STRIDE
		{
			get
			{
				return 32899;
			}
		}
		public static int GL_COLOR_ARRAY_TYPE
		{
			get
			{
				return 32898;
			}
		}
		public static int GL_COLOR_CLEAR_VALUE
		{
			get
			{
				return 3106;
			}
		}
		public static int GL_COLOR_WRITEMASK
		{
			get
			{
				return 3107;
			}
		}
		public static int GL_COMBINE
		{
			get
			{
				return 34160;
			}
		}
		public static int GL_COMBINE_ALPHA
		{
			get
			{
				return 34162;
			}
		}
		public static int GL_COMBINE_RGB
		{
			get
			{
				return 34161;
			}
		}
		public static int GL_CONSTANT
		{
			get
			{
				return 34166;
			}
		}
		public static int GL_COORD_REPLACE_OES
		{
			get
			{
				return 34914;
			}
		}
		public static int GL_CULL_FACE_MODE
		{
			get
			{
				return 2885;
			}
		}
		public static int GL_CURRENT_COLOR
		{
			get
			{
				return 2816;
			}
		}
		public static int GL_CURRENT_NORMAL
		{
			get
			{
				return 2818;
			}
		}
		public static int GL_CURRENT_TEXTURE_COORDS
		{
			get
			{
				return 2819;
			}
		}
		public static int GL_DEPTH_CLEAR_VALUE
		{
			get
			{
				return 2931;
			}
		}
		public static int GL_DEPTH_FUNC
		{
			get
			{
				return 2932;
			}
		}
		public static int GL_DEPTH_RANGE
		{
			get
			{
				return 2928;
			}
		}
		public static int GL_DEPTH_WRITEMASK
		{
			get
			{
				return 2930;
			}
		}
		public static int GL_DOT3_RGB
		{
			get
			{
				return 34478;
			}
		}
		public static int GL_DOT3_RGBA
		{
			get
			{
				return 34479;
			}
		}
		public static int GL_DYNAMIC_DRAW
		{
			get
			{
				return 35048;
			}
		}
		public static int GL_ELEMENT_ARRAY_BUFFER
		{
			get
			{
				return 34963;
			}
		}
		public static int GL_ELEMENT_ARRAY_BUFFER_BINDING
		{
			get
			{
				return 34965;
			}
		}
		public static int GL_FRONT_FACE
		{
			get
			{
				return 2886;
			}
		}
		public static int GL_GENERATE_MIPMAP
		{
			get
			{
				return 33169;
			}
		}
		public static int GL_GENERATE_MIPMAP_HINT
		{
			get
			{
				return 33170;
			}
		}
		public static int GL_INTERPOLATE
		{
			get
			{
				return 34165;
			}
		}
		public static int GL_LINE_WIDTH
		{
			get
			{
				return 2849;
			}
		}
		public static int GL_LOGIC_OP_MODE
		{
			get
			{
				return 3056;
			}
		}
		public static int GL_MATRIX_MODE
		{
			get
			{
				return 2976;
			}
		}
		public static int GL_MAX_CLIP_PLANES
		{
			get
			{
				return 3378;
			}
		}
		public static int GL_MODELVIEW_MATRIX
		{
			get
			{
				return 2982;
			}
		}
		public static int GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES
		{
			get
			{
				return 35213;
			}
		}
		public static int GL_MODELVIEW_STACK_DEPTH
		{
			get
			{
				return 2979;
			}
		}
		public static int GL_NORMAL_ARRAY_BUFFER_BINDING
		{
			get
			{
				return 34967;
			}
		}
		public static int GL_NORMAL_ARRAY_POINTER
		{
			get
			{
				return 32911;
			}
		}
		public static int GL_NORMAL_ARRAY_STRIDE
		{
			get
			{
				return 32895;
			}
		}
		public static int GL_NORMAL_ARRAY_TYPE
		{
			get
			{
				return 32894;
			}
		}
		public static int GL_OPERAND0_ALPHA
		{
			get
			{
				return 34200;
			}
		}
		public static int GL_OPERAND0_RGB
		{
			get
			{
				return 34192;
			}
		}
		public static int GL_OPERAND1_ALPHA
		{
			get
			{
				return 34201;
			}
		}
		public static int GL_OPERAND1_RGB
		{
			get
			{
				return 34193;
			}
		}
		public static int GL_OPERAND2_ALPHA
		{
			get
			{
				return 34202;
			}
		}
		public static int GL_OPERAND2_RGB
		{
			get
			{
				return 34194;
			}
		}
		public static int GL_POINT_DISTANCE_ATTENUATION
		{
			get
			{
				return 33065;
			}
		}
		public static int GL_POINT_FADE_THRESHOLD_SIZE
		{
			get
			{
				return 33064;
			}
		}
		public static int GL_POINT_SIZE
		{
			get
			{
				return 2833;
			}
		}
		public static int GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES
		{
			get
			{
				return 35743;
			}
		}
		public static int GL_POINT_SIZE_ARRAY_OES
		{
			get
			{
				return 35740;
			}
		}
		public static int GL_POINT_SIZE_ARRAY_POINTER_OES
		{
			get
			{
				return 35212;
			}
		}
		public static int GL_POINT_SIZE_ARRAY_STRIDE_OES
		{
			get
			{
				return 35211;
			}
		}
		public static int GL_POINT_SIZE_ARRAY_TYPE_OES
		{
			get
			{
				return 35210;
			}
		}
		public static int GL_POINT_SIZE_MAX
		{
			get
			{
				return 33063;
			}
		}
		public static int GL_POINT_SIZE_MIN
		{
			get
			{
				return 33062;
			}
		}
		public static int GL_POINT_SPRITE_OES
		{
			get
			{
				return 34913;
			}
		}
		public static int GL_POLYGON_OFFSET_FACTOR
		{
			get
			{
				return 32824;
			}
		}
		public static int GL_POLYGON_OFFSET_UNITS
		{
			get
			{
				return 10752;
			}
		}
		public static int GL_PREVIOUS
		{
			get
			{
				return 34168;
			}
		}
		public static int GL_PRIMARY_COLOR
		{
			get
			{
				return 34167;
			}
		}
		public static int GL_PROJECTION_MATRIX
		{
			get
			{
				return 2983;
			}
		}
		public static int GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES
		{
			get
			{
				return 35214;
			}
		}
		public static int GL_PROJECTION_STACK_DEPTH
		{
			get
			{
				return 2980;
			}
		}
		public static int GL_RGB_SCALE
		{
			get
			{
				return 34163;
			}
		}
		public static int GL_SAMPLE_BUFFERS
		{
			get
			{
				return 32936;
			}
		}
		public static int GL_SAMPLE_COVERAGE_INVERT
		{
			get
			{
				return 32939;
			}
		}
		public static int GL_SAMPLE_COVERAGE_VALUE
		{
			get
			{
				return 32938;
			}
		}
		public static int GL_SAMPLES
		{
			get
			{
				return 32937;
			}
		}
		public static int GL_SCISSOR_BOX
		{
			get
			{
				return 3088;
			}
		}
		public static int GL_SHADE_MODEL
		{
			get
			{
				return 2900;
			}
		}
		public static int GL_SRC0_ALPHA
		{
			get
			{
				return 34184;
			}
		}
		public static int GL_SRC0_RGB
		{
			get
			{
				return 34176;
			}
		}
		public static int GL_SRC1_ALPHA
		{
			get
			{
				return 34185;
			}
		}
		public static int GL_SRC1_RGB
		{
			get
			{
				return 34177;
			}
		}
		public static int GL_SRC2_ALPHA
		{
			get
			{
				return 34186;
			}
		}
		public static int GL_SRC2_RGB
		{
			get
			{
				return 34178;
			}
		}
		public static int GL_STATIC_DRAW
		{
			get
			{
				return 35044;
			}
		}
		public static int GL_STENCIL_CLEAR_VALUE
		{
			get
			{
				return 2961;
			}
		}
		public static int GL_STENCIL_FAIL
		{
			get
			{
				return 2964;
			}
		}
		public static int GL_STENCIL_FUNC
		{
			get
			{
				return 2962;
			}
		}
		public static int GL_STENCIL_PASS_DEPTH_FAIL
		{
			get
			{
				return 2965;
			}
		}
		public static int GL_STENCIL_PASS_DEPTH_PASS
		{
			get
			{
				return 2966;
			}
		}
		public static int GL_STENCIL_REF
		{
			get
			{
				return 2967;
			}
		}
		public static int GL_STENCIL_VALUE_MASK
		{
			get
			{
				return 2963;
			}
		}
		public static int GL_STENCIL_WRITEMASK
		{
			get
			{
				return 2968;
			}
		}
		public static int GL_SUBTRACT
		{
			get
			{
				return 34023;
			}
		}
		public static int GL_TEXTURE_BINDING_2D
		{
			get
			{
				return 32873;
			}
		}
		public static int GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING
		{
			get
			{
				return 34970;
			}
		}
		public static int GL_TEXTURE_COORD_ARRAY_POINTER
		{
			get
			{
				return 32914;
			}
		}
		public static int GL_TEXTURE_COORD_ARRAY_SIZE
		{
			get
			{
				return 32904;
			}
		}
		public static int GL_TEXTURE_COORD_ARRAY_STRIDE
		{
			get
			{
				return 32906;
			}
		}
		public static int GL_TEXTURE_COORD_ARRAY_TYPE
		{
			get
			{
				return 32905;
			}
		}
		public static int GL_TEXTURE_MATRIX
		{
			get
			{
				return 2984;
			}
		}
		public static int GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES
		{
			get
			{
				return 35215;
			}
		}
		public static int GL_TEXTURE_STACK_DEPTH
		{
			get
			{
				return 2981;
			}
		}
		public static int GL_VERTEX_ARRAY_BUFFER_BINDING
		{
			get
			{
				return 34966;
			}
		}
		public static int GL_VERTEX_ARRAY_POINTER
		{
			get
			{
				return 32910;
			}
		}
		public static int GL_VERTEX_ARRAY_SIZE
		{
			get
			{
				return 32890;
			}
		}
		public static int GL_VERTEX_ARRAY_STRIDE
		{
			get
			{
				return 32892;
			}
		}
		public static int GL_VERTEX_ARRAY_TYPE
		{
			get
			{
				return 32891;
			}
		}
		public static int GL_VIEWPORT
		{
			get
			{
				return 2978;
			}
		}
		public static int GL_WRITE_ONLY
		{
			get
			{
				return 35001;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.opengl.GLES11.staticClass = @__class;
			global::android.opengl.GLES11._glColorPointer5073 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glColorPointer", "(IIII)V");
			global::android.opengl.GLES11._glDrawElements5074 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glDrawElements", "(IIII)V");
			global::android.opengl.GLES11._glNormalPointer5075 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glNormalPointer", "(III)V");
			global::android.opengl.GLES11._glTexCoordPointer5076 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexCoordPointer", "(IIII)V");
			global::android.opengl.GLES11._glVertexPointer5077 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glVertexPointer", "(IIII)V");
			global::android.opengl.GLES11._glBindBuffer5078 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glBindBuffer", "(II)V");
			global::android.opengl.GLES11._glBufferData5079 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glBufferData", "(IILjava/nio/Buffer;I)V");
			global::android.opengl.GLES11._glBufferSubData5080 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glBufferSubData", "(IIILjava/nio/Buffer;)V");
			global::android.opengl.GLES11._glClipPlanef5081 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glClipPlanef", "(I[FI)V");
			global::android.opengl.GLES11._glClipPlanef5082 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glClipPlanef", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glClipPlanex5083 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glClipPlanex", "(I[II)V");
			global::android.opengl.GLES11._glClipPlanex5084 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glClipPlanex", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glColor4ub5085 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glColor4ub", "(BBBB)V");
			global::android.opengl.GLES11._glDeleteBuffers5086 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glDeleteBuffers", "(I[II)V");
			global::android.opengl.GLES11._glDeleteBuffers5087 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glDeleteBuffers", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGenBuffers5088 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGenBuffers", "(I[II)V");
			global::android.opengl.GLES11._glGenBuffers5089 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGenBuffers", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetBooleanv5090 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetBooleanv", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetBooleanv5091 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetBooleanv", "(I[ZI)V");
			global::android.opengl.GLES11._glGetBufferParameteriv5092 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetBufferParameteriv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetBufferParameteriv5093 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetBufferParameteriv", "(II[II)V");
			global::android.opengl.GLES11._glGetClipPlanef5094 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetClipPlanef", "(I[FI)V");
			global::android.opengl.GLES11._glGetClipPlanef5095 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetClipPlanef", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glGetClipPlanex5096 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetClipPlanex", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetClipPlanex5097 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetClipPlanex", "(I[II)V");
			global::android.opengl.GLES11._glGetFixedv5098 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetFixedv", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetFixedv5099 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetFixedv", "(I[II)V");
			global::android.opengl.GLES11._glGetFloatv5100 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetFloatv", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glGetFloatv5101 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetFloatv", "(I[FI)V");
			global::android.opengl.GLES11._glGetLightfv5102 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetLightfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glGetLightfv5103 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetLightfv", "(II[FI)V");
			global::android.opengl.GLES11._glGetLightxv5104 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetLightxv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetLightxv5105 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetLightxv", "(II[II)V");
			global::android.opengl.GLES11._glGetMaterialfv5106 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetMaterialfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glGetMaterialfv5107 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetMaterialfv", "(II[FI)V");
			global::android.opengl.GLES11._glGetMaterialxv5108 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetMaterialxv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetMaterialxv5109 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetMaterialxv", "(II[II)V");
			global::android.opengl.GLES11._glGetTexEnvfv5110 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexEnvfv", "(II[FI)V");
			global::android.opengl.GLES11._glGetTexEnvfv5111 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexEnvfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glGetTexEnviv5112 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexEnviv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetTexEnviv5113 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexEnviv", "(II[II)V");
			global::android.opengl.GLES11._glGetTexEnvxv5114 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexEnvxv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetTexEnvxv5115 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexEnvxv", "(II[II)V");
			global::android.opengl.GLES11._glGetTexParameterfv5116 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexParameterfv", "(II[FI)V");
			global::android.opengl.GLES11._glGetTexParameterfv5117 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexParameterfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glGetTexParameteriv5118 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexParameteriv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetTexParameteriv5119 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexParameteriv", "(II[II)V");
			global::android.opengl.GLES11._glGetTexParameterxv5120 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexParameterxv", "(II[II)V");
			global::android.opengl.GLES11._glGetTexParameterxv5121 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexParameterxv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glIsBuffer5122 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glIsBuffer", "(I)Z");
			global::android.opengl.GLES11._glIsEnabled5123 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glIsEnabled", "(I)Z");
			global::android.opengl.GLES11._glIsTexture5124 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glIsTexture", "(I)Z");
			global::android.opengl.GLES11._glPointParameterf5125 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glPointParameterf", "(IF)V");
			global::android.opengl.GLES11._glPointParameterfv5126 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glPointParameterfv", "(I[FI)V");
			global::android.opengl.GLES11._glPointParameterfv5127 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glPointParameterfv", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glPointParameterx5128 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glPointParameterx", "(II)V");
			global::android.opengl.GLES11._glPointParameterxv5129 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glPointParameterxv", "(I[II)V");
			global::android.opengl.GLES11._glPointParameterxv5130 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glPointParameterxv", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glPointSizePointerOES5131 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glPointSizePointerOES", "(IILjava/nio/Buffer;)V");
			global::android.opengl.GLES11._glTexEnvi5132 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexEnvi", "(III)V");
			global::android.opengl.GLES11._glTexEnviv5133 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexEnviv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glTexEnviv5134 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexEnviv", "(II[II)V");
			global::android.opengl.GLES11._glTexParameterfv5135 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexParameterfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glTexParameterfv5136 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexParameterfv", "(II[FI)V");
			global::android.opengl.GLES11._glTexParameteri5137 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexParameteri", "(III)V");
			global::android.opengl.GLES11._glTexParameteriv5138 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexParameteriv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glTexParameteriv5139 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexParameteriv", "(II[II)V");
			global::android.opengl.GLES11._glTexParameterxv5140 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexParameterxv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glTexParameterxv5141 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexParameterxv", "(II[II)V");
			global::android.opengl.GLES11._GLES115142 = @__env.GetMethodID(global::android.opengl.GLES11.staticClass, "<init>", "()V");
		}
	}
}
