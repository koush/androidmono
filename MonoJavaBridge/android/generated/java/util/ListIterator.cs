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
		internal static global::MonoJavaBridge.MethodId _add26430;
		void java.util.ListIterator.add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._add26430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNext26431;
		bool java.util.ListIterator.hasNext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ListIterator_._hasNext26431);
		}
		internal static global::MonoJavaBridge.MethodId _next26432;
		global::java.lang.Object java.util.ListIterator.next()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListIterator_._next26432)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26433;
		void java.util.ListIterator.remove()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._remove26433);
		}
		internal static global::MonoJavaBridge.MethodId _set26434;
		void java.util.ListIterator.set(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._set26434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _previousIndex26435;
		int java.util.ListIterator.previousIndex()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.ListIterator_._previousIndex26435);
		}
		internal static global::MonoJavaBridge.MethodId _hasPrevious26436;
		bool java.util.ListIterator.hasPrevious()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ListIterator_._hasPrevious26436);
		}
		internal static global::MonoJavaBridge.MethodId _previous26437;
		global::java.lang.Object java.util.ListIterator.previous()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListIterator_._previous26437)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _nextIndex26438;
		int java.util.ListIterator.nextIndex()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.ListIterator_._nextIndex26438);
		}
		internal static global::MonoJavaBridge.MethodId _hasNext26439;
		bool java.util.Iterator.hasNext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ListIterator_._hasNext26439);
		}
		internal static global::MonoJavaBridge.MethodId _next26440;
		global::java.lang.Object java.util.Iterator.next()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListIterator_._next26440)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26441;
		void java.util.Iterator.remove()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._remove26441);
		}
		static ListIterator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ListIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ListIterator"));
			global::java.util.ListIterator_._add26430 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "add", "(Ljava/lang/Object;)V");
			global::java.util.ListIterator_._hasNext26431 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "hasNext", "()Z");
			global::java.util.ListIterator_._next26432 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "next", "()Ljava/lang/Object;");
			global::java.util.ListIterator_._remove26433 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "remove", "()V");
			global::java.util.ListIterator_._set26434 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "set", "(Ljava/lang/Object;)V");
			global::java.util.ListIterator_._previousIndex26435 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "previousIndex", "()I");
			global::java.util.ListIterator_._hasPrevious26436 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "hasPrevious", "()Z");
			global::java.util.ListIterator_._previous26437 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "previous", "()Ljava/lang/Object;");
			global::java.util.ListIterator_._nextIndex26438 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "nextIndex", "()I");
			global::java.util.ListIterator_._hasNext26439 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "hasNext", "()Z");
			global::java.util.ListIterator_._next26440 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "next", "()Ljava/lang/Object;");
			global::java.util.ListIterator_._remove26441 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "remove", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
