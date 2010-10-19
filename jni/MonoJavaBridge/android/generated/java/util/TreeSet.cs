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
		internal static global::MonoJavaBridge.MethodId _add20966;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TreeSet._add20966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._add20966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clone20967;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._clone20967)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._clone20967)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear20968;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.TreeSet._clear20968);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._clear20968);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty20969;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TreeSet._isEmpty20969);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._isEmpty20969);
		}
		internal static global::MonoJavaBridge.MethodId _contains20970;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TreeSet._contains20970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._contains20970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll20971;
		public override bool addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TreeSet._addAll20971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._addAll20971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size20972;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.TreeSet._size20972);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._size20972);
		}
		internal static global::MonoJavaBridge.MethodId _iterator20973;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._iterator20973)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._iterator20973)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove20974;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TreeSet._remove20974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._remove20974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _floor20975;
		public virtual global::java.lang.Object floor(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._floor20975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._floor20975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _pollFirst20976;
		public virtual global::java.lang.Object pollFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._pollFirst20976)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._pollFirst20976)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _pollLast20977;
		public virtual global::java.lang.Object pollLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._pollLast20977)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._pollLast20977)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _descendingIterator20978;
		public virtual global::java.util.Iterator descendingIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._descendingIterator20978)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._descendingIterator20978)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _last20979;
		public virtual global::java.lang.Object last() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._last20979)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._last20979)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _first20980;
		public virtual global::java.lang.Object first() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._first20980)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._first20980)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _comparator20981;
		public virtual global::java.util.Comparator comparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._comparator20981)) as java.util.Comparator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._comparator20981)) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _subSet20982;
		public virtual global::java.util.SortedSet subSet(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._subSet20982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._subSet20982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _headSet20983;
		public virtual global::java.util.SortedSet headSet(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._headSet20983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._headSet20983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _tailSet20984;
		public virtual global::java.util.SortedSet tailSet(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._tailSet20984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._tailSet20984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _lower20985;
		public virtual global::java.lang.Object lower(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._lower20985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._lower20985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _ceiling20986;
		public virtual global::java.lang.Object ceiling(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._ceiling20986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._ceiling20986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _higher20987;
		public virtual global::java.lang.Object higher(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeSet._higher20987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeSet.staticClass, global::java.util.TreeSet._higher20987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _TreeSet20988;
		public TreeSet()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeSet.staticClass, global::java.util.TreeSet._TreeSet20988);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TreeSet20989;
		public TreeSet(java.util.Comparator arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeSet.staticClass, global::java.util.TreeSet._TreeSet20989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TreeSet20990;
		public TreeSet(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeSet.staticClass, global::java.util.TreeSet._TreeSet20990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TreeSet20991;
		public TreeSet(java.util.SortedSet arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeSet.staticClass, global::java.util.TreeSet._TreeSet20991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TreeSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TreeSet"));
			global::java.util.TreeSet._add20966 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.TreeSet._clone20967 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.TreeSet._clear20968 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "clear", "()V");
			global::java.util.TreeSet._isEmpty20969 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "isEmpty", "()Z");
			global::java.util.TreeSet._contains20970 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.TreeSet._addAll20971 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.TreeSet._size20972 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "size", "()I");
			global::java.util.TreeSet._iterator20973 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.TreeSet._remove20974 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.TreeSet._floor20975 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "floor", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeSet._pollFirst20976 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "pollFirst", "()Ljava/lang/Object;");
			global::java.util.TreeSet._pollLast20977 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "pollLast", "()Ljava/lang/Object;");
			global::java.util.TreeSet._descendingIterator20978 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "descendingIterator", "()Ljava/util/Iterator;");
			global::java.util.TreeSet._last20979 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "last", "()Ljava/lang/Object;");
			global::java.util.TreeSet._first20980 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "first", "()Ljava/lang/Object;");
			global::java.util.TreeSet._comparator20981 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "comparator", "()Ljava/util/Comparator;");
			global::java.util.TreeSet._subSet20982 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;");
			global::java.util.TreeSet._headSet20983 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
			global::java.util.TreeSet._tailSet20984 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
			global::java.util.TreeSet._lower20985 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "lower", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeSet._ceiling20986 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "ceiling", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeSet._higher20987 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "higher", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeSet._TreeSet20988 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "<init>", "()V");
			global::java.util.TreeSet._TreeSet20989 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "<init>", "(Ljava/util/Comparator;)V");
			global::java.util.TreeSet._TreeSet20990 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::java.util.TreeSet._TreeSet20991 = @__env.GetMethodIDNoThrow(global::java.util.TreeSet.staticClass, "<init>", "(Ljava/util/SortedSet;)V");
		}
	}
}
