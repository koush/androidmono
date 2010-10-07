namespace android.opengl
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class GLES10Ext : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static GLES10Ext()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.opengl.GLES10Ext), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.opengl.GLES10Ext(@__env);
			}
		}
		protected GLES10Ext(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _glQueryMatrixxOES5411;
		public static int glQueryMatrixxOES(int[] arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLES10Ext.staticClass, global::android.opengl.GLES10Ext._glQueryMatrixxOES5411, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glQueryMatrixxOES5412;
		public static int glQueryMatrixxOES(java.nio.IntBuffer arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLES10Ext.staticClass, global::android.opengl.GLES10Ext._glQueryMatrixxOES5412, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GLES10Ext5413;
		public GLES10Ext()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.opengl.GLES10Ext.staticClass, global::android.opengl.GLES10Ext._GLES10Ext5413, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.opengl.GLES10Ext.staticClass = @__class;
			global::android.opengl.GLES10Ext._glQueryMatrixxOES5411 = @__env.GetStaticMethodID(global::android.opengl.GLES10Ext.staticClass, "glQueryMatrixxOES", "([II[II)I");
			global::android.opengl.GLES10Ext._glQueryMatrixxOES5412 = @__env.GetStaticMethodID(global::android.opengl.GLES10Ext.staticClass, "glQueryMatrixxOES", "(Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;)I");
			global::android.opengl.GLES10Ext._GLES10Ext5413 = @__env.GetMethodID(global::android.opengl.GLES10Ext.staticClass, "<init>", "()V");
		}
	}
}
