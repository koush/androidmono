namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicMarkableReference : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AtomicMarkableReference()
		{
			InitJNI();
		}
		protected AtomicMarkableReference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27639;
		public virtual global::java.lang.Object get(bool[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicMarkableReference._get27639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, global::java.util.concurrent.atomic.AtomicMarkableReference._get27639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set27640;
		public virtual void set(java.lang.Object arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicMarkableReference._set27640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, global::java.util.concurrent.atomic.AtomicMarkableReference._set27640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27641;
		public virtual bool compareAndSet(java.lang.Object arg0, java.lang.Object arg1, bool arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicMarkableReference._compareAndSet27641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, global::java.util.concurrent.atomic.AtomicMarkableReference._compareAndSet27641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27642;
		public virtual bool weakCompareAndSet(java.lang.Object arg0, java.lang.Object arg1, bool arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicMarkableReference._weakCompareAndSet27642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, global::java.util.concurrent.atomic.AtomicMarkableReference._weakCompareAndSet27642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::java.lang.Object Reference
		{
			get
			{
				return getReference();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReference27643;
		public virtual global::java.lang.Object getReference() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicMarkableReference._getReference27643)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, global::java.util.concurrent.atomic.AtomicMarkableReference._getReference27643)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isMarked27644;
		public virtual bool isMarked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicMarkableReference._isMarked27644);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, global::java.util.concurrent.atomic.AtomicMarkableReference._isMarked27644);
		}
		internal static global::MonoJavaBridge.MethodId _attemptMark27645;
		public virtual bool attemptMark(java.lang.Object arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicMarkableReference._attemptMark27645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, global::java.util.concurrent.atomic.AtomicMarkableReference._attemptMark27645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicMarkableReference27646;
		public AtomicMarkableReference(java.lang.Object arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicMarkableReference.staticClass, global::java.util.concurrent.atomic.AtomicMarkableReference._AtomicMarkableReference27646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicMarkableReference"));
			global::java.util.concurrent.atomic.AtomicMarkableReference._get27639 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, "get", "([Z)Ljava/lang/Object;");
			global::java.util.concurrent.atomic.AtomicMarkableReference._set27640 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, "set", "(Ljava/lang/Object;Z)V");
			global::java.util.concurrent.atomic.AtomicMarkableReference._compareAndSet27641 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, "compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;ZZ)Z");
			global::java.util.concurrent.atomic.AtomicMarkableReference._weakCompareAndSet27642 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;ZZ)Z");
			global::java.util.concurrent.atomic.AtomicMarkableReference._getReference27643 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, "getReference", "()Ljava/lang/Object;");
			global::java.util.concurrent.atomic.AtomicMarkableReference._isMarked27644 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, "isMarked", "()Z");
			global::java.util.concurrent.atomic.AtomicMarkableReference._attemptMark27645 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, "attemptMark", "(Ljava/lang/Object;Z)Z");
			global::java.util.concurrent.atomic.AtomicMarkableReference._AtomicMarkableReference27646 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, "<init>", "(Ljava/lang/Object;Z)V");
		}
	}
}
