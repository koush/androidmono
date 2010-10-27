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
		internal static global::MonoJavaBridge.MethodId _glColorPointer8514;
		public static void glColorPointer(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glColorPointer8514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawElements8515;
		public static void glDrawElements(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glDrawElements8515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glNormalPointer8516;
		public static void glNormalPointer(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glNormalPointer8516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexCoordPointer8517;
		public static void glTexCoordPointer(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexCoordPointer8517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexPointer8518;
		public static void glVertexPointer(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glVertexPointer8518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glBindBuffer8519;
		public static void glBindBuffer(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glBindBuffer8519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBufferData8520;
		public static void glBufferData(int arg0, int arg1, java.nio.Buffer arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glBufferData8520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glBufferSubData8521;
		public static void glBufferSubData(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glBufferSubData8521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanef8522;
		public static void glClipPlanef(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glClipPlanef8522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanef8523;
		public static void glClipPlanef(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glClipPlanef8523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanex8524;
		public static void glClipPlanex(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glClipPlanex8524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanex8525;
		public static void glClipPlanex(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glClipPlanex8525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4ub8526;
		public static void glColor4ub(byte arg0, byte arg1, byte arg2, byte arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glColor4ub8526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteBuffers8527;
		public static void glDeleteBuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glDeleteBuffers8527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteBuffers8528;
		public static void glDeleteBuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glDeleteBuffers8528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGenBuffers8529;
		public static void glGenBuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGenBuffers8529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenBuffers8530;
		public static void glGenBuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGenBuffers8530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBooleanv8531;
		public static void glGetBooleanv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetBooleanv8531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBooleanv8532;
		public static void glGetBooleanv(int arg0, bool[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetBooleanv8532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBufferParameteriv8533;
		public static void glGetBufferParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetBufferParameteriv8533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBufferParameteriv8534;
		public static void glGetBufferParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetBufferParameteriv8534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanef8535;
		public static void glGetClipPlanef(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetClipPlanef8535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanef8536;
		public static void glGetClipPlanef(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetClipPlanef8536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanex8537;
		public static void glGetClipPlanex(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetClipPlanex8537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanex8538;
		public static void glGetClipPlanex(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetClipPlanex8538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFixedv8539;
		public static void glGetFixedv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetFixedv8539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFixedv8540;
		public static void glGetFixedv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetFixedv8540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFloatv8541;
		public static void glGetFloatv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetFloatv8541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFloatv8542;
		public static void glGetFloatv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetFloatv8542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightfv8543;
		public static void glGetLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetLightfv8543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightfv8544;
		public static void glGetLightfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetLightfv8544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightxv8545;
		public static void glGetLightxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetLightxv8545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightxv8546;
		public static void glGetLightxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetLightxv8546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialfv8547;
		public static void glGetMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetMaterialfv8547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialfv8548;
		public static void glGetMaterialfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetMaterialfv8548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialxv8549;
		public static void glGetMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetMaterialxv8549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialxv8550;
		public static void glGetMaterialxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetMaterialxv8550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnvfv8551;
		public static void glGetTexEnvfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexEnvfv8551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnvfv8552;
		public static void glGetTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexEnvfv8552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnviv8553;
		public static void glGetTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexEnviv8553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnviv8554;
		public static void glGetTexEnviv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexEnviv8554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnvxv8555;
		public static void glGetTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexEnvxv8555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnvxv8556;
		public static void glGetTexEnvxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexEnvxv8556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterfv8557;
		public static void glGetTexParameterfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexParameterfv8557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterfv8558;
		public static void glGetTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexParameterfv8558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameteriv8559;
		public static void glGetTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexParameteriv8559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameteriv8560;
		public static void glGetTexParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexParameteriv8560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterxv8561;
		public static void glGetTexParameterxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexParameterxv8561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterxv8562;
		public static void glGetTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glGetTexParameterxv8562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glIsBuffer8563;
		public static bool glIsBuffer(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glIsBuffer8563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glIsEnabled8564;
		public static bool glIsEnabled(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glIsEnabled8564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glIsTexture8565;
		public static bool glIsTexture(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glIsTexture8565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterf8566;
		public static void glPointParameterf(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointParameterf8566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterfv8567;
		public static void glPointParameterfv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointParameterfv8567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterfv8568;
		public static void glPointParameterfv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointParameterfv8568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterx8569;
		public static void glPointParameterx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointParameterx8569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterxv8570;
		public static void glPointParameterxv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointParameterxv8570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterxv8571;
		public static void glPointParameterxv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointParameterxv8571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSizePointerOES8572;
		public static void glPointSizePointerOES(int arg0, int arg1, java.nio.Buffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glPointSizePointerOES8572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvi8573;
		public static void glTexEnvi(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexEnvi8573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnviv8574;
		public static void glTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexEnviv8574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnviv8575;
		public static void glTexEnviv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexEnviv8575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterfv8576;
		public static void glTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameterfv8576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterfv8577;
		public static void glTexParameterfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameterfv8577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameteri8578;
		public static void glTexParameteri(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameteri8578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameteriv8579;
		public static void glTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameteriv8579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameteriv8580;
		public static void glTexParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameteriv8580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterxv8581;
		public static void glTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameterxv8581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterxv8582;
		public static void glTexParameterxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._glTexParameterxv8582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _GLES118583;
		public GLES11() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._GLES118583);
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
			global::android.opengl.GLES11._glColorPointer8514 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glColorPointer", "(IIII)V");
			global::android.opengl.GLES11._glDrawElements8515 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glDrawElements", "(IIII)V");
			global::android.opengl.GLES11._glNormalPointer8516 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glNormalPointer", "(III)V");
			global::android.opengl.GLES11._glTexCoordPointer8517 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexCoordPointer", "(IIII)V");
			global::android.opengl.GLES11._glVertexPointer8518 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glVertexPointer", "(IIII)V");
			global::android.opengl.GLES11._glBindBuffer8519 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glBindBuffer", "(II)V");
			global::android.opengl.GLES11._glBufferData8520 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glBufferData", "(IILjava/nio/Buffer;I)V");
			global::android.opengl.GLES11._glBufferSubData8521 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glBufferSubData", "(IIILjava/nio/Buffer;)V");
			global::android.opengl.GLES11._glClipPlanef8522 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glClipPlanef", "(I[FI)V");
			global::android.opengl.GLES11._glClipPlanef8523 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glClipPlanef", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glClipPlanex8524 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glClipPlanex", "(I[II)V");
			global::android.opengl.GLES11._glClipPlanex8525 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glClipPlanex", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glColor4ub8526 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glColor4ub", "(BBBB)V");
			global::android.opengl.GLES11._glDeleteBuffers8527 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glDeleteBuffers", "(I[II)V");
			global::android.opengl.GLES11._glDeleteBuffers8528 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glDeleteBuffers", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGenBuffers8529 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGenBuffers", "(I[II)V");
			global::android.opengl.GLES11._glGenBuffers8530 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGenBuffers", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetBooleanv8531 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetBooleanv", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetBooleanv8532 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetBooleanv", "(I[ZI)V");
			global::android.opengl.GLES11._glGetBufferParameteriv8533 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetBufferParameteriv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetBufferParameteriv8534 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetBufferParameteriv", "(II[II)V");
			global::android.opengl.GLES11._glGetClipPlanef8535 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetClipPlanef", "(I[FI)V");
			global::android.opengl.GLES11._glGetClipPlanef8536 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetClipPlanef", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glGetClipPlanex8537 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetClipPlanex", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetClipPlanex8538 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetClipPlanex", "(I[II)V");
			global::android.opengl.GLES11._glGetFixedv8539 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetFixedv", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetFixedv8540 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetFixedv", "(I[II)V");
			global::android.opengl.GLES11._glGetFloatv8541 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetFloatv", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glGetFloatv8542 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetFloatv", "(I[FI)V");
			global::android.opengl.GLES11._glGetLightfv8543 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetLightfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glGetLightfv8544 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetLightfv", "(II[FI)V");
			global::android.opengl.GLES11._glGetLightxv8545 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetLightxv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetLightxv8546 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetLightxv", "(II[II)V");
			global::android.opengl.GLES11._glGetMaterialfv8547 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetMaterialfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glGetMaterialfv8548 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetMaterialfv", "(II[FI)V");
			global::android.opengl.GLES11._glGetMaterialxv8549 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetMaterialxv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetMaterialxv8550 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetMaterialxv", "(II[II)V");
			global::android.opengl.GLES11._glGetTexEnvfv8551 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexEnvfv", "(II[FI)V");
			global::android.opengl.GLES11._glGetTexEnvfv8552 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexEnvfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glGetTexEnviv8553 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexEnviv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetTexEnviv8554 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexEnviv", "(II[II)V");
			global::android.opengl.GLES11._glGetTexEnvxv8555 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexEnvxv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetTexEnvxv8556 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexEnvxv", "(II[II)V");
			global::android.opengl.GLES11._glGetTexParameterfv8557 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexParameterfv", "(II[FI)V");
			global::android.opengl.GLES11._glGetTexParameterfv8558 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexParameterfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glGetTexParameteriv8559 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexParameteriv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glGetTexParameteriv8560 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexParameteriv", "(II[II)V");
			global::android.opengl.GLES11._glGetTexParameterxv8561 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexParameterxv", "(II[II)V");
			global::android.opengl.GLES11._glGetTexParameterxv8562 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexParameterxv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glIsBuffer8563 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glIsBuffer", "(I)Z");
			global::android.opengl.GLES11._glIsEnabled8564 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glIsEnabled", "(I)Z");
			global::android.opengl.GLES11._glIsTexture8565 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glIsTexture", "(I)Z");
			global::android.opengl.GLES11._glPointParameterf8566 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointParameterf", "(IF)V");
			global::android.opengl.GLES11._glPointParameterfv8567 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointParameterfv", "(I[FI)V");
			global::android.opengl.GLES11._glPointParameterfv8568 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointParameterfv", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glPointParameterx8569 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointParameterx", "(II)V");
			global::android.opengl.GLES11._glPointParameterxv8570 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointParameterxv", "(I[II)V");
			global::android.opengl.GLES11._glPointParameterxv8571 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointParameterxv", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glPointSizePointerOES8572 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointSizePointerOES", "(IILjava/nio/Buffer;)V");
			global::android.opengl.GLES11._glTexEnvi8573 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexEnvi", "(III)V");
			global::android.opengl.GLES11._glTexEnviv8574 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexEnviv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glTexEnviv8575 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexEnviv", "(II[II)V");
			global::android.opengl.GLES11._glTexParameterfv8576 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameterfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11._glTexParameterfv8577 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameterfv", "(II[FI)V");
			global::android.opengl.GLES11._glTexParameteri8578 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameteri", "(III)V");
			global::android.opengl.GLES11._glTexParameteriv8579 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameteriv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glTexParameteriv8580 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameteriv", "(II[II)V");
			global::android.opengl.GLES11._glTexParameterxv8581 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameterxv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11._glTexParameterxv8582 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameterxv", "(II[II)V");
			global::android.opengl.GLES11._GLES118583 = @__env.GetMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "<init>", "()V");
		}
	}
}
