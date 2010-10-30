namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConcurrentLinkedQueue : java.util.AbstractQueue, Queue, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConcurrentLinkedQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add27134;
		public override bool add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentLinkedQueue._add27134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty27135;
		public override bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "isEmpty", "()Z", ref global::java.util.concurrent.ConcurrentLinkedQueue._isEmpty27135);
		}
		internal static global::MonoJavaBridge.MethodId _contains27136;
		public override bool contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentLinkedQueue._contains27136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size27137;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "size", "()I", ref global::java.util.concurrent.ConcurrentLinkedQueue._size27137);
		}
		internal static global::MonoJavaBridge.MethodId _toArray27138;
		public override global::java.lang.Object[] toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentLinkedQueue._toArray27138) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray27139;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentLinkedQueue._toArray27139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator27140;
		public override global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.concurrent.ConcurrentLinkedQueue._iterator27140) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove27141;
		public override bool remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentLinkedQueue._remove27141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll27142;
		public override global::java.lang.Object poll()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "poll", "()Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentLinkedQueue._poll27142) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek27143;
		public override global::java.lang.Object peek()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "peek", "()Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentLinkedQueue._peek27143) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer27144;
		public override bool offer(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "offer", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentLinkedQueue._offer27144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ConcurrentLinkedQueue27145;
		public ConcurrentLinkedQueue() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ConcurrentLinkedQueue._ConcurrentLinkedQueue27145.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ConcurrentLinkedQueue._ConcurrentLinkedQueue27145 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._ConcurrentLinkedQueue27145);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConcurrentLinkedQueue27146;
		public ConcurrentLinkedQueue(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ConcurrentLinkedQueue._ConcurrentLinkedQueue27146.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ConcurrentLinkedQueue._ConcurrentLinkedQueue27146 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._ConcurrentLinkedQueue27146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ConcurrentLinkedQueue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ConcurrentLinkedQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ConcurrentLinkedQueue"));
		}
		internal static void InitJNI()
		{
		}
	}
}
