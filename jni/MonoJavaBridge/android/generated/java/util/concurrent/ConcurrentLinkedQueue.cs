namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConcurrentLinkedQueue : java.util.AbstractQueue, Queue, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConcurrentLinkedQueue()
		{
			InitJNI();
		}
		protected ConcurrentLinkedQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add27133;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._add27133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._add27133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty27134;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._isEmpty27134);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._isEmpty27134);
		}
		internal static global::MonoJavaBridge.MethodId _contains27135;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._contains27135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._contains27135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size27136;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._size27136);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._size27136);
		}
		internal static global::MonoJavaBridge.MethodId _toArray27137;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._toArray27137)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._toArray27137)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray27138;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._toArray27138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._toArray27138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator27139;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._iterator27139)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._iterator27139)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove27140;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._remove27140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._remove27140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll27141;
		public override global::java.lang.Object poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._poll27141)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._poll27141)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek27142;
		public override global::java.lang.Object peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._peek27142)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._peek27142)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer27143;
		public override bool offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._offer27143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._offer27143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ConcurrentLinkedQueue27144;
		public ConcurrentLinkedQueue()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._ConcurrentLinkedQueue27144);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConcurrentLinkedQueue27145;
		public ConcurrentLinkedQueue(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._ConcurrentLinkedQueue27145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ConcurrentLinkedQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ConcurrentLinkedQueue"));
			global::java.util.concurrent.ConcurrentLinkedQueue._add27133 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentLinkedQueue._isEmpty27134 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "isEmpty", "()Z");
			global::java.util.concurrent.ConcurrentLinkedQueue._contains27135 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentLinkedQueue._size27136 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "size", "()I");
			global::java.util.concurrent.ConcurrentLinkedQueue._toArray27137 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentLinkedQueue._toArray27138 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentLinkedQueue._iterator27139 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.ConcurrentLinkedQueue._remove27140 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentLinkedQueue._poll27141 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentLinkedQueue._peek27142 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentLinkedQueue._offer27143 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentLinkedQueue._ConcurrentLinkedQueue27144 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "<init>", "()V");
			global::java.util.concurrent.ConcurrentLinkedQueue._ConcurrentLinkedQueue27145 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "<init>", "(Ljava/util/Collection;)V");
		}
	}
}
