namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.EntityIterator_))]
	public interface EntityIterator : java.util.Iterator
	{
		void close();
		void reset();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.EntityIterator))]
	public sealed partial class EntityIterator_ : java.lang.Object, EntityIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EntityIterator_()
		{
			InitJNI();
		}
		internal EntityIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close1525;
		 void android.content.EntityIterator.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.EntityIterator_._close1525);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.EntityIterator_.staticClass, global::android.content.EntityIterator_._close1525);
		}
		internal static global::MonoJavaBridge.MethodId _reset1526;
		 void android.content.EntityIterator.reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.EntityIterator_._reset1526);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.EntityIterator_.staticClass, global::android.content.EntityIterator_._reset1526);
		}
		internal static global::MonoJavaBridge.MethodId _hasNext1527;
		 bool java.util.Iterator.hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.EntityIterator_._hasNext1527);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.EntityIterator_.staticClass, global::android.content.EntityIterator_._hasNext1527);
		}
		internal static global::MonoJavaBridge.MethodId _next1528;
		 global::java.lang.Object java.util.Iterator.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.EntityIterator_._next1528)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.EntityIterator_.staticClass, global::android.content.EntityIterator_._next1528)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove1529;
		 void java.util.Iterator.remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.EntityIterator_._remove1529);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.EntityIterator_.staticClass, global::android.content.EntityIterator_._remove1529);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.EntityIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/EntityIterator"));
			global::android.content.EntityIterator_._close1525 = @__env.GetMethodIDNoThrow(global::android.content.EntityIterator_.staticClass, "close", "()V");
			global::android.content.EntityIterator_._reset1526 = @__env.GetMethodIDNoThrow(global::android.content.EntityIterator_.staticClass, "reset", "()V");
			global::android.content.EntityIterator_._hasNext1527 = @__env.GetMethodIDNoThrow(global::android.content.EntityIterator_.staticClass, "hasNext", "()Z");
			global::android.content.EntityIterator_._next1528 = @__env.GetMethodIDNoThrow(global::android.content.EntityIterator_.staticClass, "next", "()Ljava/lang/Object;");
			global::android.content.EntityIterator_._remove1529 = @__env.GetMethodIDNoThrow(global::android.content.EntityIterator_.staticClass, "remove", "()V");
		}
	}
}
