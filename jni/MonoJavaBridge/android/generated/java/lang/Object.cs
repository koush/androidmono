namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Object 
	{
		internal static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Object()
		{
			InitJNI();
		}
		protected Object(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize14735;
		protected virtual void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Object._finalize14735);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Object.staticClass, global::java.lang.Object._finalize14735);
		}
		internal static global::MonoJavaBridge.MethodId _wait14736;
		public virtual void wait() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Object._wait14736);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Object.staticClass, global::java.lang.Object._wait14736);
		}
		internal static global::MonoJavaBridge.MethodId _wait14737;
		public virtual void wait(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Object._wait14737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Object.staticClass, global::java.lang.Object._wait14737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _wait14738;
		public virtual void wait(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Object._wait14738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Object.staticClass, global::java.lang.Object._wait14738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals14739;
		public virtual bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Object._equals14739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Object.staticClass, global::java.lang.Object._equals14739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString14740;
		public virtual global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Object._toString14740)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Object.staticClass, global::java.lang.Object._toString14740)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode14741;
		public virtual int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Object._hashCode14741);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Object.staticClass, global::java.lang.Object._hashCode14741);
		}
		public new global::java.lang.Class Class
		{
			get
			{
				return getClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClass14742;
		public virtual global::java.lang.Class getClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Object._getClass14742)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Object.staticClass, global::java.lang.Object._getClass14742)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _clone14743;
		protected virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Object._clone14743)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Object.staticClass, global::java.lang.Object._clone14743)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _notify14744;
		public virtual void notify() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Object._notify14744);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Object.staticClass, global::java.lang.Object._notify14744);
		}
		internal static global::MonoJavaBridge.MethodId _notifyAll14745;
		public virtual void notifyAll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Object._notifyAll14745);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Object.staticClass, global::java.lang.Object._notifyAll14745);
		}
		internal static global::MonoJavaBridge.MethodId _Object14746;
		public Object()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Object.staticClass, global::java.lang.Object._Object14746);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Object.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Object"));
			global::java.lang.Object._finalize14735 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "finalize", "()V");
			global::java.lang.Object._wait14736 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "wait", "()V");
			global::java.lang.Object._wait14737 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "wait", "(J)V");
			global::java.lang.Object._wait14738 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "wait", "(JI)V");
			global::java.lang.Object._equals14739 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Object._toString14740 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Object._hashCode14741 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "hashCode", "()I");
			global::java.lang.Object._getClass14742 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "getClass", "()Ljava/lang/Class;");
			global::java.lang.Object._clone14743 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.lang.Object._notify14744 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "notify", "()V");
			global::java.lang.Object._notifyAll14745 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "notifyAll", "()V");
			global::java.lang.Object._Object14746 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "<init>", "()V");
		}
	}
}
