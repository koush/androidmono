namespace android.sax
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface EndElementListener 
	{
		void end();
	}

	public partial class EndElementListener_
	{
		public static global::java.lang.Class _class
		{
			get { return __EndElementListener.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __EndElementListener : java.lang.Object, EndElementListener
	{
		internal static global::java.lang.Class staticClass;
		static __EndElementListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.sax.__EndElementListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.sax.__EndElementListener(@__env);
			}
		}
		internal __EndElementListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _end6975;
		 void android.sax.EndElementListener.end() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.sax.__EndElementListener._end6975);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.sax.__EndElementListener.staticClass, global::android.sax.__EndElementListener._end6975);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.sax.__EndElementListener.staticClass = @__class;
			global::android.sax.__EndElementListener._end6975 = @__env.GetMethodID(global::android.sax.__EndElementListener.staticClass, "android.sax.EndElementListener.end", "()V");
		}
	}
}
