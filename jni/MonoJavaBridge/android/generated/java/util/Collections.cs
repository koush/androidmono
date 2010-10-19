namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Collections : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Collections()
		{
			InitJNI();
		}
		protected Collections(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _min20083;
		public static global::java.lang.Object min(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._min20083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _min20084;
		public static global::java.lang.Object min(java.util.Collection arg0, java.util.Comparator arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._min20084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _max20085;
		public static global::java.lang.Object max(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._max20085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _max20086;
		public static global::java.lang.Object max(java.util.Collection arg0, java.util.Comparator arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._max20086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _replaceAll20087;
		public static bool replaceAll(java.util.List arg0, java.lang.Object arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Collections.staticClass, global::java.util.Collections._replaceAll20087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addAll20088;
		public static bool addAll(java.util.Collection arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Collections.staticClass, global::java.util.Collections._addAll20088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _list20089;
		public static global::java.util.ArrayList list(java.util.Enumeration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._list20089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _synchronizedSet20090;
		public static global::java.util.Set synchronizedSet(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._synchronizedSet20090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _synchronizedCollection20091;
		public static global::java.util.Collection synchronizedCollection(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._synchronizedCollection20091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _copy20092;
		public static void copy(java.util.List arg0, java.util.List arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._copy20092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _synchronizedList20093;
		public static global::java.util.List synchronizedList(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._synchronizedList20093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _reverse20094;
		public static void reverse(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._reverse20094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fill20095;
		public static void fill(java.util.List arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._fill20095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sort20096;
		public static void sort(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._sort20096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort20097;
		public static void sort(java.util.List arg0, java.util.Comparator arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._sort20097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _swap20098;
		public static void swap(java.util.List arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._swap20098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch20099;
		public static int binarySearch(java.util.List arg0, java.lang.Object arg1, java.util.Comparator arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._binarySearch20099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch20100;
		public static int binarySearch(java.util.List arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._binarySearch20100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _synchronizedMap20101;
		public static global::java.util.Map synchronizedMap(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._synchronizedMap20101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _shuffle20102;
		public static void shuffle(java.util.List arg0, java.util.Random arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._shuffle20102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _shuffle20103;
		public static void shuffle(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._shuffle20103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotate20104;
		public static void rotate(java.util.List arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._rotate20104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfSubList20105;
		public static int indexOfSubList(java.util.List arg0, java.util.List arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._indexOfSubList20105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOfSubList20106;
		public static int lastIndexOfSubList(java.util.List arg0, java.util.List arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._lastIndexOfSubList20106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _unmodifiableCollection20107;
		public static global::java.util.Collection unmodifiableCollection(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._unmodifiableCollection20107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _unmodifiableSet20108;
		public static global::java.util.Set unmodifiableSet(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._unmodifiableSet20108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _unmodifiableSortedSet20109;
		public static global::java.util.SortedSet unmodifiableSortedSet(java.util.SortedSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._unmodifiableSortedSet20109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _unmodifiableList20110;
		public static global::java.util.List unmodifiableList(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._unmodifiableList20110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _unmodifiableMap20111;
		public static global::java.util.Map unmodifiableMap(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._unmodifiableMap20111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _unmodifiableSortedMap20112;
		public static global::java.util.SortedMap unmodifiableSortedMap(java.util.SortedMap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._unmodifiableSortedMap20112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _synchronizedSortedSet20113;
		public static global::java.util.SortedSet synchronizedSortedSet(java.util.SortedSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._synchronizedSortedSet20113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _synchronizedSortedMap20114;
		public static global::java.util.SortedMap synchronizedSortedMap(java.util.SortedMap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._synchronizedSortedMap20114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _checkedCollection20115;
		public static global::java.util.Collection checkedCollection(java.util.Collection arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._checkedCollection20115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _checkedSet20116;
		public static global::java.util.Set checkedSet(java.util.Set arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._checkedSet20116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _checkedSortedSet20117;
		public static global::java.util.SortedSet checkedSortedSet(java.util.SortedSet arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._checkedSortedSet20117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _checkedList20118;
		public static global::java.util.List checkedList(java.util.List arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._checkedList20118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _checkedMap20119;
		public static global::java.util.Map checkedMap(java.util.Map arg0, java.lang.Class arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._checkedMap20119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _checkedSortedMap20120;
		public static global::java.util.SortedMap checkedSortedMap(java.util.SortedMap arg0, java.lang.Class arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._checkedSortedMap20120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _emptySet20121;
		public static global::java.util.Set emptySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._emptySet20121)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _emptyList20122;
		public static global::java.util.List emptyList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._emptyList20122)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _emptyMap20123;
		public static global::java.util.Map emptyMap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._emptyMap20123)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _singleton20124;
		public static global::java.util.Set singleton(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._singleton20124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _singletonList20125;
		public static global::java.util.List singletonList(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._singletonList20125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _singletonMap20126;
		public static global::java.util.Map singletonMap(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._singletonMap20126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _nCopies20127;
		public static global::java.util.List nCopies(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._nCopies20127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _reverseOrder20128;
		public static global::java.util.Comparator reverseOrder(java.util.Comparator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._reverseOrder20128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _reverseOrder20129;
		public static global::java.util.Comparator reverseOrder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._reverseOrder20129)) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _enumeration20130;
		public static global::java.util.Enumeration enumeration(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._enumeration20130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _frequency20131;
		public static int frequency(java.util.Collection arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._frequency20131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _disjoint20132;
		public static bool disjoint(java.util.Collection arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Collections.staticClass, global::java.util.Collections._disjoint20132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newSetFromMap20133;
		public static global::java.util.Set newSetFromMap(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._newSetFromMap20133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY_SET20134;
		public static global::java.util.Set EMPTY_SET
		{
			get
			{
				return default(global::java.util.Set);
			}
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY_LIST20135;
		public static global::java.util.List EMPTY_LIST
		{
			get
			{
				return default(global::java.util.List);
			}
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY_MAP20136;
		public static global::java.util.Map EMPTY_MAP
		{
			get
			{
				return default(global::java.util.Map);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Collections.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Collections"));
			global::java.util.Collections._min20083 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "min", "(Ljava/util/Collection;)Ljava/lang/Object;");
			global::java.util.Collections._min20084 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "min", "(Ljava/util/Collection;Ljava/util/Comparator;)Ljava/lang/Object;");
			global::java.util.Collections._max20085 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "max", "(Ljava/util/Collection;)Ljava/lang/Object;");
			global::java.util.Collections._max20086 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "max", "(Ljava/util/Collection;Ljava/util/Comparator;)Ljava/lang/Object;");
			global::java.util.Collections._replaceAll20087 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "replaceAll", "(Ljava/util/List;Ljava/lang/Object;Ljava/lang/Object;)Z");
			global::java.util.Collections._addAll20088 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "addAll", "(Ljava/util/Collection;[Ljava/lang/Object;)Z");
			global::java.util.Collections._list20089 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "list", "(Ljava/util/Enumeration;)Ljava/util/ArrayList;");
			global::java.util.Collections._synchronizedSet20090 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedSet", "(Ljava/util/Set;)Ljava/util/Set;");
			global::java.util.Collections._synchronizedCollection20091 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedCollection", "(Ljava/util/Collection;)Ljava/util/Collection;");
			global::java.util.Collections._copy20092 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "copy", "(Ljava/util/List;Ljava/util/List;)V");
			global::java.util.Collections._synchronizedList20093 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedList", "(Ljava/util/List;)Ljava/util/List;");
			global::java.util.Collections._reverse20094 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "reverse", "(Ljava/util/List;)V");
			global::java.util.Collections._fill20095 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "fill", "(Ljava/util/List;Ljava/lang/Object;)V");
			global::java.util.Collections._sort20096 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "sort", "(Ljava/util/List;)V");
			global::java.util.Collections._sort20097 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "sort", "(Ljava/util/List;Ljava/util/Comparator;)V");
			global::java.util.Collections._swap20098 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "swap", "(Ljava/util/List;II)V");
			global::java.util.Collections._binarySearch20099 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "binarySearch", "(Ljava/util/List;Ljava/lang/Object;Ljava/util/Comparator;)I");
			global::java.util.Collections._binarySearch20100 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "binarySearch", "(Ljava/util/List;Ljava/lang/Object;)I");
			global::java.util.Collections._synchronizedMap20101 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedMap", "(Ljava/util/Map;)Ljava/util/Map;");
			global::java.util.Collections._shuffle20102 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "shuffle", "(Ljava/util/List;Ljava/util/Random;)V");
			global::java.util.Collections._shuffle20103 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "shuffle", "(Ljava/util/List;)V");
			global::java.util.Collections._rotate20104 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "rotate", "(Ljava/util/List;I)V");
			global::java.util.Collections._indexOfSubList20105 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "indexOfSubList", "(Ljava/util/List;Ljava/util/List;)I");
			global::java.util.Collections._lastIndexOfSubList20106 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "lastIndexOfSubList", "(Ljava/util/List;Ljava/util/List;)I");
			global::java.util.Collections._unmodifiableCollection20107 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableCollection", "(Ljava/util/Collection;)Ljava/util/Collection;");
			global::java.util.Collections._unmodifiableSet20108 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableSet", "(Ljava/util/Set;)Ljava/util/Set;");
			global::java.util.Collections._unmodifiableSortedSet20109 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableSortedSet", "(Ljava/util/SortedSet;)Ljava/util/SortedSet;");
			global::java.util.Collections._unmodifiableList20110 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableList", "(Ljava/util/List;)Ljava/util/List;");
			global::java.util.Collections._unmodifiableMap20111 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableMap", "(Ljava/util/Map;)Ljava/util/Map;");
			global::java.util.Collections._unmodifiableSortedMap20112 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableSortedMap", "(Ljava/util/SortedMap;)Ljava/util/SortedMap;");
			global::java.util.Collections._synchronizedSortedSet20113 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedSortedSet", "(Ljava/util/SortedSet;)Ljava/util/SortedSet;");
			global::java.util.Collections._synchronizedSortedMap20114 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedSortedMap", "(Ljava/util/SortedMap;)Ljava/util/SortedMap;");
			global::java.util.Collections._checkedCollection20115 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedCollection", "(Ljava/util/Collection;Ljava/lang/Class;)Ljava/util/Collection;");
			global::java.util.Collections._checkedSet20116 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedSet", "(Ljava/util/Set;Ljava/lang/Class;)Ljava/util/Set;");
			global::java.util.Collections._checkedSortedSet20117 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedSortedSet", "(Ljava/util/SortedSet;Ljava/lang/Class;)Ljava/util/SortedSet;");
			global::java.util.Collections._checkedList20118 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedList", "(Ljava/util/List;Ljava/lang/Class;)Ljava/util/List;");
			global::java.util.Collections._checkedMap20119 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedMap", "(Ljava/util/Map;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/Map;");
			global::java.util.Collections._checkedSortedMap20120 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedSortedMap", "(Ljava/util/SortedMap;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/SortedMap;");
			global::java.util.Collections._emptySet20121 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "emptySet", "()Ljava/util/Set;");
			global::java.util.Collections._emptyList20122 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "emptyList", "()Ljava/util/List;");
			global::java.util.Collections._emptyMap20123 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "emptyMap", "()Ljava/util/Map;");
			global::java.util.Collections._singleton20124 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "singleton", "(Ljava/lang/Object;)Ljava/util/Set;");
			global::java.util.Collections._singletonList20125 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "singletonList", "(Ljava/lang/Object;)Ljava/util/List;");
			global::java.util.Collections._singletonMap20126 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "singletonMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;");
			global::java.util.Collections._nCopies20127 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "nCopies", "(ILjava/lang/Object;)Ljava/util/List;");
			global::java.util.Collections._reverseOrder20128 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "reverseOrder", "(Ljava/util/Comparator;)Ljava/util/Comparator;");
			global::java.util.Collections._reverseOrder20129 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "reverseOrder", "()Ljava/util/Comparator;");
			global::java.util.Collections._enumeration20130 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "enumeration", "(Ljava/util/Collection;)Ljava/util/Enumeration;");
			global::java.util.Collections._frequency20131 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "frequency", "(Ljava/util/Collection;Ljava/lang/Object;)I");
			global::java.util.Collections._disjoint20132 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "disjoint", "(Ljava/util/Collection;Ljava/util/Collection;)Z");
			global::java.util.Collections._newSetFromMap20133 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "newSetFromMap", "(Ljava/util/Map;)Ljava/util/Set;");
		}
	}
}
