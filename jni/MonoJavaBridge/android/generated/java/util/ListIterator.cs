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
		internal static global::MonoJavaBridge.MethodId _add26311;
		 void java.util.ListIterator.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._add26311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._add26311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNext26312;
		 bool java.util.ListIterator.hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ListIterator_._hasNext26312);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._hasNext26312);
		}
		internal static global::MonoJavaBridge.MethodId _next26313;
		 global::java.lang.Object java.util.ListIterator.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListIterator_._next26313)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._next26313)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26314;
		 void java.util.ListIterator.remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._remove26314);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._remove26314);
		}
		internal static global::MonoJavaBridge.MethodId _set26315;
		 void java.util.ListIterator.set(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._set26315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._set26315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _previousIndex26316;
		 int java.util.ListIterator.previousIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.ListIterator_._previousIndex26316);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._previousIndex26316);
		}
		internal static global::MonoJavaBridge.MethodId _hasPrevious26317;
		 bool java.util.ListIterator.hasPrevious() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ListIterator_._hasPrevious26317);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._hasPrevious26317);
		}
		internal static global::MonoJavaBridge.MethodId _previous26318;
		 global::java.lang.Object java.util.ListIterator.previous() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListIterator_._previous26318)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._previous26318)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _nextIndex26319;
		 int java.util.ListIterator.nextIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.ListIterator_._nextIndex26319);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._nextIndex26319);
		}
		internal static global::MonoJavaBridge.MethodId _hasNext26320;
		 bool java.util.Iterator.hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ListIterator_._hasNext26320);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._hasNext26320);
		}
		internal static global::MonoJavaBridge.MethodId _next26321;
		 global::java.lang.Object java.util.Iterator.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListIterator_._next26321)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._next26321)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26322;
		 void java.util.Iterator.remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ListIterator_._remove26322);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ListIterator_.staticClass, global::java.util.ListIterator_._remove26322);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ListIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ListIterator"));
			global::java.util.ListIterator_._add26311 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "add", "(Ljava/lang/Object;)V");
			global::java.util.ListIterator_._hasNext26312 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "hasNext", "()Z");
			global::java.util.ListIterator_._next26313 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "next", "()Ljava/lang/Object;");
			global::java.util.ListIterator_._remove26314 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "remove", "()V");
			global::java.util.ListIterator_._set26315 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "set", "(Ljava/lang/Object;)V");
			global::java.util.ListIterator_._previousIndex26316 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "previousIndex", "()I");
			global::java.util.ListIterator_._hasPrevious26317 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "hasPrevious", "()Z");
			global::java.util.ListIterator_._previous26318 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "previous", "()Ljava/lang/Object;");
			global::java.util.ListIterator_._nextIndex26319 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "nextIndex", "()I");
			global::java.util.ListIterator_._hasNext26320 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "hasNext", "()Z");
			global::java.util.ListIterator_._next26321 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "next", "()Ljava/lang/Object;");
			global::java.util.ListIterator_._remove26322 = @__env.GetMethodIDNoThrow(global::java.util.ListIterator_.staticClass, "remove", "()V");
		}
	}
}
