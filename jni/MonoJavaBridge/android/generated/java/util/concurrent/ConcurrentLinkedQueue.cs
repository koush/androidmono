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
		internal static global::MonoJavaBridge.MethodId _add21185;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._add21185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._add21185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty21186;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._isEmpty21186);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._isEmpty21186);
		}
		internal static global::MonoJavaBridge.MethodId _contains21187;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._contains21187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._contains21187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size21188;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._size21188);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._size21188);
		}
		internal static global::MonoJavaBridge.MethodId _toArray21189;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._toArray21189)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._toArray21189)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray21190;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._toArray21190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._toArray21190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator21191;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._iterator21191)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._iterator21191)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove21192;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._remove21192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._remove21192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll21193;
		public override global::java.lang.Object poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._poll21193)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._poll21193)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek21194;
		public override global::java.lang.Object peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._peek21194)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._peek21194)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer21195;
		public override bool offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue._offer21195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._offer21195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ConcurrentLinkedQueue21196;
		public ConcurrentLinkedQueue()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._ConcurrentLinkedQueue21196);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConcurrentLinkedQueue21197;
		public ConcurrentLinkedQueue(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._ConcurrentLinkedQueue21197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ConcurrentLinkedQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ConcurrentLinkedQueue"));
			global::java.util.concurrent.ConcurrentLinkedQueue._add21185 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentLinkedQueue._isEmpty21186 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "isEmpty", "()Z");
			global::java.util.concurrent.ConcurrentLinkedQueue._contains21187 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentLinkedQueue._size21188 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "size", "()I");
			global::java.util.concurrent.ConcurrentLinkedQueue._toArray21189 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentLinkedQueue._toArray21190 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentLinkedQueue._iterator21191 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.ConcurrentLinkedQueue._remove21192 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentLinkedQueue._poll21193 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentLinkedQueue._peek21194 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentLinkedQueue._offer21195 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentLinkedQueue._ConcurrentLinkedQueue21196 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "<init>", "()V");
			global::java.util.concurrent.ConcurrentLinkedQueue._ConcurrentLinkedQueue21197 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "<init>", "(Ljava/util/Collection;)V");
		}
	}
}
