namespace java.nio.channels.spi 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbstractSelectionKey : java.nio.channels.SelectionKey
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AbstractSelectionKey() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.channels.spi.AbstractSelectionKey), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbstractSelectionKey(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isValid11451; 
		public sealed override bool isValid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelectionKey)) 
				return @__env.CallBooleanMethod(this, _isValid11451); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.channels.spi.AbstractSelectionKey.staticClass, _isValid11451); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel11452; 
		public sealed override void cancel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.spi.AbstractSelectionKey)) 
				@__env.CallVoidMethod(this, _cancel11452); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.channels.spi.AbstractSelectionKey.staticClass, _cancel11452); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractSelectionKey11453; 
		protected AbstractSelectionKey()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.channels.spi.AbstractSelectionKey.staticClass, _AbstractSelectionKey11453, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.spi.AbstractSelectionKey.staticClass = @__class; 
			global::java.nio.channels.spi.AbstractSelectionKey._isValid11451 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectionKey.staticClass, "isValid", "()Z"); 
			global::java.nio.channels.spi.AbstractSelectionKey._cancel11452 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectionKey.staticClass, "cancel", "()V"); 
			global::java.nio.channels.spi.AbstractSelectionKey._AbstractSelectionKey11453 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectionKey.staticClass, "<init>", "()V"); 
		} 
	} 
} 
