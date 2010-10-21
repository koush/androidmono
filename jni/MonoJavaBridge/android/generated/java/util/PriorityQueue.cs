namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PriorityQueue : java.util.AbstractQueue, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PriorityQueue()
		{
			InitJNI();
		}
		protected PriorityQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26419;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue._add26419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._add26419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear26420;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.PriorityQueue._clear26420);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._clear26420);
		}
		internal static global::MonoJavaBridge.MethodId _contains26421;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue._contains26421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._contains26421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26422;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.PriorityQueue._size26422);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._size26422);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26423;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PriorityQueue._toArray26423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._toArray26423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26424;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PriorityQueue._toArray26424)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._toArray26424)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26425;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PriorityQueue._iterator26425)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._iterator26425)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26426;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue._remove26426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._remove26426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll26427;
		public override global::java.lang.Object poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PriorityQueue._poll26427)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._poll26427)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek26428;
		public override global::java.lang.Object peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PriorityQueue._peek26428)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._peek26428)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer26429;
		public override bool offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue._offer26429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._offer26429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _comparator26430;
		public virtual global::java.util.Comparator comparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PriorityQueue._comparator26430)) as java.util.Comparator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._comparator26430)) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _PriorityQueue26431;
		public PriorityQueue()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._PriorityQueue26431);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityQueue26432;
		public PriorityQueue(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._PriorityQueue26432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityQueue26433;
		public PriorityQueue(int arg0, java.util.Comparator arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._PriorityQueue26433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityQueue26434;
		public PriorityQueue(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._PriorityQueue26434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityQueue26435;
		public PriorityQueue(java.util.PriorityQueue arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._PriorityQueue26435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityQueue26436;
		public PriorityQueue(java.util.SortedSet arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._PriorityQueue26436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.PriorityQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/PriorityQueue"));
			global::java.util.PriorityQueue._add26419 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.PriorityQueue._clear26420 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "clear", "()V");
			global::java.util.PriorityQueue._contains26421 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.PriorityQueue._size26422 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "size", "()I");
			global::java.util.PriorityQueue._toArray26423 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.PriorityQueue._toArray26424 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.PriorityQueue._iterator26425 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.PriorityQueue._remove26426 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.PriorityQueue._poll26427 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.PriorityQueue._peek26428 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.PriorityQueue._offer26429 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.PriorityQueue._comparator26430 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "comparator", "()Ljava/util/Comparator;");
			global::java.util.PriorityQueue._PriorityQueue26431 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "()V");
			global::java.util.PriorityQueue._PriorityQueue26432 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(I)V");
			global::java.util.PriorityQueue._PriorityQueue26433 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(ILjava/util/Comparator;)V");
			global::java.util.PriorityQueue._PriorityQueue26434 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::java.util.PriorityQueue._PriorityQueue26435 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(Ljava/util/PriorityQueue;)V");
			global::java.util.PriorityQueue._PriorityQueue26436 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(Ljava/util/SortedSet;)V");
		}
	}
}
