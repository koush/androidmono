namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Iterator_))]
	public interface Iterator  : global::MonoJavaBridge.IJavaObject 
	{
		bool hasNext();
		global::java.lang.Object next();
		void remove();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Iterator))]
	public sealed partial class Iterator_ : java.lang.Object, Iterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Iterator_()
		{
			InitJNI();
		}
		internal Iterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasNext20388;
		 bool java.util.Iterator.hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Iterator_._hasNext20388);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Iterator_.staticClass, global::java.util.Iterator_._hasNext20388);
		}
		internal static global::MonoJavaBridge.MethodId _next20389;
		 global::java.lang.Object java.util.Iterator.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Iterator_._next20389)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Iterator_.staticClass, global::java.util.Iterator_._next20389)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove20390;
		 void java.util.Iterator.remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Iterator_._remove20390);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Iterator_.staticClass, global::java.util.Iterator_._remove20390);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Iterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Iterator"));
			global::java.util.Iterator_._hasNext20388 = @__env.GetMethodIDNoThrow(global::java.util.Iterator_.staticClass, "hasNext", "()Z");
			global::java.util.Iterator_._next20389 = @__env.GetMethodIDNoThrow(global::java.util.Iterator_.staticClass, "next", "()Ljava/lang/Object;");
			global::java.util.Iterator_._remove20390 = @__env.GetMethodIDNoThrow(global::java.util.Iterator_.staticClass, "remove", "()V");
		}
	}
}
