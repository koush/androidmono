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
		internal static global::MonoJavaBridge.MethodId _add20594;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue._add20594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._add20594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear20595;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.PriorityQueue._clear20595);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._clear20595);
		}
		internal static global::MonoJavaBridge.MethodId _contains20596;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue._contains20596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._contains20596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size20597;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.PriorityQueue._size20597);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._size20597);
		}
		internal static global::MonoJavaBridge.MethodId _toArray20598;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PriorityQueue._toArray20598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._toArray20598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray20599;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PriorityQueue._toArray20599)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._toArray20599)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator20600;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PriorityQueue._iterator20600)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._iterator20600)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove20601;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue._remove20601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._remove20601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll20602;
		public override global::java.lang.Object poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PriorityQueue._poll20602)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._poll20602)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek20603;
		public override global::java.lang.Object peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PriorityQueue._peek20603)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._peek20603)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer20604;
		public override bool offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue._offer20604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._offer20604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _comparator20605;
		public virtual global::java.util.Comparator comparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PriorityQueue._comparator20605)) as java.util.Comparator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._comparator20605)) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _PriorityQueue20606;
		public PriorityQueue()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._PriorityQueue20606);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityQueue20607;
		public PriorityQueue(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._PriorityQueue20607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityQueue20608;
		public PriorityQueue(int arg0, java.util.Comparator arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._PriorityQueue20608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityQueue20609;
		public PriorityQueue(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._PriorityQueue20609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityQueue20610;
		public PriorityQueue(java.util.PriorityQueue arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._PriorityQueue20610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityQueue20611;
		public PriorityQueue(java.util.SortedSet arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._PriorityQueue20611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.PriorityQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/PriorityQueue"));
			global::java.util.PriorityQueue._add20594 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.PriorityQueue._clear20595 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "clear", "()V");
			global::java.util.PriorityQueue._contains20596 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.PriorityQueue._size20597 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "size", "()I");
			global::java.util.PriorityQueue._toArray20598 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.PriorityQueue._toArray20599 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.PriorityQueue._iterator20600 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.PriorityQueue._remove20601 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.PriorityQueue._poll20602 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.PriorityQueue._peek20603 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.PriorityQueue._offer20604 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.PriorityQueue._comparator20605 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "comparator", "()Ljava/util/Comparator;");
			global::java.util.PriorityQueue._PriorityQueue20606 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "()V");
			global::java.util.PriorityQueue._PriorityQueue20607 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(I)V");
			global::java.util.PriorityQueue._PriorityQueue20608 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(ILjava/util/Comparator;)V");
			global::java.util.PriorityQueue._PriorityQueue20609 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::java.util.PriorityQueue._PriorityQueue20610 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(Ljava/util/PriorityQueue;)V");
			global::java.util.PriorityQueue._PriorityQueue20611 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(Ljava/util/SortedSet;)V");
		}
	}
}
