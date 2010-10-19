namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.AbstractQueue_))]
	public abstract partial class AbstractQueue : java.util.AbstractCollection, Queue
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractQueue()
		{
			InitJNI();
		}
		protected AbstractQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _poll19823;
		public abstract global::java.lang.Object poll();
		internal static global::MonoJavaBridge.MethodId _peek19824;
		public abstract global::java.lang.Object peek();
		internal static global::MonoJavaBridge.MethodId _offer19825;
		public abstract bool offer(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _add19826;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractQueue._add19826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractQueue.staticClass, global::java.util.AbstractQueue._add19826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear19827;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.AbstractQueue._clear19827);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.AbstractQueue.staticClass, global::java.util.AbstractQueue._clear19827);
		}
		internal static global::MonoJavaBridge.MethodId _addAll19828;
		public override bool addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractQueue._addAll19828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractQueue.staticClass, global::java.util.AbstractQueue._addAll19828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove19829;
		public virtual global::java.lang.Object remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractQueue._remove19829)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractQueue.staticClass, global::java.util.AbstractQueue._remove19829)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _element19830;
		public virtual global::java.lang.Object element() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractQueue._element19830)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractQueue.staticClass, global::java.util.AbstractQueue._element19830)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractQueue19831;
		protected AbstractQueue()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractQueue.staticClass, global::java.util.AbstractQueue._AbstractQueue19831);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractQueue"));
			global::java.util.AbstractQueue._poll19823 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.AbstractQueue._peek19824 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.AbstractQueue._offer19825 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractQueue._add19826 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractQueue._clear19827 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue.staticClass, "clear", "()V");
			global::java.util.AbstractQueue._addAll19828 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractQueue._remove19829 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue.staticClass, "remove", "()Ljava/lang/Object;");
			global::java.util.AbstractQueue._element19830 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue.staticClass, "element", "()Ljava/lang/Object;");
			global::java.util.AbstractQueue._AbstractQueue19831 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.AbstractQueue))]
	public sealed partial class AbstractQueue_ : java.util.AbstractQueue
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractQueue_()
		{
			InitJNI();
		}
		internal AbstractQueue_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _poll19832;
		public override global::java.lang.Object poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractQueue_._poll19832)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractQueue_.staticClass, global::java.util.AbstractQueue_._poll19832)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek19833;
		public override global::java.lang.Object peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractQueue_._peek19833)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractQueue_.staticClass, global::java.util.AbstractQueue_._peek19833)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer19834;
		public override bool offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractQueue_._offer19834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractQueue_.staticClass, global::java.util.AbstractQueue_._offer19834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size19835;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractQueue_._size19835);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractQueue_.staticClass, global::java.util.AbstractQueue_._size19835);
		}
		internal static global::MonoJavaBridge.MethodId _iterator19836;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractQueue_._iterator19836)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractQueue_.staticClass, global::java.util.AbstractQueue_._iterator19836)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractQueue_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractQueue"));
			global::java.util.AbstractQueue_._poll19832 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue_.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.AbstractQueue_._peek19833 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue_.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.AbstractQueue_._offer19834 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue_.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractQueue_._size19835 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue_.staticClass, "size", "()I");
			global::java.util.AbstractQueue_._iterator19836 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
