namespace java.nio.channels.spi 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbstractSelectionKey : java.nio.channels.SelectionKey
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AbstractSelectionKey() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.spi.AbstractSelectionKey), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbstractSelectionKey(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isValid12315; 
		public sealed override bool isValid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.nio.channels.spi.AbstractSelectionKey._isValid12315); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.channels.spi.AbstractSelectionKey.staticClass, global::java.nio.channels.spi.AbstractSelectionKey._isValid12315); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel12316; 
		public sealed override void cancel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.nio.channels.spi.AbstractSelectionKey._cancel12316); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.spi.AbstractSelectionKey.staticClass, global::java.nio.channels.spi.AbstractSelectionKey._cancel12316); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractSelectionKey12317; 
		protected AbstractSelectionKey()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.channels.spi.AbstractSelectionKey.staticClass, global::java.nio.channels.spi.AbstractSelectionKey._AbstractSelectionKey12317, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.spi.AbstractSelectionKey.staticClass = @__class; 
			global::java.nio.channels.spi.AbstractSelectionKey._isValid12315 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectionKey.staticClass, "isValid", "()Z"); 
			global::java.nio.channels.spi.AbstractSelectionKey._cancel12316 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectionKey.staticClass, "cancel", "()V"); 
			global::java.nio.channels.spi.AbstractSelectionKey._AbstractSelectionKey12317 = @__env.GetMethodID(global::java.nio.channels.spi.AbstractSelectionKey.staticClass, "<init>", "()V"); 
		} 
	} 
} 
