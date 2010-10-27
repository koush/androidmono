namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TreeSet : java.util.AbstractSet, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TreeSet()
		{
			InitJNI();
		}
		protected TreeSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26914;
		public override bool add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TreeSet._add26914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._add26914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clone26915;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._clone26915)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._clone26915)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear26916;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.TreeSet._clear26916);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._clear26916);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26917;
		public override bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TreeSet._isEmpty26917);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._isEmpty26917);
		}
		internal static global::MonoJavaBridge.MethodId _contains26918;
		public override bool contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TreeSet._contains26918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._contains26918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26919;
		public override bool addAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TreeSet._addAll26919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._addAll26919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26920;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.TreeSet._size26920);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._size26920);
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator26921;
		public override global::java.util.Iterator iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._iterator26921)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._iterator26921)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26922;
		public override bool remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TreeSet._remove26922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._remove26922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _floor26923;
		public virtual global::java.lang.Object floor(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._floor26923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._floor26923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _pollFirst26924;
		public virtual global::java.lang.Object pollFirst()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._pollFirst26924)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._pollFirst26924)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _pollLast26925;
		public virtual global::java.lang.Object pollLast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._pollLast26925)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._pollLast26925)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _descendingIterator26926;
		public virtual global::java.util.Iterator descendingIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._descendingIterator26926)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._descendingIterator26926)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _last26927;
		public virtual global::java.lang.Object last()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._last26927)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._last26927)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _first26928;
		public virtual global::java.lang.Object first()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._first26928)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._first26928)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _comparator26929;
		public virtual global::java.util.Comparator comparator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._comparator26929)) as java.util.Comparator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._comparator26929)) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _subSet26930;
		public virtual global::java.util.SortedSet subSet(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._subSet26930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._subSet26930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _headSet26931;
		public virtual global::java.util.SortedSet headSet(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._headSet26931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._headSet26931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _tailSet26932;
		public virtual global::java.util.SortedSet tailSet(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._tailSet26932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._tailSet26932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _lower26933;
		public virtual global::java.lang.Object lower(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._lower26933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._lower26933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _ceiling26934;
		public virtual global::java.lang.Object ceiling(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._ceiling26934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._ceiling26934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _higher26935;
		public virtual global::java.lang.Object higher(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._higher26935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._higher26935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _TreeSet26936;
		public TreeSet() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeSet.staticClass, global::java.util.TreeSet._TreeSet26936);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TreeSet26937;
		public TreeSet(java.util.Comparator arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeSet.staticClass, global::java.util.TreeSet._TreeSet26937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TreeSet26938;
		public TreeSet(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeSet.staticClass, global::java.util.TreeSet._TreeSet26938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TreeSet26939;
		public TreeSet(java.util.SortedSet arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeSet.staticClass, global::java.util.TreeSet._TreeSet26939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TreeSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TreeSet"));
			global::java.util.TreeSet._add26914 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.TreeSet._clone26915 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.TreeSet._clear26916 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "clear", "()V");
			global::java.util.TreeSet._isEmpty26917 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "isEmpty", "()Z");
			global::java.util.TreeSet._contains26918 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.TreeSet._addAll26919 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.TreeSet._size26920 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "size", "()I");
			global::java.util.TreeSet._iterator26921 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.TreeSet._remove26922 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.TreeSet._floor26923 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "floor", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeSet._pollFirst26924 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "pollFirst", "()Ljava/lang/Object;");
			global::java.util.TreeSet._pollLast26925 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "pollLast", "()Ljava/lang/Object;");
			global::java.util.TreeSet._descendingIterator26926 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "descendingIterator", "()Ljava/util/Iterator;");
			global::java.util.TreeSet._last26927 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "last", "()Ljava/lang/Object;");
			global::java.util.TreeSet._first26928 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "first", "()Ljava/lang/Object;");
			global::java.util.TreeSet._comparator26929 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "comparator", "()Ljava/util/Comparator;");
			global::java.util.TreeSet._subSet26930 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;");
			global::java.util.TreeSet._headSet26931 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
			global::java.util.TreeSet._tailSet26932 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
			global::java.util.TreeSet._lower26933 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "lower", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeSet._ceiling26934 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "ceiling", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeSet._higher26935 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "higher", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeSet._TreeSet26936 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "<init>", "()V");
			global::java.util.TreeSet._TreeSet26937 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "<init>", "(Ljava/util/Comparator;)V");
			global::java.util.TreeSet._TreeSet26938 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::java.util.TreeSet._TreeSet26939 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "<init>", "(Ljava/util/SortedSet;)V");
		}
	}
}
