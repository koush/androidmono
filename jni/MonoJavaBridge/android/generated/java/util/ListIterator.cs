namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.ListIterator_))]
	public interface ListIterator : Iterator
	{
		void add(java.lang.Object arg0);
		new bool hasNext();
		new global::java.lang.Object next();
		new void remove();
		void set(java.lang.Object arg0);
		int previousIndex();
		bool hasPrevious();
		global::java.lang.Object previous();
		int nextIndex();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.ListIterator))]
	public sealed partial class ListIterator_ : java.lang.Object, ListIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ListIterator_()
		{
			InitJNI();
		}
		internal ListIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add15519;
		 void java.util.ListIterator.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._add15519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._add15519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNext15520;
		 bool java.util.ListIterator.hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ListIterator_._hasNext15520);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._hasNext15520);
		}
		internal static global::MonoJavaBridge.MethodId _next15521;
		 global::java.lang.Object java.util.ListIterator.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListIterator_._next15521)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._next15521)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove15522;
		 void java.util.ListIterator.remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._remove15522);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._remove15522);
		}
		internal static global::MonoJavaBridge.MethodId _set15523;
		 void java.util.ListIterator.set(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._set15523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._set15523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _previousIndex15524;
		 int java.util.ListIterator.previousIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.ListIterator_._previousIndex15524);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._previousIndex15524);
		}
		internal static global::MonoJavaBridge.MethodId _hasPrevious15525;
		 bool java.util.ListIterator.hasPrevious() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ListIterator_._hasPrevious15525);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._hasPrevious15525);
		}
		internal static global::MonoJavaBridge.MethodId _previous15526;
		 global::java.lang.Object java.util.ListIterator.previous() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListIterator_._previous15526)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._previous15526)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _nextIndex15527;
		 int java.util.ListIterator.nextIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.ListIterator_._nextIndex15527);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._nextIndex15527);
		}
		internal static global::MonoJavaBridge.MethodId _hasNext15528;
		 bool java.util.Iterator.hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ListIterator_._hasNext15528);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._hasNext15528);
		}
		internal static global::MonoJavaBridge.MethodId _next15529;
		 global::java.lang.Object java.util.Iterator.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListIterator_._next15529)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._next15529)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove15530;
		 void java.util.Iterator.remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._remove15530);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._remove15530);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ListIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ListIterator"));
			global::java.util.ListIterator_._add15519 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "add", "(Ljava/lang/Object;)V");
			global::java.util.ListIterator_._hasNext15520 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "hasNext", "()Z");
			global::java.util.ListIterator_._next15521 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "next", "()Ljava/lang/Object;");
			global::java.util.ListIterator_._remove15522 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "remove", "()V");
			global::java.util.ListIterator_._set15523 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "set", "(Ljava/lang/Object;)V");
			global::java.util.ListIterator_._previousIndex15524 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "previousIndex", "()I");
			global::java.util.ListIterator_._hasPrevious15525 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "hasPrevious", "()Z");
			global::java.util.ListIterator_._previous15526 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "previous", "()Ljava/lang/Object;");
			global::java.util.ListIterator_._nextIndex15527 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "nextIndex", "()I");
			global::java.util.ListIterator_._hasNext15528 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "hasNext", "()Z");
			global::java.util.ListIterator_._next15529 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "next", "()Ljava/lang/Object;");
			global::java.util.ListIterator_._remove15530 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "remove", "()V");
		}
	}
}
