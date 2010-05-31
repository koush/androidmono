namespace java.nio.channels.spi 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbstractInterruptibleChannel : java.lang.Object, Channel, InterruptibleChannel
	{ 
		internal static global::java.lang.Class staticClass; 
		static AbstractInterruptibleChannel() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.spi.AbstractInterruptibleChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbstractInterruptibleChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close12298; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.nio.channels.spi.AbstractInterruptibleChannel._close12298); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, global::java.nio.channels.spi.AbstractInterruptibleChannel._close12298); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOpen12299; 
		public virtual bool isOpen() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.nio.channels.spi.AbstractInterruptibleChannel._isOpen12299); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, global::java.nio.channels.spi.AbstractInterruptibleChannel._isOpen12299); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _end12300; 
		protected virtual void end(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.nio.channels.spi.AbstractInterruptibleChannel._end12300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, global::java.nio.channels.spi.AbstractInterruptibleChannel._end12300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implCloseChannel12301; 
		protected abstract void implCloseChannel(); 
		internal static global::net.sf.jni4net.jni.MethodId _begin12302; 
		protected virtual void begin() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.nio.channels.spi.AbstractInterruptibleChannel._begin12302); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, global::java.nio.channels.spi.AbstractInterruptibleChannel._begin12302); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractInterruptibleChannel12303; 
		protected AbstractInterruptibleChannel()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, global::java.nio.channels.spi.AbstractInterruptibleChannel._AbstractInterruptibleChannel12303, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass = @__class; 
			global::java.nio.channels.spi.AbstractInterruptibleChannel._close12298 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "close", "()V"); 
			global::java.nio.channels.spi.AbstractInterruptibleChannel._isOpen12299 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "isOpen", "()Z"); 
			global::java.nio.channels.spi.AbstractInterruptibleChannel._end12300 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "end", "(Z)V"); 
			global::java.nio.channels.spi.AbstractInterruptibleChannel._implCloseChannel12301 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "implCloseChannel", "()V"); 
			global::java.nio.channels.spi.AbstractInterruptibleChannel._begin12302 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "begin", "()V"); 
			global::java.nio.channels.spi.AbstractInterruptibleChannel._AbstractInterruptibleChannel12303 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractInterruptibleChannel.staticClass, "<init>", "()V"); 
		} 
	} 
} 
