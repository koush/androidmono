namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ConditionVariable : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ConditionVariable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.ConditionVariable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _close5216; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.ConditionVariable)) 
				@__env.CallVoidMethod(this, _close5216); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.ConditionVariable.staticClass, _close5216); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _open5217; 
		public virtual void open() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.ConditionVariable)) 
				@__env.CallVoidMethod(this, _open5217); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.ConditionVariable.staticClass, _open5217); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _block5218; 
		public virtual void block() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.ConditionVariable)) 
				@__env.CallVoidMethod(this, _block5218); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.ConditionVariable.staticClass, _block5218); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _block5219; 
		public virtual bool block(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.ConditionVariable)) 
				return @__env.CallBooleanMethod(this, _block5219, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.ConditionVariable.staticClass, _block5219, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ConditionVariable5220; 
		public ConditionVariable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.ConditionVariable.staticClass, _ConditionVariable5220, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ConditionVariable5221; 
		public ConditionVariable(bool arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.ConditionVariable.staticClass, _ConditionVariable5221, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.ConditionVariable.staticClass = @__class; 
			global::android.os.ConditionVariable._close5216 = @__env.GetMethodID(global::android.os.ConditionVariable.staticClass, "close", "()V"); 
			global::android.os.ConditionVariable._open5217 = @__env.GetMethodID(global::android.os.ConditionVariable.staticClass, "open", "()V"); 
			global::android.os.ConditionVariable._block5218 = @__env.GetMethodID(global::android.os.ConditionVariable.staticClass, "block", "()V"); 
			global::android.os.ConditionVariable._block5219 = @__env.GetMethodID(global::android.os.ConditionVariable.staticClass, "block", "(J)Z"); 
			global::android.os.ConditionVariable._ConditionVariable5220 = @__env.GetMethodID(global::android.os.ConditionVariable.staticClass, "<init>", "()V"); 
			global::android.os.ConditionVariable._ConditionVariable5221 = @__env.GetMethodID(global::android.os.ConditionVariable.staticClass, "<init>", "(Z)V"); 
		} 
	} 
} 
