namespace android.opengl
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class GLException : java.lang.RuntimeException
	{
		internal static global::java.lang.Class staticClass;
		static GLException()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.opengl.GLException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.opengl.GLException(@__env);
			}
		}
		protected GLException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _GLException5264;
		public GLException(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.opengl.GLException.staticClass, global::android.opengl.GLException._GLException5264, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GLException5265;
		public GLException(int arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.opengl.GLException.staticClass, global::android.opengl.GLException._GLException5265, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.opengl.GLException.staticClass = @__class;
			global::android.opengl.GLException._GLException5264 = @__env.GetMethodID(global::android.opengl.GLException.staticClass, "<init>", "(I)V");
			global::android.opengl.GLException._GLException5265 = @__env.GetMethodID(global::android.opengl.GLException.staticClass, "<init>", "(ILjava/lang/String;)V");
		}
	}
}
