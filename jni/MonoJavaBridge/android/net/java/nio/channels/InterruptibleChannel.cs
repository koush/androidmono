namespace java.nio.channels 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface InterruptibleChannel : Channel
	{ 
		new void close(); 
	} 

	public partial class InterruptibleChannel_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __InterruptibleChannel.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __InterruptibleChannel : java.lang.Object, InterruptibleChannel
	{ 
		internal static global::java.lang.Class staticClass; 
		static __InterruptibleChannel() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.channels.__InterruptibleChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.nio.channels.__InterruptibleChannel(@__env); 
			} 
		} 
		internal __InterruptibleChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close12211; 
		 void java.nio.channels.InterruptibleChannel.close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.__InterruptibleChannel)) 
				@__env.CallVoidMethod(this, _close12211); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.channels.__InterruptibleChannel.staticClass, _close12211); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close12212; 
		 void java.nio.channels.Channel.close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.__InterruptibleChannel)) 
				@__env.CallVoidMethod(this, _close12212); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.channels.__InterruptibleChannel.staticClass, _close12212); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOpen12213; 
		 bool java.nio.channels.Channel.isOpen() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.__InterruptibleChannel)) 
				return @__env.CallBooleanMethod(this, _isOpen12213); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.channels.__InterruptibleChannel.staticClass, _isOpen12213); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close12214; 
		 void java.io.Closeable.close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.__InterruptibleChannel)) 
				@__env.CallVoidMethod(this, _close12214); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.channels.__InterruptibleChannel.staticClass, _close12214); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.__InterruptibleChannel.staticClass = @__class; 
			global::java.nio.channels.__InterruptibleChannel._close12211 = @__env.GetMethodID(global::java.nio.channels.__InterruptibleChannel.staticClass, "java.nio.channels.InterruptibleChannel.close", "()V"); 
			global::java.nio.channels.__InterruptibleChannel._close12212 = @__env.GetMethodID(global::java.nio.channels.__InterruptibleChannel.staticClass, "java.nio.channels.Channel.close", "()V"); 
			global::java.nio.channels.__InterruptibleChannel._isOpen12213 = @__env.GetMethodID(global::java.nio.channels.__InterruptibleChannel.staticClass, "java.nio.channels.Channel.isOpen", "()Z"); 
			global::java.nio.channels.__InterruptibleChannel._close12214 = @__env.GetMethodID(global::java.nio.channels.__InterruptibleChannel.staticClass, "java.io.Closeable.close", "()V"); 
		} 
	} 
} 
