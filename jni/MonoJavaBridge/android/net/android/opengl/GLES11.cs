namespace android.opengl 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GLES11 : android.opengl.GLES10
	{ 
		internal new static global::java.lang.Class staticClass; 
		static GLES11() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.opengl.GLES11), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _glColorPointer4824; 
		public static void glColorPointer(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glColorPointer4824, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawElements4825; 
		public static void glDrawElements(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glDrawElements4825, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glNormalPointer4826; 
		public static void glNormalPointer(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glNormalPointer4826, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexCoordPointer4827; 
		public static void glTexCoordPointer(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glTexCoordPointer4827, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glVertexPointer4828; 
		public static void glVertexPointer(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glVertexPointer4828, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glBindBuffer4829; 
		public static void glBindBuffer(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glBindBuffer4829, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glBufferData4830; 
		public static void glBufferData(int arg0, int arg1, java.nio.Buffer arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glBufferData4830, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glBufferSubData4831; 
		public static void glBufferSubData(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glBufferSubData4831, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanef4832; 
		public static void glClipPlanef(int arg0, float[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glClipPlanef4832, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanef4833; 
		public static void glClipPlanef(int arg0, java.nio.FloatBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glClipPlanef4833, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanex4834; 
		public static void glClipPlanex(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glClipPlanex4834, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanex4835; 
		public static void glClipPlanex(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glClipPlanex4835, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glColor4ub4836; 
		public static void glColor4ub(byte arg0, byte arg1, byte arg2, byte arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glColor4ub4836, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteBuffers4837; 
		public static void glDeleteBuffers(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glDeleteBuffers4837, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteBuffers4838; 
		public static void glDeleteBuffers(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glDeleteBuffers4838, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGenBuffers4839; 
		public static void glGenBuffers(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGenBuffers4839, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGenBuffers4840; 
		public static void glGenBuffers(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGenBuffers4840, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetBooleanv4841; 
		public static void glGetBooleanv(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetBooleanv4841, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetBooleanv4842; 
		public static void glGetBooleanv(int arg0, bool[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetBooleanv4842, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetBufferParameteriv4843; 
		public static void glGetBufferParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetBufferParameteriv4843, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetBufferParameteriv4844; 
		public static void glGetBufferParameteriv(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetBufferParameteriv4844, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanef4845; 
		public static void glGetClipPlanef(int arg0, float[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetClipPlanef4845, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanef4846; 
		public static void glGetClipPlanef(int arg0, java.nio.FloatBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetClipPlanef4846, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanex4847; 
		public static void glGetClipPlanex(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetClipPlanex4847, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanex4848; 
		public static void glGetClipPlanex(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetClipPlanex4848, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetFixedv4849; 
		public static void glGetFixedv(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetFixedv4849, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetFixedv4850; 
		public static void glGetFixedv(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetFixedv4850, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetFloatv4851; 
		public static void glGetFloatv(int arg0, java.nio.FloatBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetFloatv4851, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetFloatv4852; 
		public static void glGetFloatv(int arg0, float[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetFloatv4852, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetLightfv4853; 
		public static void glGetLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetLightfv4853, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetLightfv4854; 
		public static void glGetLightfv(int arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetLightfv4854, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetLightxv4855; 
		public static void glGetLightxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetLightxv4855, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetLightxv4856; 
		public static void glGetLightxv(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetLightxv4856, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetMaterialfv4857; 
		public static void glGetMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetMaterialfv4857, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetMaterialfv4858; 
		public static void glGetMaterialfv(int arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetMaterialfv4858, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetMaterialxv4859; 
		public static void glGetMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetMaterialxv4859, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetMaterialxv4860; 
		public static void glGetMaterialxv(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetMaterialxv4860, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexEnvfv4861; 
		public static void glGetTexEnvfv(int arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetTexEnvfv4861, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexEnvfv4862; 
		public static void glGetTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetTexEnvfv4862, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexEnviv4863; 
		public static void glGetTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetTexEnviv4863, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexEnviv4864; 
		public static void glGetTexEnviv(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetTexEnviv4864, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexEnvxv4865; 
		public static void glGetTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetTexEnvxv4865, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexEnvxv4866; 
		public static void glGetTexEnvxv(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetTexEnvxv4866, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameterfv4867; 
		public static void glGetTexParameterfv(int arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetTexParameterfv4867, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameterfv4868; 
		public static void glGetTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetTexParameterfv4868, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameteriv4869; 
		public static void glGetTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetTexParameteriv4869, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameteriv4870; 
		public static void glGetTexParameteriv(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetTexParameteriv4870, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameterxv4871; 
		public static void glGetTexParameterxv(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetTexParameterxv4871, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameterxv4872; 
		public static void glGetTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glGetTexParameterxv4872, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glIsBuffer4873; 
		public static bool glIsBuffer(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11.staticClass, _glIsBuffer4873, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glIsEnabled4874; 
		public static bool glIsEnabled(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11.staticClass, _glIsEnabled4874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glIsTexture4875; 
		public static bool glIsTexture(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11.staticClass, _glIsTexture4875, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterf4876; 
		public static void glPointParameterf(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glPointParameterf4876, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterfv4877; 
		public static void glPointParameterfv(int arg0, float[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glPointParameterfv4877, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterfv4878; 
		public static void glPointParameterfv(int arg0, java.nio.FloatBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glPointParameterfv4878, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterx4879; 
		public static void glPointParameterx(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glPointParameterx4879, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterxv4880; 
		public static void glPointParameterxv(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glPointParameterxv4880, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterxv4881; 
		public static void glPointParameterxv(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glPointParameterxv4881, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointSizePointerOES4882; 
		public static void glPointSizePointerOES(int arg0, int arg1, java.nio.Buffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glPointSizePointerOES4882, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvi4883; 
		public static void glTexEnvi(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glTexEnvi4883, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnviv4884; 
		public static void glTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glTexEnviv4884, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnviv4885; 
		public static void glTexEnviv(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glTexEnviv4885, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterfv4886; 
		public static void glTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glTexParameterfv4886, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterfv4887; 
		public static void glTexParameterfv(int arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glTexParameterfv4887, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameteri4888; 
		public static void glTexParameteri(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glTexParameteri4888, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameteriv4889; 
		public static void glTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glTexParameteriv4889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameteriv4890; 
		public static void glTexParameteriv(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glTexParameteriv4890, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterxv4891; 
		public static void glTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glTexParameterxv4891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterxv4892; 
		public static void glTexParameterxv(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, _glTexParameterxv4892, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GLES114893; 
		public GLES11()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.opengl.GLES11.staticClass, _GLES114893, this); 
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
			global::android.opengl.GLES11._glColorPointer4824 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glColorPointer", "(IIII)V"); 
			global::android.opengl.GLES11._glDrawElements4825 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glDrawElements", "(IIII)V"); 
			global::android.opengl.GLES11._glNormalPointer4826 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glNormalPointer", "(III)V"); 
			global::android.opengl.GLES11._glTexCoordPointer4827 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexCoordPointer", "(IIII)V"); 
			global::android.opengl.GLES11._glVertexPointer4828 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glVertexPointer", "(IIII)V"); 
			global::android.opengl.GLES11._glBindBuffer4829 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glBindBuffer", "(II)V"); 
			global::android.opengl.GLES11._glBufferData4830 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glBufferData", "(IILjava/nio/Buffer;I)V"); 
			global::android.opengl.GLES11._glBufferSubData4831 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glBufferSubData", "(IIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES11._glClipPlanef4832 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glClipPlanef", "(I[FI)V"); 
			global::android.opengl.GLES11._glClipPlanef4833 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glClipPlanef", "(ILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES11._glClipPlanex4834 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glClipPlanex", "(I[II)V"); 
			global::android.opengl.GLES11._glClipPlanex4835 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glClipPlanex", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11._glColor4ub4836 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glColor4ub", "(BBBB)V"); 
			global::android.opengl.GLES11._glDeleteBuffers4837 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glDeleteBuffers", "(I[II)V"); 
			global::android.opengl.GLES11._glDeleteBuffers4838 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glDeleteBuffers", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11._glGenBuffers4839 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGenBuffers", "(I[II)V"); 
			global::android.opengl.GLES11._glGenBuffers4840 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGenBuffers", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11._glGetBooleanv4841 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetBooleanv", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11._glGetBooleanv4842 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetBooleanv", "(I[ZI)V"); 
			global::android.opengl.GLES11._glGetBufferParameteriv4843 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetBufferParameteriv", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11._glGetBufferParameteriv4844 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetBufferParameteriv", "(II[II)V"); 
			global::android.opengl.GLES11._glGetClipPlanef4845 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetClipPlanef", "(I[FI)V"); 
			global::android.opengl.GLES11._glGetClipPlanef4846 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetClipPlanef", "(ILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES11._glGetClipPlanex4847 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetClipPlanex", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11._glGetClipPlanex4848 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetClipPlanex", "(I[II)V"); 
			global::android.opengl.GLES11._glGetFixedv4849 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetFixedv", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11._glGetFixedv4850 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetFixedv", "(I[II)V"); 
			global::android.opengl.GLES11._glGetFloatv4851 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetFloatv", "(ILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES11._glGetFloatv4852 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetFloatv", "(I[FI)V"); 
			global::android.opengl.GLES11._glGetLightfv4853 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetLightfv", "(IILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES11._glGetLightfv4854 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetLightfv", "(II[FI)V"); 
			global::android.opengl.GLES11._glGetLightxv4855 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetLightxv", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11._glGetLightxv4856 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetLightxv", "(II[II)V"); 
			global::android.opengl.GLES11._glGetMaterialfv4857 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetMaterialfv", "(IILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES11._glGetMaterialfv4858 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetMaterialfv", "(II[FI)V"); 
			global::android.opengl.GLES11._glGetMaterialxv4859 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetMaterialxv", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11._glGetMaterialxv4860 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetMaterialxv", "(II[II)V"); 
			global::android.opengl.GLES11._glGetTexEnvfv4861 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexEnvfv", "(II[FI)V"); 
			global::android.opengl.GLES11._glGetTexEnvfv4862 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexEnvfv", "(IILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES11._glGetTexEnviv4863 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexEnviv", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11._glGetTexEnviv4864 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexEnviv", "(II[II)V"); 
			global::android.opengl.GLES11._glGetTexEnvxv4865 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexEnvxv", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11._glGetTexEnvxv4866 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexEnvxv", "(II[II)V"); 
			global::android.opengl.GLES11._glGetTexParameterfv4867 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexParameterfv", "(II[FI)V"); 
			global::android.opengl.GLES11._glGetTexParameterfv4868 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexParameterfv", "(IILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES11._glGetTexParameteriv4869 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexParameteriv", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11._glGetTexParameteriv4870 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexParameteriv", "(II[II)V"); 
			global::android.opengl.GLES11._glGetTexParameterxv4871 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexParameterxv", "(II[II)V"); 
			global::android.opengl.GLES11._glGetTexParameterxv4872 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glGetTexParameterxv", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11._glIsBuffer4873 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glIsBuffer", "(I)Z"); 
			global::android.opengl.GLES11._glIsEnabled4874 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glIsEnabled", "(I)Z"); 
			global::android.opengl.GLES11._glIsTexture4875 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glIsTexture", "(I)Z"); 
			global::android.opengl.GLES11._glPointParameterf4876 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glPointParameterf", "(IF)V"); 
			global::android.opengl.GLES11._glPointParameterfv4877 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glPointParameterfv", "(I[FI)V"); 
			global::android.opengl.GLES11._glPointParameterfv4878 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glPointParameterfv", "(ILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES11._glPointParameterx4879 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glPointParameterx", "(II)V"); 
			global::android.opengl.GLES11._glPointParameterxv4880 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glPointParameterxv", "(I[II)V"); 
			global::android.opengl.GLES11._glPointParameterxv4881 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glPointParameterxv", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11._glPointSizePointerOES4882 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glPointSizePointerOES", "(IILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES11._glTexEnvi4883 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexEnvi", "(III)V"); 
			global::android.opengl.GLES11._glTexEnviv4884 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexEnviv", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11._glTexEnviv4885 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexEnviv", "(II[II)V"); 
			global::android.opengl.GLES11._glTexParameterfv4886 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexParameterfv", "(IILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES11._glTexParameterfv4887 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexParameterfv", "(II[FI)V"); 
			global::android.opengl.GLES11._glTexParameteri4888 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexParameteri", "(III)V"); 
			global::android.opengl.GLES11._glTexParameteriv4889 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexParameteriv", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11._glTexParameteriv4890 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexParameteriv", "(II[II)V"); 
			global::android.opengl.GLES11._glTexParameterxv4891 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexParameterxv", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11._glTexParameterxv4892 = @__env.GetStaticMethodID(global::android.opengl.GLES11.staticClass, "glTexParameterxv", "(II[II)V"); 
			global::android.opengl.GLES11._GLES114893 = @__env.GetMethodID(global::android.opengl.GLES11.staticClass, "<init>", "()V"); 
		} 
	} 
} 
