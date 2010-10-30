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
		private static global::MonoJavaBridge.MethodId _m0;
		void android.content.EntityIterator.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.EntityIterator_.staticClass, "close", "()V", ref global::android.content.EntityIterator_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.content.EntityIterator.reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.EntityIterator_.staticClass, "reset", "()V", ref global::android.content.EntityIterator_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool java.util.Iterator.hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.EntityIterator_.staticClass, "hasNext", "()Z", ref global::android.content.EntityIterator_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.Object java.util.Iterator.next()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.EntityIterator_.staticClass, "next", "()Ljava/lang/Object;", ref global::android.content.EntityIterator_._m3) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void java.util.Iterator.remove()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.EntityIterator_.staticClass, "remove", "()V", ref global::android.content.EntityIterator_._m4);
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
