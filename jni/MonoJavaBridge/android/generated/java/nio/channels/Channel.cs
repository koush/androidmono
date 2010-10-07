namespace java.nio.channels
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface Channel : java.io.Closeable
	{
		new void close();
		bool isOpen();
	}

	public partial class Channel_
	{
		public static global::java.lang.Class _class
		{
			get { return __Channel.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __Channel : java.lang.Object, Channel
	{
		internal static global::java.lang.Class staticClass;
		static __Channel()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.__Channel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.nio.channels.__Channel(@__env);
			}
		}
		internal __Channel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _close12882;
		 void java.nio.channels.Channel.close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.channels.__Channel._close12882);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.__Channel.staticClass, global::java.nio.channels.__Channel._close12882);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOpen12883;
		 bool java.nio.channels.Channel.isOpen() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.channels.__Channel._isOpen12883);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.channels.__Channel.staticClass, global::java.nio.channels.__Channel._isOpen12883);
		}
		internal static global::net.sf.jni4net.jni.MethodId _close12884;
		 void java.io.Closeable.close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.channels.__Channel._close12884);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.__Channel.staticClass, global::java.nio.channels.__Channel._close12884);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.channels.__Channel.staticClass = @__class;
			global::java.nio.channels.__Channel._close12882 = @__env.GetMethodID(global::java.nio.channels.__Channel.staticClass, "java.nio.channels.Channel.close", "()V");
			global::java.nio.channels.__Channel._isOpen12883 = @__env.GetMethodID(global::java.nio.channels.__Channel.staticClass, "java.nio.channels.Channel.isOpen", "()Z");
			global::java.nio.channels.__Channel._close12884 = @__env.GetMethodID(global::java.nio.channels.__Channel.staticClass, "java.io.Closeable.close", "()V");
		}
	}
}
