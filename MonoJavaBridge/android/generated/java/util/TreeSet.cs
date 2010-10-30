namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TreeSet : java.util.AbstractSet, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TreeSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26915;
		public override bool add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._add26915.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._add26915 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "add", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._add26915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clone26916;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._clone26916.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._clone26916 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._clone26916) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear26917;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._clear26917.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._clear26917 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "clear", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._clear26917);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26918;
		public override bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._isEmpty26918.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._isEmpty26918 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "isEmpty", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._isEmpty26918);
		}
		internal static global::MonoJavaBridge.MethodId _contains26919;
		public override bool contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._contains26919.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._contains26919 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "contains", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._contains26919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26920;
		public override bool addAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._addAll26920.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._addAll26920 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._addAll26920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26921;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._size26921.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._size26921 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "size", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._size26921);
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator26922;
		public override global::java.util.Iterator iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._iterator26922.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._iterator26922 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "iterator", "()Ljava/util/Iterator;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._iterator26922) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26923;
		public override bool remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._remove26923.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._remove26923 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "remove", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._remove26923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _floor26924;
		public virtual global::java.lang.Object floor(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._floor26924.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._floor26924 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "floor", "(Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._floor26924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _pollFirst26925;
		public virtual global::java.lang.Object pollFirst()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._pollFirst26925.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._pollFirst26925 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "pollFirst", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._pollFirst26925) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _pollLast26926;
		public virtual global::java.lang.Object pollLast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._pollLast26926.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._pollLast26926 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "pollLast", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._pollLast26926) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _descendingIterator26927;
		public virtual global::java.util.Iterator descendingIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._descendingIterator26927.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._descendingIterator26927 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "descendingIterator", "()Ljava/util/Iterator;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._descendingIterator26927) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _last26928;
		public virtual global::java.lang.Object last()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._last26928.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._last26928 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "last", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._last26928) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _first26929;
		public virtual global::java.lang.Object first()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._first26929.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._first26929 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "first", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._first26929) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _comparator26930;
		public virtual global::java.util.Comparator comparator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._comparator26930.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._comparator26930 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "comparator", "()Ljava/util/Comparator;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Comparator>(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._comparator26930) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _subSet26931;
		public virtual global::java.util.SortedSet subSet(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._subSet26931.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._subSet26931 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedSet>(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._subSet26931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _headSet26932;
		public virtual global::java.util.SortedSet headSet(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._headSet26932.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._headSet26932 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedSet>(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._headSet26932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _tailSet26933;
		public virtual global::java.util.SortedSet tailSet(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._tailSet26933.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._tailSet26933 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedSet>(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._tailSet26933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _lower26934;
		public virtual global::java.lang.Object lower(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._lower26934.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._lower26934 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "lower", "(Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._lower26934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _ceiling26935;
		public virtual global::java.lang.Object ceiling(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._ceiling26935.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._ceiling26935 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "ceiling", "(Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._ceiling26935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _higher26936;
		public virtual global::java.lang.Object higher(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._higher26936.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._higher26936 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "higher", "(Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._higher26936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _TreeSet26937;
		public TreeSet() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._TreeSet26937.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._TreeSet26937 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeSet.staticClass, global::java.util.TreeSet._TreeSet26937);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TreeSet26938;
		public TreeSet(java.util.Comparator arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._TreeSet26938.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._TreeSet26938 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "<init>", "(Ljava/util/Comparator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeSet.staticClass, global::java.util.TreeSet._TreeSet26938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TreeSet26939;
		public TreeSet(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._TreeSet26939.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._TreeSet26939 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeSet.staticClass, global::java.util.TreeSet._TreeSet26939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TreeSet26940;
		public TreeSet(java.util.SortedSet arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeSet._TreeSet26940.native == global::System.IntPtr.Zero)
				global::java.util.TreeSet._TreeSet26940 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "<init>", "(Ljava/util/SortedSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeSet.staticClass, global::java.util.TreeSet._TreeSet26940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static TreeSet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TreeSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TreeSet"));
		}
		internal static void InitJNI()
		{
		}
	}
}
