namespace java.util
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface EventListener 
	{
	}

	public partial class EventListener_
	{
		public static global::java.lang.Class _class
		{
			get { return __EventListener.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __EventListener : java.lang.Object, EventListener
	{
		internal static global::java.lang.Class staticClass;
		static __EventListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.__EventListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.util.__EventListener(@__env);
			}
		}
		internal __EventListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.__EventListener.staticClass = @__class;
		}
	}
}
