namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.EntityIterator_))]
	public partial interface EntityIterator : java.util.Iterator
	{
		void close();
		void reset();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.EntityIterator))]
	internal sealed partial class EntityIterator_ : java.lang.Object, EntityIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EntityIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close3095;
		void android.content.EntityIterator.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.EntityIterator_.staticClass, "close", "()V", ref global::android.content.EntityIterator_._close3095);
		}
		internal static global::MonoJavaBridge.MethodId _reset3096;
		void android.content.EntityIterator.reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.EntityIterator_.staticClass, "reset", "()V", ref global::android.content.EntityIterator_._reset3096);
		}
		internal static global::MonoJavaBridge.MethodId _hasNext3097;
		bool java.util.Iterator.hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.EntityIterator_.staticClass, "hasNext", "()Z", ref global::android.content.EntityIterator_._hasNext3097);
		}
		internal static global::MonoJavaBridge.MethodId _next3098;
		global::java.lang.Object java.util.Iterator.next()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.EntityIterator_.staticClass, "next", "()Ljava/lang/Object;", ref global::android.content.EntityIterator_._next3098) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove3099;
		void java.util.Iterator.remove()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.EntityIterator_.staticClass, "remove", "()V", ref global::android.content.EntityIterator_._remove3099);
		}
		static EntityIterator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.EntityIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/EntityIterator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
