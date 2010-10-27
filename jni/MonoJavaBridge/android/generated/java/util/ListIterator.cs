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
		static ListIterator_()
		{
			InitJNI();
		}
		internal ListIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26429;
		void java.util.ListIterator.add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._add26429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._add26429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNext26430;
		bool java.util.ListIterator.hasNext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ListIterator_._hasNext26430);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._hasNext26430);
		}
		internal static global::MonoJavaBridge.MethodId _next26431;
		global::java.lang.Object java.util.ListIterator.next()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListIterator_._next26431)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._next26431)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26432;
		void java.util.ListIterator.remove()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._remove26432);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._remove26432);
		}
		internal static global::MonoJavaBridge.MethodId _set26433;
		void java.util.ListIterator.set(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._set26433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._set26433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _previousIndex26434;
		int java.util.ListIterator.previousIndex()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.ListIterator_._previousIndex26434);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._previousIndex26434);
		}
		internal static global::MonoJavaBridge.MethodId _hasPrevious26435;
		bool java.util.ListIterator.hasPrevious()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ListIterator_._hasPrevious26435);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._hasPrevious26435);
		}
		internal static global::MonoJavaBridge.MethodId _previous26436;
		global::java.lang.Object java.util.ListIterator.previous()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListIterator_._previous26436)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._previous26436)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _nextIndex26437;
		int java.util.ListIterator.nextIndex()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.ListIterator_._nextIndex26437);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._nextIndex26437);
		}
		internal static global::MonoJavaBridge.MethodId _hasNext26438;
		bool java.util.Iterator.hasNext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ListIterator_._hasNext26438);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._hasNext26438);
		}
		internal static global::MonoJavaBridge.MethodId _next26439;
		global::java.lang.Object java.util.Iterator.next()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListIterator_._next26439)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._next26439)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26440;
		void java.util.Iterator.remove()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._remove26440);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._remove26440);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ListIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ListIterator"));
			global::java.util.ListIterator_._add26429 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "add", "(Ljava/lang/Object;)V");
			global::java.util.ListIterator_._hasNext26430 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "hasNext", "()Z");
			global::java.util.ListIterator_._next26431 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "next", "()Ljava/lang/Object;");
			global::java.util.ListIterator_._remove26432 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "remove", "()V");
			global::java.util.ListIterator_._set26433 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "set", "(Ljava/lang/Object;)V");
			global::java.util.ListIterator_._previousIndex26434 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "previousIndex", "()I");
			global::java.util.ListIterator_._hasPrevious26435 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "hasPrevious", "()Z");
			global::java.util.ListIterator_._previous26436 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "previous", "()Ljava/lang/Object;");
			global::java.util.ListIterator_._nextIndex26437 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "nextIndex", "()I");
			global::java.util.ListIterator_._hasNext26438 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "hasNext", "()Z");
			global::java.util.ListIterator_._next26439 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "next", "()Ljava/lang/Object;");
			global::java.util.ListIterator_._remove26440 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "remove", "()V");
		}
	}
}
