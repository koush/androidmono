namespace javax.microedition.khronos.opengles
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface GL 
	{
	}

	public partial class GL_
	{
		public static global::java.lang.Class _class
		{
			get { return __GL.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __GL : java.lang.Object, GL
	{
		internal static global::java.lang.Class staticClass;
		static __GL()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::javax.microedition.khronos.opengles.__GL), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::javax.microedition.khronos.opengles.__GL(@__env);
			}
		}
		internal __GL(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::javax.microedition.khronos.opengles.__GL.staticClass = @__class;
		}
	}
}
