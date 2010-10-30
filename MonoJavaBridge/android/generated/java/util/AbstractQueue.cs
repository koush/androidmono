namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.AbstractQueue_))]
	public abstract partial class AbstractQueue : java.util.AbstractCollection, Queue
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _poll25718;
		public abstract global::java.lang.Object poll();
		internal static global::MonoJavaBridge.MethodId _peek25719;
		public abstract global::java.lang.Object peek();
		internal static global::MonoJavaBridge.MethodId _offer25720;
		public abstract bool offer(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _add25721;
		public override bool add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractQueue.staticClass, global::java.util.AbstractQueue._add25721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear25722;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.AbstractQueue.staticClass, global::java.util.AbstractQueue._clear25722);
		}
		internal static global::MonoJavaBridge.MethodId _addAll25723;
		public override bool addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractQueue.staticClass, global::java.util.AbstractQueue._addAll25723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove25724;
		public virtual global::java.lang.Object remove()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractQueue.staticClass, global::java.util.AbstractQueue._remove25724)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _element25725;
		public virtual global::java.lang.Object element()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractQueue.staticClass, global::java.util.AbstractQueue._element25725)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractQueue25726;
		protected AbstractQueue() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractQueue.staticClass, global::java.util.AbstractQueue._AbstractQueue25726);
			Init(@__env, handle);
		}
		static AbstractQueue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractQueue"));
			global::java.util.AbstractQueue._poll25718 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.AbstractQueue._peek25719 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.AbstractQueue._offer25720 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractQueue._add25721 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractQueue._clear25722 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue.staticClass, "clear", "()V");
			global::java.util.AbstractQueue._addAll25723 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractQueue._remove25724 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue.staticClass, "remove", "()Ljava/lang/Object;");
			global::java.util.AbstractQueue._element25725 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue.staticClass, "element", "()Ljava/lang/Object;");
			global::java.util.AbstractQueue._AbstractQueue25726 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.AbstractQueue))]
	internal sealed partial class AbstractQueue_ : java.util.AbstractQueue
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractQueue_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _poll25727;
		public override global::java.lang.Object poll()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractQueue_._poll25727)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek25728;
		public override global::java.lang.Object peek()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractQueue_._peek25728)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer25729;
		public override bool offer(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractQueue_._offer25729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size25730;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractQueue_._size25730);
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator25731;
		public override global::java.util.Iterator iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractQueue_._iterator25731)) as java.util.Iterator;
		}
		static AbstractQueue_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractQueue_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractQueue"));
			global::java.util.AbstractQueue_._poll25727 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue_.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.AbstractQueue_._peek25728 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue_.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.AbstractQueue_._offer25729 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue_.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractQueue_._size25730 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue_.staticClass, "size", "()I");
			global::java.util.AbstractQueue_._iterator25731 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
