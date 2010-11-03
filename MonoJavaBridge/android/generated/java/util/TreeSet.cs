namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TreeSet : java.util.AbstractSet, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TreeSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.TreeSet.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.TreeSet._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeSet.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.TreeSet._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.TreeSet.staticClass, "clear", "()V", ref global::java.util.TreeSet._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.TreeSet.staticClass, "isEmpty", "()Z", ref global::java.util.TreeSet._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.TreeSet.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.TreeSet._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.TreeSet.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.TreeSet._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.TreeSet.staticClass, "size", "()I", ref global::java.util.TreeSet._m6);
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.TreeSet.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.TreeSet._m7) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override bool remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.TreeSet.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.TreeSet._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.Object floor(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeSet.staticClass, "floor", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.TreeSet._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.Object pollFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeSet.staticClass, "pollFirst", "()Ljava/lang/Object;", ref global::java.util.TreeSet._m10) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.Object pollLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeSet.staticClass, "pollLast", "()Ljava/lang/Object;", ref global::java.util.TreeSet._m11) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.util.Iterator descendingIterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.TreeSet.staticClass, "descendingIterator", "()Ljava/util/Iterator;", ref global::java.util.TreeSet._m12) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.lang.Object last()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeSet.staticClass, "last", "()Ljava/lang/Object;", ref global::java.util.TreeSet._m13) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.lang.Object first()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeSet.staticClass, "first", "()Ljava/lang/Object;", ref global::java.util.TreeSet._m14) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::java.util.Comparator comparator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Comparator>(this, global::java.util.TreeSet.staticClass, "comparator", "()Ljava/util/Comparator;", ref global::java.util.TreeSet._m15) as java.util.Comparator;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::java.util.SortedSet subSet(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedSet>(this, global::java.util.TreeSet.staticClass, "subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;", ref global::java.util.TreeSet._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.SortedSet;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.util.SortedSet headSet(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedSet>(this, global::java.util.TreeSet.staticClass, "headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", ref global::java.util.TreeSet._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.SortedSet;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.util.SortedSet tailSet(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedSet>(this, global::java.util.TreeSet.staticClass, "tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", ref global::java.util.TreeSet._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.SortedSet;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual global::java.lang.Object lower(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeSet.staticClass, "lower", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.TreeSet._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.lang.Object ceiling(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeSet.staticClass, "ceiling", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.TreeSet._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::java.lang.Object higher(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeSet.staticClass, "higher", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.TreeSet._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public TreeSet() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._m22.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._m22 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeSet.staticClass, global::java.util.TreeSet._m22);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public TreeSet(java.util.Comparator arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._m23.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._m23 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "<init>", "(Ljava/util/Comparator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeSet.staticClass, global::java.util.TreeSet._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public TreeSet(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._m24.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._m24 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeSet.staticClass, global::java.util.TreeSet._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public TreeSet(java.util.SortedSet arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._m25.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._m25 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "<init>", "(Ljava/util/SortedSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeSet.staticClass, global::java.util.TreeSet._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static TreeSet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TreeSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TreeSet"));
		}
	}
}
