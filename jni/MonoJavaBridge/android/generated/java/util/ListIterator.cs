namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.ListIterator_))]
	public interface ListIterator : Iterator
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
		internal static global::MonoJavaBridge.MethodId _add20486;
		 void java.util.ListIterator.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._add20486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._add20486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNext20487;
		 bool java.util.ListIterator.hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ListIterator_._hasNext20487);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._hasNext20487);
		}
		internal static global::MonoJavaBridge.MethodId _next20488;
		 global::java.lang.Object java.util.ListIterator.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListIterator_._next20488)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._next20488)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove20489;
		 void java.util.ListIterator.remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._remove20489);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._remove20489);
		}
		internal static global::MonoJavaBridge.MethodId _set20490;
		 void java.util.ListIterator.set(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._set20490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._set20490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _previousIndex20491;
		 int java.util.ListIterator.previousIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.ListIterator_._previousIndex20491);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._previousIndex20491);
		}
		internal static global::MonoJavaBridge.MethodId _hasPrevious20492;
		 bool java.util.ListIterator.hasPrevious() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ListIterator_._hasPrevious20492);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._hasPrevious20492);
		}
		internal static global::MonoJavaBridge.MethodId _previous20493;
		 global::java.lang.Object java.util.ListIterator.previous() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListIterator_._previous20493)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._previous20493)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _nextIndex20494;
		 int java.util.ListIterator.nextIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.ListIterator_._nextIndex20494);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._nextIndex20494);
		}
		internal static global::MonoJavaBridge.MethodId _hasNext20495;
		 bool java.util.Iterator.hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ListIterator_._hasNext20495);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._hasNext20495);
		}
		internal static global::MonoJavaBridge.MethodId _next20496;
		 global::java.lang.Object java.util.Iterator.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListIterator_._next20496)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._next20496)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove20497;
		 void java.util.Iterator.remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._remove20497);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._remove20497);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ListIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ListIterator"));
			global::java.util.ListIterator_._add20486 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "add", "(Ljava/lang/Object;)V");
			global::java.util.ListIterator_._hasNext20487 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "hasNext", "()Z");
			global::java.util.ListIterator_._next20488 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "next", "()Ljava/lang/Object;");
			global::java.util.ListIterator_._remove20489 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "remove", "()V");
			global::java.util.ListIterator_._set20490 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "set", "(Ljava/lang/Object;)V");
			global::java.util.ListIterator_._previousIndex20491 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "previousIndex", "()I");
			global::java.util.ListIterator_._hasPrevious20492 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "hasPrevious", "()Z");
			global::java.util.ListIterator_._previous20493 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "previous", "()Ljava/lang/Object;");
			global::java.util.ListIterator_._nextIndex20494 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "nextIndex", "()I");
			global::java.util.ListIterator_._hasNext20495 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "hasNext", "()Z");
			global::java.util.ListIterator_._next20496 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "next", "()Ljava/lang/Object;");
			global::java.util.ListIterator_._remove20497 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "remove", "()V");
		}
	}
}
