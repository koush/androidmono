namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Iterator_))]
	public partial interface Iterator  : global::MonoJavaBridge.IJavaObject 
	{
		bool hasNext();
		global::java.lang.Object next();
		void remove();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Iterator))]
	internal sealed partial class Iterator_ : java.lang.Object, Iterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Iterator_()
		{
			InitJNI();
		}
		internal Iterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasNext26331;
		 bool java.util.Iterator.hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Iterator_._hasNext26331);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Iterator_.staticClass, global::java.util.Iterator_._hasNext26331);
		}
		internal static global::MonoJavaBridge.MethodId _next26332;
		 global::java.lang.Object java.util.Iterator.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Iterator_._next26332)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Iterator_.staticClass, global::java.util.Iterator_._next26332)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26333;
		 void java.util.Iterator.remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Iterator_._remove26333);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Iterator_.staticClass, global::java.util.Iterator_._remove26333);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Iterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Iterator"));
			global::java.util.Iterator_._hasNext26331 = @__env.GetMethodIDNoThrow(global::java.util.Iterator_.staticClass, "hasNext", "()Z");
			global::java.util.Iterator_._next26332 = @__env.GetMethodIDNoThrow(global::java.util.Iterator_.staticClass, "next", "()Ljava/lang/Object;");
			global::java.util.Iterator_._remove26333 = @__env.GetMethodIDNoThrow(global::java.util.Iterator_.staticClass, "remove", "()V");
		}
	}
}
