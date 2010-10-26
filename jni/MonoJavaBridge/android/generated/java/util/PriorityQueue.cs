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
		internal static global::MonoJavaBridge.MethodId _add26537;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue._add26537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._add26537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear26538;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.PriorityQueue._clear26538);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._clear26538);
		}
		internal static global::MonoJavaBridge.MethodId _contains26539;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue._contains26539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._contains26539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26540;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.PriorityQueue._size26540);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._size26540);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26541;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PriorityQueue._toArray26541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._toArray26541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26542;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PriorityQueue._toArray26542)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._toArray26542)) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator26543;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PriorityQueue._iterator26543)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._iterator26543)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26544;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue._remove26544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._remove26544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll26545;
		public override global::java.lang.Object poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PriorityQueue._poll26545)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._poll26545)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek26546;
		public override global::java.lang.Object peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PriorityQueue._peek26546)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._peek26546)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer26547;
		public override bool offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue._offer26547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._offer26547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _comparator26548;
		public virtual global::java.util.Comparator comparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PriorityQueue._comparator26548)) as java.util.Comparator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._comparator26548)) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _PriorityQueue26549;
		public PriorityQueue()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._PriorityQueue26549);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityQueue26550;
		public PriorityQueue(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._PriorityQueue26550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityQueue26551;
		public PriorityQueue(int arg0, java.util.Comparator arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._PriorityQueue26551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityQueue26552;
		public PriorityQueue(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._PriorityQueue26552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityQueue26553;
		public PriorityQueue(java.util.PriorityQueue arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._PriorityQueue26553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityQueue26554;
		public PriorityQueue(java.util.SortedSet arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._PriorityQueue26554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.PriorityQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/PriorityQueue"));
			global::java.util.PriorityQueue._add26537 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.PriorityQueue._clear26538 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "clear", "()V");
			global::java.util.PriorityQueue._contains26539 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.PriorityQueue._size26540 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "size", "()I");
			global::java.util.PriorityQueue._toArray26541 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.PriorityQueue._toArray26542 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.PriorityQueue._iterator26543 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.PriorityQueue._remove26544 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.PriorityQueue._poll26545 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.PriorityQueue._peek26546 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.PriorityQueue._offer26547 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.PriorityQueue._comparator26548 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "comparator", "()Ljava/util/Comparator;");
			global::java.util.PriorityQueue._PriorityQueue26549 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "()V");
			global::java.util.PriorityQueue._PriorityQueue26550 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(I)V");
			global::java.util.PriorityQueue._PriorityQueue26551 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(ILjava/util/Comparator;)V");
			global::java.util.PriorityQueue._PriorityQueue26552 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::java.util.PriorityQueue._PriorityQueue26553 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(Ljava/util/PriorityQueue;)V");
			global::java.util.PriorityQueue._PriorityQueue26554 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(Ljava/util/SortedSet;)V");
		}
	}
}
