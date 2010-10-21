namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GLES11 : android.opengl.GLES10
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GLES11()
		{
			InitJNI();
		}
		protected GLES11(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _glColorPointer8474;
		public static void glColorPointer(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glColorPointer8474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawElements8475;
		public static void glDrawElements(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glDrawElements8475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glNormalPointer8476;
		public static void glNormalPointer(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glNormalPointer8476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexCoordPointer8477;
		public static void glTexCoordPointer(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexCoordPointer8477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexPointer8478;
		public static void glVertexPointer(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glVertexPointer8478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glBindBuffer8479;
		public static void glBindBuffer(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glBindBuffer8479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBufferData8480;
		public static void glBufferData(int arg0, int arg1, java.nio.Buffer arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glBufferData8480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glBufferSubData8481;
		public static void glBufferSubData(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glBufferSubData8481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanef8482;
		public static void glClipPlanef(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glClipPlanef8482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanef8483;
		public static void glClipPlanef(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glClipPlanef8483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanex8484;
		public static void glClipPlanex(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glClipPlanex8484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanex8485;
		public static void glClipPlanex(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glClipPlanex8485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4ub8486;
		public static void glColor4ub(byte arg0, byte arg1, byte arg2, byte arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glColor4ub8486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteBuffers8487;
		public static void glDeleteBuffers(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glDeleteBuffers8487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteBuffers8488;
		public static void glDeleteBuffers(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glDeleteBuffers8488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGenBuffers8489;
		public static void glGenBuffers(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGenBuffers8489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenBuffers8490;
		public static void glGenBuffers(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGenBuffers8490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBooleanv8491;
		public static void glGetBooleanv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetBooleanv8491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBooleanv8492;
		public static void glGetBooleanv(int arg0, bool[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetBooleanv8492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBufferParameteriv8493;
		public static void glGetBufferParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetBufferParameteriv8493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBufferParameteriv8494;
		public static void glGetBufferParameteriv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetBufferParameteriv8494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanef8495;
		public static void glGetClipPlanef(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetClipPlanef8495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanef8496;
		public static void glGetClipPlanef(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetClipPlanef8496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanex8497;
		public static void glGetClipPlanex(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetClipPlanex8497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanex8498;
		public static void glGetClipPlanex(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetClipPlanex8498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFixedv8499;
		public static void glGetFixedv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetFixedv8499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFixedv8500;
		public static void glGetFixedv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetFixedv8500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFloatv8501;
		public static void glGetFloatv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetFloatv8501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFloatv8502;
		public static void glGetFloatv(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetFloatv8502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightfv8503;
		public static void glGetLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetLightfv8503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightfv8504;
		public static void glGetLightfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetLightfv8504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightxv8505;
		public static void glGetLightxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetLightxv8505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightxv8506;
		public static void glGetLightxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetLightxv8506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialfv8507;
		public static void glGetMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetMaterialfv8507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialfv8508;
		public static void glGetMaterialfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetMaterialfv8508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialxv8509;
		public static void glGetMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetMaterialxv8509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialxv8510;
		public static void glGetMaterialxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetMaterialxv8510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnvfv8511;
		public static void glGetTexEnvfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexEnvfv8511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnvfv8512;
		public static void glGetTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexEnvfv8512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnviv8513;
		public static void glGetTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexEnviv8513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnviv8514;
		public static void glGetTexEnviv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexEnviv8514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnvxv8515;
		public static void glGetTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexEnvxv8515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnvxv8516;
		public static void glGetTexEnvxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexEnvxv8516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterfv8517;
		public static void glGetTexParameterfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexParameterfv8517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterfv8518;
		public static void glGetTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexParameterfv8518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameteriv8519;
		public static void glGetTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexParameteriv8519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameteriv8520;
		public static void glGetTexParameteriv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexParameteriv8520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterxv8521;
		public static void glGetTexParameterxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexParameterxv8521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterxv8522;
		public static void glGetTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexParameterxv8522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glIsBuffer8523;
		public static bool glIsBuffer(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glIsBuffer8523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glIsEnabled8524;
		public static bool glIsEnabled(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glIsEnabled8524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glIsTexture8525;
		public static bool glIsTexture(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glIsTexture8525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterf8526;
		public static void glPointParameterf(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointParameterf8526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterfv8527;
		public static void glPointParameterfv(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointParameterfv8527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterfv8528;
		public static void glPointParameterfv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointParameterfv8528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterx8529;
		public static void glPointParameterx(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointParameterx8529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterxv8530;
		public static void glPointParameterxv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointParameterxv8530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterxv8531;
		public static void glPointParameterxv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointParameterxv8531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSizePointerOES8532;
		public static void glPointSizePointerOES(int arg0, int arg1, java.nio.Buffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointSizePointerOES8532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvi8533;
		public static void glTexEnvi(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexEnvi8533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnviv8534;
		public static void glTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexEnviv8534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnviv8535;
		public static void glTexEnviv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexEnviv8535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterfv8536;
		public static void glTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameterfv8536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterfv8537;
		public static void glTexParameterfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameterfv8537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameteri8538;
		public static void glTexParameteri(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameteri8538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameteriv8539;
		public static void glTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameteriv8539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameteriv8540;
		public static void glTexParameteriv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameteriv8540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterxv8541;
		public static void glTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameterxv8541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterxv8542;
		public static void glTexParameterxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameterxv8542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _GLES118543;
		public GLES11()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._GLES118543);
			Init(@__env, handle);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLES11.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLES11"));
			global::android.opengl.GLES11._glColorPointer8474 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glColorPointer", "(IIII)V");
			global::android.opengl.GLES11._glDrawElements8475 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glDrawElements", "(IIII)V");
			global::android.opengl.GLES11._glNormalPointer8476 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glNormalPointer", "(III)V");
			global::android.opengl.GLES11._glTexCoordPointer8477 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexCoordPointer", "(IIII)V");
			global::android.opengl.GLES11._glVertexPointer8478 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glVertexPointer", "(IIII)V");
			global::android.opengl.GLES11._glBindBuffer8479 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glBindBuffer", "(II)V");
			global::android.opengl.GLES11._glBufferData8480 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glBufferData", "(IILjava/nio/Buffer;I)V");
			global::android.opengl.GLES11._glBufferSubData8481 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glBufferSubData", "(IIILjava/nio/Buffer;)V");
			global::android.opengl.GLES11._glClipPlanef8482 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glClipPlanef", "(I[FI)V");
			global::android.opengl.GLES11._glClipPlanef8483 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glClipPlanef", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glClipPlanex8484 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glClipPlanex", "(I[II)V");
			global::android.opengl.GLES11._glClipPlanex8485 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glClipPlanex", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glColor4ub8486 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glColor4ub", "(BBBB)V");
			global::android.opengl.GLES11._glDeleteBuffers8487 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glDeleteBuffers", "(I[II)V");
			global::android.opengl.GLES11._glDeleteBuffers8488 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glDeleteBuffers", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGenBuffers8489 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGenBuffers", "(I[II)V");
			global::android.opengl.GLES11._glGenBuffers8490 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGenBuffers", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetBooleanv8491 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetBooleanv", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetBooleanv8492 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetBooleanv", "(I[ZI)V");
			global::android.opengl.GLES11._glGetBufferParameteriv8493 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetBufferParameteriv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetBufferParameteriv8494 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetBufferParameteriv", "(II[II)V");
			global::android.opengl.GLES11._glGetClipPlanef8495 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetClipPlanef", "(I[FI)V");
			global::android.opengl.GLES11._glGetClipPlanef8496 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetClipPlanef", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glGetClipPlanex8497 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetClipPlanex", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetClipPlanex8498 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetClipPlanex", "(I[II)V");
			global::android.opengl.GLES11._glGetFixedv8499 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetFixedv", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetFixedv8500 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetFixedv", "(I[II)V");
			global::android.opengl.GLES11._glGetFloatv8501 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetFloatv", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glGetFloatv8502 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetFloatv", "(I[FI)V");
			global::android.opengl.GLES11._glGetLightfv8503 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetLightfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glGetLightfv8504 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetLightfv", "(II[FI)V");
			global::android.opengl.GLES11._glGetLightxv8505 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetLightxv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetLightxv8506 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetLightxv", "(II[II)V");
			global::android.opengl.GLES11._glGetMaterialfv8507 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetMaterialfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glGetMaterialfv8508 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetMaterialfv", "(II[FI)V");
			global::android.opengl.GLES11._glGetMaterialxv8509 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetMaterialxv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetMaterialxv8510 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetMaterialxv", "(II[II)V");
			global::android.opengl.GLES11._glGetTexEnvfv8511 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexEnvfv", "(II[FI)V");
			global::android.opengl.GLES11._glGetTexEnvfv8512 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexEnvfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glGetTexEnviv8513 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexEnviv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetTexEnviv8514 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexEnviv", "(II[II)V");
			global::android.opengl.GLES11._glGetTexEnvxv8515 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexEnvxv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetTexEnvxv8516 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexEnvxv", "(II[II)V");
			global::android.opengl.GLES11._glGetTexParameterfv8517 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexParameterfv", "(II[FI)V");
			global::android.opengl.GLES11._glGetTexParameterfv8518 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexParameterfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glGetTexParameteriv8519 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexParameteriv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetTexParameteriv8520 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexParameteriv", "(II[II)V");
			global::android.opengl.GLES11._glGetTexParameterxv8521 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexParameterxv", "(II[II)V");
			global::android.opengl.GLES11._glGetTexParameterxv8522 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexParameterxv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glIsBuffer8523 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glIsBuffer", "(I)Z");
			global::android.opengl.GLES11._glIsEnabled8524 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glIsEnabled", "(I)Z");
			global::android.opengl.GLES11._glIsTexture8525 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glIsTexture", "(I)Z");
			global::android.opengl.GLES11._glPointParameterf8526 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointParameterf", "(IF)V");
			global::android.opengl.GLES11._glPointParameterfv8527 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointParameterfv", "(I[FI)V");
			global::android.opengl.GLES11._glPointParameterfv8528 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointParameterfv", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glPointParameterx8529 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointParameterx", "(II)V");
			global::android.opengl.GLES11._glPointParameterxv8530 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointParameterxv", "(I[II)V");
			global::android.opengl.GLES11._glPointParameterxv8531 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointParameterxv", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glPointSizePointerOES8532 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointSizePointerOES", "(IILjava/nio/Buffer;)V");
			global::android.opengl.GLES11._glTexEnvi8533 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexEnvi", "(III)V");
			global::android.opengl.GLES11._glTexEnviv8534 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexEnviv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glTexEnviv8535 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexEnviv", "(II[II)V");
			global::android.opengl.GLES11._glTexParameterfv8536 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameterfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glTexParameterfv8537 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameterfv", "(II[FI)V");
			global::android.opengl.GLES11._glTexParameteri8538 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameteri", "(III)V");
			global::android.opengl.GLES11._glTexParameteriv8539 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameteriv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glTexParameteriv8540 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameteriv", "(II[II)V");
			global::android.opengl.GLES11._glTexParameterxv8541 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameterxv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glTexParameterxv8542 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameterxv", "(II[II)V");
			global::android.opengl.GLES11._GLES118543 = @__env.GetMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "<init>", "()V");
		}
	}
}
