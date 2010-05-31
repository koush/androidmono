namespace javax.microedition.khronos.egl
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface EGL 
	{
	}

	public partial class EGL_
	{
		public static global::java.lang.Class _class
		{
			get { return __EGL.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __EGL : java.lang.Object, EGL
	{
		internal static global::java.lang.Class staticClass;
		static __EGL()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::javax.microedition.khronos.egl.__EGL), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::javax.microedition.khronos.egl.__EGL(@__env);
			}
		}
		internal __EGL(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::javax.microedition.khronos.egl.__EGL.staticClass = @__class;
		}
	}
}
