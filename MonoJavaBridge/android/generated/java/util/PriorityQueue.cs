namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PriorityQueue : java.util.AbstractQueue, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PriorityQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.PriorityQueue.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.PriorityQueue._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.PriorityQueue.staticClass, "clear", "()V", ref global::java.util.PriorityQueue._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.PriorityQueue.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.PriorityQueue._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.PriorityQueue.staticClass, "size", "()I", ref global::java.util.PriorityQueue._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.PriorityQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.PriorityQueue._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.lang.Object[] toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.PriorityQueue.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.PriorityQueue._m5) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.PriorityQueue.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.PriorityQueue._m6) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.PriorityQueue.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.PriorityQueue._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.lang.Object poll()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.PriorityQueue.staticClass, "poll", "()Ljava/lang/Object;", ref global::java.util.PriorityQueue._m8) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.lang.Object peek()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.PriorityQueue.staticClass, "peek", "()Ljava/lang/Object;", ref global::java.util.PriorityQueue._m9) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override bool offer(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.PriorityQueue.staticClass, "offer", "(Ljava/lang/Object;)Z", ref global::java.util.PriorityQueue._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.util.Comparator comparator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Comparator>(this, global::java.util.PriorityQueue.staticClass, "comparator", "()Ljava/util/Comparator;", ref global::java.util.PriorityQueue._m11) as java.util.Comparator;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public PriorityQueue() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.PriorityQueue._m12.native == global::System.IntPtr.Zero)
				global::java.util.PriorityQueue._m12 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._m12);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public PriorityQueue(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.PriorityQueue._m13.native == global::System.IntPtr.Zero)
				global::java.util.PriorityQueue._m13 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public PriorityQueue(int arg0, java.util.Comparator arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.PriorityQueue._m14.native == global::System.IntPtr.Zero)
				global::java.util.PriorityQueue._m14 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(ILjava/util/Comparator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public PriorityQueue(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.PriorityQueue._m15.native == global::System.IntPtr.Zero)
				global::java.util.PriorityQueue._m15 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public PriorityQueue(java.util.PriorityQueue arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.PriorityQueue._m16.native == global::System.IntPtr.Zero)
				global::java.util.PriorityQueue._m16 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(Ljava/util/PriorityQueue;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public PriorityQueue(java.util.SortedSet arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.PriorityQueue._m17.native == global::System.IntPtr.Zero)
				global::java.util.PriorityQueue._m17 = @__env.GetMethodIDNoThrow(global::java.util.PriorityQueue.staticClass, "<init>", "(Ljava/util/SortedSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PriorityQueue.staticClass, global::java.util.PriorityQueue._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PriorityQueue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.PriorityQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/PriorityQueue"));
		}
	}
}
