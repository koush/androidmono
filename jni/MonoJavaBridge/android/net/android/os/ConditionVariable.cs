namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ConditionVariable : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ConditionVariable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.ConditionVariable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.ConditionVariable(@__env); 
			} 
		} 
		protected ConditionVariable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close5474; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.os.ConditionVariable._close5474); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.ConditionVariable.staticClass, global::android.os.ConditionVariable._close5474); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _open5475; 
		public virtual void open() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.os.ConditionVariable._open5475); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.ConditionVariable.staticClass, global::android.os.ConditionVariable._open5475); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _block5476; 
		public virtual void block() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.os.ConditionVariable._block5476); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.ConditionVariable.staticClass, global::android.os.ConditionVariable._block5476); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _block5477; 
		public virtual bool block(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.os.ConditionVariable._block5477, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.ConditionVariable.staticClass, global::android.os.ConditionVariable._block5477, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ConditionVariable5478; 
		public ConditionVariable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.ConditionVariable.staticClass, global::android.os.ConditionVariable._ConditionVariable5478, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ConditionVariable5479; 
		public ConditionVariable(bool arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.ConditionVariable.staticClass, global::android.os.ConditionVariable._ConditionVariable5479, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.ConditionVariable.staticClass = @__class; 
			global::android.os.ConditionVariable._close5474 = @__env.GetMethodID(global::android.os.ConditionVariable.staticClass, "close", "()V"); 
			global::android.os.ConditionVariable._open5475 = @__env.GetMethodID(global::android.os.ConditionVariable.staticClass, "open", "()V"); 
			global::android.os.ConditionVariable._block5476 = @__env.GetMethodID(global::android.os.ConditionVariable.staticClass, "block", "()V"); 
			global::android.os.ConditionVariable._block5477 = @__env.GetMethodID(global::android.os.ConditionVariable.staticClass, "block", "(J)Z"); 
			global::android.os.ConditionVariable._ConditionVariable5478 = @__env.GetMethodID(global::android.os.ConditionVariable.staticClass, "<init>", "()V"); 
			global::android.os.ConditionVariable._ConditionVariable5479 = @__env.GetMethodID(global::android.os.ConditionVariable.staticClass, "<init>", "(Z)V"); 
		} 
	} 
} 
