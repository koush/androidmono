namespace java.nio.channels.spi 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbstractInterruptibleChannel : java.lang.Object, Channel, InterruptibleChannel
	{ 
		internal static global::java.lang.Class staticClass; 
		static AbstractInterruptibleChannel() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.channels.spi.AbstractInterruptibleChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbstractInterruptibleChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close11434; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractInterruptibleChannel)) 
				@__env.CallVoidMethod(this, _close11434); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, _close11434); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOpen11435; 
		public virtual bool isOpen() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractInterruptibleChannel)) 
				return @__env.CallBooleanMethod(this, _isOpen11435); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, _isOpen11435); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _end11436; 
		protected virtual void end(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractInterruptibleChannel)) 
				@__env.CallVoidMethod(this, _end11436, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, _end11436, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implCloseChannel11437; 
		protected abstract void implCloseChannel(); 
		internal static global::net.sf.jni4net.jni.MethodId _begin11438; 
		protected virtual void begin() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractInterruptibleChannel)) 
				@__env.CallVoidMethod(this, _begin11438); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, _begin11438); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractInterruptibleChannel11439; 
		protected AbstractInterruptibleChannel()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, _AbstractInterruptibleChannel11439, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass = @__class; 
			global::java.nio.channels.spi.AbstractInterruptibleChannel._close11434 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "close", "()V"); 
			global::java.nio.channels.spi.AbstractInterruptibleChannel._isOpen11435 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "isOpen", "()Z"); 
			global::java.nio.channels.spi.AbstractInterruptibleChannel._end11436 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "end", "(Z)V"); 
			global::java.nio.channels.spi.AbstractInterruptibleChannel._implCloseChannel11437 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "implCloseChannel", "()V"); 
			global::java.nio.channels.spi.AbstractInterruptibleChannel._begin11438 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "begin", "()V"); 
			global::java.nio.channels.spi.AbstractInterruptibleChannel._AbstractInterruptibleChannel11439 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "<init>", "()V"); 
		} 
	} 
} 
