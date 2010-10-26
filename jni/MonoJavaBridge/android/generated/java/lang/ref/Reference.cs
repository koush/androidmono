namespace java.lang.@ref
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.@ref.Reference_))]
	public abstract partial class Reference : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Reference()
		{
			InitJNI();
		}
		protected Reference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get20985;
		public virtual global::java.lang.Object get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.@ref.Reference._get20985)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.@ref.Reference.staticClass, global::java.lang.@ref.Reference._get20985)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear20986;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.@ref.Reference._clear20986);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.@ref.Reference.staticClass, global::java.lang.@ref.Reference._clear20986);
		}
		internal static global::MonoJavaBridge.MethodId _isEnqueued20987;
		public virtual bool isEnqueued() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.@ref.Reference._isEnqueued20987);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.@ref.Reference.staticClass, global::java.lang.@ref.Reference._isEnqueued20987);
		}
		internal static global::MonoJavaBridge.MethodId _enqueue20988;
		public virtual bool enqueue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.@ref.Reference._enqueue20988);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.@ref.Reference.staticClass, global::java.lang.@ref.Reference._enqueue20988);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.@ref.Reference.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ref/Reference"));
			global::java.lang.@ref.Reference._get20985 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.Reference.staticClass, "get", "()Ljava/lang/Object;");
			global::java.lang.@ref.Reference._clear20986 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.Reference.staticClass, "clear", "()V");
			global::java.lang.@ref.Reference._isEnqueued20987 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.Reference.staticClass, "isEnqueued", "()Z");
			global::java.lang.@ref.Reference._enqueue20988 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.Reference.staticClass, "enqueue", "()Z");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.@ref.Reference))]
	internal sealed partial class Reference_ : java.lang.@ref.Reference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Reference_()
		{
			InitJNI();
		}
		internal Reference_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.@ref.Reference_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ref/Reference"));
		}
	}
}
