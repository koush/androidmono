namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.ListIterator_))]
	public partial interface ListIterator : Iterator
	{
		void add(java.lang.Object arg0);
		bool hasNext();
		global::java.lang.Object next();
		void remove();
		void set(java.lang.Object arg0);
		int previousIndex();
		bool hasPrevious();
		global::java.lang.Object previous();
		int nextIndex();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.ListIterator))]
	internal sealed partial class ListIterator_ : java.lang.Object, ListIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ListIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void java.util.ListIterator.add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.ListIterator_.staticClass, "add", "(Ljava/lang/Object;)V", ref global::java.util.ListIterator_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool java.util.ListIterator.hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.ListIterator_.staticClass, "hasNext", "()Z", ref global::java.util.ListIterator_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.Object java.util.ListIterator.next()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ListIterator_.staticClass, "next", "()Ljava/lang/Object;", ref global::java.util.ListIterator_._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void java.util.ListIterator.remove()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.ListIterator_.staticClass, "remove", "()V", ref global::java.util.ListIterator_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void java.util.ListIterator.set(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.ListIterator_.staticClass, "set", "(Ljava/lang/Object;)V", ref global::java.util.ListIterator_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		int java.util.ListIterator.previousIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.ListIterator_.staticClass, "previousIndex", "()I", ref global::java.util.ListIterator_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		bool java.util.ListIterator.hasPrevious()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.ListIterator_.staticClass, "hasPrevious", "()Z", ref global::java.util.ListIterator_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.lang.Object java.util.ListIterator.previous()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ListIterator_.staticClass, "previous", "()Ljava/lang/Object;", ref global::java.util.ListIterator_._m7) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		int java.util.ListIterator.nextIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.ListIterator_.staticClass, "nextIndex", "()I", ref global::java.util.ListIterator_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		bool java.util.Iterator.hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.ListIterator_.staticClass, "hasNext", "()Z", ref global::java.util.ListIterator_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.lang.Object java.util.Iterator.next()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ListIterator_.staticClass, "next", "()Ljava/lang/Object;", ref global::java.util.ListIterator_._m10) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void java.util.Iterator.remove()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.ListIterator_.staticClass, "remove", "()V", ref global::java.util.ListIterator_._m11);
		}
		static ListIterator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ListIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ListIterator"));
		}
	}
}
